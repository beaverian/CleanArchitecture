Clean Architecture E-Commerce Solution
Welcome to the Clean Architecture E-Commerce Solution, an advanced and scalable e-commerce platform built with the .NET 8 SDK and ASP.NET Core. This solution adheres to the principles of Clean Architecture, ensuring that our application is maintainable, extensible, and easily deployable across various environments. By structuring our solution into clearly separated layers and focusing on encapsulating the core business logic, we aim to provide a flexible architecture that can adapt to the changing needs of e-commerce businesses.

Solution Structure
Our solution is meticulously organized into four primary projects, each serving a specific function:

Core: The centerpiece of our solution, this project contains the domain entities and interfaces. It encapsulates essential business logic and rules, forming the foundation of our application.
Application: This project is dedicated to implementing the application's use cases through the CQRS (Command Query Responsibility Segregation) pattern. It includes commands for executing data manipulation operations and queries for data retrieval, promoting a clean separation of concerns.
Infrastructure: Here, we implement the interfaces defined in the Core project. This project is responsible for concrete data access, integration with third-party services, and handling other infrastructure tasks.
WebAPI: Acting as the presentation layer, this project exposes the application's functionalities through a RESTful API. It serves as the primary entry point for client applications, directing their requests to the appropriate command or query handlers within the Application layer.
Key Features
Product Management: Effortlessly manage your product inventory, including creating, updating, listing, and deleting products.
Order Processing: A comprehensive system for managing orders, processing payments, and overseeing shipments.
Customer Management: Maintain detailed customer profiles, encompassing order history, preferences, and saved payment methods.
Shopping Cart: A dynamic shopping cart system, enabling customers to manage their product selections before finalizing their purchases.
Payment Integration: Support for various payment methods and gateways, ensuring secure and versatile payment processing options.
Shipping Integration: Configure shipping options and integrate with providers to offer real-time rates and tracking capabilities.
Technologies
.NET 8 SDK: Utilized for building both the RESTful API and the web application, harnessing the latest advancements in .NET technology.
Entity Framework Core: Our chosen ORM for seamless data access, configured to work with SQL Server for data persistence.
MediatR: Facilitates the implementation of the CQRS pattern, streamlining the handling of commands and queries.
Swagger: Provides comprehensive API documentation and an interactive testing interface.
Getting Started
To begin working with this solution:

Ensure the .NET 8 SDK and SQL Server are installed on your machine.
Clone the repository to your local environment.
Navigate to the CleanArchitectureECommerce.WebApi project directory. Update the appsettings.json with your SQL Server connection string.
Open a terminal in the project directory and execute dotnet restore to install dependencies.
Use dotnet ef database update to apply existing database migrations.
Launch the application with dotnet run.
For more in-depth setup instructions and guidelines on contributing to this project, please refer to the sections that follow.

Contributing
Contributions are warmly welcomed and greatly appreciated. Whether it's adding new features, fixing bugs, or enhancing documentation, your input helps improve this project for everyone. Check out the CONTRIBUTING.md file for more information on making contributions.

License
This project is made available under the MIT License. For more details, see the LICENSE file.
