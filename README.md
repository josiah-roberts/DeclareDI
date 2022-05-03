# DeclareDI

Declarative extension for `Microsoft.Extensions.DependencyInjection`, designed to allow functional-style, dependency-injected programming.

## Usage

For higher-order functions:

```C#
public delegate DateTime NowPlusDays(int days);
public delegate string NowPlusDaysFormatted(int days);

public static class Functions {
    
    [Service]
    public static NowPlusDays NowPlusDays() => 
        (days) => DateTime.Now.AddDays(days);

    [Service]
    public static NowPlusDaysFormatted NowPlusDaysFormatted(NowPlusDays nowPlusDays) => 
        (days) => nowPlusDays(days).ToLongDateString();
}
```
