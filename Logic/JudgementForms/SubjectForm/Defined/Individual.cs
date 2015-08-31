using System;

namespace Logic.JudgementForms.SubjectForm.Defined
{    
    class Individual : General
    {
        private DefinedForms _innerType;

        public DefinedForms InnerType
        {
            get { return _innerType; }
            protected set { _innerType = value; }
        }

        public Individual()
        {
            _innerType = DefinedForms.Individual;
        }

        public override int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
