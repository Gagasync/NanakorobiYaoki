namespace NanakorobiYaoki;

public class SyntaxTrivia
{
    public SyntaxTrivia(string text)
    {
        Text = text;
    }

    public string Text { get; }
}

public class SyntaxTriviaList {
    private readonly SyntaxTrivia[] _trivia;

    public SyntaxTriviaList(SyntaxTrivia[] trivia)
    {
        _trivia = trivia;
    }

    public SyntaxTrivia[] Trivia => _trivia;
}