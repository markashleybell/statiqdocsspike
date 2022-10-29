namespace MyLibrary;
public class TestClass
{
    /// <summary>
    /// Creates a new TestClass instance.
    /// </summary>
    /// <param name="id">The ID of this instance.</param>
    /// <param name="name">The name of this instance.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="name"/> is null</exception>
    public TestClass(int id, string name)
    {
        ID = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public int ID { get; set; }

    public string Name { get; set; }
}
