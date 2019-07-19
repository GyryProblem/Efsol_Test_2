using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Questionary
    {
        public TemplateQuestionary TempQuest { get; set; }
    }

    public static class TemplateQuestionaryPool
    {
        public static List<TemplateQuestionary> Pool { get; set; } = new List<TemplateQuestionary>
            {
                new TemplateQuestionary
                {
                    Questions = new []
                    {
                        new Question {Text = "Введите имя:"},
                        new Question {Text = "Введите возраст:"},
                        new Question {Text = "Введите пол:"},
                        new Question {Text = "Введите дату рождения:"},
                        new Question {Text = "Введите семейное положение:"},
                        new Question {Text = "Любите ли вы программировать:"}
                    }

                }
            };
    }
}