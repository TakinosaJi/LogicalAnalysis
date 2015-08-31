using System;
using System.Collections.Generic;
using Logic.NotionTypes.DefinitionParts;
using Logic.NotionTypes.DivisionParts;

namespace Logic
{
    class Division
    {
        private Divident _divident;

        private Members _members;

        /// <summary>
        /// Деление должно иметь одно основание. При делении понятий 
        /// чаще всего повторяется ошибка, заключающаяся в том, 
        /// что в процессе деления меняется основание деления.
        /// </summary>
        private FeatureKey _fundamentumDivision;

        /// <summary>
        /// Это значит, что если мы перечисляем по какому-нибудь основанию
        /// или принципу виды данного родового понятия, то мы должны точно перечислить все виды, 
        /// не уменьшая и не увеличивая их количества, т. е. сумма видов должна равняться делимому роду.
        /// </summary>
        public Boolean IsComplete
        {
            get { return false; }
        }

        /// <summary>
        /// SelfExplanatory...
        /// </summary>
        public Boolean DifiniesExcludeEachOther
        {
            get { return false; }
        }

        /// <summary>
        /// Деление должно быть непрерывным, т. е. при делении какого-либо понятия 
        /// нужно переходить к ближайшему низшему роду, в противном случае будет получаться то, что называется скачком в делении. 
        /// Если бы мы понятие «природа» разде¬лили на 1) «животные», 2) «растения», 3) «минералы», то в этом делении 
        /// был бы слишком внезапный переход от понятия «при¬рода» к понятиям «минералы», «животные». Чтобы исправить ошибку, 
        /// следует вставить между понятием «природа» и членами вышеприведённого деления ещё два посредствующих звена.
        /// </summary>
        public Boolean IsIncessatly
        {
            get { return false; }
        }

        public Division()
        {
            
        }
    }
}
