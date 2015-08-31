using System;
using Logic.JudgementForms.ApproachForm.BehaviourContracts;

namespace Logic.JudgementForms.ApproachForm
{
    class Analytical : IApproachForm
    {
        private ApproachForms _innerType;

        public ApproachForms InnerType
        {
            get { return _innerType; }
        }

        public Analytical()
        {
            _innerType = ApproachForms.Analytical;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
