// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class RC2 : SymmetricAlgorithm // TypeDefIndex: 10130
{
	// Fields
	protected int EffectiveKeySizeValue; // 0x44
	private static KeySizes[] s_legalBlockSizes; // 0x0
	private static KeySizes[] s_legalKeySizes; // 0x8

	// Properties
	public virtual int EffectiveKeySize { get; }
	public override int KeySize { get; set; }

	// Methods

	// RVA: 0x2EB1AF4 Offset: 0x2EADAF4 VA: 0x2EB1AF4
	protected void .ctor() { }

	// RVA: 0x2EB1B8C Offset: 0x2EADB8C VA: 0x2EB1B8C Slot: 26
	public virtual int get_EffectiveKeySize() { }

	// RVA: 0x2EB1BA8 Offset: 0x2EADBA8 VA: 0x2EB1BA8 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x2EB1BB0 Offset: 0x2EADBB0 VA: 0x2EB1BB0 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x2EB1C24 Offset: 0x2EADC24 VA: 0x2EB1C24
	private static void .cctor() { }
}
