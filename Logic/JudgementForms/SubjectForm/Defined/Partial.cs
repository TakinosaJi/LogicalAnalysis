using System;

namespace Logic.JudgementForms.SubjectForm.Defined
{
    class Partial : DefinedForm
    {
        private DefinedForms _innerType;

        public DefinedForms InnerType
        {
            get { return _innerType; }
        }

        public Partial()
        {
            _innerType = DefinedForms.General;
        }

        public override int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
