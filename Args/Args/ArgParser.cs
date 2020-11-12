using System.Collections.Generic;
using System.Linq;
using Args.Domain;

namespace Args
{
    public class ArgParser
    {
        public ArgParser()
        {
            Commands = new List<Command>();
        }

        private List<Command> Commands { get; }

        private Dictionary<string, string> ParseCommands(string[] args)
        {
            var dic = new Dictionary<string, string>();

            for (int i = 0; i < args.Length; i++)
            {
                if (IsCommand(args[i]))
                {
                    if (IsCommand(args[i + 1]))
                    {
                        dic.Add(NormalizedCommand(args, i), string.Empty);
                    }
                    else
                    {
                        dic.Add(NormalizedCommand(args, i), args[i + 1]);
                        i++;
                    }
                }
            }

            return dic;
        }

        private static string NormalizedCommand(string[] args, int i)
        {
            return args[i].Substring(1, args[i].Length - 1);
        }

        private bool IsCommand(string v)
        {
            return v.StartsWith('-');
        }

        public void Parse(string[] args, Schema schema)
        {
            foreach (var item in ParseCommands(args))
            {
                Commands.Add(FactoryCommand.Create(item.Key, schema.GetType(item.Key), item.Value));
            }
        }

        public string FlagValue(string flagName)
        {
            return Commands.First(x => x.ArgName == flagName).GetFlagValue();
        }
    }
}
