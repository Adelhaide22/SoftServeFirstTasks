using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSequence_7
{
    public class SquareSequence : ISequence
    {
        #region Field

        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        #endregion

        #region Props
        public int StartRange { get; }
        public int FinishRange { get; }

        #endregion

        #region Ctor
        public SquareSequence(int f, int s = 0)
        {
            FinishRange = f;
            StartRange = s;
        }

        #endregion

        #region Methods

        public IEnumerable<int> GetSequence()
        {
            for (int i = StartRange; i * i < FinishRange; i++)
            {
                log.Info($"Add {i} to sequense");
                yield return i;
            }
        }

        public string GetStringResult(IEnumerable<int> sequence)
        {
            return string.Join(", ", sequence);
        }

        #endregion
    }
}
