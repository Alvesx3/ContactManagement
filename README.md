# Contact Management Web Application

## Description

Contact Management is an ASP.NET Core web application built to manage contacts efficiently. It allows users to add, view, edit, and delete contacts. The application uses Razor Pages and MariaDB to store contact data.

## Features

- View a list of existing contacts
- Add new contacts
- Edit existing contacts
- Delete contacts (soft delete)

## Technologies Used

- ASP.NET Core (Razor Pages)
- Entity Framework Core with MariaDB
- HTML, CSS, and JavaScript (Bootstrap for styling)
- MariaDB 10.6

## How to Use

1. Clone the repository to your local machine using the following command:
    - https://github.com/Alvesx3/ContactManagement
2. Set up the database:
    - Install MariaDB 10.6 and create a new database named "ContactManagement".
    - Update the connection string in the "appsettings.json" file to match your MariaDB configuration.

3. Build and run the application:
    - cd ContactManagement
    - dotnet build
    - dotnet run
  
4. Open a web browser and visit `https://localhost:5001` to access the application.

## Contributing

We welcome contributions from the community! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.

## License

This project is licensed under the [MIT License](/LICENSE).
