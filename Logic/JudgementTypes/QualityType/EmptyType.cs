using Logic.JudgementTypes.QualityType.BehaviourContracts;

namespace Logic.JudgementTypes.QualityType
{
    class EmptyType : IQualityType
    {
        public int GetIdent()
        {
            return 0;
        }
    }
}
