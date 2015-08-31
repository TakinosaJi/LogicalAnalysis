using System;
using Logic.ConclusionTypes.DirectConclusion.BehaviourContracts;

namespace Logic.ConclusionTypes.DirectConclusion
{
    class Obversion : IDirectConclusionType
    {
        private DirectConclusionTypes _innerType;

        public DirectConclusionTypes InnerType
        {
            get { return _innerType; }
        }

        public Obversion()
        {
            _innerType = DirectConclusionTypes.Obversion;
        }

        public int GetIdent()
        {
            return (Int32)_innerType;
        } 
    }
}