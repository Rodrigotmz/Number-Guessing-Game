using Spectre.Console;
AnsiConsole.MarkupLine("[#fca311]Welcome to the Number Guessing Game!\nI'm thinking of a number between 1 and 100.\nYou have 5 chances to guess the correct number.[/]\n");
AnsiConsole.MarkupLine("[#e5e5e5]Please select the difficulty level:\r\n1. Easy (10 chances)\r\n2. Medium (5 chances)\r\n3. Hard (3 chances)[/]\n");
var option = AnsiConsole.Prompt(new SelectionPrompt<string>()
    .Title("[green]Select a difficulty level:[/]")
    .AddChoices(new[] { "Easy", "Medium", "Hard" })
    .HighlightStyle(new Style(foreground: Color.Green, decoration: Decoration.Bold))
);
var chances = option switch
{
    "Easy" => 10,
    "Medium" => 5,
    "Hard" => 3,
    _ => throw new ArgumentOutOfRangeException()
};
AnsiConsole.MarkupLine($"[green]You selected the {option} difficult level\nLets start the game![/]");

var random = new Random();
int numberToGuess = random.Next(1, 100);
bool guessed = false;
int attempts = 0;
while (attempts < chances && !guessed)
{
    var guess = AnsiConsole.Prompt(new TextPrompt<int>("[green]Enter your guess:[/]")
        .ValidationErrorMessage("[red]Please enter a valid number.[/]")
        .Validate(input =>
        {
            if (input < 1 || input > 100)
            {
                return ValidationResult.Error("[red]Number must be between 1 and 100.[/]");
            }
            return ValidationResult.Success();
        })
    );
    attempts++;
    if (guess == numberToGuess)
    {
        guessed = true;
        AnsiConsole.MarkupLine($"[green]Congratulations! You guessed the correct number in {attempts} attempts.[/]");

    }
    else if (guess > numberToGuess)
    {
        AnsiConsole.MarkupLine($"[red]Incorrect! The number is less than {guess}.[/]");
        AnsiConsole.MarkupLine($"[yellow]Attempt {attempts}/{chances}:[/] You guessed {guess}.");
    }
    else if (guess < numberToGuess)
    {
        AnsiConsole.MarkupLine($"[red]Incorrect! The number is greater than {guess}.[/]");
        AnsiConsole.MarkupLine($"[yellow]Attempt {attempts}/{chances}:[/] You guessed {guess}.");
    }
}
if (!guessed)
{
    AnsiConsole.MarkupLine($"[red]Sorry! You've used all your attempts. The correct number was {numberToGuess}.[/]");
}