namespace EternalQuest
{
    // Custom goal type where recording an event deducts points (breaks a good habit / indulges a bad one)
    public class NegativeGoal : Goal
    {
        public NegativeGoal(string name, string description, int penaltyPoints) 
            : base(name, description, penaltyPoints) { }

        public override int RecordEvent()
        {
            return -_points; // Deducts points from user score
        }

        public override bool IsComplete() => false;

        public override string GetDetailsString()
        {
            return $"[⚠ BAD HABIT] {_shortName} ({_description}) - Penalty: -{_points} pts";
        }

        public override string GetStringRepresentation()
        {
            return $"NegativeGoal:{_shortName}|{_description}|{_points}";
        }
    }
}