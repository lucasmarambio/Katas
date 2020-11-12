using System;
using Args.Domain;

namespace Args
{
    public class FactoryCommand
    {
        public static Command Create(string argname, TypeEnum type, string value)
        {
            switch (type)
            {
                case TypeEnum.String:
                    return StringCommand.Create(argname, value);
                case TypeEnum.Int:
                    return IntCommand.Create(argname, value);
                case TypeEnum.Bool:
                    return BooleanCommand.Create(argname, value);
                default:
                    // TODO: Handle not supported types
                    throw new NotImplementedException();
            }
        }
    }
}