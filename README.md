# API de CRUD de Produtos

Esta é uma API simples de CRUD (Create, Read, Update, Delete) desenvolvida em .NET Core, utilizando C# e Entity Framework Core para operações de banco de dados. A API permite a criação, leitura, atualização e exclusão de produtos.

## Endpoints Disponíveis

A API possui os seguintes endpoints:

- `GET /api/products`: Retorna todos os produtos cadastrados.
- `GET /api/products/{id}`: Retorna um produto específico com base no ID fornecido.
- `POST /api/products`: Cria um novo produto.
- `PATCH /api/products/{id}`: Atualiza parcialmente um produto existente com base no ID fornecido.
- `DELETE /api/products/{id}`: Exclui um produto existente com base no ID fornecido.

## Modelo de Dados

A API utiliza o seguinte modelo de dados para os produtos:

```json
{
  "id": "guid",
  "name": "string",
  "description": "string",
  "price": "decimal",
  "category": "string"
}
```

Claro, aqui está um exemplo de README.md para sua API CRUD de produtos:

markdown
Copy code
# API de CRUD de Produtos

Esta é uma API simples de CRUD (Create, Read, Update, Delete) desenvolvida em .NET Core, utilizando C# e Entity Framework Core para operações de banco de dados. A API permite a criação, leitura, atualização e exclusão de produtos.

## Endpoints Disponíveis

A API possui os seguintes endpoints:

- `GET /api/products`: Retorna todos os produtos cadastrados.
- `GET /api/products/{id}`: Retorna um produto específico com base no ID fornecido.
- `POST /api/products`: Cria um novo produto.
- `PUT /api/products/{id}`: Atualiza um produto existente com base no ID fornecido.
- `PATCH /api/products/{id}`: Atualiza parcialmente um produto existente com base no ID fornecido.
- `DELETE /api/products/{id}`: Exclui um produto existente com base no ID fornecido.

## Modelo de Dados

A API utiliza o seguinte modelo de dados para os produtos:

```json
{
  "id": "guid",
  "name": "string",
  "description": "string",
  "price": "decimal",
  "category": "string"
}
```
# Como Usar

- Certifique-se de ter o .NET Core SDK instalado na sua máquina.

- Clone este repositório para o seu ambiente local:

```
git clone https://github.com/seu-usuario/Products-CRUD-DotNet.git
```

- Navegue até o diretório do projeto:

```
cd Products-CRUD-DotNet
```

- Execute as migrações do banco de dados para criar o esquema do banco de dados:

```
dotnet ef database update
```

- Execute o projeto usando o comando dotnet run:

```
dotnet run
```
- A API estará disponível em https://localhost:5197 por padrão.

- Você pode testar os endpoints usando ferramentas como Postman ou Swagger UI.

# Configuração do Banco de Dados
- Esta API utiliza o PostgreSQL como banco de dados. Certifique-se de configurar corretamente a string de conexão no arquivo appsettings.json.
