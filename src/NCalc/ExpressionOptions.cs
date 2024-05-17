using System;

namespace NCalc;

[Flags]
public enum ExpressionOptions
{
    // Summary:
    //     Specifies that no options are set.
    None = 1,

    //
    // Summary:
    //     Specifies case-insensitive matching.
    IgnoreCase = 2,

    //
    // Summary:
    //     No-cache mode. Ingores any pre-compiled expression in the cache.
    NoCache = 4,

    //
    // Summary:
    //     Treats parameters as arrays and result a set of results.
    IterateParameters = 8,

    //
    // Summary:
    //     When using Round(), if a number is halfway between two others, it is rounded toward the nearest number that is away from zero. 
    RoundAwayFromZero = 16,

    //
    // Summary:
    //     Specifies the use of CaseInsensitiveComparer for comparasions.
    CaseInsensitiveComparer = 32,

    //
    // Summary:
    //     Uses decimals instead of doubles as default floating point data type
    DecimalAsDefault = 64
}

// Summary:
//     Provides enumerated values to use to set evaluation options.
//
public static class ExpressionOptionsExtensions
{
    public static bool HasOption(this ExpressionOptions options, ExpressionOptions option)
    {
        return (options & option) == option;
    }
}