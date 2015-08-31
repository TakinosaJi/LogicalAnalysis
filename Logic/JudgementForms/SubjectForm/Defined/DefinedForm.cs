using System;
using Logic.JudgementForms.SubjectForm.BehaviourContracts;
using Logic.JudgementForms.SubjectForm.Defined.BehaviourContracts;

namespace Logic.JudgementForms.SubjectForm.Defined
{ 
    class DefinedForm : ISubjectForm
    {
        private IDefinedForm _form;
        private SubjectForms _innerForm;
        public IDefinedForm Form
        {
            get { return _form; }
        }

        public SubjectForms InnerForm
        {
            get { return _innerForm; }
        }

        public DefinedForm()
        {
            _form = new EmptyForm();
            _innerForm = SubjectForms.Defined;
        }

        public DefinedForm(IDefinedForm form)
        {
            _form = form;
            _innerForm = SubjectForms.Defined;
        }

        public virtual int GetIdent()
        {
            return (Int32)_innerForm;
        }
    }
}
