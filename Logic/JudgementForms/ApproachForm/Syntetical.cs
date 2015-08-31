using System;
using Logic.JudgementForms.ApproachForm.BehaviourContracts;

namespace Logic.JudgementForms.ApproachForm
{
    class Syntetical : IApproachForm
    {
       private ApproachForms _innerType;

        public ApproachForms InnerType
        {
            get { return _innerType; }
        }

        public Syntetical()
        {
            _innerType = ApproachForms.Syntetical;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
