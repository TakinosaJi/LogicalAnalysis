using Logic.JudgementForms.BehaviourContratcs;
using Logic.JudgementForms.PredicateForm.BehaviourContracts;

namespace Logic.JudgementForms.PredicateForm
{
    class PredicateForm
    {
        private readonly IPredicateForm _form;

        public PredicateForm()
        {
            _form = new EmptyForm();
        }
        public PredicateForm(IPredicateForm form)
        {
            _form = form;
        }

        public IPredicateForm Form
        {
            get { return (IPredicateForm)_form; }
        }
    }
}
