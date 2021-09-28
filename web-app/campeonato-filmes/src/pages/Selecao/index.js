import React, { useState, useEffect, useCallback } from 'react';
import Grid from '@material-ui/core/Grid';
import CardFilme from '../../components/CardFilme';
import Header from '../../components/Header';
import './styles.css';
import './../../global.css';
import adapter from '../../adapters/FilmeAdapter';
import Loader from "react-loader-spinner";
import { useHistory } from "react-router-dom";
import Alert from "../../components/Alert";

function Selecao() {
    /// Lista a quantidade de filmes exigidos
    const FILMES_EXIGIDOS = 8;
    /// permite acesso ao router/history, para navegação entre páginas.
    const history = useHistory();

    /// variáveis de controle de filmes

    /// Lista os filmes recebidos pela API
    const [filmesDisponiveis, setFilmesDisponiveis] = useState([]);

    /// Lista os filmes selecionados pelo usuário
    const [filmesSelecionados, setFilmesSelecionados] = useState([]);

    /// Determina a visibilidade do spinner de carregamento do botão de campeonato.
    const [isSpinnerBotaoCampVisivel, setSpinnerBotaoCampVisivel] = useState(false);

    const [alertObject, setAlertObject] = useState({
        open: false,
        titulo: "",
        texto: ""
    });


    ///

    /// Consulta a API para receber os filmes disponíveis.
    const listaFilmesDisponiveisAsync = useCallback(async () => {
        try {
        const resposta = await adapter.listAll();
        
            if (resposta.status === 200) {
                const filmes = resposta.data;
                filmes.sort(function (a, b) {
                    return a.titulo.toUpperCase().localeCompare(b.titulo.toUpperCase());
                });
                setFilmesDisponiveis(filmes);
            } else {
                throw new Error();
            }
        } catch {
            console.log("falhou");

            setAlertObject(
                {
                    open: true,
                    titulo: "Atenção",
                    texto: "falha de comunicação com o servidor. Por favor, atualize a página."
                }
            );

        }
    }, []);

    /// Envia os filmes selecionados
    /// Obtém os dois vencedores
    /// redireciona para página de resultados
    const executaCampeonato = useCallback(async () => {
        if (filmesSelecionados.length !== FILMES_EXIGIDOS) {
            setAlertObject(
                {
                    open: true,
                    titulo: "Atenção",
                    texto: "A quantidade de filmes exigidos é 8!"
                }
            );
            return;
        }
        setSpinnerBotaoCampVisivel(true);
        const resposta = await adapter.executaCampeonato(filmesSelecionados);
        if (resposta.status === 200) {
            setSpinnerBotaoCampVisivel(false);
            history.push(
                {
                    pathname: '/resultado',
                    state: {
                        vencedores: resposta.data
                    }
                }
            );
        }
        else {
            setSpinnerBotaoCampVisivel(false);
            setAlertObject(
                {
                    open: true,
                    titulo: "Atenção",
                    texto: "falha de comunicação com o servidor. Por favor, tente novamente em instantes."
                }
            );
        }


    }, [filmesSelecionados, history]);

    /// Atualiza a lista de filmes selecionados
    const atualizaFilmesSelecionados = useCallback((filme, incluir) => {
        // true = incluir
        // false = apagar
        if (incluir) {
            setFilmesSelecionados([...filmesSelecionados, { ...filme }]);
        }
        else {
            setFilmesSelecionados(filmesSelecionados.filter(item => item.id !== filme.id));
        }
    }, [filmesSelecionados]);

    /// Verifica se a lista de filmes disponíveis foi carregada.
    const verificaSeFilmesCarregados = useCallback(() => {
        return filmesDisponiveis.length > 0
    }, [filmesDisponiveis]);

    /// Carrega uma vez na inicialização.
    useEffect(() => {
        (async () => {
            await listaFilmesDisponiveisAsync();
        })()
    }, [listaFilmesDisponiveisAsync]);

    return (
        <div id="container">
            <Alert
                open={alertObject.open}
                titulo={alertObject.titulo}
                texto={alertObject.texto}
                fechaDialogo={setAlertObject}/>

            <Header titulo="Fase de Seleção"
                descricao="Selecione 8 filmes que você deseja que entrem na competição e depois pressione o botão Gerar Meu Campeonato para prosseguir.">
            </Header>
            <div className="conteudo">
                <div id="painel">
                    <div id="contador">
                        <p>Selecionados<br />
                            {filmesSelecionados.length} de {FILMES_EXIGIDOS} filmes</p>
                    </div>
                    <div id="gerador-container">
                        <button
                            data-testid="btn-gera-campeonato"
                            className="botao-preto"
                            style={{ display: !isSpinnerBotaoCampVisivel ? 'block' : 'none' }}
                            disabled={!verificaSeFilmesCarregados()}
                            id="get-campeao"
                            onClick={() => { executaCampeonato(history) }}
                        >GERAR MEU CAMPEONATO</button>
                        <Loader
                            className="loader"
                            type="Oval"
                            color="#505050"
                            height={44}
                            width={44}
                            visible={isSpinnerBotaoCampVisivel} //3 secs
                        />
                    </div>
                </div>
                <Grid id="grid-filmes"
                    style={{ flexGrow: 1 }}
                    container spacing={1}>
                    <Grid item xs={12}>
                        <Grid container spacing={1} justifyContent="center">
                            {
                                filmesDisponiveis.map(
                                    (value, index) =>
                                    (
                                        <Grid
                                            key={value.id}
                                            item>
                                            <CardFilme
                                                testid={`filme-${index + 1}`}
                                                filme={value}
                                                callback={atualizaFilmesSelecionados}
                                            ></CardFilme>
                                        </Grid>
                                    )
                                )
                            }
                        </Grid>
                    </Grid>
                </Grid>
                <Loader
                    className="loader"
                    type="Oval"
                    color="#505050"
                    height={75}
                    width={75}
                    visible={!verificaSeFilmesCarregados()}
                />
            </div>
        </div>
    );
}

export default Selecao;