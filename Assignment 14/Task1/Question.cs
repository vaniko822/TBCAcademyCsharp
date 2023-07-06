using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Question
    {
        private string _question;
        private int _score;
        private List<string> _options;
        private int _correctAnswer ;

        public string QuestionP
        {
            get { return _question; }
            set { _question = value; }
        }

        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        public List<string> Options
        {
            get { return _options; }
            set { _options = value; }
        }

        public int CorrectAnswer
        {
            get { return _correctAnswer; }
            set { _correctAnswer = value; }
        }
    }

}
