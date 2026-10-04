// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
[MonoTODO("Some X500DistinguishedNameFlags options aren't supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
public sealed class X500DistinguishedName : AsnEncodedData // TypeDefIndex: 14132
{
	// Fields
	private string name; // 0x20
	private byte[] canonEncoding; // 0x28

	// Properties
	public string Name { get; }

	// Methods

	// RVA: 0x348DDC4 Offset: 0x3489DC4 VA: 0x348DDC4
	public void .ctor(byte[] encodedDistinguishedName) { }

	// RVA: 0x348DFBC Offset: 0x3489FBC VA: 0x348DFBC
	public string get_Name() { }

	// RVA: 0x348DFC4 Offset: 0x3489FC4 VA: 0x348DFC4
	public string Decode(X500DistinguishedNameFlags flag) { }

	// RVA: 0x348E18C Offset: 0x348A18C VA: 0x348E18C Slot: 5
	public override string Format(bool multiLine) { }

	// RVA: 0x348E114 Offset: 0x348A114 VA: 0x348E114
	private static string GetSeparator(X500DistinguishedNameFlags flag) { }

	// RVA: 0x348DECC Offset: 0x3489ECC VA: 0x348DECC
	private void DecodeRawData() { }

	// RVA: 0x348E1E8 Offset: 0x348A1E8 VA: 0x348E1E8
	private static string Canonize(string s) { }

	// RVA: 0x348E3C4 Offset: 0x348A3C4 VA: 0x348E3C4
	internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2) { }
}
