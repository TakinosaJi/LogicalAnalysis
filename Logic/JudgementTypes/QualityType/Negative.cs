using System;
using Logic.JudgementTypes.QualityType.BehaviourContracts;

namespace Logic.JudgementTypes.QualityType
{
    class Negative : IQualityType
    {
        private QualityTypes _innerType;

        public QualityTypes InnerType
        {
            get { return _innerType; }
        }

        public Negative()
        {
            _innerType = QualityTypes.Negative;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
