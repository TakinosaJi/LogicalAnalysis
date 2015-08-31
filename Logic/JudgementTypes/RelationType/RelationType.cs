using Logic.JudgementTypes.BehaviourContracts;
using Logic.JudgementTypes.RelationType.BehaviourContracts;

namespace Logic.JudgementTypes.RelationType
{
    class RelationType
    {
        private readonly IRelationType _type;

        public RelationType()
        {
            _type = new EmptyType();
        }
        public RelationType(IRelationType type)
        {
            _type = type;
        }

        public IRelationType Type
        {
            get { return (IRelationType)_type; }
        }
    }
}
