using Logic.JudgementForms.SubjectForm.Undefined.BehaviourContracts;

namespace Logic.JudgementForms.SubjectForm.Undefined
{
    class EmptyForm : IUndefinedForm
    {
        public int GetIdent()
        {
            return 0;
        }
    }
}
