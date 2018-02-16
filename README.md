# Word Counter

A web app, built with C#, that counts the number of words that are repeated in an entered sentence.

## Specs

### User enters a sentence and then a word to check

* Occurs once:
  * Example Input: "The quick brown fox jumps over a lazy dog" & "the".
  * Example Output: "'the' occurs 1 time in the sentence."
* Occurs Multiple Times:
  * Example Input: "Developing webapps is hard. Is it too late to become an Android App Developer?" & "is".
  * Example Output: "'is' occurs 2 times in the sentence."
* Occurs no times:
  * Example Input: "There are zero issues with this sentence." & "is".
  * Example Output: "'is' does not occur in the sentence."

## Installation

### Install .NET

### Clone this repository

### In your preferred shell, navigate to the `~/Word-Counter.Solution/Word-Counter` folder and run the following commands

`$ dotnet restore`

(above not required for .NET Core 2.0 SDK or newer releases)

`$ dotnet run`

### Navigate to localhost:5000 in your preferred browser

## License

### This project is distributed under the MIT License
