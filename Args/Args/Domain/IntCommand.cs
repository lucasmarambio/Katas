using System;
using System.Collections.Generic;
using System.Text;

namespace Args.Domain
{
    public class IntCommand : Command
    {
        private int _value;

        private IntCommand(string argName, int value) : base(argName)
        {
            _value = value;
        }

        public static IntCommand Create(string argName, string value)
        {
            if (int.TryParse(value, out int intValue))
            {
                return new IntCommand(argName, intValue);
            }
            else if (IsDefault(value))
            {
                return new IntCommand(argName, 0);
            }
            else
            {
                // TODO: HandleError
                throw new NotImplementedException();
            }
        }

        public override string GetFlagValue() => _value.ToString();
    }
}
