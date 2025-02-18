
using System.Runtime.CompilerServices;

namespace Goal{
    public abstract class Goal
    {
        protected string _shortname;
        protected string _description;
        protected int _points;

        public Goal(string name, string description, int points)
        {
            _shortname = name;
            _description =description;
            _points = points;
        }
        public abstract void RecordEvent();

        public abstract bool IsComplete();

        public virtual string GetDetailsString()
        {
            return "";
        }

        public abstract string GetStringRepresentation();
    }
}
