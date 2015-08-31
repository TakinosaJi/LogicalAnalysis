using Logic.ConclusionTypes.BehaviourContracts;
using Logic.JudgementTypes.BehaviourContracts;

namespace Logic.ConclusionTypes
{
    class EmptyType : IConclusionType
    {
        public int GetIdent()
        {
            return 0;
        }
    }
}
