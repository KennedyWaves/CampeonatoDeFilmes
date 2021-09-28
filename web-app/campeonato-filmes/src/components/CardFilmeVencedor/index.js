import React from 'react';
import './styles.css';

function CardFilmeVencedor(props) {
    return (<div className="card">
        <div className="card-conteudo card-conteudo-vencedor">
            <div className="card-posicao">
                <h1>{props.posicao}&ordm;</h1>
            </div>
            <div className="card-info">
                <h4 className="info-titulo-vencedor">{props.filme.titulo}</h4>
            </div>
        </div>
    </div>);
}

export default CardFilmeVencedor;