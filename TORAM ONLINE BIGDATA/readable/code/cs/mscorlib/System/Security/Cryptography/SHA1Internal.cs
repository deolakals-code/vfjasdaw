// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
internal class SHA1Internal // TypeDefIndex: 10168
{
	// Fields
	private uint[] _H; // 0x10
	private ulong count; // 0x18
	private byte[] _ProcessingBuffer; // 0x20
	private int _ProcessingBufferCount; // 0x28
	private uint[] buff; // 0x30

	// Methods

	// RVA: 0x2EC50A8 Offset: 0x2EC10A8 VA: 0x2EC50A8
	public void .ctor() { }

	// RVA: 0x2EC51F0 Offset: 0x2EC11F0 VA: 0x2EC51F0
	public void HashCore(byte[] rgb, int ibStart, int cbSize) { }

	// RVA: 0x2EC5804 Offset: 0x2EC1804 VA: 0x2EC5804
	public byte[] HashFinal() { }

	// RVA: 0x2EC5168 Offset: 0x2EC1168 VA: 0x2EC5168
	public void Initialize() { }

	// RVA: 0x2EC52F0 Offset: 0x2EC12F0 VA: 0x2EC52F0
	private void ProcessBlock(byte[] inputBuffer, uint inputOffset) { }

	// RVA: 0x2EC5A98 Offset: 0x2EC1A98 VA: 0x2EC5A98
	private static void InitialiseBuff(uint[] buff, byte[] input, uint inputOffset) { }

	// RVA: 0x2EC6138 Offset: 0x2EC2138 VA: 0x2EC6138
	private static void FillBuff(uint[] buff) { }

	// RVA: 0x2EC58DC Offset: 0x2EC18DC VA: 0x2EC58DC
	private void ProcessFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x2EC62BC Offset: 0x2EC22BC VA: 0x2EC62BC
	internal void AddLength(ulong length, byte[] buffer, int position) { }
}
