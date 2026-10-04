// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA512Managed : SHA512 // TypeDefIndex: 10148
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA512; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x2EBAC10 Offset: 0x2EB6C10 VA: 0x2EBAC10
	public void .ctor() { }

	// RVA: 0x2EBAE04 Offset: 0x2EB6E04 VA: 0x2EBAE04 Slot: 18
	public override void Initialize() { }

	// RVA: 0x2EBAE48 Offset: 0x2EB6E48 VA: 0x2EBAE48 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2EBB014 Offset: 0x2EB7014 VA: 0x2EBB014 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x2EBAD04 Offset: 0x2EB6D04 VA: 0x2EBAD04
	private void InitializeState() { }

	// RVA: 0x2EBAE4C Offset: 0x2EB6E4C VA: 0x2EBAE4C
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x2EBB018 Offset: 0x2EB7018 VA: 0x2EBB018
	private byte[] _EndHash() { }

	// RVA: 0x2EBB1CC Offset: 0x2EB71CC VA: 0x2EBB1CC
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x2EBBAFC Offset: 0x2EB7AFC VA: 0x2EBBAFC
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x2EBBA7C Offset: 0x2EB7A7C VA: 0x2EBBA7C
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x2EBBAE8 Offset: 0x2EB7AE8 VA: 0x2EBBAE8
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x2EBBA8C Offset: 0x2EB7A8C VA: 0x2EBBA8C
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x2EBBA20 Offset: 0x2EB7A20 VA: 0x2EBBA20
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x2EBBB04 Offset: 0x2EB7B04 VA: 0x2EBBB04
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x2EBBB60 Offset: 0x2EB7B60 VA: 0x2EBBB60
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x2EBB978 Offset: 0x2EB7978 VA: 0x2EBB978
	private static void SHA512Expand(ulong* x) { }

	// RVA: 0x2EBBBBC Offset: 0x2EB7BBC VA: 0x2EBBBBC
	private static void .cctor() { }
}
