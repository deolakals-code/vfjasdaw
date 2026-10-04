// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class RIPEMD160Managed : RIPEMD160 // TypeDefIndex: 10137
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateMD160; // 0x38
	private uint[] _blockDWords; // 0x40

	// Methods

	// RVA: 0x2EB0418 Offset: 0x2EAC418 VA: 0x2EB0418
	public void .ctor() { }

	// RVA: 0x2EB5818 Offset: 0x2EB1818 VA: 0x2EB5818 Slot: 18
	public override void Initialize() { }

	// RVA: 0x2EB585C Offset: 0x2EB185C VA: 0x2EB585C Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2EB59E0 Offset: 0x2EB19E0 VA: 0x2EB59E0 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x2EB5794 Offset: 0x2EB1794 VA: 0x2EB5794
	private void InitializeState() { }

	// RVA: 0x2EB5860 Offset: 0x2EB1860 VA: 0x2EB5860
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x2EB59E4 Offset: 0x2EB19E4 VA: 0x2EB59E4
	private byte[] _EndHash() { }

	// RVA: 0x2EB5B94 Offset: 0x2EB1B94 VA: 0x2EB5B94
	private static void MDTransform(uint* blockDWords, uint* state, byte* block) { }

	// RVA: 0x2EB7260 Offset: 0x2EB3260 VA: 0x2EB7260
	private static uint F(uint x, uint y, uint z) { }

	// RVA: 0x2EB726C Offset: 0x2EB326C VA: 0x2EB726C
	private static uint G(uint x, uint y, uint z) { }

	// RVA: 0x2EB727C Offset: 0x2EB327C VA: 0x2EB727C
	private static uint H(uint x, uint y, uint z) { }

	// RVA: 0x2EB7288 Offset: 0x2EB3288 VA: 0x2EB7288
	private static uint I(uint x, uint y, uint z) { }

	// RVA: 0x2EB7298 Offset: 0x2EB3298 VA: 0x2EB7298
	private static uint J(uint x, uint y, uint z) { }
}
