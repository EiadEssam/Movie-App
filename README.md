# 🎬 Movie App - ASP.NET Core MVC

![ASP.NET Core](https://img.shields.io/badge/.NET-6.0-512BD4?logo=dotnet)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.2-7952B3?logo=bootstrap)
![License](https://img.shields.io/badge/license-MIT-yellow)

A sleek movie management application with a **black & yellow** modern theme, built using **ASP.NET Core MVC**.

---

## ✨ Features

- **CRUD Operations** – Create, read, update, and delete movies  
- **Genre Filtering** – Filter movies by genre  
- **Search Functionality** – Find movies by title  
- **Interactive Star Ratings** – Visual 5-star rating system  
- **Responsive Design** – Optimized for desktop and mobile  
- **Modern UI** – Black/yellow high-contrast theme  

---

## 🛠️ Tech Stack

| Technology               | Purpose                   |
|--------------------------|---------------------------|
| **ASP.NET Core MVC**     | Backend framework         |
| **Entity Framework Core**| Database operations       |
| **Bootstrap 5**          | Frontend styling          |
| **jQuery**               | Client-side interactions  |
| **Bootstrap Icons**      | UI icons                  |

---

## 🚀 Run Locally

### **Prerequisites**
- [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)  
- [SQL Server LocalDB](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb) (comes with Visual Studio)  
- Visual Studio 2022 (Recommended) or VS Code  

---

### **Steps**
1. **Clone the repository**
   ```bash
   git clone https://github.com/EiadEssam/MvcMovie.git
   cd MvcMovie
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Update the database**
   - Check the connection string in `appsettings.json` (defaults to LocalDB)
   - Run:
     ```bash
     dotnet ef database update
     ```

4. **Run the application**
   ```bash
   dotnet run
   ```
   Or press **F5** in Visual Studio.

5. **Open in browser**
   ```
   https://localhost:5001
   ```
   (Port may vary; check the console output after running)

---

## 📂 Project Structure
```
MvcMovie/
├── Controllers/       # MVC controllers
├── Models/            # Data models
├── Views/             # Razor views
│   ├── Home/          # Home/About pages
│   └── Movies/        # Movie CRUD pages
├── wwwroot/           # Static assets (CSS, JS, images)
└── appsettings.json   # Configuration (DB connection, etc.)
```

---

## 👨‍💻 Developer

**Eiad Essam**  
🔗 [GitHub](https://www.github.com/EiadEssam)  
🔗 [LinkedIn](https://www.linkedin.com/in/eiad-essam-50771a254/)  
📧 **eiad103essam@gmail.com**

---

<div align="center">
  <sub>Built with ♥ using ASP.NET Core & Bootstrap</sub>
</div>


---

