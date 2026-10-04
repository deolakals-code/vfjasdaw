// Assembly: Mono.Security.dll
// Namespace: 
public class PKCS8.PrivateKeyInfo // TypeDefIndex: 16921
{
	// Fields
	private int _version; // 0x10
	private string _algorithm; // 0x18
	private byte[] _key; // 0x20
	private ArrayList _list; // 0x28

	// Properties
	public string Algorithm { get; }
	public byte[] PrivateKey { get; }

	// Methods

	// RVA: 0x2E5AAEC Offset: 0x2E56AEC VA: 0x2E5AAEC
	public void .ctor() { }

	// RVA: 0x2E5AB5C Offset: 0x2E56B5C VA: 0x2E5AB5C
	public void .ctor(byte[] data) { }

	// RVA: 0x2E5ADF4 Offset: 0x2E56DF4 VA: 0x2E5ADF4
	public string get_Algorithm() { }

	// RVA: 0x2E5ADFC Offset: 0x2E56DFC VA: 0x2E5ADFC
	public byte[] get_PrivateKey() { }

	// RVA: 0x2E5AB84 Offset: 0x2E56B84 VA: 0x2E5AB84
	private void Decode(byte[] data) { }

	// RVA: 0x2E5AE70 Offset: 0x2E56E70 VA: 0x2E5AE70
	private static byte[] RemoveLeadingZero(byte[] bigInt) { }

	// RVA: 0x2E5AF0C Offset: 0x2E56F0C VA: 0x2E5AF0C
	private static byte[] Normalize(byte[] bigInt, int length) { }

	// RVA: 0x2E5AFAC Offset: 0x2E56FAC VA: 0x2E5AFAC
	public static RSA DecodeRSA(byte[] keypair) { }

	// RVA: 0x2E5B408 Offset: 0x2E57408 VA: 0x2E5B408
	public static byte[] Encode(RSA rsa) { }

	// RVA: 0x2E5B600 Offset: 0x2E57600 VA: 0x2E5B600
	public static DSA DecodeDSA(byte[] privateKey, DSAParameters dsaParameters) { }

	// RVA: 0x2E5B734 Offset: 0x2E57734 VA: 0x2E5B734
	public static byte[] Encode(DSA dsa) { }

	// RVA: 0x2E5B780 Offset: 0x2E57780 VA: 0x2E5B780
	public static byte[] Encode(AsymmetricAlgorithm aa) { }
}
