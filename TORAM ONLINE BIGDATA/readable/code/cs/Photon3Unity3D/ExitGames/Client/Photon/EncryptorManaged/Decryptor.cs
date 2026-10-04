// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon.EncryptorManaged
public class Decryptor : CryptoBase // TypeDefIndex: 17011
{
	// Fields
	private readonly byte[] IV; // 0x20
	private readonly byte[] readBuffer; // 0x28

	// Methods

	// RVA: 0x310EE88 Offset: 0x310AE88 VA: 0x310EE88
	public byte[] DecryptBufferWithIV(byte[] data, int offset, int len, out int outLen) { }

	// RVA: 0x310F4E8 Offset: 0x310B4E8 VA: 0x310F4E8
	public bool CheckHMAC(byte[] data, int len) { }

	// RVA: 0x310F71C Offset: 0x310B71C VA: 0x310F71C
	public void .ctor() { }
}
