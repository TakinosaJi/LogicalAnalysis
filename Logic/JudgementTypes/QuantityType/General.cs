using System;
using Logic.JudgementTypes.QuantityType.BehaviourContracts;

namespace Logic.JudgementTypes.QuantityType
{
    class General : IQuantityType
    {
        public QuantityTypes _innerType;

        public QuantityTypes InnerType
        {
            get
            {
                return _innerType;
                
            }
            protected set { _innerType = value; }
        }

        public General()
        {
            InnerType = QuantityTypes.General;
        }

        public virtual Int32 GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
