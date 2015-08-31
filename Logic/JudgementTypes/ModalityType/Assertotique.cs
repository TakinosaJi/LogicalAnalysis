using System;
using Logic.JudgementTypes.ModalityType.BehaviourContracts;

namespace Logic.JudgementTypes.ModalityType
{
    class Assertotique : IModalityType
    {
        private ModalityTypes _innerType;
        public ModalityTypes InnerType
        {
            get { return _innerType; }
        }

        public Assertotique()
        {
            _innerType = ModalityTypes.Assertotique;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
