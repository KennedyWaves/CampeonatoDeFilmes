import React, { useState } from 'react';
import './styles.css';
import './../../global.css';

function CardFilme(props) {
    const [isFilmeSelecionado, setFilmeSelecionado] = useState(false);
    /// Gera o retorno para a atualização da lista de filmes selecionados.
    function CheckboxCallback() {
        setFilmeSelecionado((prevState) => !prevState);
        props.callback(props.filme, !isFilmeSelecionado);
    }

    return (
        <div
            className="card"
            onClick={CheckboxCallback}
            data-testid={props.testid}
        >
            <div className="card-conteudo">
                <div className="card-checkbox"
                >
                    <input
                        checked={isFilmeSelecionado}
                        type="checkbox"
                        readOnly
                    />
                </div>
                <div className="card-info">
                    <h5 className="info">{props.filme.titulo}</h5>
                    <h6 className="info">{props.filme.ano}</h6>
                </div>
            </div>
        </div>);
}

export default CardFilme;