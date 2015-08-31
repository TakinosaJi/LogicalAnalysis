using System;
using Logic.JudgementForms.SubjectPredicateRelationForm.BehaviourContracts;

namespace Logic.JudgementForms.SubjectPredicateRelationForm
{
    class Relation : ISubjectPredicateRelationForm
    {
        private SubjectPredicateRelationForms _innerType;

        public SubjectPredicateRelationForms InnerType
        {
            get { return _innerType; }
        }

        public Relation()
        {
            _innerType = SubjectPredicateRelationForms.Relation;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
