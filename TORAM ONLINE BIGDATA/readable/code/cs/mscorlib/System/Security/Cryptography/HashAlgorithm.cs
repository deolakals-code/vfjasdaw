// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
public abstract class HashAlgorithm : IDisposable, ICryptoTransform // TypeDefIndex: 10099
{
	// Fields
	private bool _disposed; // 0x10
	protected int HashSizeValue; // 0x14
	protected internal byte[] HashValue; // 0x18
	protected int State; // 0x20

	// Properties
	public virtual int HashSize { get; }
	public virtual byte[] Hash { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	public virtual bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x2EACA90 Offset: 0x2EA8A90 VA: 0x2EACA90
	protected void .ctor() { }

	// RVA: 0x2EACA98 Offset: 0x2EA8A98 VA: 0x2EACA98
	public static HashAlgorithm Create(string hashName) { }

	// RVA: 0x2EACB18 Offset: 0x2EA8B18 VA: 0x2EACB18 Slot: 10
	public virtual int get_HashSize() { }

	// RVA: 0x2EACB20 Offset: 0x2EA8B20 VA: 0x2EACB20 Slot: 11
	public virtual byte[] get_Hash() { }

	// RVA: 0x2EACC54 Offset: 0x2EA8C54 VA: 0x2EACC54
	public byte[] ComputeHash(byte[] buffer) { }

	// RVA: 0x2EACDB4 Offset: 0x2EA8DB4 VA: 0x2EACDB4
	public byte[] ComputeHash(byte[] buffer, int offset, int count) { }

	// RVA: 0x2EACCF8 Offset: 0x2EA8CF8 VA: 0x2EACCF8
	private byte[] CaptureHashCodeAndReinitialize() { }

	// RVA: 0x2EACF14 Offset: 0x2EA8F14 VA: 0x2EACF14 Slot: 4
	public void Dispose() { }

	// RVA: 0x2EACF80 Offset: 0x2EA8F80 VA: 0x2EACF80
	public void Clear() { }

	// RVA: 0x2EAD014 Offset: 0x2EA9014 VA: 0x2EAD014 Slot: 12
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2EAD024 Offset: 0x2EA9024 VA: 0x2EAD024 Slot: 13
	public virtual int get_InputBlockSize() { }

	// RVA: 0x2EAD02C Offset: 0x2EA902C VA: 0x2EAD02C Slot: 14
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x2EAD034 Offset: 0x2EA9034 VA: 0x2EAD034 Slot: 15
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x2EAD03C Offset: 0x2EA903C VA: 0x2EAD03C Slot: 8
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x2EAD21C Offset: 0x2EA921C VA: 0x2EAD21C Slot: 9
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x2EAD0D8 Offset: 0x2EA90D8 VA: 0x2EAD0D8
	private void ValidateTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: -1 Offset: -1 Slot: 16
	protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract byte[] HashFinal();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void Initialize();
}
