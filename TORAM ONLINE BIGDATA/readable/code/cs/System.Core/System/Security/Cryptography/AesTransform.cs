// Assembly: System.Core.dll
// Namespace: System.Security.Cryptography
internal class AesTransform : SymmetricTransform // TypeDefIndex: 15180
{
	// Fields
	private uint[] expandedKey; // 0x58
	private int Nk; // 0x60
	private int Nr; // 0x64
	private static readonly uint[] Rcon; // 0x0
	private static readonly byte[] SBox; // 0x8
	private static readonly byte[] iSBox; // 0x10
	private static readonly uint[] T0; // 0x18
	private static readonly uint[] T1; // 0x20
	private static readonly uint[] T2; // 0x28
	private static readonly uint[] T3; // 0x30
	private static readonly uint[] iT0; // 0x38
	private static readonly uint[] iT1; // 0x40
	private static readonly uint[] iT2; // 0x48
	private static readonly uint[] iT3; // 0x50

	// Methods

	// RVA: 0x3110640 Offset: 0x310C640 VA: 0x3110640
	public void .ctor(Aes algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x3111048 Offset: 0x310D048 VA: 0x3111048 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x3110F84 Offset: 0x310CF84 VA: 0x3110F84
	private uint SubByte(uint a) { }

	// RVA: 0x311105C Offset: 0x310D05C VA: 0x311105C
	private void Encrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x3112E88 Offset: 0x310EE88 VA: 0x3112E88
	private void Decrypt128(byte[] indata, byte[] outdata, uint[] ekey) { }

	// RVA: 0x3114C7C Offset: 0x3110C7C VA: 0x3114C7C
	private static void .cctor() { }
}
