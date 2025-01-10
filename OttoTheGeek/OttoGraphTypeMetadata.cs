using System;
using GraphQL.Types;

namespace OttoTheGeek;

public static class OttoGraphTypeMetadata
{
    public const string ClrTypeKey = "Otto.ClrType";

    public static Type GetOttoClrType(this IGraphType graphType)
    {
        graphType.Metadata.TryGetValue(ClrTypeKey, out var type);

        return type as Type;
    }

    public static void SetOttoClrTypeMetadata(this IGraphType graphType, Type clrType)
    {
        graphType.Metadata[ClrTypeKey] = clrType;
    }
}
