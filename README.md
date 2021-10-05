# ProjetoCSharp 
![Badge](https://img.shields.io/badge/.NET5-WebApi-%237159c1?style=for-the-badge&logo=c-sharp&logoColor=green)

## :scroll: Roadmap:
 * [Sobre](#sobre)
 *  [Ferramentas](#ferramntas-utilizadas)   
 *  [To Do List](#to-do-list) 


### :notebook: Sobre
- Esse projeto é uma construção gradual de uma WebAPI em .Net5. 🚧  Ainda em construção... :construction_worker:
- Obs: o HelloWorld foi modificado para observação de como ficou mais enxuto a utilização do .Net 5;

### :wrench: Ferramntas Utilizadas 
* [.NET5](https://dotnet.microsoft.com/download/dotnet/5.0); 
* Editor de texto [VSCode](https://code.visualstudio.com/Download);
* [Git](https://code.visualstudio.com/Download);
* [GitHub Desktop](https://desktop.github.com/).

### :heavy_check_mark: To Do List (HelloWorld)
- **1 -** Crie um repositório no GitHub;
- **2 -** Clone o projeto para a sua maquina e abra no VSCode;
- **3 -** Crie um .gitignore, pode ser o [exemplo](https://github.com/TheJessicaBohn/ProjetoCSharp/blob/main/.gitignore) deste repositório; 
- **4 -** Execute o comando ```dotnet --version``` para podermos ver a versão instalado do .Net;
- **5 -** Crie uma pasta com o nome do projeto e entre na mesma pelo comando ```cd nomeDaPasta``` ;
- **6 -** Execute o comando: ```dotnet new console```;
- **7 -** Para executar o projeto execute o comando ```dotnet run```;

### :heavy_check_mark: To Do List (WebAPI)

- **1 -** Mesmo passo a passo do **HelloWorld** até o passo **5**, podendo pular os passos caso o projeto seja criado no mesmo repositório;
- **2 -** Execute o comando: ```dotnet new webapi```;
- **3 -** 41 min aula 15
- **4 -** 
- **5 -** 
-  Para testar execute: ```dotnet run``` e clique em: http://localhost:5000 e coloque /WeatherForecast no navegador quando abrir a janela, e será retornado um json;
- **6 -** Crie um novo Controller na pastas Controllers criada pelo comando ```dotnet new webapi```, como no exemplo [MovieControlle.cs](https://github.com/TheJessicaBohn/ProjetoCSharp/blob/main/Controllers/MovieController.cs);
- dotnet add package Microsoft.EntityFrameworkCore.Sqlite instalar pacotes
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet tool install --global dotnet-ef
- dotnet ef migrations add PrimeiraVersao
- dotnet ef database update
- `dotnet add package FluentValidation` e `dotnet add package FluentValidation.AspNetCore`

### :watch: Outros Comandos:
- ```dotnet new``` serve como um helper com vários templates para completar o comando e iniciar o projeto;

### :bulb: Dicas:
- Todos os anos saí uma nova versão de .Net, se não quer perder as atualizações leia a [documentação](https://docs.microsoft.com/pt-br/dotnet/); 
- VSCode, funciona como uma pagina web então pode-se utilizar os mesmos comandos de um navegador dentro do editor;
