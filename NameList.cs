namespace NameListIndexer;

public class NameList
{
    private readonly List<string> _names = new();

    public int Count => _names.Count;

    public string? this[int index]
    {
        get
        {
            if (index < 0 || index >= _names.Count)
            {
                return null;
            }

            return _names[index];
        }
        set
        {
            if (index < 0 || index > _names.Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index),
                    $"Index {index} is outside the bounds of the list.");
            }

            if (index == _names.Count)
            {
                _names.Add(value ?? string.Empty);
            }
            else
            {
                _names[index] = value ?? string.Empty;
            }
        }
    }
}
