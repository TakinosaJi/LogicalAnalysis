using Logic.JudgementForms.BehaviourContratcs;
using Logic.JudgementForms.SubjectForm.BehaviourContracts;

namespace Logic.JudgementForms.SubjectForm
{
    class SubjectForm
    {
        private ISubjectForm _form;

        public SubjectForm()
        {
            _form = new EmptyForm();
        }
        public SubjectForm(ISubjectForm form)
        {
            _form = form;
        }

        public ISubjectForm Form
        {
            get { return _form; }
        }
    }
}
