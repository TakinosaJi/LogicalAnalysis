using Logic.JudgementTypes.BehaviourContracts;
using Logic.JudgementTypes.RelationType.BehaviourContracts;

namespace Logic.JudgementTypes.RelationType
{
    class EmptyType : IRelationType
    {
        public int GetIdent()
        {
            return 0;
        }
    }
}
