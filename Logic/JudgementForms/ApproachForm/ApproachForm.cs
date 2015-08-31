using Logic.JudgementForms.ApproachForm.BehaviourContracts;
using Logic.JudgementForms.BehaviourContratcs;

namespace Logic.JudgementForms.ApproachForm
{
    class ApproachForm
    {
        private readonly IJudgementForm _form;

        public ApproachForm()
        {
            _form = new EmptyForm();
        }
        public ApproachForm(IApproachForm form)
        {
            _form = form;
        }

        public IApproachForm Form
        {
            get { return (IApproachForm)_form; }
        }
    }
}
