using System;
using Logic.JudgementTypes.QualityType.BehaviourContracts;

namespace Logic.JudgementTypes.QualityType
{
    class Affirmative : IQualityType
    {
        private QualityTypes _innerType;

        public QualityTypes InnerType
        {
            get { return _innerType; }
        }

        public Affirmative()
        {
            _innerType = QualityTypes.Affirmative;
        }

        public int GetIdent()
        {
            return (Int32)QualityTypes.Affirmative;
        }
    }
}
