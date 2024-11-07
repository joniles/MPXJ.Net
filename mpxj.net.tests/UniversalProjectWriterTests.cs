using NUnit.Framework;
using System.IO;

namespace MPXJ.Net
{
	public class UniversalProjectWriterTests
	{
		private const string Path = "TestData/Results/";

		[SetUp]
		public void SetUp()
		{
			Directory.CreateDirectory(Path);
		}

		[TearDown]
		public void TearDown()
		{
			Directory.Delete(Path, true);
		}

		[Test]
		public void WriteToFileTest()
		{
			var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
			const string filePath = Path + "Sample1-written.xml";
			new UniversalProjectWriter(FileFormat.MSPDI).Write(project, filePath);
			Assert.That(File.Exists(filePath), Is.True);
		}

		[Test]
		public void WriteToStreamTest()
		{
			using (var ms = new MemoryStream())
			{
				var project = new UniversalProjectReader().Read("TestData/Sample1.mpp");
				const string filePath = Path + "Sample1-written-from-stream.xml";
				new UniversalProjectWriter(FileFormat.MSPDI).Write(project, ms);
				File.WriteAllBytes(filePath, ms.ToArray());
				Assert.That(File.Exists(filePath), Is.True);
			}
		}
	}
}
