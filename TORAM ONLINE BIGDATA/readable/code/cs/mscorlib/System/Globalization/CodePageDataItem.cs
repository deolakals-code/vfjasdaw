// Assembly: mscorlib.dll
// Namespace: System.Globalization
[Serializable]
internal class CodePageDataItem // TypeDefIndex: 10820
{
	// Fields
	internal int m_dataIndex; // 0x10
	internal int m_uiFamilyCodePage; // 0x14
	internal string m_webName; // 0x18
	internal string m_headerName; // 0x20
	internal uint m_flags; // 0x28
	private static readonly char[] sep; // 0x0

	// Properties
	public string WebName { get; }
	public string HeaderName { get; }

	// Methods

	// RVA: 0x2F9EBE0 Offset: 0x2F9ABE0 VA: 0x2F9EBE0
	internal void .ctor(int dataIndex) { }

	// RVA: 0x2F9EC84 Offset: 0x2F9AC84 VA: 0x2F9EC84
	internal static string CreateString(string pStrings, uint index) { }

	// RVA: 0x2F9ED38 Offset: 0x2F9AD38 VA: 0x2F9ED38
	public string get_WebName() { }

	// RVA: 0x2F9EE08 Offset: 0x2F9AE08 VA: 0x2F9EE08
	public string get_HeaderName() { }

	// RVA: 0x2F9EED8 Offset: 0x2F9AED8 VA: 0x2F9EED8
	private static void .cctor() { }
}
