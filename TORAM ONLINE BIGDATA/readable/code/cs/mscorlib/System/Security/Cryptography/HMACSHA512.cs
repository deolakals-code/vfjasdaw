// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACSHA512 : HMAC // TypeDefIndex: 10123
{
	// Fields
	private bool m_useLegacyBlockSize; // 0x61

	// Properties
	private int BlockSize { get; }

	// Methods

	// RVA: 0x2EB0C20 Offset: 0x2EACC20 VA: 0x2EB0C20
	public void .ctor() { }

	// RVA: 0x2EB0C44 Offset: 0x2EACC44 VA: 0x2EB0C44
	public void .ctor(byte[] key) { }

	// RVA: 0x2EB0D44 Offset: 0x2EACD44 VA: 0x2EB0D44
	private int get_BlockSize() { }
}
