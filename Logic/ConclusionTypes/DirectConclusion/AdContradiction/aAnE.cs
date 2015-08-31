using System;
using Logic.ConclusionTypes.DirectConclusion.AdContradiction.BehaviourContracts;

namespace Logic.ConclusionTypes.DirectConclusion.AdContradiction
{
    /// <summary>
    /// От истинности обще-утвердительного суждения «все растения суть организмы» 
    /// заключаем к ложности противного суждения: «ни одно растение не есть организм». 
    /// Случаев умозаключения adcontrariam два: от истин¬ности А к ложности Е и от истинности Е к ложности А.
    /// </summary>
    class aAnE : IAdContradictionType
    {
        public aAnE() { }

        public virtual Int32 GetIdent()
        {
            return (Int32)AdContradictionTypes.aAnE;
        }
    }
}
