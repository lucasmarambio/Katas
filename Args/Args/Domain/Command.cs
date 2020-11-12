namespace Args.Domain
{
    public abstract class Command
    {
        protected string _argName;

        public Command(string argName)
        {
            _argName = argName;
        }

        public string ArgName { get => _argName; }

        protected static bool IsDefault(string value)
        {
            return string.IsNullOrEmpty(value);
        }

        public abstract string GetFlagValue();
    }
}
