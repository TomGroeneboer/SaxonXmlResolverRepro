using Saxon.Api;

namespace ConsoleApp1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var processor = new Processor();
			var compiler = processor.NewXsltCompiler();
			var resolver = new CustomXmlResolver();

			// This setter doesn't work properly
			compiler.XmlResolver = resolver;
			
			var shouldBeTrue = ReferenceEquals(compiler.XmlResolver, resolver);
		}
	}
}
