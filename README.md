# Word Unscrambler App

## Description
The Word Unscrambler App is a C# console application that helps users find real words from scrambled letters. You can input words either manually or from a file, and the app will check them against a known list of words.

## How to Run

### Prerequisites
- Make sure you have the .NET SDK installed. You can get it from [Microsoft .NET Download](https://dotnet.microsoft.com/download).

### Running the Application
1. Clone the repo:
   ```bash
   git clone https://github.com/yourusername/word-unscrambler.git
2. Navigate to the project directory:
   ```bash
   cd word-unscrambler
3. Build and run the application:
   ```bash
   dotnet run

## How to Use
1. Start the application: Follow the on-screen instructions.
2. Input Choice:
   - Type 'M' for manually entering scrambled words.
   - Type 'F' to load words from a file.
3. Enter Data:
   - If manual, type the scrambled words separated by commas.
   - If file, type the file path.
4. View Results:
   Matches will be displayed if found; otherwise, you'll see a message stating no matches found.

## Features
 ### Two Input Modes: 
 - Manual text entry and file-based input.
 ### Word Matching: 
 - Compares input against a list to find unscrambled matches.

## Classes
1. Program: This class serves as the entry point of the application. It provides methods for manual entry or file input of scrambled words, matches them against a list of known words, and displays the matches.
2. Constants: This class holds constant strings used throughout the application, such as prompts, messages, and file names. It centralizes these values to maintain consistency and ease of maintenance.
3. FileReader: This class is responsible for reading input from a file. It contains a method to read lines from a specified file and returns them as an array of strings.
4. WordMatcher: This class handles the logic for matching scrambled words against a list of known words. It compares each scrambled word against the list and checks for direct matches or matches where the letters can be rearranged to form a word. It returns a list of matched words.
5. MatchedWords: This struct represents a matched pair of a scrambled word and its unscrambled counterpart. It contains properties to store both the scrambled word and its unscrambled match. This struct is used to organize and return matched words from the WordMatcher class.

## Credits
This project is created for educational purposes only and shouldn't be used for other intentions.

### Contact
If you have any questions or suggestions, feel free to reach out at [sargsyan_sahak@yahoo.com].

### Key Elements Included:
- **Description:** Provides a clear idea of what the app does.
- **How to Run:** Detailed setup and execution instructions.
- **How to Use:** Step-by-step user interaction guide.
- **Features:** Highlights the main functionality.
- **Contact:** Provides a method for users to reach out.
