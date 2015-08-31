using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class Thinking
    {
        #region Fields
        private readonly IEnumerable<Notion> _notions;
        private readonly IEnumerable<Judgement> _judgements;
        private readonly IEnumerable<Conclusion> _conclusions;
        #endregion
        
        #region Properties
        #endregion

        #region Constructors
        public Thinking()
        {
            _notions = new List<Notion>();
            _judgements = new List<Judgement>();
            _conclusions = new List<Conclusion>();
        }

        public Thinking(IEnumerable<Notion> notions)
        {
            _notions = new List<Notion>(notions);
        }
        #endregion

        #region ClassImplementation
        #endregion

        #region InterfaceImplementation
        #endregion

        #region Methods
        /// <summary>
        /// Процесс образования менее общих понятий из более общих называется ограничением (determlnatio). 
        /// Для образования менее общего понятия мы должны к более общему прибавить несколько признаков, 
        /// благодаря чему по-нятие уясняется (determinatur). 
        /// </summary>
        /// <returns></returns>
        public Notion Determine() { return new Notion(); }
        /// <summary>
        /// Обратный процесс образования более общего понятия из менее общего, при котором, наоборот, 
        /// некоторое количество признаков от данного понятия отнимается, называется обобщением (generalisatio).
        /// </summary>
        /// <returns></returns>
        public Notion Generalize() { return new Notion(); }

        public Judgement MakeJudgement()
        {
            //Use JudgementFabric;
            throw new NotImplementedException();
        }
        #endregion

        //Закон тождества. Закон тождества можно формулировать: «А есть А», т. е. всякий предмет есть то, что он есть.
        //Закон противоречия. Закон противоречия формулируется так: «А не может в одно и то же время быть В и не - В», или: «из двух суждений, из которых одно утверждает то, что другое отрицает, одно должно быть ложным».
        //Закон исключённого третьего. Закон исключённого третьего формулируется следующим образом: «при двух суждениях, из которых одно утверждает то, что другое отрицает («А есть В» и «А есть не-В»), не может быть третьего, среднего суж¬дения».
        //Закон достаточного основания. Четвёртый закон мышления называется «законом достаточного основания» (lexrationis sufficientis). Этот закон обыкновенно определяется так: «мы все должны мыслить на достаточном основании», т. е. всякая мысль, всякое суждение должно иметь определённое логическое обоснование.
    }
}
