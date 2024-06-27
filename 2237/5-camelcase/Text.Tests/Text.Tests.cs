using System.Reflection;
using NUnit.Framework;
using Text;

namespace Text.Tests
{
	public class Tests
	{
		[Test]
		public void TestWithOneWord()
		{
			int result = Str.CamelCase("hello");
			Assert.AreEqual(1, result);
		}

		[Test]
		public void TestWithSeveralWords()
		{
			int result = Str.CamelCase("holbertonSchoolCsharpProject");
			Assert.AreEqual(4, result);
		}

		[Test]
		public void TestWithEmptyString()
		{
			int result = Str.CamelCase("");
			Assert.AreEqual(0, result);
		}

		[Test]
		public void TestWithTwoWords()
		{
			int result = Str.CamelCase("holbertonSchool");
			Assert.AreEqual(2, result);
		}
	}
}
