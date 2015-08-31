using Logic.JudgementTypes.BehaviourContracts;
using Logic.JudgementTypes.ModalityType.BehaviourContracts;

namespace Logic.JudgementTypes.ModalityType
{
    class ModalityType
    {
        private readonly IModalityType _type;

        public ModalityType()
        {
            _type = new EmptyType();
        }
        public ModalityType(IModalityType type)
        {
            _type = type;
        }

        public IModalityType Type
        {
            get { return (IModalityType)_type; }
        }
    }
}
