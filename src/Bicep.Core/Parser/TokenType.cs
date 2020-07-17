namespace Bicep.Core.Parser
{
    public enum TokenType
    {
        Unrecognized,
        LeftBrace,
        RightBrace,
        LeftParen,
        RightParen,
        LeftSquare,
        RightSquare,
        Comma,
        Dot,
        Question,
        Colon,
        Semicolon,
        Assignment,
        Plus,
        Minus,
        Asterisk,
        Slash,
        Modulus,
        Exclamation,
        LessThan,
        GreaterThan,
        LessThanOrEqual,
        GreaterThanOrEqual,
        Equals,
        NotEquals,
        EqualsInsensitive,
        NotEqualsInsensitive,
        BinaryAnd,
        BinaryOr,
        Identifier,
        String,
        Number,
        DefaultKeyword,
        ParameterKeyword,
        OutputKeyword,
        VariableKeyword,
        ResourceKeyword,
        ModuleKeyword,
        TrueKeyword,
        FalseKeyword,
        NullKeyword,
        NewLine,
        EndOfFile,
    }
}