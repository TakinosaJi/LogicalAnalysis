using Logic.JudgementForms.BehaviourContratcs;
using Logic.JudgementForms.PredicateForm.BehaviourContracts;
using Logic.JudgementForms.SubjectPredicateRelationForm.BehaviourContracts;

namespace Logic.JudgementForms.SubjectPredicateRelationForm
{
    class SubjectPredicateRelationForm
    {
        private readonly IJudgementForm _form;

        public SubjectPredicateRelationForm()
        {
            _form = new EmptyForm();
        }
        public SubjectPredicateRelationForm(ISubjectPredicateRelationForm form)
        {
            _form = form;
        }

        public ISubjectPredicateRelationForm Form
        {
            get { return (ISubjectPredicateRelationForm)_form; }
        }
    }
}
