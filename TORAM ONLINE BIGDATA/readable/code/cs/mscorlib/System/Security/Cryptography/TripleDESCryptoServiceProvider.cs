// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class TripleDESCryptoServiceProvider : TripleDES // TypeDefIndex: 10158
{
	// Methods

	// RVA: 0x2EBCF94 Offset: 0x2EB8F94 VA: 0x2EBCF94
	public void .ctor() { }

	// RVA: 0x2EBD3C0 Offset: 0x2EB93C0 VA: 0x2EBD3C0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x2EBD7F0 Offset: 0x2EB97F0 VA: 0x2EBD7F0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x2EBD8F8 Offset: 0x2EB98F8 VA: 0x2EBD8F8 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x2EBDA74 Offset: 0x2EB9A74 VA: 0x2EBDA74 Slot: 25
	public override void GenerateIV() { }
}
