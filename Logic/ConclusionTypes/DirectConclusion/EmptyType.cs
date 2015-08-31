using Logic.ConclusionTypes.DirectConclusion.BehaviourContracts;
using Logic.JudgementTypes.BehaviourContracts;

namespace Logic.ConclusionTypes.DirectConclusion
{
    class EmptyType : IDirectConclusionType
    {
        public int GetIdent()
        {
            return 0;
        }
    }
}
