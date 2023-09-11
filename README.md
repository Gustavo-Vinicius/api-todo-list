## 💻 Api Todo List .
## A aplicação se trata de um gerenciamento de tarefas, realizei a criação de um crud para esse gerenciamento de tarefas, incluindo os metódos : GET, POST, PUT, DELETE.
## 📫  Routes

### Todo List Controller

<img src="https://img.shields.io/badge/-GET-%2361AFFE" height="30" />

**"/api/tarefas"**

_Get todas as tarefas_

**response:**
```
[
  {
     "id": string,
     "Nome": string,
     "Detalhes": string,
     "Concluido": bool,
     "DataCadastro": DateTime
     "DataConclusao": DateTime
  }
]
```

<hr>


<img src="https://img.shields.io/badge/-POST-%2349CC90" height="30" />

**"/api/tarefas"**

_Cria uma nova tarefa_

**required headers:**

`"client"`

**body:**
```
{
     "Nome": string,
     "Detalhes": string,
     "Concluido": bool,
}
```

**response:**
```
{
     "id": string,
     "Nome": string,
     "Detalhes": string,
     "Concluido": bool,
     "DataCadastro": DateTime
     "DataConclusao": DateTime
}
```

<hr>

<img src="https://img.shields.io/badge/-PUT-%23FCA130" height="30" />

**"/api/tarefas/{id}"**

_Atualiza tarefa pelo Id_

**required headers:**

`Authorization: Bearer {token JWT}`

**roles:**

`"client"`

**route params:**

`id: int`

**body:**
```
{
     "id": string,
     "Nome": string,
     "Detalhes": string,
     "Concluido": bool,
}
```

**response:**
_No content_

<hr>

<img src="https://img.shields.io/badge/-DELETE-%23F93E3E" height="30" />

**"/api/tarefas/{id}"**

_Detetar tarefa pelo id cadastrado_

**required headers:**

`Authorization: Bearer {token JWT}`

**roles:**

`"client"`

**route params:**

`id: string`

**response:**
_No content_

<hr>

## 🌐 Status
<p>Em Desenvolvimento</p>

## 🔧 Installation
`$ git clone https://github.com/Gustavo-Vinicius/api-todo-list.git`

`$ cd dev/TaskManager.API`

`$ dotnet restore`

`$ dotnet ef database update -s ../TaskManager.API/TaskManager.API.csproj`

`$ cd ../TaskManager.API`

`$ dotnet run`

**Server listenning at  [https://localhost:5000/](https://localhost:5000/)!**

## 🔨 Tools used

<div>
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="80" /> 
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" width="80" />
<img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/mongodb/mongodb-original-wordmark.svg" width="80" />

</div>
