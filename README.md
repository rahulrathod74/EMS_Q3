🏆 EmployeeAPI

This is a RESTful Employee Management System API built with ASP.NET Core (.NET 8) using Entity Framework Core for data persistence and JWT-based authentication for securing endpoints.
🚀 Project Overview

This API allows authenticated users to manage employee data. It includes the following features:
✅ JWT-based Authentication and Authorization
✅ CRUD Operations for Employee Management
✅ User Login and JWT Token Generation
✅ Protected Endpoints for Employee Operations
✅ Clean Code Following SOLID Principles
🏗️ Tech Stack

    Backend: .NET 8 (ASP.NET Core)
    Database: SQL Server
    ORM: Entity Framework Core
    Security: JWT (JSON Web Token)
    Tooling: Swagger UI for API testing

📂 Project Structure

📦 EmployeeApi
├── 📁 Controllers
│ ├── AuthController.cs
│ └── EmployeeController.cs
├── 📁 Data
│ └── AppDbContext.cs
├── 📁 Models
│ ├── Employee.cs
│ └── UserLogin.cs
├── 📁 Services
│ ├── IEmployeeService.cs
│ └── EmployeeService.cs
├── 📄 Program.cs
├── 📄 appsettings.json
└── 📄 README.md
⚙️ Setup Instructions

✅ Step 1: Clone the Repository

git clone https://github.com/your-username/EmployeeApi.git
cd EmployeeApi

✅ Step 2: Setup the Database

    Open SQL Server Management Studio
    Create a new database:

CREATE DATABASE EmployeeDB;

    Update the connection string in appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=EmployeeDB;Integrated Security=True;Trust Server Certificate=True"
}

✅ Step 3: Apply Migrations
Generate the database schema using the following commands:

dotnet ef migrations add InitialCreate
dotnet ef database update

✅ Step 4: Run the Application
To start the server:

dotnet run

✅ Step 5: Open Swagger UI
Open your browser:

https://localhost:7127/swagger/index.html

🔐 Authentication Setup

    Register a user using /api/auth/login
    Log in to get a JWT token
    Use the token to authorize other endpoints via Swagger

📌 API Endpoints
🔑 1. Authentication Endpoints

POST /api/auth/login – Authenticate user and generate JWT token

    Example Request:

{
  "username": "rahul",
  "password": "rahi123"
}

    Example Response:

{
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
}

👥 2. Employee Endpoints

GET /api/employee – Get all employees (Authorization Required)

    Example Request:

curl -X GET "https://localhost:7127/api/employee" -H "Authorization: Bearer <JWT_TOKEN>"

    Example Response:

[
  {
    "id": 1,
    "firstName": "Rahul",
    "lastName": "Rathod",
    "email": "rahul@example.com",
    "dateOfBirth": "1995-02-25",
    "position": "Software Engineer",
    "salary": 75000
  }
]

GET /api/employee/{id} – Get employee by ID (Authorization Required)

    Example Request:

curl -X GET "https://localhost:7127/api/employee/1" -H "Authorization: Bearer <JWT_TOKEN>"

    Example Response:

{
  "id": 1,
  "firstName": "Rahul",
  "lastName": "Rathod",
  "email": "rahul@example.com",
  "dateOfBirth": "1995-02-25",
  "position": "Software Engineer",
  "salary": 75000
}

POST /api/employee – Create a new employee (Authorization Required)

    Example Request:

{
  "firstName": "Rahul",
  "lastName": "Rathod",
  "email": "rahul@example.com",
  "dateOfBirth": "1995-02-25",
  "position": "Software Engineer",
  "salary": 75000
}

    Example Response:

{
  "id": 2,
  "firstName": "Rahul",
  "lastName": "Rathod",
  "email": "rahul@example.com",
  "dateOfBirth": "1995-02-25",
  "position": "Software Engineer",
  "salary": 75000
}

PUT /api/employee/{id} – Update an employee (Authorization Required)

    Example Request:

{
  "firstName": "Johnny",
  "lastName": "Doe",
  "email": "johnny@example.com",
  "dateOfBirth": "1990-05-15",
  "position": "Senior Engineer",
  "salary": 90000
}

    Example Response:

{
  "id": 1,
  "firstName": "Johnny",
  "lastName": "Doe",
  "email": "johnny@example.com",
  "dateOfBirth": "1990-05-15",
  "position": "Senior Engineer",
  "salary": 90000
}

DELETE /api/employee/{id} – Delete an employee (Authorization Required)

    Example Request:

curl -X DELETE "https://localhost:7127/api/employee/1" -H "Authorization: Bearer <JWT_TOKEN>"

    Example Response:

{
  "message": "Employee deleted successfully"
}

🛡️ Authentication & Authorization

    JWT-based authentication is used to secure endpoints.
    All EmployeeController endpoints require a valid JWT token.
    Use Swagger's "Authorize" button to enter the token.

🚦 Troubleshooting

401 Unauthorized:

    Ensure the token is valid and not expired.
    Verify JWT configuration in appsettings.json.

500 Internal Server Error:

    Check database connection and migrations.
    Ensure Program.cs contains the correct services.

Invalid Username or Password:

    Ensure login credentials are correct.

🏆 Future Improvements

✅ Add role-based authorization
✅ Implement password hashing for better security
✅ Add unit tests for improved coverage
🌟 Contributors

👨‍💻 Rahul Rathod
📄 License

This project is licensed under the MIT License.
🎯 Done! 🚀

🔥 Now you're ready to manage employees with secure authentication! 😎
