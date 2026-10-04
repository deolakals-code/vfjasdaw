// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RijndaelManaged : Rijndael // TypeDefIndex: 10133
{
	// Methods

	// RVA: 0x2EB2414 Offset: 0x2EAE414 VA: 0x2EB2414
	public void .ctor() { }

	// RVA: 0x2EB24EC Offset: 0x2EAE4EC VA: 0x2EB24EC Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x2EB25F4 Offset: 0x2EAE5F4 VA: 0x2EB25F4 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x2EB2608 Offset: 0x2EAE608 VA: 0x2EB2608 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x2EB2640 Offset: 0x2EAE640 VA: 0x2EB2640 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x2EB2500 Offset: 0x2EAE500 VA: 0x2EB2500
	private ICryptoTransform NewEncryptor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int feedbackSize, RijndaelManagedTransformMode encryptMode) { }
}
