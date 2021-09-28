import Adapter from './Adapter';

    async function listAll() {
        return await Adapter.get("/filmes");
    }
    async function executaCampeonato(data) {
        return await Adapter.post("/filmes/campeonato",
            data,
            {
                headers: {
                    'Access-Control-Allow-Origin': '*',
                    'Content-Type': 'application/json',
                }
            }
        );
    }

    const adapter ={listAll,executaCampeonato};
export default adapter;