import { render, screen, waitFor } from '@testing-library/react';
import userEvent from '@testing-library/user-event';

import Selecao from '../../pages/Selecao';
import Adapter from '../../adapters/FilmeAdapter';
import { mockReturn } from '../helpers/mockListAll';

describe("<Selecao />", () => {
    beforeEach(async () => {
        jest.spyOn(Adapter, "listAll")
            .mockResolvedValue(mockReturn);
        await waitFor(() => {
            render(
                <Selecao />
            );
        });
    });

    afterEach(()=>{jest.clearAllMocks()});

    test("Ao clicar em 9 cards, deve exibir Alert, exigindo exatamente 8 filmes.", () => {

        const listFilmes = [...Array(9).keys()];

        for (const index of listFilmes) {
            userEvent.click(screen.queryByTestId(`filme-${index + 1}`));
        }
        userEvent.click(screen.queryByTestId("btn-gera-campeonato"));
        const message = screen.queryByText("A quantidade de filmes exigidos é 8!");

        expect(message).toHaveTextContent("A quantidade de filmes exigidos é 8!");
    });

    test("Ao clicar em 7 cards, deve exibir Alert, exigindo exatamente 8 filmes.", () => {

        const listFilmes = [...Array(7).keys()];

        for (const index of listFilmes) {
            userEvent.click(screen.queryByTestId(`filme-${index + 1}`));
        }
        userEvent.click(screen.queryByTestId("btn-gera-campeonato"));
        const message = screen.queryByText("A quantidade de filmes exigidos é 8!");

        expect(message).toHaveTextContent("A quantidade de filmes exigidos é 8!");
    });

    test("Ao clicar em 8 carda, submeter executaCampionado", async () => {
        const mockApi = jest.spyOn(Adapter, "executaCampeonato").mockRejectedValue({
            status: 200,
            data: []
        });
        const listFilmes = [...Array(8).keys()];
        for (const index of listFilmes) {
                userEvent.click(screen.queryByTestId(`filme-${index + 1}`));
        } 
        userEvent.click(screen.queryByTestId("btn-gera-campeonato"));
        expect(screen.queryByText("A quantidade de filmes exigidos é 8!")).toBeFalsy()
        await expect(mockApi).toHaveBeenCalledTimes(1);
    });
});