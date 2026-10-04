// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public abstract class HMAC : KeyedHashAlgorithm // TypeDefIndex: 10117
{
	// Fields
	private int blockSizeValue; // 0x30
	internal string m_hashName; // 0x38
	internal HashAlgorithm m_hash1; // 0x40
	internal HashAlgorithm m_hash2; // 0x48
	private byte[] m_inner; // 0x50
	private byte[] m_outer; // 0x58
	private bool m_hashing; // 0x60

	// Properties
	protected int BlockSizeValue { get; set; }
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0x2EAFA24 Offset: 0x2EABA24 VA: 0x2EAFA24
	protected int get_BlockSizeValue() { }

	// RVA: 0x2EAFA2C Offset: 0x2EABA2C VA: 0x2EAFA2C
	protected void set_BlockSizeValue(int value) { }

	// RVA: 0x2EAFA34 Offset: 0x2EABA34 VA: 0x2EAFA34
	private void UpdateIOPadBuffers() { }

	// RVA: 0x2EAFBC0 Offset: 0x2EABBC0 VA: 0x2EAFBC0
	internal void InitializeKey(byte[] key) { }

	// RVA: 0x2EAFCE0 Offset: 0x2EABCE0 VA: 0x2EAFCE0 Slot: 19
	public override byte[] get_Key() { }

	// RVA: 0x2EAFD58 Offset: 0x2EABD58 VA: 0x2EAFD58 Slot: 20
	public override void set_Key(byte[] value) { }

	// RVA: 0x2EAFDC4 Offset: 0x2EABDC4 VA: 0x2EAFDC4
	public static HMAC Create() { }

	// RVA: 0x2EAFE54 Offset: 0x2EABE54 VA: 0x2EAFE54 Slot: 18
	public override void Initialize() { }

	// RVA: 0x2EAFE9C Offset: 0x2EABE9C VA: 0x2EAFE9C Slot: 16
	protected override void HashCore(byte[] rgb, int ib, int cb) { }

	// RVA: 0x2EAFF24 Offset: 0x2EABF24 VA: 0x2EAFF24 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x2EB0068 Offset: 0x2EAC068 VA: 0x2EB0068 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2EB0208 Offset: 0x2EAC208 VA: 0x2EB0208
	protected void .ctor() { }
}
