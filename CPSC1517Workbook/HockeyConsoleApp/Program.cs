﻿using Hockey.Data;

Console.WriteLine("Welcome the the HockeyPlayer Test App");



// default constructor
//HockeyPlayer player1 = new HockeyPlayer();
// default constructor with object-initializer
//HockeyPlayer player2 = new HockeyPlayer()
//{
//    FirstName = "Connor",
//    LastName = "McDavid",
//};

// greedy constructor
HockeyPlayer player3 = new HockeyPlayer("Bobby", "Orr", "Parry Sound", new DateOnly(1948, 3, 20), 196, 73, Position.Defense, Shot.Right);


Console.WriteLine(player3);
// Output things about the players
//Console.WriteLine($"The player's name is {player1.FirstName} {player1.LastName} and they are born on {player1.DateOfBirth}");
//Console.WriteLine($"The player's name is {player2.FirstName} {player2.LastName} and they are born on {player2.DateOfBirth}");
//Console.WriteLine($"The player's name is {player3.FirstName} {player3.LastName} and they are born on {player3.DateOfBirth}");