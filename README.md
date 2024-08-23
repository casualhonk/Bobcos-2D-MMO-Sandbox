# Bobcos

Welcome to the open-sourced version of Bobcos! 

## About

Bobcos is a project that was initially developed with a vision of creating an engaging and enjoyable game. While the game may not have reached its full potential, we've decided to open-source the code to allow for community contributions and improvements.

## Contribution Guidelines

- **Use Policy**: You are welcome to use  to Bobcos as your own project but dont say you made it your self.
- **Contributions**: We appreciate any contributions to improve the game. Please follow the guidelines below when contributing:
  - Fork the repository.
  - Create a new branch for your feature or bugfix.
  - Make your changes and commit them with clear and concise commit messages.
  - Open a pull request, and provide a detailed description of your changes.

## Getting Started

### Unity Bobcos Client

1. **Clone the repository**:
    ```sh
    git clone https://github.com/yourusername/bobcos.git
    ```

2. **Open the project in Unity**:
    - Open Unity Hub.
    - Click on `Add` and select the cloned repository folder.

3. **Install any required packages**:
    - Unity should prompt you to install any missing packages. Follow the prompts to install them.

### Bobcos Server

1. **Navigate to the console project directory**:
    ```sh
    cd bobcos/BobcosServer
    ```

2. **Create a new solution**:
    ```sh
    dotnet new sln -n BobcosConsoleSolution
    ```

3. **Add the project to the solution**:
    ```sh
    dotnet sln BobcosConsoleSolution.sln add BobcosConsoleProject.csproj
    ```

4. **Restore dependencies**:
    ```sh
    dotnet restore
    ```

5. **Run the console project**:
    ```sh
    dotnet run
    ```

## License

This project is licensed under the terms of the MIT license.

## Contact

If you have any questions or need further assistance, please feel free to reach out through the following channels:

- **Discord**: phoave
- **Twitter**: [@neris_phoave](https://twitter.com/neris_phoave)

## Happy coding!

Kind regards,  
Neris
