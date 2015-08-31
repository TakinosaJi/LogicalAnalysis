using System;
using Logic.JudgementTypes.ModalityType.BehaviourContracts;

namespace Logic.JudgementTypes.ModalityType
{
    class Appodictique : IModalityType
    {
        private ModalityTypes _innerType;

        public ModalityTypes InnerType
        {
            get { return _innerType; }
        }

        public Appodictique()
        {
            _innerType = ModalityTypes.Appodictique;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
