# Hotel Finder Web API

# Screenshots

<img width="1482" alt="1" src="https://github.com/user-attachments/assets/04818d93-d131-4399-a7f4-380b8c5c3d42" />

## Overview
 
Hotel Finder Web API is an ASP.NET Core Web API application that allows users to search for hotels. This API provides a RESTful service to query, filter, and list hotel data. It offers a flexible and extensible backend infrastructure that can be used in hotel search and reservation platforms.

## Technologies Used

- ASP.NET Core Web API: The framework used for building the API.
- Entity Framework Core: ORM (Object-Relational Mapping) technology used for database operations.
- SQL Server: Database management system.
- Swagger: Used for API documentation and testing.

### Installation and Setup

Follow these steps to set up the project on your local machine:

1. ### Clone the Repository
 
  ```
  git clone https://github.com/aliyldiz/hotel-finder-webapi.git
  cd hotel-finder-webapi
  ```

2. ### Install Dependencies

Restore the required NuGet packages:
  
  ```  
  dotnet restore
  ```

3. ### Database Setup

Use EF Core Migrations to set up the database:
  
  ```
  dotnet ef database update
  ```

4. ### Run the Project

Start the project on your local server:

  ```
  dotnet run
  ```

5. ### Access the Application

The project will run at the following address:
  
  ```
  http://localhost:5000
  ```

## Contributing

We welcome contributions! To contribute, please follow these steps:

### Steps to Contribute

1. Fork the repository.
2. Create a new branch: `git checkout -b feature/FeatureName`.
3. Make your changes: `git commit -m 'Add some feature'`.
4. Push to the branch: `git push origin feature/FeatureName`.
5. Open a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any inquiries or issues, please contact [Ali Yildiz](https://github.com/aliyldiz).
