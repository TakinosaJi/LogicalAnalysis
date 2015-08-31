using Logic.JudgementForms.SubjectForm.BehaviourContracts;

namespace Logic.JudgementForms.SubjectForm
{
    class EmptyForm : ISubjectForm
    {
        public int GetIdent()
        {
            return 0;
        }
    }
}
