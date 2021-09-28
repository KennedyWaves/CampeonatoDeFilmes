import './styles.css';

function Header(props) {
        return (
            <header>
                <div id="background">
                    <div id="content">
                        <h5 id="titulo" className="center">CAMPEONATO DE FILMES</h5>
                        <h1 id="pagina" className="center">{props.titulo}</h1>
                        <p id="separator" className="center">___</p>
                        <h5 id="descricao" className="center" style={
                            {
                                fontFamily: (props.useSerif ? 'IBM Plex Serif':'sans-serif')
                            }
                        }>{props.descricao}</h5>
                    </div>
                </div>
            </header>
        );
}
export default Header;