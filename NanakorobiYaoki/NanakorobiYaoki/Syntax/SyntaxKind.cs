namespace NanakorobiYaoki;

public enum SyntaxKind
{
    // Special
    ListKind,

    // Tokens
    BadToken,
    EndOfFileToken,
    
    PlusToken,
    MinusToken,
    StarToken,
    SlashToken,
    ExclamationToken,
    EqualsToken,
    ColonToken,
    CommaToken,
    SemicolonToken,
    OpenBraceToken,
    CloseBraceToken,
    OpenBracketToken,
    CloseBracketToken,
    OpenParenToken,
    CloseParenToken,
    LessThanToken,
    GreaterThanToken,
    AndToken,
    CaretToken,
    PipeToken,
    QuestionToken,
    DotToken,
    TildeToken,

    PlusPlusToken,
    PlusEqualsToken,
    MinusMinusToken,
    MinusEqualsToken,
    StarEqualsToken,
    SlashEqualsToken,
    ExclamationEqualsToken,
    EqualsEqualsToken,
    LessThanEqualsToken,
    GreaterThanEqualsToken,
    LessThanLessThanToken,
    GreaterThanGreaterThanToken,
    ColonColonToken,
    AndAndToken,
    PipePipeToken,

    // Keywords
    ClassKeyword,
    VoidKeyword,
    IntKeyword,
    LongKeyword,
    StrKeyword,
    InterfaceKeyword,
    PublicKeyword,
    PrivateKeyword,
    StaticKeyword,
    AbstractKeyword,
    FinalKeyword,
    ExtendsKeyword,
    ImplementsKeyword,

    // Literals
    StringLiteralToken,
    NumberLiteralToken,
    
    // Statements

    // Expressions
    BinaryExpression,
    UnaryExpression,

    // Declarations
    ClassDeclaration,
    InterfaceDeclaration,
    MethodDeclaration,
    FieldDeclaration,
    LocalVariableDeclaration,
}