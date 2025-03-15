🏆 Employee Management System API

This is a RESTful Employee Management System API built with ASP.NET Core (.NET 8) using Entity Framework Core for data persistence and JWT-based authentication for securing endpoints.
🚀 Project Overview

This API allows authenticated users to manage employee data. It includes the following features:
✅ JWT-based Authentication and Authorization
✅ CRUD Operations for Employee Management
✅ User Registration and Login
✅ Protected Endpoints for Employee Operations
🏗️ Tech Stack

    Backend: .NET 8 (ASP.NET Core)
    Database: SQL Server
    ORM: Entity Framework Core
    Security: JWT (JSON Web Token)
    Tooling: Swagger UI for API testing

📂 Project Structure

📦 EmployeeManagementSystem
├── 📁 Controllers
│   ├── AuthController.cs
│   └── EmployeeController.cs
├── 📁 Data
│   ├── AppDbContext.cs
├── 📁 Models
│   ├── Employee.cs
│   └── User.cs
├── 📁 Services
│   ├── IEmployeeService.cs
│   ├── EmployeeService.cs
│   ├── IUserService.cs
│   └── UserService.cs
├── 📄 Program.cs
├── 📄 appsettings.json
└── 📄 README.md

⚙️ Setup Instructions
✅ Step 1: Clone the Repository

git clone https://github.com/your-username/EmployeeManagementSystem.git
cd EmployeeManagementSystem

✅ Step 2: Setup the Database

    Open SQL Server Management Studio
    Create a new database:

    CREATE DATABASE EmployeeDB;

    Update the connection string in appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EmployeeDB;Trusted_Connection=True;"
}

✅ Step 3: Apply Migrations

Run the following commands in the terminal to create database tables:

dotnet ef migrations add InitialCreate
dotnet ef database update

✅ Step 4: Run the Application

To start the server:

dotnet run

✅ Step 5: Open Swagger UI

Open your browser:

https://localhost:7210/swagger/index.html

🔐 Authentication Setup

To protect endpoints using JWT:

    Register a user using /api/auth/register
    Log in using /api/auth/login to get a token
    Use the token to authorize other endpoints

📌 API Endpoints
🔑 1. Authentication Endpoints
Method	Route	Description
POST	/api/auth/register	Register a new user
POST	/api/auth/login	Authenticate user and generate JWT token
👥 2. Employee Endpoints
Method	Route	Description	Authorization
GET	/api/employee	Get all employees	✅
GET	/api/employee/{id}	Get employee by ID	✅
POST	/api/employee	Create a new employee	✅
PUT	/api/employee/{id}	Update employee by ID	✅
DELETE	/api/employee/{id}	Delete employee by ID	✅
💡 Request/Response Examples
✅ 1. Register a New User

Request

POST /api/auth/register
{
  "username": "john",
  "password": "pass123"
}

Response

{
  "message": "User registered successfully!"
}

✅ 2. Login to Get JWT Token

Request

POST /api/auth/login
{
  "username": "john",
  "password": "pass123"
}

Response

{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}

✅ 3. Create Employee

Request

POST /api/employee
{
  "firstName": "John",
  "lastName": "Doe",
  "email": "john@example.com",
  "dateOfBirth": "1990-05-15",
  "position": "Software Engineer"
}

Response

{
  "id": 1,
  "firstName": "John",
  "lastName": "Doe",
  "email": "john@example.com",
  "dateOfBirth": "1990-05-15",
  "position": "Software Engineer"
}

✅ 4. Get All Employees

Request

GET /api/employee

Response

[
  {
    "id": 1,
    "firstName": "John",
    "lastName": "Doe",
    "email": "john@example.com",
    "dateOfBirth": "1990-05-15",
    "position": "Software Engineer"
  }
]

✅ 5. Update Employee

Request

PUT /api/employee/1
{
  "firstName": "Johnny",
  "lastName": "Doe",
  "email": "johnny@example.com",
  "dateOfBirth": "1990-05-15",
  "position": "Senior Engineer"
}

Response

{
  "id": 1,
  "firstName": "Johnny",
  "lastName": "Doe",
  "email": "johnny@example.com",
  "dateOfBirth": "1990-05-15",
  "position": "Senior Engineer"
}

✅ 6. Delete Employee

Request

DELETE /api/employee/1

Response

{
  "message": "Employee deleted successfully"
}

🛡️ Authentication & Authorization

    JWT-based authentication is used to secure endpoints
    All EmployeeController endpoints require an authorization token
    Use Swagger’s Authorize button to add the token

🚦 Troubleshooting
Issue	Solution
401 Unauthorized	Ensure the token is valid and not expired
500 Internal Server Error	Check database connection and migrations
Invalid username or password	Ensure correct login credentials
🏆 Future Improvements

    Add role-based authorization
    Implement password hashing for better security
    Add unit tests for better coverage

🌟 Contributors

👨‍💻 Your Name
📄 License

This project is licensed under the MIT License.
🎯 Done! 🚀

🔥 Now you're ready to manage employees with secure authentication! 😎
