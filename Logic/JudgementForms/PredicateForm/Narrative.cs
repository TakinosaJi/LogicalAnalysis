using System;
using Logic.JudgementForms.PredicateForm.BehaviourContracts;

namespace Logic.JudgementForms.PredicateForm
{
    class Narrative : IPredicateForm
    {
        private PredicateForms _innerType;
        public PredicateForms InnerType
        {
            get { return _innerType; }
        }

        public Narrative()
        {
            _innerType = PredicateForms.Narrative;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
