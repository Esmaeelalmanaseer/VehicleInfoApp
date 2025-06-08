# VehicleInfoApp 

A web application built with ASP.NET Core Blazor Server that allows users to select a car make and manufacturing year, and view related vehicle types and models using the [NHTSA API](https://vpic.nhtsa.dot.gov/api/).

---

## 🛠 Requirements

- .NET 8 SDK
- Docker & Docker Compose
- Visual Studio 2022+ or VS Code
- GitHub account (for deployment or source control)

---

## ▶️ Run Locally

Clone the repository and run the app using .NET CLI:

```bash
git clone https://github.com/YOUR_USERNAME/VehicleInfoApp.git
cd VehicleInfoApp
dotnet run
 docker build --no-cache -t vehicleinfoapp .
docker-compose up --build
