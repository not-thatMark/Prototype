using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prototype
{   //storing information about the chosen options from the user
    //1 question has many options
    //when 1 or more options is chosen it become a unique answer for the question from the user and it get stored include: 
    //content of the answer(option);
    //the user's ip address;
    //question id;
    //and optionid is the id of the chosen option belongs to the question
    public class answer
    {
        string answers;
        string ip;
        int questionid;
        int optionid;
        public string Answers
        {
            set { answers = value; }
            get { return answers; }
        }
        public string IpAddress
        {
            set { ip = value; }
            get { return ip; }

        }
        public int QuestionID
        {
            set { questionid = value; }
            get { return questionid; }
        }

    }
}