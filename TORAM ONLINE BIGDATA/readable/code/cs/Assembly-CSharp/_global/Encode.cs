// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class Encode // TypeDefIndex: 5483
{
	// Fields
	private static bool utf8BOMFlag; // 0x0

	// Properties
	public static Encoding UTF8NoBom { get; }

	// Methods

	// RVA: 0x1778948 Offset: 0x1774948 VA: 0x1778948
	public static Encoding get_UTF8NoBom() { }

	// RVA: 0x17789A0 Offset: 0x17749A0 VA: 0x17789A0
	public static bool LoadEncodeFile(string file, out string fileData) { }

	// RVA: 0x177932C Offset: 0x177532C VA: 0x177932C
	public static List<string> LoadEncodeFileLineList(string file) { }

	// RVA: 0x1778DA4 Offset: 0x1774DA4 VA: 0x1778DA4
	public static Encoding GetCode(byte[] bytes) { }
}
