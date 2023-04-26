Github Repositry
https://github.com/AmmarAliAlsawad/tic-tac-toe-final
Lessons Learned
This code is a console-based implementation of the game Tic Tac Toe, also known as Noughts and Crosses. The program allows the user to play against a computer opponent, with the user choosing their symbol (X or O) and whether they want to go first or second.

The program uses a one-dimensional integer array of size 9 to represent the game board, where each element in the array corresponds to a cell on the board. The value 0 represents an empty cell, 1 represents the player's symbol, and 2 represents the computer's symbol.

The main game loop alternates between the player's turn and the computer's turn until a winner is determined or the game ends in a tie. The program checks for a winner by iterating over the board array and checking for three in a row horizontally, vertically, or diagonally.

The program uses various control structures such as while loops, if statements, and for loops, as well as the Random class from the System namespace to randomly select the computer's moves. The program also includes methods for checking for a winner and printing the game board.                                                                                                                     
Struggles                                                                                                                                                                Randomized computer moves: The program uses a random number generator to select the computer's moves. This introduces an element of unpredictability to the game, making it more challenging for the player.

Checking for invalid user input: The program checks that the user inputs a valid move, i.e., an integer between 0 and 8 that corresponds to an empty cell on the board. If the user enters an invalid move, the program prompts them to enter a valid move. This adds an element of challenge for the user, as they need to ensure that they enter a valid move to continue playing.

Alternating turn order: The program alternates between the player's turn and the computer's turn, with the user choosing whether they want to go first or second. This introduces an element of strategy for the user, as they need to decide whether to go first or second based on their playing style and the computer's moves.

Checking for a winner: The program checks for a winner after each move, and ends the game if a winner is found. This adds an element of challenge for the user, as they need to ensure that they play strategically to win the game.                   
Bugs                                                                                                                                                                                              
Issues                                                                                                                                                                 Each Function should only have one return statement.  Each Loop should have a Single-Line Comment before the Do-While, While, For, or ForEach describing the purpose of the Loop.

The Do-While should have an additional Single-Line Comment describing what is being checked in the While Expression for it to continue; any other evaluation would necessitate a "break". Decision Trees should be Single-Line commented the line before if or switch statement that describes the purpose of the Decision-Tree and then each Truth block should have a single-line comment at the top of the block describing what that blocks decision result is.

Switch-Case statements should have additional Single-Line comment on the right-hand side of the Case statement to communicate that statements intent. Member Methods should be Multi-Line Commented, effectively communicating the purpose and intent of the Method as it pertains to the Class. As well, the Comment block should describe the type and purpose of the Parameters and Return Value. Abstract all your Console. Writeline calls into a single method that makes one call to Console.WriteLine. A Class will be commented with Multi-Line comments and should effectively communicate the Classes purpose, not its members but the Class itself. Member Methods should be Multi-Line Commented, effectively communicating the purpose and intent of the Method as it pertains to the Class. As well, the Comment block should describe the type and purpose of the Parameters and Return Value. There is no initial option to choose whether to go first or not. When I start a Game, there is no option to choose my symbol. There is no guide to where the numbers 0-9 represent on the board. Game Board is present on initial load/start. Game Board display does not reflect System Symbol initially or on refresh. Game Board display does not reflect Player Symbol initially or on refresh.Review your existing comments and find related logic and place into its own object implementation. Most students have at least a Game, Board, and Player object; others have additional Objects to control/manage other logic features.

The key is to understand "what is the purpose/intent of each object". What is the purpose of the Program class? it's purpose/intent is not to run the game. When you merge from one branch to another, you need to follow these guides:

Always use the "Always create a new merge commit" option
DEV branch should highly volatile with a lot of Atomic Commits
QA branch is to test feature or bug-fix developments from DEV and provides you the ability to verify no existing features have unintended consequences
Master branch is highly stable and only has commits that are verified not to break functionality; typically there are only 1 commit from QA per patch, update, or release. You need to create a DEV branch.You need to create a QA branch.                    
Resolved
Use meaningful names for variables and functions that accurately reflect their purpose and intent. For example, instead of using generic names like userTurn and computerTurn, consider using names like userSelectedSquare and computerSelectedSquare.

Separate concerns and responsibilities by creating separate objects to handle different parts of the game logic, such as a Board object to manage the game board and a Player object to represent the human and computer players. This can make the code more modular and easier to maintain.

Follow best practices for code organization and commenting, such as using single-line and multi-line comments to describe the purpose of functions and loops, and grouping related code together with whitespace and comments.

Consider implementing error handling and input validation to handle cases where the user enters invalid input or the program encounters unexpected errors.

Use version control software like Git to manage code changes and collaborate with other developers. Follow best practices for branching and merging, such as creating separate branches for feature development and bug fixes, and thoroughly testing changes before merging them into the main branch.   
