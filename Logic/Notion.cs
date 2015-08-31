using System;
using System.Collections.Generic;

namespace Logic
{
    class Notion
    {
        #region Fields
        private Int64 _ID;
        private IEnumerable<Feature> _content;
        private IEnumerable<Notion> _volume;
        #endregion

        #region Properties
        public Int64 ID
        {
            get { return _ID; }
        }
        public IEnumerable<Feature> Content
        {
            get { return _content; }
        }
        public IEnumerable<Notion> Volume
        {
            get { return _volume; }
        }
        #endregion

        #region Constructors
        #endregion

        #region InterfaceImplementation
        #endregion

        #region Methods
        #endregion
    }
}
