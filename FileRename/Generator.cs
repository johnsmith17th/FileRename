using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileRename
{
    public interface INameGenerator
    {
        string GetNextName();
    }

    public class SerialNameGenerator : INameGenerator
    {
        public int Seed { get; private set; }
        public int Digit { get; private set; }
        public string Prefix { get; private set; }
        public string Suffix { get; private set; }
        public int Current { get; private set; }

        public SerialNameGenerator(string prefix, string suffix, int seed, int digit)
        {
            this.Prefix = prefix;
            this.Suffix = suffix;
            this.Seed = seed;
            this.Digit = digit;
            this.Current = seed;
        }

        #region INameGenerator 成员

        public string GetNextName()
        {
            return string.Format("{0}{1}{2}",
                Prefix,
                Current++.ToString(string.Format("D{0}", Digit)),
                Suffix);
        }

        #endregion
    }
}
