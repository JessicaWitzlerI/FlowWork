# 🧠 FlowWork – API para Gestão de Tarefas e Produtividade

* Jessica Witzler Costacurta | RM99068
* Camilly Breitbach Ishida | RM551474

## 📘 Contexto

Vivemos um momento de grandes transformações no mundo do trabalho: automação, inteligência artificial e modelos híbridos estão redefinindo como, quando e onde trabalhamos.  
Pensando nesse **Futuro do Trabalho**, o projeto **FlowWork** propõe uma solução digital para **gerenciar tarefas, equipes e produtividade**, promovendo um ambiente mais **organizado, seguro e humano**.

---

## 💡 Por que criamos essa ideia?

A ideia do **FlowWork** surgiu da necessidade de unir **tecnologia, automação e bem-estar no trabalho**.  
Com tantas mudanças no ambiente corporativo, as equipes precisam de ferramentas que:
- Organizem e monitorem tarefas de forma inteligente.
- Mantenham segurança e clareza nos fluxos de atividades.
- Favoreçam produtividade sem comprometer a saúde mental.

A API foi construída com **ASP.NET Core 10**, **Entity Framework Core** e **SQL Server**, garantindo escalabilidade, performance e boas práticas de desenvolvimento.

---

## ⚙️ Funcionalidades da API

| Recurso | Descrição |
|----------|------------|
| 🔐 **Autenticação JWT** | Gera token para acesso seguro à API. |
| 👥 **Usuários** | Cadastro, listagem, edição e exclusão de usuários. |
| 📋 **Tarefas** | Controle completo de tarefas (CRUD), associadas a usuários. |
| 🔄 **Relacionamento** | Cada tarefa pertence a um usuário (1:N). |
| 📊 **Status de tarefas** | Enum de status: “A Fazer”, “Em Andamento” e “Concluído”. |
| 🌐 **Versionamento da API** | Estrutura com `/api/v1/` pronta para futuras versões. |

---

## 🧩 Tecnologias Utilizadas

- **ASP.NET Core 10 (Web API)**
- **Entity Framework Core**
- **SQL Server**
- **JWT (JSON Web Token)**
- **Swagger UI**
- **C# 12**
- **Dependency Injection**

---

## 🌐 Banco de Dados SQL Server

Para que seja possível ter acesso ao banco de dados, é necessário que faça alteração no **appsettings.json** com o seu local host e acesse utilizando a **Autenticação do Windows**.

<img width="502" height="604" alt="image" src="https://github.com/user-attachments/assets/46c86f76-f54f-43a8-9e73-d468c0517d42" />

### Para Criar o Banco de Dados 

No terminal do Visual Studio você deve:

- Escrever: **Add-Migration InitialDB -Context SistemaTarefasDBContext**
  
Para criar a migração com o nome de InitialDB. 


- E depois escrever: **Update-Database -Context SistemaTarefasDBContext**

Para rodar a Migration. 

---

## 💡 Para Acessar o Swagger

- Execute o projeto (dotnet run ou F5).
- Abra o navegador e vá até https://localhost:5001/swagger.

### No navegador 

<img width="1365" height="629" alt="image" src="https://github.com/user-attachments/assets/4e3f79ce-4b6e-4723-ba5d-0664a6a2971b" />

---

## 🔐 Autenticação JWT

Antes de acessar os endpoints de Usuário e Tarefa, é necessário autenticar:

**"login": "admin"***
**"password": "admin"**

<img width="1352" height="435" alt="image" src="https://github.com/user-attachments/assets/8f8a7930-6aee-411f-9a6e-8a10fab59076" />


Após isso, será gerado um **token** que deve ser colocado em **Authorize**.


<img width="1346" height="707" alt="image" src="https://github.com/user-attachments/assets/27e11411-6493-4a45-9c94-a466d1f4dbab" />


Com isso, é possível ver os cadastros feitos e alterar as tabelas. Apenas administradores podem acessar. 


---

## 📋 Draw.io - Fluxo de Aplicação

![Sistema de Tarefas](https://github.com/user-attachments/assets/627591b5-94c7-4980-9fae-016d57cb15f3)

---

## 👥 Link do Vídeo 

https://youtu.be/xjW3QswIHAo






