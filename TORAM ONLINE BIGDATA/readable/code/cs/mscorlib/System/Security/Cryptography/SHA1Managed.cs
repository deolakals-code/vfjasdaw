// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA1Managed : SHA1 // TypeDefIndex: 10142
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA1; // 0x38
	private uint[] _expandedBuffer; // 0x40

	// Methods

	// RVA: 0x2EB0634 Offset: 0x2EAC634 VA: 0x2EB0634
	public void .ctor() { }

	// RVA: 0x2EB8910 Offset: 0x2EB4910 VA: 0x2EB8910 Slot: 18
	public override void Initialize() { }

	// RVA: 0x2EB8954 Offset: 0x2EB4954 VA: 0x2EB8954 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2EB8AD8 Offset: 0x2EB4AD8 VA: 0x2EB8AD8 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x2EB888C Offset: 0x2EB488C VA: 0x2EB888C
	private void InitializeState() { }

	// RVA: 0x2EB8958 Offset: 0x2EB4958 VA: 0x2EB8958
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x2EB8ADC Offset: 0x2EB4ADC VA: 0x2EB8ADC
	private byte[] _EndHash() { }

	// RVA: 0x2EB8C94 Offset: 0x2EB4C94 VA: 0x2EB8C94
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x2EB9084 Offset: 0x2EB5084 VA: 0x2EB9084
	private static void SHAExpand(uint* x) { }
}
