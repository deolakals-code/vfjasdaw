// Assembly: System.Core.dll
// Namespace: System.Security.Cryptography
public sealed class AesManaged : Aes // TypeDefIndex: 15178
{
	// Fields
	private RijndaelManaged m_rijndael; // 0x48

	// Properties
	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x310FD10 Offset: 0x310BD10 VA: 0x310FD10
	public void .ctor() { }

	// RVA: 0x310FE80 Offset: 0x310BE80 VA: 0x310FE80 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x310FEA0 Offset: 0x310BEA0 VA: 0x310FEA0 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x310FEC0 Offset: 0x310BEC0 VA: 0x310FEC0 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x310FEE0 Offset: 0x310BEE0 VA: 0x310FEE0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x310FF00 Offset: 0x310BF00 VA: 0x310FF00 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x310FF20 Offset: 0x310BF20 VA: 0x310FF20 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x310FF44 Offset: 0x310BF44 VA: 0x310FF44 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x310FF68 Offset: 0x310BF68 VA: 0x310FF68 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x310FF8C Offset: 0x310BF8C VA: 0x310FF8C Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x311000C Offset: 0x310C00C VA: 0x311000C Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x3110030 Offset: 0x310C030 VA: 0x3110030 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x3110054 Offset: 0x310C054 VA: 0x3110054 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x3110078 Offset: 0x310C078 VA: 0x3110078 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x31101B8 Offset: 0x310C1B8 VA: 0x31101B8 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x31101DC Offset: 0x310C1DC VA: 0x31101DC Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x311031C Offset: 0x310C31C VA: 0x311031C Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x311044C Offset: 0x310C44C VA: 0x311044C Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x3110470 Offset: 0x310C470 VA: 0x3110470 Slot: 24
	public override void GenerateKey() { }
}
