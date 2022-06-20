using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppTestje.Model
{
    public class Answer
    {
        private string _answertext;
        private bool _correct;

        public Answer(string a)
        {
            _answertext = a;
        }

        public Boolean Correct { 
            get { return _correct; }
            set { _correct = value; } }
    }
}
