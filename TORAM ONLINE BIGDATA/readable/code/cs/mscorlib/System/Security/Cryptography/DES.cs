// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class DES : SymmetricAlgorithm // TypeDefIndex: 10111
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x2EADB58 Offset: 0x2EA9B58 VA: 0x2EADB58
	protected void .ctor() { }

	// RVA: 0x2EADBF0 Offset: 0x2EA9BF0 VA: 0x2EADBF0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x2EAE004 Offset: 0x2EAA004 VA: 0x2EAE004 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x2EAE228 Offset: 0x2EAA228 VA: 0x2EAE228
	public static DES Create() { }

	// RVA: 0x2EADCD8 Offset: 0x2EA9CD8 VA: 0x2EADCD8
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x2EADDF8 Offset: 0x2EA9DF8 VA: 0x2EADDF8
	public static bool IsSemiWeakKey(byte[] rgbKey) { }

	// RVA: 0x2EAE338 Offset: 0x2EAA338 VA: 0x2EAE338
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x2EAE358 Offset: 0x2EAA358 VA: 0x2EAE358
	private static ulong QuadWordFromBigEndian(byte[] block) { }

	// RVA: 0x2EAE3F0 Offset: 0x2EAA3F0 VA: 0x2EAE3F0
	private static void .cctor() { }
}
