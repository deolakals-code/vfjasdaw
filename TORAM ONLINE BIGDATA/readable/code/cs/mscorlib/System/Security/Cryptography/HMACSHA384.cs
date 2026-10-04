// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class HMACSHA384 : HMAC // TypeDefIndex: 10122
{
	// Fields
	private bool m_useLegacyBlockSize; // 0x61

	// Properties
	private int BlockSize { get; }

	// Methods

	// RVA: 0x2EB09AC Offset: 0x2EAC9AC VA: 0x2EB09AC
	public void .ctor() { }

	// RVA: 0x2EB09D0 Offset: 0x2EAC9D0 VA: 0x2EB09D0
	public void .ctor(byte[] key) { }

	// RVA: 0x2EB0C08 Offset: 0x2EACC08 VA: 0x2EB0C08
	private int get_BlockSize() { }
}
