// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class MACTripleDES : KeyedHashAlgorithm // TypeDefIndex: 10126
{
	// Fields
	private ICryptoTransform m_encryptor; // 0x30
	private CryptoStream _cs; // 0x38
	private TailStream _ts; // 0x40
	private int m_bytesPerBlock; // 0x48
	private TripleDES des; // 0x50

	// Methods

	// RVA: 0x2EB0EDC Offset: 0x2EACEDC VA: 0x2EB0EDC
	public void .ctor() { }

	// RVA: 0x2EB1040 Offset: 0x2EAD040 VA: 0x2EB1040 Slot: 18
	public override void Initialize() { }

	// RVA: 0x2EB104C Offset: 0x2EAD04C VA: 0x2EB104C Slot: 16
	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }

	// RVA: 0x2EB1268 Offset: 0x2EAD268 VA: 0x2EB1268 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x2EB1444 Offset: 0x2EAD444 VA: 0x2EB1444 Slot: 12
	protected override void Dispose(bool disposing) { }
}
