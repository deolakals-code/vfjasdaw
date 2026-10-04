// Assembly: System.dll
// Namespace: System.Net
internal class HeaderInfo // TypeDefIndex: 14420
{
	// Fields
	internal readonly bool IsRequestRestricted; // 0x10
	internal readonly bool IsResponseRestricted; // 0x11
	internal readonly HeaderParser Parser; // 0x18
	internal readonly string HeaderName; // 0x20
	internal readonly bool AllowMultiValues; // 0x28

	// Methods

	// RVA: 0x34F4788 Offset: 0x34F0788 VA: 0x34F4788
	internal void .ctor(string name, bool requestRestricted, bool responseRestricted, bool multi, HeaderParser p) { }
}
