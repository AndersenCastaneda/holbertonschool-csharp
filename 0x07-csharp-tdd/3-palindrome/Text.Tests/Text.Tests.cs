using NUnit.Framework;
using Text;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void Str_IsPalindrome_casac()
        {
            Assert.IsTrue(Str.IsPalindrome("casac"));
        }

        [Test]
        public void Str_IsPalindrome_casa()
        {
            Assert.IsFalse(Str.IsPalindrome("casa"));
        }

        [Test]
        public void Str_IsPalindrome_anitalavalatina()
        {
            Assert.IsTrue(Str.IsPalindrome("anitalavalatina"));
        }

        [Test]
        public void Str_IsPalindrome_Desserts_I_stressed()
        {
            Assert.IsFalse(Str.IsPalindrome("Desserts, I stressed!"));
        }
    }
}