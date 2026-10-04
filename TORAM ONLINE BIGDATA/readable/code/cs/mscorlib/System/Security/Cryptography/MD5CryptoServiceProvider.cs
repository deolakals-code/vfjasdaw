// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class MD5CryptoServiceProvider : MD5 // TypeDefIndex: 10163
{
	// Fields
	private uint[] _H; // 0x28
	private uint[] buff; // 0x30
	private ulong count; // 0x38
	private byte[] _ProcessingBuffer; // 0x40
	private int _ProcessingBufferCount; // 0x48
	private static readonly uint[] K; // 0x0

	// Methods

	// RVA: 0x2EC0058 Offset: 0x2EBC058 VA: 0x2EC0058
	public void .ctor() { }

	// RVA: 0x2EC2724 Offset: 0x2EBE724 VA: 0x2EC2724 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2EC27C4 Offset: 0x2EBE7C4 VA: 0x2EC27C4 Slot: 12
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2EC2834 Offset: 0x2EBE834 VA: 0x2EC2834 Slot: 16
	protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2EC35AC Offset: 0x2EBF5AC VA: 0x2EC35AC Slot: 17
	protected override byte[] HashFinal() { }

	// RVA: 0x2EC3830 Offset: 0x2EBF830 VA: 0x2EC3830 Slot: 18
	public override void Initialize() { }

	// RVA: 0x2EC2934 Offset: 0x2EBE934 VA: 0x2EC2934
	private void ProcessBlock(byte[] inputBuffer, int inputOffset) { }

	// RVA: 0x2EC3684 Offset: 0x2EBF684 VA: 0x2EC3684
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x2EC38A4 Offset: 0x2EBF8A4 VA: 0x2EC38A4
	internal void AddLength(ulong length, byte[] buffer, int position) { }

	// RVA: 0x2EC3994 Offset: 0x2EBF994 VA: 0x2EC3994
	private static void .cctor() { }
}
