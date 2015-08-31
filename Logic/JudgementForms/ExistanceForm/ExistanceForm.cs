using Logic.JudgementForms.ApproachForm.BehaviourContracts;
using Logic.JudgementForms.BehaviourContratcs;
using Logic.JudgementForms.ExistanceForm.BehaviourContracts;

namespace Logic.JudgementForms.ExistanceForm
{
    class ExistanceForm
    {
        private readonly IJudgementForm _form;

        public ExistanceForm()
        {
            _form = new EmptyForm();
        }
        public ExistanceForm(IExistanceForm form)
        {
            _form = form;
        }

        public IExistanceForm Form
        {
            get { return (IExistanceForm)_form; }
        }
    }
}
