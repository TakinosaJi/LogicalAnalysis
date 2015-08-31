using Logic.JudgementTypes.BehaviourContracts;
using Logic.JudgementTypes.QualityType.BehaviourContracts;

namespace Logic.JudgementTypes.QualityType
{
    class QualityType
    {
        private readonly IQualityType _type;

        public QualityType()
        {
            _type = new EmptyType();
        }
        public QualityType(IQualityType type)
        {
            _type = type;
        }

        public IQualityType Form
        {
            get { return (IQualityType)_type; }
        }
    }
}
