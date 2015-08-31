using System;
using Logic.JudgementTypes.RelationType.BehaviourContracts;

namespace Logic.JudgementTypes.RelationType
{
    class Conditional : IRelationType
    {
        private RelationTypes _innerType;

        public RelationTypes InnerType
        {
            get { return _innerType; }
        }

        public Conditional()
        {
            _innerType = RelationTypes.Conditional;
        }
        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
