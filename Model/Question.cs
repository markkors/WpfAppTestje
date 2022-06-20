using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTestje.Model
{



    public class Question
    {
        private List<Answer> _answers = new List<Answer>();
        private string _questiontext;


        public Question(string q, Random rnd)
        {
            _questiontext = q;
            // maak 4 antwoorden
            for(int i = 0; i < 4; i++)
            {
                createAnswer();
            }

            // zet random een van de antwoord op correct
            Answers[rnd.Next(Answers.Count)].Correct = true;
            
        }

        public void createAnswer()
        {
            string answer = Guid.NewGuid().ToString();
            Answer a = new Answer(string.Format("Antwoord {0}",answer)); 
            _answers.Add(a);   
        }


        public List<Answer> Answers { 
            get { return _answers; }
            set { _answers = value; } 
        }

        public string QuestionText { 
            get { return _questiontext; }
            set { _questiontext = value; }
        }




    }
}
