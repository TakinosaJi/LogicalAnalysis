using Logic.JudgementTypes.BehaviourContracts;
using Logic.JudgementTypes.QualityType.BehaviourContracts;
using Logic.JudgementTypes.QuantityType.BehaviourContracts;

namespace Logic.JudgementTypes.QuantityType
{
    class QuantityType
    {
        private readonly IQuantityType _type;

        public QuantityType()
        {
            _type = new EmptyType();
        }
        public QuantityType(IQuantityType type)
        {
            _type = type;
        }

        public IQuantityType Type
        {
            get { return (IQuantityType)_type; }
        }
    }
}
