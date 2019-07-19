using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class SomeQuestion
    {
        public string Text { get; set; }

        public Guid SessionId { get; set; } = Guid.NewGuid();

        public int QuestionId { get; set; } = 0;
        public Answer ThisAnswer { get; set; }
    }


}