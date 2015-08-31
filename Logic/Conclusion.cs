using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    abstract class Conclusion
    {
        #region Fields
        //Premices
        private readonly List<Judgement> _premices;

        #endregion

        #region Properties
        public List<Judgement> Premices
        {
            get { return _premices; }
        }
        public Judgement Consequence { get; private set; }
        #endregion

        #region Constructors

        protected Conclusion(params Judgement[] premices)
        {
            _premices = new List<Judgement>();
            _premices.AddRange(premices);        
        }
        #endregion

        #region InterfaceImplementation
        #endregion

        #region Methods

        public abstract Judgement Produce();

        #endregion
    }
}
