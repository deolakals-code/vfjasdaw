// Assembly: Photon3Unity3D.dll
// Namespace: Photon.SocketServer.Security
internal interface ICryptoProvider : IDisposable // TypeDefIndex: 16950
{
	// Properties
	public abstract byte[] PublicKey { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract byte[] get_PublicKey();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void DeriveSharedKey(byte[] otherPartyPublicKey);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract byte[] Encrypt(byte[] data);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract byte[] Decrypt(byte[] data, int offset, int count);
}
