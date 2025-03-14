namespace NanakorobiYaoki;

using System.Collections.Generic;
using System.Linq;

public class SyntaxNode
{
    private readonly SyntaxKind _kind;
    private readonly List<NodeOrToken> _children;
    private readonly int _length;

    public SyntaxNode(SyntaxKind kind, List<NodeOrToken> children)
    {
        _kind = kind;
        _children = children;
        _length = children.Sum(x => x.Length);
    }

    public SyntaxKind Kind => _kind;
    public int ChildCount => _children.Count;
    public int Length => _length;

    public NodeOrToken? GetChild(int index)
    {
        if (index >= ChildCount)
        {
            return null;
        }

        return _children[index];
    }
}
