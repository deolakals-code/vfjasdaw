// Assembly: System.Core.dll
// Namespace: System.Security.Cryptography
public sealed class AesCryptoServiceProvider : Aes // TypeDefIndex: 15179
{
	// Properties
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override int FeedbackSize { get; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x3110494 Offset: 0x310C494 VA: 0x3110494
	public void .ctor() { }

	// RVA: 0x31104F8 Offset: 0x310C4F8 VA: 0x31104F8 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x3110524 Offset: 0x310C524 VA: 0x3110524 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x3110550 Offset: 0x310C550 VA: 0x3110550 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x3110D3C Offset: 0x310CD3C VA: 0x3110D3C Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x3110E2C Offset: 0x310CE2C VA: 0x3110E2C Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x3110E34 Offset: 0x310CE34 VA: 0x3110E34 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x3110E3C Offset: 0x310CE3C VA: 0x3110E3C Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x3110E44 Offset: 0x310CE44 VA: 0x3110E44 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x3110E4C Offset: 0x310CE4C VA: 0x3110E4C Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x3110E54 Offset: 0x310CE54 VA: 0x3110E54 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x3110E5C Offset: 0x310CE5C VA: 0x3110E5C Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x3110E64 Offset: 0x310CE64 VA: 0x3110E64 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x3110E6C Offset: 0x310CE6C VA: 0x3110E6C Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x3110EC8 Offset: 0x310CEC8 VA: 0x3110EC8 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x3110ED0 Offset: 0x310CED0 VA: 0x3110ED0 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x3110ED8 Offset: 0x310CED8 VA: 0x3110ED8 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x3110F28 Offset: 0x310CF28 VA: 0x3110F28 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x3110F78 Offset: 0x310CF78 VA: 0x3110F78 Slot: 5
	protected override void Dispose(bool disposing) { }
}
