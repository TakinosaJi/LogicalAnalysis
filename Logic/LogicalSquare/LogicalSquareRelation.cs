using System;

namespace Logic.LogicalSquare
{
    abstract class LogicalSquareRelation
    {
        public Boolean? ExtremeContradiction { get; set; }

        protected Boolean _differentQuantity;
        protected Boolean _differentQuality;
        public Boolean DifferentQuantity
        {
            get { return _differentQuantity; }
        }
        public Boolean DifferentQuality {
            get { return _differentQuality; } 
        }

        protected LogicalSquareRelation()
        {
            ExtremeContradiction = null;
        }
    }
}
