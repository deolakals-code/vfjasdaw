// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class DESCryptoServiceProvider : DES // TypeDefIndex: 10112
{
	// Methods

	// RVA: 0x2EAE278 Offset: 0x2EAA278 VA: 0x2EAE278
	public void .ctor() { }

	// RVA: 0x2EAE530 Offset: 0x2EAA530 VA: 0x2EAE530 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x2EAE660 Offset: 0x2EAA660 VA: 0x2EAE660 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x2EAE790 Offset: 0x2EAA790 VA: 0x2EAE790 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x2EAE87C Offset: 0x2EAA87C VA: 0x2EAE87C Slot: 25
	public override void GenerateIV() { }
}
