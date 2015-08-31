using System;
using Logic.JudgementForms.ExistanceForm.BehaviourContracts;
using Logic.JudgementForms.SubjectForm;

namespace Logic.JudgementForms.ExistanceForm
{
    class Existence : IExistanceForm
    {
        private ExistanceForms _innerType;

        public ExistanceForms InnerType
        {
            get { return _innerType; }
        }

        public Existence()
        {
            _innerType = ExistanceForms.Existance;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
