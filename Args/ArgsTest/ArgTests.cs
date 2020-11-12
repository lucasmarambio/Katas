using Args;
using Args.Domain;
using Xunit;

namespace ArgsTest
{
    public class ArgTests
    {
        [Fact]
        public void ShouldValidateBasicParse()
        {
            var stu = new ArgParser();
            var args = "-l -p 8080 -d /usr/logs".Split(" ");
            stu.Parse(args, new Schema());

            Assert.Equal(stu.FlagValue("l"), false.ToString());
        }
    }
}
