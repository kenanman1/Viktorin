using System;
namespace examen
{
    abstract class Lessons
    {
        public int points;
        public int choose;
        public string choosestr;
        public string[] answer;
        internal List<string> questions = new List<string>();
        internal List<int> answers = new List<int>();
        public virtual void Questions()
        {

        }
    }
}
