using Logic.JudgementForms.BehaviourContratcs;
using Logic.JudgementForms.SubjectPredicateRelationForm.BehaviourContracts;

namespace Logic.JudgementForms.SubjectPredicateRelationForm
{
    class EmptyForm : ISubjectPredicateRelationForm
    {
        public int GetIdent()
        {
            return 0;
        }
    }
}
