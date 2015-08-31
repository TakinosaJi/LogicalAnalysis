using Logic.ConclusionTypes.BehaviourContracts;
using Logic.ConclusionTypes.DirectConclusion.BehaviourContracts;

namespace Logic.ConclusionTypes.DirectConclusion
{
    public class DirectConclusionType
    {
        private IDirectConclusionType _type;

        public DirectConclusionType()
        {
            _type = new EmptyType();
        }
        public DirectConclusionType(IDirectConclusionType type)
        {
            _type = type;
        }

        public IDirectConclusionType Type
        {
            get { return _type; }
        }   
    }
}