// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
public sealed class X509SubjectKeyIdentifierExtension : X509Extension // TypeDefIndex: 14158
{
	// Fields
	internal const string oid = "2.5.29.14";
	internal const string friendlyName = "Subject Key Identifier";
	private byte[] _subjectKeyIdentifier; // 0x28
	private string _ski; // 0x30
	private AsnDecodeStatus _status; // 0x38

	// Properties
	public string SubjectKeyIdentifier { get; }

	// Methods

	// RVA: 0x349132C Offset: 0x348D32C VA: 0x349132C
	public void .ctor() { }

	// RVA: 0x348D01C Offset: 0x348901C VA: 0x348D01C
	public void .ctor(AsnEncodedData encodedSubjectKeyIdentifier, bool critical) { }

	// RVA: 0x349C5A0 Offset: 0x34985A0 VA: 0x349C5A0
	public void .ctor(byte[] subjectKeyIdentifier, bool critical) { }

	// RVA: 0x349C7EC Offset: 0x34987EC VA: 0x349C7EC
	public void .ctor(string subjectKeyIdentifier, bool critical) { }

	// RVA: 0x349CA48 Offset: 0x3498A48 VA: 0x349CA48
	public void .ctor(PublicKey key, bool critical) { }

	// RVA: 0x3491D9C Offset: 0x348DD9C VA: 0x3491D9C
	public void .ctor(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical) { }

	// RVA: 0x349216C Offset: 0x348E16C VA: 0x349216C
	public string get_SubjectKeyIdentifier() { }

	// RVA: 0x349CA54 Offset: 0x3498A54 VA: 0x349CA54 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x349CC20 Offset: 0x3498C20 VA: 0x349CC20
	internal static byte FromHexChar(char c) { }

	// RVA: 0x349CC64 Offset: 0x3498C64 VA: 0x349CC64
	internal static byte FromHexChars(char c1, char c2) { }

	// RVA: 0x349C954 Offset: 0x3498954 VA: 0x349C954
	internal static byte[] FromHex(string hex) { }

	// RVA: 0x349C428 Offset: 0x3498428 VA: 0x349C428
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x349C778 Offset: 0x3498778 VA: 0x349C778
	internal byte[] Encode() { }

	// RVA: 0x349CD00 Offset: 0x3498D00 VA: 0x349CD00 Slot: 6
	internal override string ToString(bool multiLine) { }
}
