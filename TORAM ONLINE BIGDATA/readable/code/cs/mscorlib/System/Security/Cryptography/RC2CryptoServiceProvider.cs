// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RC2CryptoServiceProvider : RC2 // TypeDefIndex: 10131
{
	// Fields
	private bool m_use40bitSalt; // 0x48
	private static KeySizes[] s_legalKeySizes; // 0x0

	// Properties
	public override int EffectiveKeySize { get; }

	// Methods

	// RVA: 0x2EB1D64 Offset: 0x2EADD64 VA: 0x2EB1D64
	public void .ctor() { }

	// RVA: 0x2EB1ED0 Offset: 0x2EADED0 VA: 0x2EB1ED0 Slot: 26
	public override int get_EffectiveKeySize() { }

	// RVA: 0x2EB1ED8 Offset: 0x2EADED8 VA: 0x2EB1ED8 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x2EB1FA0 Offset: 0x2EADFA0 VA: 0x2EB1FA0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV) { }

	// RVA: 0x2EB2068 Offset: 0x2EAE068 VA: 0x2EB2068 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x2EB20F0 Offset: 0x2EAE0F0 VA: 0x2EB20F0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x2EB2168 Offset: 0x2EAE168 VA: 0x2EB2168
	private static void .cctor() { }
}
