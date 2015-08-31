using System;
using Logic.ConclusionTypes.DirectConclusion.BehaviourContracts;

namespace Logic.ConclusionTypes.DirectConclusion
{
    class Contradistinction : IDirectConclusionType
    {
        private DirectConclusionTypes _innerType;

        public DirectConclusionTypes InnerType
        {
            get { return _innerType; }
        }

        public Contradistinction()
        {
            _innerType = DirectConclusionTypes.Contradistinction;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        } 
    }
}