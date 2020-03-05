# Numbers To Words

#### C# Basics Exercise for Epicodus, Current Version: 03.05.2020

#### By Sarah "Sasa" Schwartz and Adela Darmansyah

## Pair Program WFH Summary

* Numbers To Words Project
* Whiteboarding practice + Further Exploration questions
* Find and Replace Project

## Description

This C# console application converts numeric numbers to written words. For instance, when a user inputs "385", the program will return "three hundred eighty five" in the console.

## Setup/Installation Requirements

* Download [.NET Core](https://dotnet.microsoft.com/download/dotnet-core/)
* Clone this [repository](https://github.com/ayohana/anagram.git/)
* Open the `Command Line Interface`.
  * Navigate into the `NumbersToWords` directory.
    * Type in the command `dotnet restore` to gather tools and dependencies for the application.
    * Type in the command `dotnet run` to run the application.
  * Navigate into the `NumbersToWords.Tests` directory.
    * Type in the command `dotnet restore` to gather tools and dependencies for the tests.
    * Type in the command `dotnet test` to run the tests. 

## Specs

- The application gather user input
  - Sample input: 385
  - Expected output: 385
- The application will convert 1-digit number into words
  - Sample input: 5
  - Expected output: Five
- The application will convert 2-digits number into words
  - Sample input: 85
  - Expected output: Eighty five
- The application will convert 3-digits number into words
  - Sample input: 385
  - Expected output: Three hundred eighty five
- The application will take multiple zeros into account
  - Sample input: 330
  - Expected output: three hundred thirty
- The application will take single zero into account
  - Sample input: 0
  - Expected output: zero
- The application will alert user if input is invalid
  - Sample input: User inputs 3applepearhello
  - Expected output: Invalid input. Please enter a number.

## Known Bugs

- No known bugs

## Technologies Used

- C#
- .NET

### License

- This software is licensed under the MIT license.
