using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace quizv4
{
    [Serializable]
    public class player
    {
        private string name;
        private int score;
        private string password;
        private int security_question;
        private string security_answers;
        private int avatar_number;

        public player()
        {
            name = "";
            score = 0;
            password = "";
            security_question = 0;
            security_answers = "";


        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int Security_Question
        {
            get { return security_question; }
            set { security_question = value; }
        }
        public string Security_Answer
        {
            get { return security_answers; }
            set { security_answers = value; }
        }
        public int avatar_numbers
        {
            get { return avatar_number; }
            set { avatar_number = value; }
        }
    }
}
