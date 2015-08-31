using System;
using System.Collections.Generic;

namespace Logic.JudgementParts
{  
    class Subject
    {
        #region Fields
        private IEnumerable<Notion> _notions;
        #endregion
 
        #region Properties
        public IEnumerable<Notion> Notions
        {
            get { return _notions; }
        }

        public IEnumerable<Notion> Volume
        {
            get
            {
                var result = new List<Notion>();
                foreach (var notion in _notions)
                {
                    result.AddRange(notion.Volume);
                }

                return result;
            }
        } 
        #endregion

        #region Constructors

        public Subject()
        {
            _notions = new List<Notion>();
        }
        #endregion
 
        #region ClassImplementation
        #endregion
  
        #region InterfaceImplementation
        #endregion

        #region Methods
        #endregion
    }
}
