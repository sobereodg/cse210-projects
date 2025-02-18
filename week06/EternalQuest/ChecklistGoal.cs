namespace Goal
{
    public class CheckListGoal:Goal
    {
        private int _amountCompleted;
        private int _target;
        private int _bonus;

        public CheckListGoal(string name, string description, int points): base(name,description,points)
        {

        }

        public override void RecordEvent()
        {

        }

        public override bool IsComplete()
        {
            return true;
        }

        public override string GetDetailsString()
        {
            return "";
        }

        public override string GetStringRepresentation()
        {
            return $"{_shortname}: {_description} - {_points} points";
        } 
    }
}