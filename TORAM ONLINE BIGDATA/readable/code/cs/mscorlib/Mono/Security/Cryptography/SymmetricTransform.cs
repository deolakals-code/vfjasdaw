// Assembly: mscorlib.dll
// Namespace: Mono.Security.Cryptography
internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 9481
{
	// Fields
	protected SymmetricAlgorithm algo; // 0x10
	protected bool encrypt; // 0x18
	protected int BlockSizeByte; // 0x1C
	protected byte[] temp; // 0x20
	protected byte[] temp2; // 0x28
	private byte[] workBuff; // 0x30
	private byte[] workout; // 0x38
	protected PaddingMode padmode; // 0x40
	protected int FeedBackByte; // 0x44
	private bool m_disposed; // 0x48
	protected bool lastBlock; // 0x49
	private RandomNumberGenerator _rng; // 0x50

	// Properties
	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }

	// Methods

	// RVA: 0x2E78730 Offset: 0x2E74730 VA: 0x2E78730
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x2E78A30 Offset: 0x2E74A30 VA: 0x2E78A30 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x2E78AD0 Offset: 0x2E74AD0 VA: 0x2E78AD0 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x2E78B3C Offset: 0x2E74B3C VA: 0x2E78B3C Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2E78BB8 Offset: 0x2E74BB8 VA: 0x2E78BB8 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x2E78BC0 Offset: 0x2E74BC0 VA: 0x2E78BC0 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x2E78BC8 Offset: 0x2E74BC8 VA: 0x2E78BC8 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x2E78BD0 Offset: 0x2E74BD0 VA: 0x2E78BD0 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output);

	// RVA: 0x2E78DFC Offset: 0x2E74DFC VA: 0x2E78DFC Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x2E78F60 Offset: 0x2E74F60 VA: 0x2E78F60 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x2E79128 Offset: 0x2E75128 VA: 0x2E79128 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x2E79174 Offset: 0x2E75174 VA: 0x2E79174 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x2E791C0 Offset: 0x2E751C0 VA: 0x2E791C0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x2E79304 Offset: 0x2E75304 VA: 0x2E79304 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x2E7950C Offset: 0x2E7550C VA: 0x2E7950C
	private bool get_KeepLastBlock() { }

	// RVA: 0x2E79530 Offset: 0x2E75530 VA: 0x2E79530
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x2E796E8 Offset: 0x2E756E8 VA: 0x2E796E8
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x2E797A4 Offset: 0x2E757A4 VA: 0x2E797A4
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x2E79988 Offset: 0x2E75988 VA: 0x2E79988 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x2E79C1C Offset: 0x2E75C1C VA: 0x2E79C1C Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x2E79EB4 Offset: 0x2E75EB4 VA: 0x2E79EB4 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }
}
