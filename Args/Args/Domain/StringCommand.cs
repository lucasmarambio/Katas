namespace Args.Domain
{
    public class StringCommand : Command
    {
        private readonly string _value;

        private StringCommand(string argName, string value) : base(argName)
        {
            _value = value;
        }

        public static StringCommand Create(string argName, string value)
        {
            return new StringCommand(argName, value);
        }

        public override string GetFlagValue() => _value;
    }
}
