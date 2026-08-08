using System;

namespace EternalQuest
{
    /*
     * =========================================================================
     * CREATIVITY AND EXCEEDED REQUIREMENTS REPORT:
     * =========================================================================
     * To exceed the base requirements for this assignment, I implemented the 
     * following features:
     * 
     * 1. Dynamic Leveling System & Titles: 
     *    Integrated a dynamic level computation inside `GoalManager.cs` based 
     *    on score thresholds (`Level = (Score / 500) + 1`). The player receives 
     *    uniquely thematic ranks depending on their level (e.g., "Novice Seeker", 
     *    "Level 13 Ninja Unicorn", "Master of Destiny").
     * 
     * 2. Milestone Badges:
     *    Players dynamically unlock virtual badges upon passing score milestones 
     *    (e.g., "Telestial Trekker" at 1,000 pts, "Celestial Champion" at 5,000 pts).
     * 
     * 3. Negative Goals (Habit Breaking):
     *    Created a custom derived class `NegativeGoal.cs`. This allows users to 
     *    track bad habits they wish to stop (e.g., "Snoozing Alarm", "Eating Junk Food"). 
     *    When an event is recorded for a negative goal, penalty points are deducted 
     *    from their total score.
     * =========================================================================
     */
    class Program
    {
        static void Main(string[] args)
        {
            GoalManager manager = new GoalManager();
            manager.Start();
        }
    }
}