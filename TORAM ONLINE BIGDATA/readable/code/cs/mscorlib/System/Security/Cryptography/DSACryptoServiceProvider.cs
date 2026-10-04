// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class DSACryptoServiceProvider : DSA // TypeDefIndex: 10162
{
	// Fields
	private KeyPairPersistence store; // 0x20
	private bool persistKey; // 0x28
	private bool persisted; // 0x29
	private bool privateKeyExportable; // 0x2A
	private bool m_disposed; // 0x2B
	private DSAManaged dsa; // 0x30
	private static bool useMachineKeyStore; // 0x0

	// Properties
	public override int KeySize { get; }
	[ComVisible(False)]
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x2EC002C Offset: 0x2EBC02C VA: 0x2EC002C
	public void .ctor() { }

	// RVA: 0x2EC21C8 Offset: 0x2EBE1C8 VA: 0x2EC21C8
	public void .ctor(int dwKeySize) { }

	// RVA: 0x2EC2200 Offset: 0x2EBE200 VA: 0x2EC2200
	private void Common(int dwKeySize, bool parameters) { }

	// RVA: 0x2EC2450 Offset: 0x2EBE450 VA: 0x2EC2450 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2EC24F0 Offset: 0x2EBE4F0 VA: 0x2EC24F0 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x2EC2510 Offset: 0x2EBE510 VA: 0x2EC2510
	public bool get_PublicOnly() { }

	// RVA: 0x2EC252C Offset: 0x2EBE52C VA: 0x2EC252C Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x2EC25D8 Offset: 0x2EBE5D8 VA: 0x2EC25D8 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x2EC262C Offset: 0x2EBE62C VA: 0x2EC262C Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x2EC264C Offset: 0x2EBE64C VA: 0x2EC264C Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x2EC26A0 Offset: 0x2EBE6A0 VA: 0x2EC26A0
	private void OnKeyGenerated(object sender, EventArgs e) { }
}
