// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
internal class TripleDESTransform : SymmetricTransform // TypeDefIndex: 10170
{
	// Fields
	private DESTransform E1; // 0x58
	private DESTransform D2; // 0x60
	private DESTransform E3; // 0x68
	private DESTransform D1; // 0x70
	private DESTransform E2; // 0x78
	private DESTransform D3; // 0x80

	// Methods

	// RVA: 0x2EBD4C8 Offset: 0x2EB94C8 VA: 0x2EBD4C8
	public void .ctor(TripleDES algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x2EC6558 Offset: 0x2EC2558 VA: 0x2EC6558 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x2EC64B4 Offset: 0x2EC24B4 VA: 0x2EC64B4
	internal static byte[] GetStrongKey() { }
}
