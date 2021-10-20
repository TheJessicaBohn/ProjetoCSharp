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
* [Git](https://code.visualstudio.com/Download), deve ser colocada na variavel Path;
* [GitHub Desktop](https://desktop.github.com/).

### :heavy_check_mark: To Do List [(HelloWorld)](https://github.com/TheJessicaBohn/ProjetoCSharp/edit/main/README.md)
- **1 -** Instale as [Ferramentas Utilizadas](#ferramntas-utilizadas) 
- **2 -** Crie um repositório no GitHub;
- **3 -** Clone (se preferir pode ser pelo GitHub Desktop) o projeto para a sua maquina e abra no VSCode;
- **4 -** Crie um .gitignore, pode ser o [exemplo](https://github.com/TheJessicaBohn/ProjetoCSharp/blob/main/.gitignore) deste repositório; 
- **5 -** Execute o comando ```dotnet --version``` para podermos ver a versão instalado do .Net;
- **6 -** Crie uma pasta com o nome do projeto e entre na mesma pelo comando ```cd nomeDaPasta``` ;
- **7 -** Execute o comando: ```dotnet new console```;
- **8 -** Para executar o projeto execute o comando ```dotnet run```;

### :heavy_check_mark: To Do List [(WebAPI)](https://github.com/TheJessicaBohn/ProjetoCSharp/tree/main/Projeto)

- **1 -** Mesmo passo a passo do **HelloWorld** até o passo **6**, podendo pular os passos caso o projeto seja criado no mesmo repositório;
- **2 -** Execute o comando: ```dotnet new webapi```;
- **3 -** Para testar execute: ```dotnet run``` e Ctrl+clique em: http://localhost:5001 e coloque /WeatherForecast no navegador quando abrir a janela, e será retornado um json;
- **4 -** Mas para facilitar pode colocar o seguinte entredereço http://localhost:5001/swagger/idex.html
- **5 -** aula16 56:47
- **6 -** Crie um novo Controller na pastas Controllers criada pelo comando ```dotnet new webapi```, como no exemplo [MovieControlle.cs](https://github.com/TheJessicaBohn/ProjetoCSharp/blob/main/Controllers/MovieController.cs);
- dotnet add package Microsoft.EntityFrameworkCore.Sqlite instalar pacotes
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet tool install --global dotnet-ef
- dotnet ef migrations add PrimeiraVersao
- dotnet ef database update
- `dotnet add package FluentValidation` e `dotnet add package FluentValidation.AspNetCore`

### :watch: Outros Comandos, atalhos e utilitários:
- ```dotnet new``` serve como um helper com vários templates para completar o comando e iniciar o projeto;
- No terminal digite ```code.``` e ele vai abrir o VSCode;
- Comentários: /* comenta multiplas linhas */, // comenta uma linha;
- Variáveis:
  - bool myBool = true; //true or false; 
  - byte myByte = 255; //0 to 255;
  - char myChar = 'j'; //U +0000 to U +ffff;
  - decimal myDecimal = 1m; //128-bit decimal values;
  - double myDouble = 1d; //64-bit double-precision;
  - float myFloat = 1f; //32-bit single-precision;
  - int myInt = 1; //-2,147,483,648 to 2,147,483,647;
  - long myLong = 1L; //64-bit singned integer type;
  - sbyte mySbyte = 1; //-128 to 127;
  - short myShort = 1; //-32,768 to 32,767;
  - uint myUint = 1; //0 to 4,294,967,295;
  - ulong myUlong = 1; //0 to 18,446,744,073,709,551,615;
  - ushort myUshort = 1; //0 to 65,535;

### :bulb: Dicas:
- Todos os anos saí uma nova versão de .Net, se não quer perder as atualizações leia a [documentação](https://docs.microsoft.com/pt-br/dotnet/); 
- VSCode, funciona como uma pagina web então pode-se utilizar os mesmos comandos de um navegador dentro do editor;
- Um bom programador é um bom googador ["Andre N. Darcie"](https://github.com/andredarcie);
- Tente seguir projetos do GitHub parecidos com a sua ideia para você aprender;
- Pesquise em inglês;
- O .gitignore do C# ou DotNet é o template do VisualStudio, na hora de adicionar um a um projeto novo ao repositório do GitHub; 
- A Cada modificação do seu projeto é interssante commitar com um titulo no seu GitHub para que, você possa acompanhar o histórico da evolução com mais clareza; 
