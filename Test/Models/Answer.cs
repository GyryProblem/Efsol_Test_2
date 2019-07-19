using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{    
    public class Answer
    {
        public Question SourceQuestion { get; set; }
        public string Text { get; set; }
        //public Guid ID { get; set; }
        //public string Name { get; set; }
        //public int Age { get; set; }
        //public string Gender { get; set; }
        //public DateTime Birth { get; set; }
        //public string Marital { get; set; }    
        //public bool Programming { get; set; }
    }

    public class AnswerPool
    {
        public Dictionary<Question, Answer> Answers { get; set; }
    }
}