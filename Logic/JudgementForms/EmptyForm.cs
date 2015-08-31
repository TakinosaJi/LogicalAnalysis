using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.JudgementForms.BehaviourContratcs;

namespace Logic.JudgementForms
{
    class EmptyForm : IJudgementForm
    {
        public int GetIdent()
        {
            return 0;
        }
    }
}
