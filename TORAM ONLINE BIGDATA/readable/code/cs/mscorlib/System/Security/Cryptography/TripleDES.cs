// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class TripleDES : SymmetricAlgorithm // TypeDefIndex: 10157
{
	// Fields
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x2EBCAA8 Offset: 0x2EB8AA8 VA: 0x2EBCAA8
	protected void .ctor() { }

	// RVA: 0x2EBCB4C Offset: 0x2EB8B4C VA: 0x2EBCB4C Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x2EBCD48 Offset: 0x2EB8D48 VA: 0x2EBCD48 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x2EBCF44 Offset: 0x2EB8F44 VA: 0x2EBCF44
	public static TripleDES Create() { }

	// RVA: 0x2EBCC14 Offset: 0x2EB8C14 VA: 0x2EBCC14
	public static bool IsWeakKey(byte[] rgbKey) { }

	// RVA: 0x2EBD0E0 Offset: 0x2EB90E0 VA: 0x2EBD0E0
	private static bool EqualBytes(byte[] rgbKey, int start1, int start2, int count) { }

	// RVA: 0x2EBCFF4 Offset: 0x2EB8FF4 VA: 0x2EBCFF4
	private static bool IsLegalKeySize(byte[] rgbKey) { }

	// RVA: 0x2EBD278 Offset: 0x2EB9278 VA: 0x2EBD278
	private static void .cctor() { }
}
