﻿using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = {90, 86, 87, 98, 100};
int[] andrewScores = {92, 89, 81, 96, 90};
int[] emmaScores = {90, 85, 87, 98, 68};
int[] loganScores = {90, 95, 87, 88, 96};

string[] studentNames = {"Sophia", "Andrew", "Emma", "Logan"};

foreach(string name in studentNames)
{
  Console.WriteLine($"{name}");
}

int sophiaSum = 0;

decimal sophiaScore;

foreach(int score in sophiaScores)
{
  sophiaSum += score;
}

sophiaScore = (decimal)sophiaSum / currentAssignments;


Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
