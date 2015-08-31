using System;
using Logic.ConclusionTypes.DirectConclusion.AdContradiction.BehaviourContracts;

namespace Logic.ConclusionTypes.DirectConclusion.AdContradiction
{
    /// <summary>
    /// Дано частно-утвердительное суждение: «некоторые люди всеведущи»; 
    /// от ложности того суждения заключаем к истинности частно-отрицательного: «некоторые люди не суть всеведущи».
    /// </summary>
    class nIaO : IAdContradictionType
    {
        public nIaO() { }

        public virtual Int32 GetIdent()
        {
            return (Int32)AdContradictionTypes.nIaO;
        }
    }
}
