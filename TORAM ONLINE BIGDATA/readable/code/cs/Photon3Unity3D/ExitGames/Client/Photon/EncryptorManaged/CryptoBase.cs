// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon.EncryptorManaged
public class CryptoBase : IDisposable // TypeDefIndex: 17009
{
	// Fields
	public const int BLOCK_SIZE = 16;
	public const int IV_SIZE = 16;
	public const int HMAC_SIZE = 32;
	protected Aes encryptor; // 0x10
	protected HMACSHA256 hmacsha256; // 0x18

	// Methods

	// RVA: 0x310E744 Offset: 0x310A744 VA: 0x310E744 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x310E840 Offset: 0x310A840 VA: 0x310E840 Slot: 4
	public void Dispose() { }

	// RVA: 0x310E7DC Offset: 0x310A7DC VA: 0x310E7DC
	private void Dispose(bool dispose) { }

	// RVA: 0x310E8A4 Offset: 0x310A8A4 VA: 0x310E8A4
	public void .ctor() { }
}
