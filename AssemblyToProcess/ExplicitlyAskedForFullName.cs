﻿namespace AssemblyToProcess
{
    public class ExplicitlyAskedForFullName
    {
        public ExplicitlyAskedForFullName(int value1, string value2)
        {
            this.Value1 = value1;
            this.Value2 = value2;
        }

        public int Value1 { get; }

        public string Value2 { get; }

        public ExplicitlyAskedForFullName WithValue1(int value) => this;

        public ExplicitlyAskedForFullName WithValue2(string value) => this;
    }
}
