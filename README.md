# 🗂️ CRUD Demo Application

A simple ASP.NET Core MVC application that demonstrates **CRUD (Create, Read, Update, Delete)** operations using Entity Framework and SQL-based data storage.

This project is built for learning how real-world web applications manage and manipulate data through a structured MVC architecture.

---

## 🚀 Live Demo

👉 https://curd-demo-app.onrender.com/

---

## 📌 About the Project

This is a beginner-friendly demonstration project that shows how to:

* Add new records to a database
* Display stored data in a list/table
* Edit existing records
* Delete records from the system
* Connect ASP.NET Core MVC with Entity Framework
* Perform database-driven operations in a web application

CRUD functionality forms the backbone of most real-world applications such as admin panels, inventory systems, student portals, etc.

---

## 🏗️ Tech Stack

| Technology            | Purpose                     |
| --------------------- | --------------------------- |
| ASP.NET Core MVC      | Web Application Framework   |
| C#                    | Backend Programming         |
| Entity Framework Core | ORM for Database Operations |
| SQL Server / LocalDB  | Data Storage                |
| Razor Views           | UI Rendering                |
| HTML / CSS            | Frontend Layout             |
| Render                | Cloud Deployment            |

---

## 📂 Project Architecture

The application follows the **MVC (Model-View-Controller)** pattern:

* **Model** → Handles data structure and database interaction
* **View** → Displays UI to users
* **Controller** → Processes requests and performs CRUD logic

This separation keeps business logic, UI, and data handling independent and maintainable.

---

## ⚙️ How to Run Locally

### 1️⃣ Clone Repository

```bash
git clone https://github.com/Dhaked1/curd-demo-app.git
cd curd-demo-app
```

---

### 2️⃣ Configure Database

Update connection string inside:

```
appsettings.json
```

Create your database in SQL Server if required.

---

### 3️⃣ Apply Migrations

```bash
dotnet ef database update
```

---

### 4️⃣ Run the Application

```bash
dotnet run
```

Open in browser:

```
https://localhost:5001
```

---

## 🧪 Features Demonstrated

✔ Database Integration using Entity Framework
✔ Form-based Data Entry
✔ Record Listing and Details View
✔ Edit and Update Workflow
✔ Delete Confirmation Logic
✔ MVC Design Pattern Implementation

---

## 🌐 Deployment

The application is deployed using **Render** cloud hosting.

---

## 📈 Learning Goals of This Project

This project was created to understand:

* How ASP.NET Core handles data-driven applications
* How CRUD operations work internally
* How MVC architecture structures a web app
* How to deploy .NET apps to cloud platforms

---

## 👨‍💻 Author

**Dhaked**

GitHub: https://github.com/Dhaked1

---

## 📜 License

This project is created for educational and practice purposes.
