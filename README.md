
![Badge](https://img.shields.io/badge/React-17.0-information?style=flat&logo=React&logoColor=white&color=61DAFB) ![Badge](https://img.shields.io/badge/.NET-5.0-information?style=flat&logo=.NET&logoColor=white&color=512BD4) ![Badge](https://img.shields.io/badge/Node.js-14.17-information?style=flat&logo=Node.js&logoColor=white&color=339933) ![Badge](https://img.shields.io/badge/Yarn-1.22-information?style=flat&logo=Yarn&logoColor=white&color=2C8EBB) ![Badge](https://img.shields.io/badge/Docker-20.1-information?style=flat&logo=Docker&logoColor=white&color=2496ED) ![Badge](https://img.shields.io/badge/OPENAPI-3.0-information?style=flat&&color=Green) ![Badge](https://img.shields.io/badge/VS%20Code-1.60-information?style=flat&logo=Visual-Studio-Code&logoColor=white&color=007ACC)

# Campeonato de Filmes

Web App e API para realização de um campeonato entre 8 filmes, a fim de identificar os dois melhores.

### Status

Concluído 🚀

## Tabela de conteúdos

<!--ts-->
*  [Pre Requisitos](#pre-requisitos)
*  [Demonstração](#demonstração)
*  [Testes](#testes)
*  [Tecnologias](#tecnologias)
<!--te-->

## Pré-requisitos

📃 Para a abertura dos projetos contidos neste repositório, estabelecem-se os seguintes requisitos:

*  [Node.js 14.17](https://nodejs.org/)
*  [Yarn 1.22](https://classic.yarnpkg.com/en/docs/install/#windows-stable)
*  [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
*  [Visual Studio Code](https://code.visualstudio.com/download)

🚀 Para a mera execução demonstrativa dos projetos, os requisitos são:

*  [Docker Desktop 4 / Docker Engine 20.10](https://docs.docker.com/get-docker/)

## Demonstração

A demonstração consiste na construção de um container docker contendo as duas aplicações. O procedimento deve ser realizado dessa forma:

### Passo 1:

📁 No diretório raiz do repositório, execute o seguinte comando:

```
docker-compose up --build
```

Imediatamente o docker iniciará a compilação dos projetos. Ao final da compilação, é esperada a seguinte saída:  
```
Starting kennedysouza-20210913_api_1 ... done
Creating kennedysouza-20210913_web_app_1 ... done
Attaching to kennedysouza-20210913_api_1, kennedysouza-20210913_web_app_1
api_1 | info: Microsoft.Hosting.Lifetime[0]
api_1 | Now listening on: http://[::]:80
api_1 | info: Microsoft.Hosting.Lifetime[0]
api_1 | Application started. Press Ctrl+C to shut down.
api_1 | info: Microsoft.Hosting.Lifetime[0]
api_1 | Hosting environment: development
api_1 | info: Microsoft.Hosting.Lifetime[0]
api_1 | Content root path: /app
```
### Passo 2:
✅ Ao fim do processo de compilação, as aplicações podem ser acessadas a partir dos seguintes endereços:

* Web App - Campeonato de Filmes : http://localhost:7894

* API - Campeonato de Filmes : http://localhost:7654/swagger

  

Para Interromper a execução, pressione Ctrl + C dentro do mesmo terminal, ou execute no diretório raiz do repositório, o seguinte comando:
```
docker-compose down
```

## Testes

### API
Para executar os testes do projeto da API, no diretório ```Api``` execute o seguinte comando:
```
dotnet test
```
### Web App
Para executar os testes do projeto do Web App, no diretório ```web-app\campeonato-filmes``` execute o seguinte comando:
```
yarn test
```


## Tecnologias

*  [C#](https://docs.microsoft.com/pt-br/dotnet/csharp/)
*  [.NET 5](https://docs.microsoft.com/pt-br/dotnet/)
*  [JavaScript](https://www.javascript.com/)
*  [React](https://reactjs.org/)