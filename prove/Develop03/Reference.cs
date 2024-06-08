public class Reference
{
    private string _book;
    private int _chapter;
    private int _vStart;
    private int _vEnd;

    public Reference(string book, int chapter, int vStart)
    {
        _book = book;
        _chapter = chapter;
        _vStart = vStart;
        _vEnd = vStart;
    }

    public Reference(string book, int chapter, int vStart, int vEnd)
    {
        _book = book;
        _chapter = chapter;
        _vStart = vStart;
        _vEnd = vEnd;
    }

    public string GetFormattedReference()
    {
        if (_vStart == _vEnd)
        {
            return $"{_book} {_chapter}:{_vStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_vStart}-{_vEnd}";
        }
    }
}
