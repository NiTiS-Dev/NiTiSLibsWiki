using NiTiS.Additions;

public enum Template : byte
{
    [EnumInfo("struct.md")]Struct = 0,
    [EnumInfo("class.md")]Class = 1,
    [EnumInfo("interface.md")]Interface = 2,
    [EnumInfo("enum.md")]Enum = 3,
}