using Logic.JudgementForms.SubjectForm.BehaviourContracts;
using Logic.JudgementForms.SubjectForm.Defined.BehaviourContracts;

namespace Logic.JudgementForms.SubjectForm.Defined
{
    class EmptyForm : IDefinedForm
    {
        public int GetIdent()
        {
            return 0;
        }
    }
}
