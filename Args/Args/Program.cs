using Args.Domain;

namespace Args
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = new Schema();
            var parser = new ArgParser();
            parser.Parse(args, schema);
        }
    }
}
