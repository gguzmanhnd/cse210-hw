using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score = 0;

        public void Start()
        {
            string choice = "";
            while (choice != "6")
            {
                Console.WriteLine();
                DisplayPlayerInfo();
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": CreateGoal(); break;
                    case "2": ListGoalDetails(); break;
                    case "3": SaveGoals(); break;
                    case "4": LoadGoals(); break;
                    case "5": RecordEvent(); break;
                    case "6": Console.WriteLine("\nGoodbye! Keep making progress on your Eternal Quest!"); break;
                    default: Console.WriteLine("Invalid option. Please enter a number from 1 to 6."); break;
                }
            }
        }

        public void DisplayPlayerInfo()
        {
            // Gamification: Calculate Level and Titles based on score
            int level = (_score / 500) + 1;
            string title = GetUserTitle(level);

            Console.WriteLine($"=== PLAYER PROFILE ===");
            Console.WriteLine($"Score: {_score} pts | Level: {level} | Rank: {title}");

            // Gamification: Badges / Milestones
            if (_score >= 5000) Console.WriteLine("🏆 Badge Earned: Celestial Champion!");
            else if (_score >= 2500) Console.WriteLine("🥇 Badge Earned: Terrestrial Traveler!");
            else if (_score >= 1000) Console.WriteLine("🥈 Badge Earned: Telestial Trekker!");
        }

        private string GetUserTitle(int level)
        {
            return level switch
            {
                1 => "Novice Seeker",
                2 => "Apprentice Voyager",
                3 => "Faithful Pathfinder",
                4 => "Level 13 Ninja Unicorn",
                5 => "Light Bearer",
                _ => "Master of Destiny"
            };
        }

        public void ListGoalDetails()
        {
            Console.WriteLine("\nThe goals are:");
            if (_goals.Count == 0)
            {
                Console.WriteLine("  (No goals created yet.)");
                return;
            }

            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {_goals[i].GetDetailsString()}");
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("\nThe types of Goals are:");
            Console.WriteLine("  1. Simple Goal (One-time complete)");
            Console.WriteLine("  2. Eternal Goal (Repeatable indefinitely)");
            Console.WriteLine("  3. Checklist Goal (Requires multiple completions)");
            Console.WriteLine("  4. Negative Goal (Deducts points for bad habits)");
            Console.Write("Which type of goal would you like to create? ");
            
            string choice = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            if (choice == "4")
            {
                Console.Write("How many penalty points does this bad habit cost? ");
                int penalty = int.Parse(Console.ReadLine());
                _goals.Add(new NegativeGoal(name, description, penalty));
                Console.WriteLine("Goal added successfully!");
                return;
            }

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("Invalid goal selection.");
                    return;
            }

            Console.WriteLine("Goal added successfully!");
        }

        public void RecordEvent()
        {
            if (_goals.Count == 0)
            {
                Console.WriteLine("\nNo goals available to record. Create one first!");
                return;
            }

            Console.WriteLine("\nThe goals are:");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {_goals[i].ShortName}");
            }

            Console.Write("Which goal did you accomplish? ");
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
            {
                Goal selectedGoal = _goals[index - 1];

                if (selectedGoal.IsComplete())
                {
                    Console.WriteLine("This goal is already complete!");
                    return;
                }

                int pointsGained = selectedGoal.RecordEvent();
                _score += pointsGained;

                if (pointsGained > 0)
                {
                    Console.WriteLine($"🎉 Congratulations! You have earned {pointsGained} points!");
                }
                else if (pointsGained < 0)
                {
                    Console.WriteLine($"⚠️ Ouch! You lost {Math.Abs(pointsGained)} points for engaging in a bad habit.");
                }

                Console.WriteLine($"You now have {_score} points.");
            }
            else
            {
                Console.WriteLine("Invalid goal selection.");
            }
        }

        public void SaveGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            Console.WriteLine("Goals successfully saved!");
        }

        public void LoadGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                return;
            }

            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            _goals.Clear();

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(':');
                string type = parts[0];
                string[] data = parts[1].Split('|');

                switch (type)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[4]), int.Parse(data[3]), int.Parse(data[5])));
                        break;
                    case "NegativeGoal":
                        _goals.Add(new NegativeGoal(data[0], data[1], int.Parse(data[2])));
                        break;
                }
            }
            Console.WriteLine("Goals successfully loaded!");
        }
    }
}