namespace NanakorobiYaoki;

public class SyntaxToken
{
    private readonly SyntaxKind _kind;
    private readonly string _text;

    private readonly SyntaxTriviaList? _trailingTrivia = null;
    private readonly SyntaxTriviaList? _leadingTrivia = null;

    public SyntaxToken(SyntaxKind kind, string text)
    {
        _kind = kind;
        _text = text;
    }

    public SyntaxToken(SyntaxKind kind, string text, SyntaxTriviaList leadingTrivia, SyntaxTriviaList trailingTrivia)
    {
        _kind = kind;
        _text = text;
        _leadingTrivia = leadingTrivia;
        _trailingTrivia = trailingTrivia;
    }

    public SyntaxKind Kind => _kind;
    public string Text => _text;
    public int Length => _text.Length;
    public SyntaxTriviaList? TrailingTrivia => _trailingTrivia;
    public SyntaxTriviaList? LeadingTrivia => _leadingTrivia;
}
