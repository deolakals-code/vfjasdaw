// Assembly: mscorlib.dll
// Namespace: 
internal struct Interop.Sys.DirectoryEntry // TypeDefIndex: 9411
{
	// Fields
	internal byte* Name; // 0x0
	internal int NameLength; // 0x8
	internal Interop.Sys.NodeType InodeType; // 0xC

	// Methods

	// RVA: 0x2E6500C Offset: 0x2E6100C VA: 0x2E6500C
	internal ReadOnlySpan<char> GetName(Span<char> buffer) { }
}
