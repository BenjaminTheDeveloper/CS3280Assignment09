# CS3280Assignment09
Rock, Papers, Scissors Game

# Code 
There are four classes found throughout this program. 
# The Game Class
- Contains a random generated outcome for the computer choice. 
- Holds the computer points, user points, as well as the rounds to be played and the user choice. 
- Methods include being able to start a game based on the rounds, add points for the computer, add points for the user. 
- Others include getters and setters, a checkForWinner style method, and a method that can tell you who won the current round. 

# The Leaderboard Class
- Holds all users in who haved played the game. 
- Contains a UserExists, LoadUserDetails, UpdateUserInfo, and a GenerateLeaderboard method. 

# The User Class 
- Each user has their total win points and a name
- User Methods include getters and setters, and an AddPoint Method()

# The Game Driver Class 
- The game driver is the class that instantiates the User, Game, and Leaderboard class. 
- It contains its own name holder, a two strings that are used to check who wins and a menuNavigation integer. 
- Methods include GameDriver constructor, its own getUserName() to hold the name, and a RunMenu()
- The RunMenu contains all of the logic that is used to call methods of each class object throuhgout the game. 

# Game play 
The game allows you to enter a screen name, select the amount of rounds you want to play per game, and check the high scores. The high scores can be cleared using the clear all scores within the game. Finally the game will then allow you to exit with the last option found throughout the gamedriver menu. 


