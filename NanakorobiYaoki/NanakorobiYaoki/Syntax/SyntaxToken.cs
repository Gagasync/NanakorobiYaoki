namespace NanakorobiYaoki;

public class SyntaxToken
{
    private readonly SyntaxKind _kind;
    private readonly string _text;

    public SyntaxToken(SyntaxKind kind, string text)
    {
        _kind = kind;
        _text = text;
    }

    public SyntaxKind Kind => _kind;
    public string Text => _text;
    public int Length => _text.Length;
}
