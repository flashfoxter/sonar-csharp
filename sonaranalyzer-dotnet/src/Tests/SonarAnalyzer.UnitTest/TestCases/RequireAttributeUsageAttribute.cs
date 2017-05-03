using System;

namespace Tests.Diagnostics
{
    public sealed class MyInvalidAttribute : Attribute // Noncompliant {{Specify targets for 'MyInvalidAttribute' with 'System.AttributeUsageAttribute'.}}
//                      ^^^^^^^^^^^^^^^^^^
    {
    }

    [AttributeUsage(AttributeTargets.Class)]
    public sealed class MyCompliantAttribute : Attribute
    {
    }
}
