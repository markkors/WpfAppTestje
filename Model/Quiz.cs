using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTestje.Model
{
    public class Quiz
    {


        private List<Question> _questions = new List<Question>();
        Random r = new Random();
        public Quiz()
        {
            // get / create the questions
            // 10 stuks
            for(int i = 0; i < 10; i++)
            {
               
          
                string question = Guid.NewGuid().ToString();
                Question q = new Question(string.Format("Vraag {0}", question),r);
                _questions.Add(q);
            } 
            

        }


        public List<Question> Questions { 
            get { return _questions; }
            set { _questions = value; } 
        }

    }
}
