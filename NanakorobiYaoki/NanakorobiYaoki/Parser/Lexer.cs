using System.Collections.Generic;

namespace NanakorobiYaoki;

public class Lexer
{
    private struct TokenInfo {
        public SyntaxKind Kind { get; init; }
        public string Text { get; init; }
    }
    private readonly SourceText _st;

    public Lexer(SourceText text)
    {
        _st = text;
    }

    public SyntaxToken Lex()
    {
        var trailingTrivia = LexTrivia(false);
        LexTokenInfo(out var tokenInfo);
        var leadingTrivia = LexTrivia(true);
        return new SyntaxToken(
            tokenInfo.Kind, 
            tokenInfo.Text, 
            new SyntaxTriviaList([.. trailingTrivia]), 
            new SyntaxTriviaList([.. leadingTrivia]));
    }

    private List<SyntaxTrivia> LexTrivia(bool isLeading)
    {
        var triviaList = new List<SyntaxTrivia>();
        return triviaList;
    }

    private void LexTokenInfo(out TokenInfo tokenInfo)
    {
        tokenInfo = new TokenInfo();
    }
}