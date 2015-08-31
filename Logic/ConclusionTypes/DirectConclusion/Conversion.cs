using System;
using Logic.ConclusionTypes.DirectConclusion.BehaviourContracts;

namespace Logic.ConclusionTypes.DirectConclusion
{
    class Conversion : IDirectConclusionType
    {
        private DirectConclusionTypes _innerType;

        public DirectConclusionTypes InnerType
        {
            get { return _innerType; }
        }

        public Boolean IsClean
        {
            get { return false; }
        }

        public Conversion()
        {
            _innerType = DirectConclusionTypes.Conversion;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        } 
    }
}