using RegexHelper;
using Xunit;

namespace RegexHelperTests
{
    public class CommentTests
    {
        [Theory]
        [InlineData("Hello,.. 3")]
        [InlineData("Hello, World.")]
        public void CommentPattern_Should_Succeed(string comment)
        {
            Assert.True(CommentPattern.isMatch(comment));
        }

        [Theory]
        [InlineData("Hello,.. + 3")]
        [InlineData("Hello @ World.")]
        public void CommentPattern_Should_Fail(string comment)
        {
            Assert.False(CommentPattern.isMatch(comment));
        }
    }
}