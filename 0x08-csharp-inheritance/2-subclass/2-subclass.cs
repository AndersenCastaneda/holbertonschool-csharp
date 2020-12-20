using System;

public class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType.IsAssignableFrom(baseType) || derivedType.IsSubclassOf(baseType);
    }
}
