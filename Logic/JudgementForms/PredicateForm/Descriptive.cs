using System;
using Logic.JudgementForms.PredicateForm.BehaviourContracts;

namespace Logic.JudgementForms.PredicateForm
{
    class Descriptive : IPredicateForm
    {
        private PredicateForms _innerType;

        public PredicateForms InnerType
        {
            get { return _innerType; }
        }

        public Descriptive()
        {
            _innerType = PredicateForms.Descriptive;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
