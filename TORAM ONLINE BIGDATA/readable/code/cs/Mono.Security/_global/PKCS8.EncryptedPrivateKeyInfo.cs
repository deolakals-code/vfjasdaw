// Assembly: Mono.Security.dll
// Namespace: 
public class PKCS8.EncryptedPrivateKeyInfo // TypeDefIndex: 16922
{
	// Fields
	private string _algorithm; // 0x10
	private byte[] _salt; // 0x18
	private int _iterations; // 0x20
	private byte[] _data; // 0x28

	// Properties
	public string Algorithm { get; }
	public byte[] EncryptedData { get; }
	public byte[] Salt { get; }
	public int IterationCount { get; }

	// Methods

	// RVA: 0x2E5B8A4 Offset: 0x2E578A4 VA: 0x2E5B8A4
	public void .ctor() { }

	// RVA: 0x2E5B8AC Offset: 0x2E578AC VA: 0x2E5B8AC
	public void .ctor(byte[] data) { }

	// RVA: 0x2E5BBA4 Offset: 0x2E57BA4 VA: 0x2E5BBA4
	public string get_Algorithm() { }

	// RVA: 0x2E5BBAC Offset: 0x2E57BAC VA: 0x2E5BBAC
	public byte[] get_EncryptedData() { }

	// RVA: 0x2E5BC20 Offset: 0x2E57C20 VA: 0x2E5BC20
	public byte[] get_Salt() { }

	// RVA: 0x2E5BCE0 Offset: 0x2E57CE0 VA: 0x2E5BCE0
	public int get_IterationCount() { }

	// RVA: 0x2E5B8D8 Offset: 0x2E578D8 VA: 0x2E5B8D8
	private void Decode(byte[] data) { }
}
