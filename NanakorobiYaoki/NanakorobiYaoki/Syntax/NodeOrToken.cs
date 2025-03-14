namespace NanakorobiYaoki;

using System.Diagnostics;

public class NodeOrToken
{
    private readonly SyntaxNode? _node;
    private readonly SyntaxToken? _token;

    public NodeOrToken(SyntaxNode node)
    {
        Debug.Assert(node is not null);
        _node = node;
        _token = null;
    }

    public NodeOrToken(SyntaxToken token)
    {
        Debug.Assert(token is not null);
        _token = token;
        _node = null;
    }

    public int Length
    {
        get
        {
            if (_token is not null)
            {
                return _token.Length;
            }
            else
            {
                return _node!.Length;
            }
        }
    }

    public SyntaxKind Kind
    {
        get
        {
            if (_token is not null)
            {
                return _token.Kind;
            }
            else
            {
                return _node!.Kind;
            }
        }
    }

    public bool IsToken => _token is not null;
    public bool IsNode => _node is not null;
}
