using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Full_GRASP_And_SOLID
{
    public class Time : TimerClient
    {
        //Ley de Demeter y ISP
        public Recipe Recipe;
        public Time(Recipe recipe)
        {
            this.Recipe= recipe;
        }
        public void TimeOut()
        {
            Recipe.CookedToTrue();
        }
    }
}