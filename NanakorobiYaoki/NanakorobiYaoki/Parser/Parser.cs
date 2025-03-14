using System;

namespace NanakorobiYaoki;

public class Parser
{
    public Parser()
    {
        
    }

    public static NodeOrToken ParseText(string text)
    {
        var parser = new Parser();
        return parser.Parse();
    }

    public NodeOrToken Parse()
    {
        throw new NotImplementedException();
    }
}
