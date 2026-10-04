// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
internal class DESTransform : SymmetricTransform // TypeDefIndex: 10161
{
	// Fields
	internal static readonly int KEY_BIT_SIZE; // 0x0
	internal static readonly int KEY_BYTE_SIZE; // 0x4
	internal static readonly int BLOCK_BIT_SIZE; // 0x8
	internal static readonly int BLOCK_BYTE_SIZE; // 0xC
	private byte[] keySchedule; // 0x58
	private byte[] byteBuff; // 0x60
	private uint[] dwordBuff; // 0x68
	private static readonly uint[] spBoxes; // 0x10
	private static readonly byte[] PC1; // 0x18
	private static readonly byte[] leftRotTotal; // 0x20
	private static readonly byte[] PC2; // 0x28
	internal static readonly uint[] ipTab; // 0x30
	internal static readonly uint[] fpTab; // 0x38

	// Methods

	// RVA: 0x2EC0F54 Offset: 0x2EBCF54 VA: 0x2EC0F54
	internal void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x2EC15F0 Offset: 0x2EBD5F0 VA: 0x2EC15F0
	private uint CipherFunct(uint r, int n) { }

	// RVA: 0x2EC1820 Offset: 0x2EBD820 VA: 0x2EC1820
	internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap) { }

	// RVA: 0x2EC1AF8 Offset: 0x2EBDAF8 VA: 0x2EC1AF8
	private static void BSwap(byte[] byteBuff) { }

	// RVA: 0x2EC1270 Offset: 0x2EBD270 VA: 0x2EC1270
	internal void SetKey(byte[] key) { }

	// RVA: 0x2EC1B70 Offset: 0x2EBDB70 VA: 0x2EC1B70
	public void ProcessBlock(byte[] input, byte[] output) { }

	// RVA: 0x2EC1EF8 Offset: 0x2EBDEF8 VA: 0x2EC1EF8 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x2EC1198 Offset: 0x2EBD198 VA: 0x2EC1198
	internal static byte[] GetStrongKey() { }

	// RVA: 0x2EC1F9C Offset: 0x2EBDF9C VA: 0x2EC1F9C
	private static void .cctor() { }
}
