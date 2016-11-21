using System;
using System.Xml;

namespace ConsoleApp1
{
    public class CustomXmlResolver : XmlResolver
    {
	    public override object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn)
	    {
			// Custom stuff here
		    throw new NotImplementedException();
	    }
    }
}
