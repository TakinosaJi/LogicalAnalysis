using System;
using System.Collections.Generic;
using Logic.ConclusionTypes.DirectConclusion.BehaviourContracts;

namespace Logic.ConclusionTypes.DirectConclusion
{
    class DirectConclusion : Conclusion
    {
        #region Fields
        //Premices
        private Judgement _premice;
        private DirectConclusionType _type;

        #endregion

        #region Properties
        public Judgement Premice
        {
            get { return _premice; }
        }

        public DirectConclusionType Type
        {
            get { return _type; }
        }
        #endregion

        #region Constructors
        protected DirectConclusion()
        {
            _premice = new Judgement();
            _type = new DirectConclusionType();
        }

        protected DirectConclusion(Judgement premice)
        {
            _premice = premice;        
        }
        #endregion

        #region ClassImplementation

        public override Judgement Produce()
        {
            if(Type.Type == DirectConclusionTypes.Obversion)
            {
                    _premice.Copula.IsAffirmative
            }
        }

        #endregion

        #region InterfaceImplementation
        #endregion

        #region Methods
        #endregion
    }
}
