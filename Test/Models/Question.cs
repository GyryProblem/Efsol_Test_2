using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Question
    {
        //  public string Text;
        public Answer ThisAnswer { get; set; } 
        public string Text { get; set; }
    }

    public class TemplateQuestionary
    {
        public Question [] Questions { get; set; }
    }
}