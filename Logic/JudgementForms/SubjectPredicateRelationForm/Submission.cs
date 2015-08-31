using System;
using Logic.JudgementForms.SubjectPredicateRelationForm.BehaviourContracts;

namespace Logic.JudgementForms.SubjectPredicateRelationForm
{
    
    class Submission : ISubjectPredicateRelationForm
    {
        private SubjectPredicateRelationForms _innerType;

        public SubjectPredicateRelationForms InnerType
        {
            get { return _innerType; }
        }

        public Submission()
        {
            _innerType = SubjectPredicateRelationForms.Submission;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
