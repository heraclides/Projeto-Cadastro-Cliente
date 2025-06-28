🐾 LHPet - Sistema de Cadastro de Clientes e Fornecedores

Projeto ASP.NET Core MVC desenvolvido para gerenciamento de clientes e fornecedores de uma clínica veterinária fictícia, **LHPet**.

---

## 🚀 Funcionalidades

-  Cadastro de **Clientes** (Nome, CPF, Email, Paciente)
-  Cadastro de **Fornecedores** (Nome, CNPJ, Email)
-  Listagem separada de clientes e fornecedores
-  Interface limpa e responsiva com Bootstrap
-  Visualização condicional: exibe tabelas apenas ao clicar em botões
-  Armazenamento dos dados no **SQL Server Express** usando **Entity Framework Core**
-  Validação e persistência real no banco de dados

---

## 🛠️ Tecnologias utilizadas

- ASP.NET Core MVC (.NET 8)
- C#
- Entity Framework Core
- SQL Server Express LocalDB
- Bootstrap 5
- Razor Views

---

## 💻 Como executar localmente

### Pré-requisitos:
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server Express](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- [SQL Server Management Studio (SSMS)](https://aka.ms/ssmsfullsetup)
- Visual Studio ou VS Code com extensão C#

### Etapas:

1. **Clone o repositório:**

```bash
git clone https://github.com/seu-usuario/LHPet.git
acesse a pasta do projeto abra o cmd e digite
cd LHPet
Configure a string de conexão no arquivo appsettings.json:

json
Copiar
Editar
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=LHPetDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
Crie o banco de dados e aplique as migrations:
utilize os codigos abaixo para criar as tabelas no BD atraves de cmd na pasta raiz.

dotnet ef migrations add InitialCreate
dotnet ef database update

Execute o projeto:
dotnet run

Acesse no navegador:

http://localhost:12700

📁 Estrutura do projeto

LHPet/
├── Controllers/
│   └── HomeController.cs
├── Models/
│   ├── Cliente.cs
│   └── Fornecedor.cs
├── Data/
│   └── LHPetContext.cs
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml
│   │   ├── CreateCliente.cshtml
│   │   └── CreateFornecedor.cshtml
│   └── Shared/_Layout.cshtml
├── appsettings.json
└── Program.cs

🤝 Contribuição
Contribuições são bem-vindas! Sinta-se à vontade para enviar pull requests ou abrir issues.

📝 Licença
Este projeto é apenas para fins educacionais e acadêmicos.
