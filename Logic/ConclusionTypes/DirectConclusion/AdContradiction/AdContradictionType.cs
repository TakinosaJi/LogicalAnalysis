using System;
using Logic.ConclusionTypes.BehaviourContracts;
using Logic.ConclusionTypes.DirectConclusion.AdContradiction.BehaviourContracts;
using Logic.ConclusionTypes.DirectConclusion.BehaviourContracts;

namespace Logic.ConclusionTypes.DirectConclusion.AdContradiction
{
    public class AdContradictionType : IDirectConclusionType
    {
        private IAdContradictionType _type;
        private DirectConclusionTypes _innerType;

        public AdContradictionType()
        {
            _type = new EmptyType();
            _innerType = DirectConclusionTypes.AdContradictional;
        }
        public AdContradictionType(IAdContradictionType type)
        {
            _type = type;
            _innerType = DirectConclusionTypes.AdContradictional;
        }

        public IAdContradictionType Type
        {
            get { return _type; }
        }

        public int GetIdent()
        {
            return (Int32) _innerType;
        }
    }
}