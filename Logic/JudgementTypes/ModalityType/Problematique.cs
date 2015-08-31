using System;
using Logic.JudgementTypes.ModalityType.BehaviourContracts;

namespace Logic.JudgementTypes.ModalityType
{
    class Problematique : IModalityType
    {
        private ModalityTypes _innerType;
        public ModalityTypes InnerType
        {
            get { return _innerType; }
        }

        public Problematique()
        {
            _innerType = ModalityTypes.Problematique;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
