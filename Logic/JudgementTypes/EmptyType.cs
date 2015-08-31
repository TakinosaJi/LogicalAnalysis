using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.JudgementForms.BehaviourContratcs;
using Logic.JudgementTypes.BehaviourContracts;
using Logic.JudgementTypes.QuantityType;

namespace Logic.JudgementTypes
{
    class EmptyType : IJudgementType
    {
        public int GetIdent()
        {
            return 0;
        }
    }
}
