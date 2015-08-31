using System;

namespace Logic.JudgementForms.SubjectForm.Defined
{  
    class General : DefinedForm
    {
        private DefinedForms _innerType;

        public DefinedForms InnerType
        {
            get { return _innerType; }
            protected set { _innerType = value; }
        }

        public General()
        {
            _innerType = DefinedForms.General;
        }

        public override int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
