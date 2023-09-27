namespace AttributeSamples.CustomAttributes;

[AttributeUsage(AttributeTargets.Assembly)]
public class AutoScanForDependencyAttribute : Attribute
{

}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Struct | AttributeTargets.Interface | AttributeTargets.Property , AllowMultiple = true, Inherited = false)]
public class CodeChangeHistoryAttribute : Attribute
{
    private readonly string author;

    public string Description { get; set; }
    public DateTime ChangeDateTime { get; set; }
    public bool IsBug { get; }

    public CodeChangeHistoryAttribute(string author, bool IsBug = false)
    {
        this.author = author;
        this.IsBug = IsBug;
    }
}