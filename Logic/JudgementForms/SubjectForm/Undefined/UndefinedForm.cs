using System;
using Logic.JudgementForms.SubjectForm.BehaviourContracts;
using Logic.JudgementForms.SubjectForm.Undefined.BehaviourContracts;

namespace Logic.JudgementForms.SubjectForm.Undefined
{   
    class UndefinedForm : ISubjectForm
    {
        private IUndefinedForm _form;
        private SubjectForms _innerForm;
        public IUndefinedForm Form
        {
            get { return _form; }
        }

        public SubjectForms InnerForm
        {
            get { return _innerForm; }
        }

        public UndefinedForm()
        {
            _form = new EmptyForm();
            _innerForm = SubjectForms.Undefined;
        }

        public UndefinedForm(IUndefinedForm form)
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
