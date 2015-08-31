using System;
using Logic.JudgementTypes.QuantityType.BehaviourContracts;

namespace Logic.JudgementTypes.QuantityType
{
    class Partial : IQuantityType
    {
        private QuantityTypes _innerType;

        public QuantityTypes InnerType
        {
            get { return _innerType; }
        }

        public Partial()
        {
            _innerType = QuantityTypes.Partial;
        }

        public Int32 GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
