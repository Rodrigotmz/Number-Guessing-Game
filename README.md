# Number-Guessing-Game

## Overview

This is a simple command-line interface (CLI) game where you try to guess a secret number between 1 and 100 chosen by the computer. The difficulty level you select determines the number of attempts you have.

## How to Play

1.  **Run the game** from your terminal. (Assuming you have the necessary programming environment set up to execute the game's code, e.g., Python).
2.  You will be greeted with a **welcome message** and the **rules** of the game.
3.  The computer will have already **selected a secret number** between 1 and 100.
4.  You will be prompted to **select a difficulty level**:
    * **Easy (1)**: 10 chances to guess.
    * **Medium (2)**: 5 chances to guess.
    * **Hard (3)**: 3 chances to guess.
5.  Enter the **number corresponding to your desired difficulty** and press Enter.
6.  The game will begin, and you will be asked to **enter your first guess**.
7.  After each guess:
    * If your guess is **correct**, you will receive a **congratulatory message** along with the **number of attempts** it took you. The game will then end.
    * If your guess is **incorrect**, you will be told whether the secret number is **greater or less than** your guess.
8.  The game continues until you either **guess the correct number** or **run out of chances**. If you run out of chances without guessing correctly, the game will end.

## Sample Gameplay
Welcome to the Number Guessing Game!
I'm thinking of a number between 1 and 100.
Please select the difficulty level:

* Easy (10 chances)
* Medium (5 chances)
* Hard (3 chances)

Enter your choice: 2
Great! You have selected the Medium difficulty level.
Let's start the game!
Enter your guess: 50
Incorrect! The number is less than 50.
Enter your guess: 25
Incorrect! The number is greater than 25.
Enter your guess: 35
Incorrect! The number is less than 35.
Enter your guess: 30
Congratulations! You guessed the correct number in 4 attempts.

## Requirements

* This is a **CLI-based game**, meaning all interaction happens through the command line.
* The game must:
    * Display a **welcome message** and **game rules** at the start.
    * Have the **computer randomly select a number** between 1 and 100.
    * Allow the **user to choose a difficulty level** (easy, medium, hard).
    * Assign a **number of chances** based on the selected difficulty (e.g., Easy: 10, Medium: 5, Hard: 3).
    * Prompt the **user to enter their guess**.
    * **Check if the guess is correct**:
        * If correct, display a **congratulatory message** and the **number of attempts**.
        * If incorrect, indicate whether the secret number is **greater or less than** the guess.
    * **End the game** when the user guesses correctly or runs out of chances.

https://roadmap.sh/projects/number-guessing-game