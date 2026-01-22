# TaskFlow – Full Stack Task Manager

TaskFlow is a full-stack task management application built to demonstrate the integration between a modern Vue.js frontend and a robust ASP.NET Core REST API with real database persistence.

---

## 🚀 Tech Stack

### Backend
- ASP.NET Core Web API
- .NET (LTS)
- Entity Framework Core
- SQLite (local database)
- Swagger / OpenAPI
- Dependency Injection
- DTO-based API design
- CORS configuration

### Frontend
- Vue.js 3
- Vite
- Axios
- Composition API
- Modern CSS UI

---

## ⚙️ How to Run the Project Locally

### 🔹 Backend (ASP.NET Core + SQLite)

cd backend/TaskFlow.Api  
dotnet run  

The API will be available at:  
https://localhost:7125/swagger  

To create or update the local database:  
dotnet ef database update  

This will generate the SQLite file (taskflow.db) locally.

---

### 🔹 Frontend (Vue.js)

cd frontend/taskflow-web  
npm install  
npm run dev  

The frontend will be available at:  
http://localhost:5173  

---

## 🔄 Features

- Create tasks  
- List all tasks  
- Mark tasks as completed  
- Delete tasks  
- Prevent duplicate task titles  
- Data persistence using SQLite  
- RESTful API integration  
- Swagger API documentation  

---

## 🧠 Architecture Highlights

- RESTful API with proper HTTP status codes  
- Entity Framework Core for data persistence  
- SQLite for local development database  
- DTOs used to separate domain models from API responses  
- Repository pattern with dependency injection  
- CORS configured for frontend integration  

---

## 📌 Future Improvements

- User authentication and authorization (JWT)  
- Pagination and filtering  
- Global error handling  
- Unit and integration tests  
- UI enhancements  
- Docker support  
- Cloud deployment  

---

## 👤 Author

Ian Chaves  
Software Developer (.NET / Vue.js)
