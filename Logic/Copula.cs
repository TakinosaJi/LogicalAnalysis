using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// Грамматический анализ предложения. В предложении мы всегда высказываем что-нибудь относительно чего-нибудь.
    /// То, относительно чего мы высказываем, называется подлежащим, субъектом, а то, что мы о нём высказываем, 
    /// называется предика¬том, сказуемым. Типом простого предложения является предложение «Л есть и», «А не есть В». 
    /// В этих предложениях А есть субъект (subjectum), В есть предикат (praedicatum); «есть» и «не есть» называется связкой (copula),
    ///  потому что она Служит для связывания подлежащего со сказуемым. Подлежащее обык¬новенно обозначается символом S, а 
    /// сказуемое — символом Р (начальные буквы слов subjectum, praedicatum).
    /// </summary>
    internal class Copula
    {
        private Boolean _isAffirmative;

        public bool IsAffirmative
        {
            get { return _isAffirmative; }
        }

        protected internal Copula()
        {
            _isAffirmative = true;
        }
    }
}
