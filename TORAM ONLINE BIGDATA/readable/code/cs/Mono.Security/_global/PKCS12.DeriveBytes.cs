// Assembly: Mono.Security.dll
// Namespace: 
public class PKCS12.DeriveBytes // TypeDefIndex: 16874
{
	// Fields
	private static byte[] keyDiversifier; // 0x0
	private static byte[] ivDiversifier; // 0x8
	private static byte[] macDiversifier; // 0x10
	private string _hashName; // 0x10
	private int _iterations; // 0x18
	private byte[] _password; // 0x20
	private byte[] _salt; // 0x28

	// Properties
	public string HashName { set; }
	public int IterationCount { set; }
	public byte[] Password { set; }
	public byte[] Salt { set; }

	// Methods

	// RVA: 0x2E476B0 Offset: 0x2E436B0 VA: 0x2E476B0
	public void .ctor() { }

	// RVA: 0x2E4C110 Offset: 0x2E48110 VA: 0x2E4C110
	public void set_HashName(string value) { }

	// RVA: 0x2E4C118 Offset: 0x2E48118 VA: 0x2E4C118
	public void set_IterationCount(int value) { }

	// RVA: 0x2E476B8 Offset: 0x2E436B8 VA: 0x2E476B8
	public void set_Password(byte[] value) { }

	// RVA: 0x2E4777C Offset: 0x2E4377C VA: 0x2E4777C
	public void set_Salt(byte[] value) { }

	// RVA: 0x2E4C120 Offset: 0x2E48120 VA: 0x2E4C120
	private void Adjust(byte[] a, int aOff, byte[] b) { }

	// RVA: 0x2E4C1E0 Offset: 0x2E481E0 VA: 0x2E4C1E0
	private byte[] Derive(byte[] diversifier, int n) { }

	// RVA: 0x2E47838 Offset: 0x2E43838 VA: 0x2E47838
	public byte[] DeriveKey(int size) { }

	// RVA: 0x2E478A8 Offset: 0x2E438A8 VA: 0x2E478A8
	public byte[] DeriveIV(int size) { }

	// RVA: 0x2E49178 Offset: 0x2E45178 VA: 0x2E49178
	public byte[] DeriveMAC(int size) { }

	// RVA: 0x2E4C610 Offset: 0x2E48610 VA: 0x2E4C610
	private static void .cctor() { }
}
