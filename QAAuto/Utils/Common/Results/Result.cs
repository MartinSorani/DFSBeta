using System.Collections.Generic;

namespace QAAuto.Utils.Common.Results
{
    public sealed class Result
    {
        public static readonly Result PASSED = new Result("PASSED", InnerEnum.PASSED, 1, "PASSED");
        public static readonly Result BLOCKED = new Result("BLOCKED", InnerEnum.BLOCKED, 2, "BLOCKED");
        public static readonly Result NOTRUN = new Result("NOTRUN", InnerEnum.NOTRUN, 0, "NOTRUN");
        public static readonly Result FAILED = new Result("FAILED", InnerEnum.FAILED, 5, "FAILED");
        public static readonly Result KNOWN_FAILURE = new Result("KNOWN_FAILURE", InnerEnum.KNOWN_FAILURE, 6, "KNOWN FAILURE");

        private static readonly IList<Result> valueList = new List<Result>();

        static Result()
        {
            valueList.Add(PASSED);
            valueList.Add(BLOCKED);
            valueList.Add(NOTRUN);
            valueList.Add(FAILED);
            valueList.Add(KNOWN_FAILURE);
        }

        public enum InnerEnum
        {
            PASSED,
            BLOCKED,
            NOTRUN,
            FAILED,
            KNOWN_FAILURE
        }

        private readonly string nameValue;
        private readonly int ordinalValue;
        private readonly InnerEnum innerEnumValue;
        private static int nextOrdinal = 0;

        internal int value;
        internal string str;

        internal Result(string name, InnerEnum innerEnum, int value, string str)
        {
            this.value = value;
            this.str = str;

            nameValue = name;
            ordinalValue = nextOrdinal++;
            innerEnumValue = innerEnum;
        }

        internal Result(string name, InnerEnum innerEnum, string str)
        {
            this.str = str;
            if (str.Equals("PASSED"))
            {
                this.value = 1;
            }
            else if (str.Equals("BLOCKED"))
            {
                this.value = 2;
            }
            else if (str.Equals("NOTRUN"))
            {
                this.value = 0;
            }
            else if (str.Equals("FAILED"))
            {
                this.value = 5;
            }
            else if (str.Equals("RETEST"))
            {
                this.value = 4;
            }
            else if (str.Equals("WARNING"))
            {
                this.value = 6;
            }
            else
            {
                this.value = -1;
            }

            nameValue = name;
            ordinalValue = nextOrdinal++;
            innerEnumValue = innerEnum;
        }

        public int Status
        {
            get
            {
                return value;
            }
        }

        public string String
        {
            get
            {
                return str;
            }
        }

        public bool failed()
        {
            return this.Equals(FAILED) || this.Equals(BLOCKED) || this.Equals(KNOWN_FAILURE);
        }

        public bool passed()
        {
            return this.Equals(PASSED);
        }

        public bool skipped()
        {
            return this.Equals(NOTRUN);
        }

        public bool failedOrBlocked()
        {
            return this.Equals(FAILED) || this.Equals(BLOCKED);
        }

        public static IList<Result> values()
        {
            return valueList;
        }

        public InnerEnum InnerEnumValue()
        {
            return innerEnumValue;
        }

        public int ordinal()
        {
            return ordinalValue;
        }

        public override string ToString()
        {
            return nameValue;
        }

        public static Result valueOf(string name)
        {
            foreach (Result enumInstance in values())
            {
                if (enumInstance.nameValue == name)
                {
                    return enumInstance;
                }
            }
            throw new System.ArgumentException(name);
        }
    }

}
