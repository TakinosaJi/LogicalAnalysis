using System;
using Logic.ConclusionTypes.DirectConclusion.AdContradiction.BehaviourContracts;

namespace Logic.ConclusionTypes.DirectConclusion.AdContradiction
{
    /// <summary>
    /// Умозаключение от подчиняющего к подчинённому.
    /// </summary>
    class AdSubordinatam  : IAdContradictionType
    {
        public AdSubordinatam() { }

        public virtual Int32 GetIdent()
        {
            return (Int32)AdContradictionTypes.AdSubordinatam;
        }
    }
}
