using System;
using Logic.JudgementForms.SubjectForm.Undefined.BehaviourContracts;

namespace Logic.JudgementForms.SubjectForm.Undefined
{ 
    class Impersonal : IUndefinedForm
    {
        private UndefinedForms _innerType;

        public UndefinedForms InnerType
        {
            get { return _innerType; }
            protected set { _innerType = value; }
        }

        public Impersonal()
        {
            _innerType = UndefinedForms.Impersonal;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
