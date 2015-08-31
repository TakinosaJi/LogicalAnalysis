using System;
using Logic.ConclusionTypes.DirectConclusion.AdContradiction.BehaviourContracts;

namespace Logic.ConclusionTypes.DirectConclusion.AdContradiction
{
    /// <summary>
    /// От ложности обще-утвердительного суждения: «все люди читают газеты», 
    /// заключаем к истинности частно-отрицательного: «некоторые люди не читают газет».
    /// </summary>
    class nAaO_nEaI : IAdContradictionType
    {
        public nAaO_nEaI() { }

        public virtual Int32 GetIdent()
        {
            return (Int32)AdContradictionTypes.nAaO_nEaI;
        }
    }
}
