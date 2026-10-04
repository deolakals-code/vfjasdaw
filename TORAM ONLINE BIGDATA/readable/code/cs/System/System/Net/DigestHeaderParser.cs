// Assembly: System.dll
// Namespace: System.Net
internal class DigestHeaderParser // TypeDefIndex: 14474
{
	// Fields
	private string header; // 0x10
	private int length; // 0x18
	private int pos; // 0x1C
	private static string[] keywords; // 0x0
	private string[] values; // 0x20

	// Properties
	public string Realm { get; }
	public string Opaque { get; }
	public string Nonce { get; }
	public string Algorithm { get; }
	public string QOP { get; }

	// Methods

	// RVA: 0x3508C3C Offset: 0x3504C3C VA: 0x3508C3C
	public void .ctor(string header) { }

	// RVA: 0x3508D04 Offset: 0x3504D04 VA: 0x3508D04
	public string get_Realm() { }

	// RVA: 0x3508D2C Offset: 0x3504D2C VA: 0x3508D2C
	public string get_Opaque() { }

	// RVA: 0x3508D58 Offset: 0x3504D58 VA: 0x3508D58
	public string get_Nonce() { }

	// RVA: 0x3508D84 Offset: 0x3504D84 VA: 0x3508D84
	public string get_Algorithm() { }

	// RVA: 0x3508DB0 Offset: 0x3504DB0 VA: 0x3508DB0
	public string get_QOP() { }

	// RVA: 0x3508DDC Offset: 0x3504DDC VA: 0x3508DDC
	public bool Parse() { }

	// RVA: 0x350913C Offset: 0x350513C VA: 0x350913C
	private void SkipWhitespace() { }

	// RVA: 0x35091BC Offset: 0x35051BC VA: 0x35091BC
	private string GetKey() { }

	// RVA: 0x3508F78 Offset: 0x3504F78 VA: 0x3508F78
	private bool GetKeywordAndValue(out string key, out string value) { }

	// RVA: 0x350924C Offset: 0x350524C VA: 0x350924C
	private static void .cctor() { }
}
