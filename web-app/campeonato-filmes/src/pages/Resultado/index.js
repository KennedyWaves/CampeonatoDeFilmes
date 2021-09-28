
import CardFilmeVencedor from '../../components/CardFilmeVencedor';
import Header from '../../components/Header';
import './../../global.css';
import './styles.css';
import {useLocation,useHistory} from 'react-router-dom';

function Resultado() {
    /// permite acesso ao router/history, para navegação entre páginas.
    const history = useHistory();
    const location = useLocation();

    if(location.state === undefined){
        history.push('/');
        return <></>;
    }
    return (
        <div id="container">
            <Header
                titulo="Resultado Final"
                descricao="Veja o resultado final do campeonato de filmes de forma simples e rápida."
                useSerif={true}
            />
            <div className="conteudo">
                {location.state.vencedores.map(
                    (value,index) =>
                    (
                            <CardFilmeVencedor
                                key={index}
                                posicao={index+1}
                                filme={value}
                            />
                    )
                )}
            </div>
        </div>
    );
}
export default Resultado;

//botão voltar
// <button id="botao-voltar" className="botao-preto" onClick={BotaoVoltarOnClick}>VOLTAR</button>