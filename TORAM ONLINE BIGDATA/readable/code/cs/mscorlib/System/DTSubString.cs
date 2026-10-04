// Assembly: mscorlib.dll
// Namespace: System
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[DefaultMember("Item")]
internal struct DTSubString // TypeDefIndex: 9593
{
	// Fields
	internal ReadOnlySpan<char> s; // 0x0
	internal int index; // 0x10
	internal int length; // 0x14
	internal DTSubStringType type; // 0x18
	internal int value; // 0x1C

	// Properties
	internal char Item { get; }

	// Methods

	// RVA: 0x2FDE3B4 Offset: 0x2FDA3B4 VA: 0x2FDE3B4
	internal char get_Item(int relativeIndex) { }
}
