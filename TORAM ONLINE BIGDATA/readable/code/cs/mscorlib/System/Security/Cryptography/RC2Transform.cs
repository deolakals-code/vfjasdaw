// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
internal class RC2Transform : SymmetricTransform // TypeDefIndex: 10164
{
	// Fields
	private ushort R0; // 0x58
	private ushort R1; // 0x5A
	private ushort R2; // 0x5C
	private ushort R3; // 0x5E
	private ushort[] K; // 0x60
	private int j; // 0x68
	private static readonly byte[] pitable; // 0x0

	// Methods

	// RVA: 0x2EC3A34 Offset: 0x2EBFA34 VA: 0x2EC3A34
	public void .ctor(RC2 rc2Algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x2EC3F9C Offset: 0x2EBFF9C VA: 0x2EC3F9C Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x2EC490C Offset: 0x2EC090C VA: 0x2EC490C
	private static void .cctor() { }
}
