using System;
using Logic.JudgementTypes.RelationType.BehaviourContracts;

namespace Logic.JudgementTypes.RelationType
{
    class Separative : IRelationType
    {
        private RelationTypes _innerType;

        public RelationTypes InnerType
        {
            get { return _innerType; }
        }

        public Separative()
        {
            _innerType = RelationTypes.Separative;
        }
        public int GetIdent()
        {
            return (Int32)_innerType;
        }
    }
}
