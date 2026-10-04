// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA256Managed : SHA256 // TypeDefIndex: 10144
{
	// Fields
	private byte[] _buffer; // 0x28
	private long _count; // 0x30
	private uint[] _stateSHA256; // 0x38
	private uint[] _W; // 0x40
	private static readonly uint[] _K; // 0x0

	// Methods

	// RVA: 0x2EB086C Offset: 0x2EAC86C VA: 0x2EB086C
	public void .ctor() { }

	// RVA: 0x2EB91F0 Offset: 0x2EB51F0 VA: 0x2EB91F0 Slot: 18
	public override void Initialize() { }

	// RVA: 0x2EB9234 Offset: 0x2EB5234 VA: 0x2EB9234 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2EB9400 Offset: 0x2EB5400 VA: 0x2EB9400 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x2EB9130 Offset: 0x2EB5130 VA: 0x2EB9130
	private void InitializeState() { }

	// RVA: 0x2EB9238 Offset: 0x2EB5238 VA: 0x2EB9238
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x2EB9404 Offset: 0x2EB5404 VA: 0x2EB9404
	private byte[] _EndHash() { }

	// RVA: 0x2EB95BC Offset: 0x2EB55BC VA: 0x2EB95BC
	private static void SHATransform(uint* expandedBuffer, uint* state, byte* block) { }

	// RVA: 0x2EB9CB0 Offset: 0x2EB5CB0 VA: 0x2EB9CB0
	private static uint RotateRight(uint x, int n) { }

	// RVA: 0x2EB9C30 Offset: 0x2EB5C30 VA: 0x2EB9C30
	private static uint Ch(uint x, uint y, uint z) { }

	// RVA: 0x2EB9C9C Offset: 0x2EB5C9C VA: 0x2EB9C9C
	private static uint Maj(uint x, uint y, uint z) { }

	// RVA: 0x2EB9CB8 Offset: 0x2EB5CB8 VA: 0x2EB9CB8
	private static uint sigma_0(uint x) { }

	// RVA: 0x2EB9D14 Offset: 0x2EB5D14 VA: 0x2EB9D14
	private static uint sigma_1(uint x) { }

	// RVA: 0x2EB9C40 Offset: 0x2EB5C40 VA: 0x2EB9C40
	private static uint Sigma_0(uint x) { }

	// RVA: 0x2EB9BD4 Offset: 0x2EB5BD4 VA: 0x2EB9BD4
	private static uint Sigma_1(uint x) { }

	// RVA: 0x2EB9B2C Offset: 0x2EB5B2C VA: 0x2EB9B2C
	private static void SHA256Expand(uint* x) { }

	// RVA: 0x2EB9D70 Offset: 0x2EB5D70 VA: 0x2EB9D70
	private static void .cctor() { }
}
