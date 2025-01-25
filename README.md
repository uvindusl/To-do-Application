# To-Do Application

## Project Description

A Windows Forms-based To-Do List application that allows users to manage their tasks efficiently using SQLite database for persistent storage.

![image](https://github.com/user-attachments/assets/c850526c-6f12-4c77-acc0-ae39837ae153)

## Features

- Add new tasks
- Update existing tasks
- Mark tasks as completed
- Store tasks in MSSQL database
- Simple and intuitive user interface

## Prerequisites

- Windows OS
- .NET Framework
- Visual Studio (recommended for development)
- CrystalReport

## Installation

1. Clone the repository
```bash
git clone https://github.com/uvindusl/To-do-Application.git
```

2. Open the solution in Visual Studio
3. Restore NuGet packages
4. Build and run the application

## Technologies Used

- C#
- Visual Studio 2022
- Windows Forms
- MSSQL
- .NET Framework
- CrystalReport

## Database Setup

The application uses SQLite to store tasks. The database is automatically created when you run the application for the first time.

## Project Structure

```
To-do-Application/
│
├── To-do-Application/
│   ├── Form1.cs       
│   ├── Program.cs    
│   ├── addtask.cs
│   ├── alltaskrpt.cs
│   ├── alltaskrept.cs
│   ├── App.config
│   ├── completedtask.rpt
│   ├── comtaskreports.cs
│   ├── Form1.cs
│   ├── login.cs
│   ├── packages.config
│   ├── Program.cs
│   ├── progrstaskrept
│   ├── register.cs
│   ├── settings.cs
│   ├── updatetask.cs
│   ├── viewallreports.cs
│   ├── viewomtask.cs
│   └── viewprogressreports.cs
│
└── To-do-Application.sln
```

## Functionality

- Add tasks with title and description
- View list of tasks
- Update task details
- Delete tasks
- Mark tasks as complete/incomplete

## Contributing

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## License

This project is open-source. Distributed under the MIT License.

## Contact

Uvindu Sankalpa - [GitHub Profile](https://github.com/uvindusl)
