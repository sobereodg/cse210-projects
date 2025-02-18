namespace Goal
{
    public class SimpleGoal:Goal
    {
        private bool _IsComplete;

        public SimpleGoal(string name, string description, int points):base(name,description,points)
        {
             _shortname = name;
            _description =description;
            _points = points;
        }

        public override void RecordEvent()
        {

        }

        public override string GetStringRepresentation()
        {
            return $"{_shortname}: {_description} - {_points} points";
        }

        public override bool IsComplete()
        {
            return true;
        }
    }
}   