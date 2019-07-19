using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test.Models;


namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private TemplateQuestionary ActiveQuestionary = TemplateQuestionaryPool.Pool[0];
        private static Dictionary<Guid, Questionary> Questionaries = new Dictionary<Guid, Questionary>();
        private AnswerPool ActiveAnswers = new AnswerPool();
        public ActionResult Index(SomeQuestion someQuestion)
        {            
            someQuestion.Text = ActiveQuestionary.Questions[someQuestion.QuestionId].Text;
            
            return View(someQuestion);
        }

        [HttpPost]
        public ActionResult ProcessQuestionary (SomeQuestion updatedModel,string questionNumber)
        {
            if (questionNumber == "Next")
            {
                updatedModel.QuestionId++;
            }
            else if (questionNumber == "Last")
            {
                updatedModel.QuestionId--;
            }

            Questionary questionary;
            if (!Questionaries.TryGetValue(updatedModel.SessionId, out questionary))
            {
                questionary = new Questionary();
                Questionaries[updatedModel.SessionId] = questionary;
            }            
            updatedModel.Text = ActiveQuestionary.Questions[updatedModel.QuestionId].Text;
            return View("Index", updatedModel);
           // return RedirectToAction("Index");
        }


    }
}