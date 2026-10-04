// Assembly: mscorlib.dll
// Namespace: Mono.Security.Cryptography
internal class DSAManaged : DSA // TypeDefIndex: 9483
{
	// Fields
	private bool keypairGenerated; // 0x20
	private bool m_disposed; // 0x21
	private BigInteger p; // 0x28
	private BigInteger q; // 0x30
	private BigInteger g; // 0x38
	private BigInteger x; // 0x40
	private BigInteger y; // 0x48
	private BigInteger j; // 0x50
	private BigInteger seed; // 0x58
	private int counter; // 0x60
	private bool j_missing; // 0x64
	private RandomNumberGenerator rng; // 0x68
	[CompilerGenerated]
	private DSAManaged.KeyGeneratedEventHandler KeyGenerated; // 0x70

	// Properties
	private RandomNumberGenerator Random { get; }
	public override int KeySize { get; }
	public bool PublicOnly { get; }

	// Methods

	// RVA: 0x2E79F64 Offset: 0x2E75F64 VA: 0x2E79F64
	public void .ctor(int dwKeySize) { }

	// RVA: 0x2E7A034 Offset: 0x2E76034 VA: 0x2E7A034 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2E7A0D4 Offset: 0x2E760D4 VA: 0x2E7A0D4
	private void Generate() { }

	// RVA: 0x2E7A6A8 Offset: 0x2E766A8 VA: 0x2E7A6A8
	private void GenerateKeyPair() { }

	// RVA: 0x2E7A8D8 Offset: 0x2E768D8 VA: 0x2E7A8D8
	private void add(byte[] a, byte[] b, int value) { }

	// RVA: 0x2E7A120 Offset: 0x2E76120 VA: 0x2E7A120
	private void GenerateParams(int keyLength) { }

	// RVA: 0x2E7A974 Offset: 0x2E76974 VA: 0x2E7A974
	private RandomNumberGenerator get_Random() { }

	// RVA: 0x2E7ACB8 Offset: 0x2E76CB8 VA: 0x2E7ACB8 Slot: 6
	public override int get_KeySize() { }

	// RVA: 0x2E7ACE4 Offset: 0x2E76CE4 VA: 0x2E7ACE4
	public bool get_PublicOnly() { }

	// RVA: 0x2E7AD58 Offset: 0x2E76D58 VA: 0x2E7AD58
	private byte[] NormalizeArray(byte[] array) { }

	// RVA: 0x2E7ADFC Offset: 0x2E76DFC VA: 0x2E7ADFC Slot: 11
	public override DSAParameters ExportParameters(bool includePrivateParameters) { }

	// RVA: 0x2E7B118 Offset: 0x2E77118 VA: 0x2E7B118 Slot: 12
	public override void ImportParameters(DSAParameters parameters) { }

	// RVA: 0x2E7B424 Offset: 0x2E77424 VA: 0x2E7B424 Slot: 10
	public override bool VerifySignature(byte[] rgbHash, byte[] rgbSignature) { }

	// RVA: 0x2E7B8B0 Offset: 0x2E778B0 VA: 0x2E7B8B0 Slot: 5
	protected override void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x2E7BAF0 Offset: 0x2E77AF0 VA: 0x2E7BAF0
	public void add_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2E7BB8C Offset: 0x2E77B8C VA: 0x2E7BB8C
	public void remove_KeyGenerated(DSAManaged.KeyGeneratedEventHandler value) { }
}
