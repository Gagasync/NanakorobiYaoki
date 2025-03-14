namespace NanakorobiYaoki;

using System.Diagnostics;

public class SourceText
{
    private readonly string _text;
    private readonly int _length;
    private int _index;

    public SourceText(string text)
    {
        _text = text;
        _length = text.Length;
        _index = 0;
    }

    public int Idx => _index;
    public int Length => _length;
    public bool IsEof => _index >= _length;
    public char Current => Peek(0);
    public char LA => Peek(1);

    public char Peek(int loc)
    {
        Debug.Assert(loc >= 0);

        var toPeek = _index + loc;
        if (toPeek >= _length)
        {
            return '\0';
        }

        return _text[toPeek];
    }

    public char Consume()
    {
        var ch = Current;
        _index++;
        return ch;
    }
}
