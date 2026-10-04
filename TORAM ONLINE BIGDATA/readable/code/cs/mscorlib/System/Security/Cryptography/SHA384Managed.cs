// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public class SHA384Managed : SHA384 // TypeDefIndex: 10146
{
	// Fields
	private byte[] _buffer; // 0x28
	private ulong _count; // 0x30
	private ulong[] _stateSHA384; // 0x38
	private ulong[] _W; // 0x40
	private static readonly ulong[] _K; // 0x0

	// Methods

	// RVA: 0x2EB0AC8 Offset: 0x2EACAC8 VA: 0x2EB0AC8
	public void .ctor() { }

	// RVA: 0x2EB9F80 Offset: 0x2EB5F80 VA: 0x2EB9F80 Slot: 18
	public override void Initialize() { }

	// RVA: 0x2EB9FC4 Offset: 0x2EB5FC4 VA: 0x2EB9FC4 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2EBA190 Offset: 0x2EB6190 VA: 0x2EBA190 Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x2EB9E80 Offset: 0x2EB5E80 VA: 0x2EB9E80
	private void InitializeState() { }

	// RVA: 0x2EB9FC8 Offset: 0x2EB5FC8 VA: 0x2EB9FC8
	private void _HashData(byte[] partIn, int ibStart, int cbSize) { }

	// RVA: 0x2EBA194 Offset: 0x2EB6194 VA: 0x2EBA194
	private byte[] _EndHash() { }

	// RVA: 0x2EBA34C Offset: 0x2EB634C VA: 0x2EBA34C
	private static void SHATransform(ulong* expandedBuffer, ulong* state, byte* block) { }

	// RVA: 0x2EBAA40 Offset: 0x2EB6A40 VA: 0x2EBAA40
	private static ulong RotateRight(ulong x, int n) { }

	// RVA: 0x2EBA9C0 Offset: 0x2EB69C0 VA: 0x2EBA9C0
	private static ulong Ch(ulong x, ulong y, ulong z) { }

	// RVA: 0x2EBAA2C Offset: 0x2EB6A2C VA: 0x2EBAA2C
	private static ulong Maj(ulong x, ulong y, ulong z) { }

	// RVA: 0x2EBA9D0 Offset: 0x2EB69D0 VA: 0x2EBA9D0
	private static ulong Sigma_0(ulong x) { }

	// RVA: 0x2EBA964 Offset: 0x2EB6964 VA: 0x2EBA964
	private static ulong Sigma_1(ulong x) { }

	// RVA: 0x2EBAA48 Offset: 0x2EB6A48 VA: 0x2EBAA48
	private static ulong sigma_0(ulong x) { }

	// RVA: 0x2EBAAA4 Offset: 0x2EB6AA4 VA: 0x2EBAAA4
	private static ulong sigma_1(ulong x) { }

	// RVA: 0x2EBA8BC Offset: 0x2EB68BC VA: 0x2EBA8BC
	private static void SHA384Expand(ulong* x) { }

	// RVA: 0x2EBAB00 Offset: 0x2EB6B00 VA: 0x2EBAB00
	private static void .cctor() { }
}
