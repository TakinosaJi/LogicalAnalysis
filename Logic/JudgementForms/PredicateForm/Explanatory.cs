using System;
using Logic.JudgementForms.PredicateForm.BehaviourContracts;

namespace Logic.JudgementForms.PredicateForm
{
    class Explanatory : IPredicateForm
    {
        private PredicateForms _innerType;
        public PredicateForms InnerType
        {
            get { return _innerType; }
        }

        public Explanatory()
        {
            _innerType = PredicateForms.Explanatory;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
