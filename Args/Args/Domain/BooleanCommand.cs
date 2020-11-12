using System;

namespace Args.Domain
{
    public class BooleanCommand : Command
    {
        private readonly bool _value;

        private BooleanCommand(string argName, bool value) : base(argName)
        {
            _value = value;
        }

        public static BooleanCommand Create(string argName, string value)
        {
            if (bool.TryParse(value, out bool boolValue))
            {
                return new BooleanCommand(argName, boolValue);
            }
            else if (IsDefault(value))
            {
                return new BooleanCommand(argName, false);
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
