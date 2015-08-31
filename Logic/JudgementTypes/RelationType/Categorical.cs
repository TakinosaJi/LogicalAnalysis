using System;
using Logic.JudgementTypes.RelationType.BehaviourContracts;

namespace Logic.JudgementTypes.RelationType
{
    class Categorical : IRelationType
    {
        private RelationTypes _innerType;

        public RelationTypes InnerType
        {
            get { return _innerType; }
        }

        public Categorical()
        {
            _innerType = RelationTypes.Categorical;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
