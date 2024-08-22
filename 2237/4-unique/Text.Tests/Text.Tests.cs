using NUnit.Framework;
using Text;

namespace Text.Tests
{
	/// <summary>
	/// Tests the <see cref="Str"/> class.
	/// </summary>
	public class Tests
	{
		/// <summary>
		/// Tests with a normal string.
		/// </summary>
		[Test]
		public void TestWithNormalString()
		{
			int result = Str.UniqueChar("Hello");
			Assert.AreEqual(0, result);
		}

		/// <summary>
		/// Tests with an empty string.
		/// </summary>
		[Test]
		public void TestWithEmptyString()
		{
			int result = Str.UniqueChar("");
			Assert.AreEqual(-1, result);
		}

		/// <summary>
		/// Tests with a repeating character only string.
		/// </summary>
		[Test]
		public void TestWithRepeatingCharacter()
		{
			int result = Str.UniqueChar("aaaaaaaa");
			Assert.AreEqual(-1, result);
		}

		/// <summary>
		/// Tests with a repeating character only string.
		/// </summary>
		[Test]
		public void TestWithRepeatingCharacterAndNonRepeating()
		{
			int result = Str.UniqueChar("aaaaaaaab");
			Assert.AreEqual(8, result);
		}

		/// <summary>
		/// Tests with only the first character unique.
		/// </summary>
		[Test]
		public void TestWithFirstUnique()
		{
			int result = Str.UniqueChar("Heeeeeeeee");
			Assert.AreEqual(0, result);
		}

		/// <summary>
		/// Tests with only one character.
		/// </summary>
		[Test]
		public void TestWithOneChar()
		{
			int result = Str.UniqueChar("a");
			Assert.AreEqual(0, result);
		}

		/// <summary>
		/// Tests with the unique character in the middle.
		/// </summary>
		[Test]
		public void TestWithMiddleUnique()
		{
			int result = Str.UniqueChar("aaaabaaaa");
			Assert.AreEqual(4, result);
		}
	}
}
