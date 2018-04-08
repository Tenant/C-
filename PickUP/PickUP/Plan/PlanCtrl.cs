using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TJU.SoftCourse;
using System.Data.OleDb;
using PickUP.Vocabulary;

namespace PickUP.Plan
{
    public class PlanCtrl
    {
        public Plan setNewPlan(string planName)
        {
            Plan newPlan = new Plan(planName);
            return newPlan;
        }

        public Plan addWord(Plan newPlan, string spelling, string meaning)
        {
            Word newWord = new Word(spelling, meaning);
            newPlan.addData(newWord);
            return newPlan;
        }
    }
}
