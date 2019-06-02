using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSequence_7
{
    class SquareSequence : ISequence
    {
        #region Field

        private static readonly Logger log = LogManager.GetCurrentClassLogger();

        #endregion

        #region Props
        public int StartRange { get => 0; }
        public int FinishRange { get; }

        #endregion

        #region Ctor
        public SquareSequence(int n)
        {
            FinishRange = n;
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
            StringBuilder sb = new StringBuilder();
            foreach (int item in sequence)
            {
                sb.Append($"{item},");
            }
            sb.Remove(sb.Length - 1, 1);
            log.Info(sb);
            return sb.ToString();
        }

        #endregion
    }
}
