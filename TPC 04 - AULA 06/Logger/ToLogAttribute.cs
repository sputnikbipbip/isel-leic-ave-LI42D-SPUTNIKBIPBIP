using System;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property | AttributeTargets.Method, AllowMultiple=true)]
public class ToLogAttribute : Attribute {

    public string Title { get; set; }

    public ToLogAttribute(String label)
    {
        Title = label;
    }

    public ToLogAttribute()
    {}
}