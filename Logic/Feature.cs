using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public abstract class Feature
    {
        #region Fields
        private Int64 _ID;
        private FeatureKey _key;
        private FeatureValue _value;
        private Boolean? _isPrimary;
        private Boolean? _isSecondary;
        #endregion

        #region Properties
        public Boolean? IsPrimary
        {
            set
            {
                _isPrimary = value;
                if (_isPrimary == null) return;
                if (_isSecondary == value)
                {
                    _isSecondary = !value;
                }
            }
            get { return _isPrimary; }
            
        }
        public Boolean? IsSecondary
        {
            set
            {
                _isSecondary = value;
                if (_isSecondary == null) return;
                if (_isPrimary == value)
                {
                    _isPrimary = !value;
                }
            }
            get { return _isSecondary; }
        }
        #endregion

        #region Constructors
        Feature()
        {
            _isPrimary = null;
            _isSecondary = null;
        }

        Feature(Boolean isPrimary)
        {
            IsPrimary = isPrimary;
        }
        #endregion
    }

    class FeatureKey
    {

    }

    class FeatureValue
    {


    }
}
