// Assembly: System.dll
// Namespace: System.Security.Cryptography.X509Certificates
public sealed class PublicKey // TypeDefIndex: 14131
{
	// Fields
	private AsnEncodedData _keyValue; // 0x10
	private AsnEncodedData _params; // 0x18
	private Oid _oid; // 0x20
	private static byte[] Empty; // 0x0

	// Properties
	public AsnEncodedData EncodedKeyValue { get; }
	public AsnEncodedData EncodedParameters { get; }
	public AsymmetricAlgorithm Key { get; }
	public Oid Oid { get; }

	// Methods

	// RVA: 0x348D104 Offset: 0x3489104 VA: 0x348D104
	public void .ctor(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue) { }

	// RVA: 0x348D27C Offset: 0x348927C VA: 0x348D27C
	public AsnEncodedData get_EncodedKeyValue() { }

	// RVA: 0x348D284 Offset: 0x3489284 VA: 0x348D284
	public AsnEncodedData get_EncodedParameters() { }

	// RVA: 0x348D28C Offset: 0x348928C VA: 0x348D28C
	public AsymmetricAlgorithm get_Key() { }

	// RVA: 0x348DCB4 Offset: 0x3489CB4 VA: 0x348DCB4
	public Oid get_Oid() { }

	// RVA: 0x348DCBC Offset: 0x3489CBC VA: 0x348DCBC
	private static byte[] GetUnsignedBigInteger(byte[] integer) { }

	// RVA: 0x348D7E8 Offset: 0x34897E8 VA: 0x348D7E8
	internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters) { }

	// RVA: 0x348D430 Offset: 0x3489430 VA: 0x348D430
	internal static RSA DecodeRSA(byte[] rawPublicKey) { }

	// RVA: 0x348DD50 Offset: 0x3489D50 VA: 0x348DD50
	private static void .cctor() { }
}
