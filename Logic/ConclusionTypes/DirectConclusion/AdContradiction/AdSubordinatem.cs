using System;
using Logic.ConclusionTypes.DirectConclusion.AdContradiction.BehaviourContracts;

namespace Logic.ConclusionTypes.DirectConclusion.AdContradiction
{
    /// <summary>
    /// Умозаключение от подчинённого к подчиняющему.
    /// </summary>
    class AdSubordinatem  : IAdContradictionType
    {
        public AdSubordinatem() { }

        public virtual Int32 GetIdent()
        {
            return (Int32)AdContradictionTypes.AdSubordinatem;
        }
    }
}
