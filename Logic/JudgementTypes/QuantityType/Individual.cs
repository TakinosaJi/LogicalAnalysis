using System;
using Logic.JudgementTypes.QuantityType.BehaviourContracts;

namespace Logic.JudgementTypes.QuantityType
{
    class Individual : General
    {
        public Individual()
        {
            InnerType = QuantityTypes.Individual;
        }

        public override int GetIdent()
        {
            return (Int32)InnerType;
        }
    }
}
