#:property LangVersion=preview

Builder john = new();
john.Build();
john.BuildExtended();

public class Builder
{
    public void Build()
    {
        Console.WriteLine("Classic Build");
    }
}

public static class BuilderExtensions
{
    extension(Builder builder)
    {
        public void BuildExtended() => Console.WriteLine("Extended Build");
    }
}
