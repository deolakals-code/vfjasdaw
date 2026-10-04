// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RSACryptoServiceProvider : RSA // TypeDefIndex: 10140
{
	// Fields
	private static CspProviderFlags s_UseMachineKeyStore; // 0x0
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private RSAManaged rsa; // 0x30

	// Properties
	public static bool UseMachineKeyStore { get; }
	public override int KeySize { get; }
	[ComVisible(False)]
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x2EB7D74 Offset: 0x2EB3D74 VA: 0x2EB7D74
	public static bool get_UseMachineKeyStore() { }

	// RVA: 0x2EB7318 Offset: 0x2EB3318 VA: 0x2EB7318
	public void .ctor() { }

	// RVA: 0x2EB7E00 Offset: 0x2EB3E00 VA: 0x2EB7E00
	public void .ctor(CspParameters parameters) { }

	// RVA: 0x2EB7DC8 Offset: 0x2EB3DC8 VA: 0x2EB7DC8
	public void .ctor(int dwKeySize) { }

	// RVA: 0x2EB7E0C Offset: 0x2EB3E0C VA: 0x2EB7E0C
	public void .ctor(int dwKeySize, CspParameters parameters) { }

	// RVA: 0x2EB7E68 Offset: 0x2EB3E68 VA: 0x2EB7E68
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x2EB80B0 Offset: 0x2EB40B0 VA: 0x2EB80B0
	private void Common(CspParameters p) { }

	// RVA: 0x2EB81DC Offset: 0x2EB41DC VA: 0x2EB81DC Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2EB827C Offset: 0x2EB427C VA: 0x2EB827C Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x2EB829C Offset: 0x2EB429C VA: 0x2EB829C
	public bool get_PublicOnly() { }

	// RVA: 0x2EB82B8 Offset: 0x2EB42B8 VA: 0x2EB82B8 Slot: 10
	public override byte[] EncryptValue(byte[] rgb) { }

	// RVA: 0x2EB82D8 Offset: 0x2EB42D8 VA: 0x2EB82D8 Slot: 11
	public override RSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x2EB8408 Offset: 0x2EB4408 VA: 0x2EB8408 Slot: 12
	public override void ImportParameters(RSAParameters parameters) { }

	// RVA: 0x2EB845C Offset: 0x2EB445C VA: 0x2EB845C
	private string GetHashNameFromOID(string oid) { }

	// RVA: 0x2EB8620 Offset: 0x2EB4620 VA: 0x2EB8620
	public bool VerifyHash(byte[] rgbHash, string str, byte[] rgbSignature) { }

	// RVA: 0x2EB8740 Offset: 0x2EB4740 VA: 0x2EB8740 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2EB8794 Offset: 0x2EB4794 VA: 0x2EB8794
	private void OnKeyGenerated(object sender, EventArgs e) { }
}
