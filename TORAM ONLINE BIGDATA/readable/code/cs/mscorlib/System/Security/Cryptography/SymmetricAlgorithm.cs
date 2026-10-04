// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 10156
{
	// Fields
	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	// Properties
	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x2EBBFD0 Offset: 0x2EB7FD0 VA: 0x2EBBFD0
	protected void .ctor() { }

	// RVA: 0x2EBBFF4 Offset: 0x2EB7FF4 VA: 0x2EBBFF4 Slot: 4
	public void Dispose() { }

	// RVA: 0x2EBC060 Offset: 0x2EB8060 VA: 0x2EBC060
	public void Clear() { }

	// RVA: 0x2EBC0F4 Offset: 0x2EB80F4 VA: 0x2EBC0F4 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2EBC16C Offset: 0x2EB816C VA: 0x2EBC16C Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x2EBC174 Offset: 0x2EB8174 VA: 0x2EBC174 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x2EBC26C Offset: 0x2EB826C VA: 0x2EBC26C Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x2EBC274 Offset: 0x2EB8274 VA: 0x2EBC274 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x2EBC308 Offset: 0x2EB8308 VA: 0x2EBC308 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x2EBC468 Offset: 0x2EB8468 VA: 0x2EBC468 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x2EBC4FC Offset: 0x2EB84FC VA: 0x2EBC4FC Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x2EBC714 Offset: 0x2EB8714 VA: 0x2EBC714 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x2EBC78C Offset: 0x2EB878C VA: 0x2EBC78C Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x2EBC794 Offset: 0x2EB8794 VA: 0x2EBC794 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x2EBC818 Offset: 0x2EB8818 VA: 0x2EBC818 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x2EBC820 Offset: 0x2EB8820 VA: 0x2EBC820 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x2EBC894 Offset: 0x2EB8894 VA: 0x2EBC894 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x2EBC89C Offset: 0x2EB889C VA: 0x2EBC89C Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x2EBC678 Offset: 0x2EB8678 VA: 0x2EBC678
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x2EBC910 Offset: 0x2EB8910 VA: 0x2EBC910
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x2EBCA08 Offset: 0x2EB8A08 VA: 0x2EBCA08 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: 0x2EBCA58 Offset: 0x2EB8A58 VA: 0x2EBCA58 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV();
}
