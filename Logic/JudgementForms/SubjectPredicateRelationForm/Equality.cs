using System;
using Logic.JudgementForms.SubjectPredicateRelationForm.BehaviourContracts;

namespace Logic.JudgementForms.SubjectPredicateRelationForm
{
    class Equality : ISubjectPredicateRelationForm
    {
        private SubjectPredicateRelationForms _innerType;

        public SubjectPredicateRelationForms InnerType
        {
            get { return _innerType; }
        }

        public Equality()
        {
            _innerType = SubjectPredicateRelationForms.Equality;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
