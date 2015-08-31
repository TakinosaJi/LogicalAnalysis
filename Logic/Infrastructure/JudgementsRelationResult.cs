using System;
using Logic.LogicalSquare;

namespace Logic.Infrastructure
{
    class JudgementsRelationResult
    {
        public Boolean IsCorrect { get; set; }
        public DefinitionState? IsTruthStateOfComparableJudgementCorrect { get; set; }
        /// <summary>
        /// Relation betwen AIEO Judgements according to Logical Square concept.
        /// </summary>
        public LogicalSquareRelation Relation { get; set; }

        public JudgementsRelationResult()
        {
            IsCorrect = false;
            IsTruthStateOfComparableJudgementCorrect = DefinitionState.Undefined;
            Relation = null;
        }
    }
}
