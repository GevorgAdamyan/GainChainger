# GainChainger automated test using C#, Selenium-Webdriver and SpecFlow.

This repository covers the folowing flow:
 - Login to this site (https://cozy-fairy-5394bc.netlify.app/).
 - Once redirect is completed. Navigate to the following url (https://www.gainchanger.com/resources/)
 - Access the first blog in the list of blog posts present in the resources page (step 2 )
 - Extract the following fields from the blog page. (H1, Meta title, Meta description, H2 elements, Paragraph elements)
 - Export the fields in a file in json format. 

## Requirements

- .NET Core

## Installation

1. Clone the repository
2. Install .NET Core (This project is written using version 7.0)
3. Install dependencies using:

    ```
    dotnet restore
    ``` 

## Usage

1. Navigate to the root folder of the project
2. Run the tests using the following command:

    ```
    dotnet test Gainchainger.csproj
    ```

## Contents

### Pages namespace

The classes in `Pages` namespace contain fields and methods which describe the pages for Page Object Model pattern.

### Support namespace

The classes in `Support` namespace contain useful methods and data that can be used in Selenium tests.

#### Helpers class

The `Helpers` class contains useful methods that can be used in Selenium tests.

##### Methods

- `GenerateJSONFile(Dictionary<string, object> dictionary)` - Generates a JSON file with provided Dictionary".

#### Data class

The `Data` class contains different data which is used in tests.

### Test classes

The test classes are located in the `StepDefinitions` folder and contain examples of Selenium tests written in C# language.

## License

This repository is licensed under the [MIT License](https://opensource.org/licenses/MIT).

## Note

Find the generated JSON file in this directory:
    ```
    bin\Debug\
    ```
