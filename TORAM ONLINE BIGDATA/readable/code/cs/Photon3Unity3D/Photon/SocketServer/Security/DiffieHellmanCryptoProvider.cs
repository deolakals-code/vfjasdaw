// Assembly: Photon3Unity3D.dll
// Namespace: Photon.SocketServer.Security
internal class DiffieHellmanCryptoProvider : ICryptoProvider, IDisposable // TypeDefIndex: 16951
{
	// Fields
	private static readonly BigInteger primeRoot; // 0x0
	private readonly BigInteger prime; // 0x10
	private readonly BigInteger secret; // 0x18
	private readonly BigInteger publicKey; // 0x20
	private Rijndael crypto; // 0x28
	private byte[] sharedKey; // 0x30

	// Properties
	public byte[] PublicKey { get; }

	// Methods

	// RVA: 0x30ECDEC Offset: 0x30E8DEC VA: 0x30ECDEC
	public void .ctor() { }

	// RVA: 0x30ED2A8 Offset: 0x30E92A8 VA: 0x30ED2A8
	public void .ctor(byte[] sharedSecretHash) { }

	// RVA: 0x30ED394 Offset: 0x30E9394 VA: 0x30ED394 Slot: 4
	public byte[] get_PublicKey() { }

	// RVA: 0x30ED4FC Offset: 0x30E94FC VA: 0x30ED4FC Slot: 5
	public void DeriveSharedKey(byte[] otherPartyPublicKey) { }

	// RVA: 0x30ED7B8 Offset: 0x30E97B8 VA: 0x30ED7B8 Slot: 6
	public byte[] Encrypt(byte[] data) { }

	// RVA: 0x30ED7D4 Offset: 0x30E97D4 VA: 0x30ED7D4 Slot: 9
	public byte[] Encrypt(byte[] data, int offset, int count) { }

	// RVA: 0x30ED9EC Offset: 0x30E99EC VA: 0x30ED9EC Slot: 7
	public byte[] Decrypt(byte[] data, int offset, int count) { }

	// RVA: 0x30EDC04 Offset: 0x30E9C04 VA: 0x30EDC04 Slot: 8
	public void Dispose() { }

	// RVA: 0x30EDC5C Offset: 0x30E9C5C VA: 0x30EDC5C
	protected void Dispose(bool disposing) { }

	// RVA: 0x30ED240 Offset: 0x30E9240 VA: 0x30ED240
	private BigInteger CalculatePublicKey() { }

	// RVA: 0x30ED798 Offset: 0x30E9798 VA: 0x30ED798
	private BigInteger CalculateSharedKey(BigInteger otherPartyPublicKey) { }

	// RVA: 0x30ED164 Offset: 0x30E9164 VA: 0x30ED164
	private BigInteger GenerateRandomSecret(int secretLength) { }

	// RVA: 0x30EE394 Offset: 0x30EA394 VA: 0x30EE394
	private static void .cctor() { }
}
