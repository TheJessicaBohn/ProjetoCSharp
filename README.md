# ProjetoCSharp 
![Badge](https://img.shields.io/badge/.NET5-WebApi-%237159c1?style=for-the-badge&logo=c-sharp&logoColor=green)

## :scroll: Roadmap:
 * [Sobre](#sobre)
 *  [Ferramentas](#ferramntas-utilizadas)   
 *  [To Do List](#to-do-list) 


### :notebook: Sobre
Esse projeto é uma construção gradual de uma WebAPI em .Net5. 🚧  Ainda em construção... :construction_worker:

### :wrench: Ferramntas Utilizadas
* [.NET5](https://dotnet.microsoft.com/download/dotnet/5.0); 
* Editor de texto [VSCode](https://code.visualstudio.com/Download);
* [Git](https://code.visualstudio.com/Download);
* [GitHub Desktop](https://desktop.github.com/).

### :heavy_check_mark: To Do List

- **1 -** Crie um repositório no GitHub;
- **2 -** Clone o projeto para a sua maquina e abra no VSCode;
- **3 -** Crie um .gitignore, pode ser o exemplo deste repositório;
- **4 -** Execute o comando: ```dotnet new webapi```;
- **5 -** Para testar execute: ```dotnet run``` e clique em: http://localhost:5000 e coloque /WeatherForecast no navegador quando abrir a janela, e será retornado um json;
- **6 -** Crie um novo Controller na pastas Controllers criada pelo comando ```dotnet new webapi```, como no exemplo [MovieControlle.cs](https://github.com/TheJessicaBohn/ProjetoCSharp/blob/main/Controllers/MovieController.cs);
- dotnet add package Microsoft.EntityFrameworkCore.Sqlite instalar pacotes
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet tool install --global dotnet-ef
- dotnet ef migrations add PrimeiraVersao
- dotnet ef database update
- `dotnet add package FluentValidation` e `dotnet add package FluentValidation.AspNetCore`
