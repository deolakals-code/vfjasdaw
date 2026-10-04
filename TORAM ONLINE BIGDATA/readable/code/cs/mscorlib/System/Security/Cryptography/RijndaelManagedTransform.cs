// Assembly: mscorlib.dll
// Namespace: System.Security.Cryptography
[ComVisible(True)]
public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable // TypeDefIndex: 10135
{
	// Fields
	private CipherMode m_cipherMode; // 0x10
	private PaddingMode m_paddingValue; // 0x14
	private RijndaelManagedTransformMode m_transformMode; // 0x18
	private int m_blockSizeBits; // 0x1C
	private int m_blockSizeBytes; // 0x20
	private int m_inputBlockSize; // 0x24
	private int m_outputBlockSize; // 0x28
	private int[] m_encryptKeyExpansion; // 0x30
	private int[] m_decryptKeyExpansion; // 0x38
	private int m_Nr; // 0x40
	private int m_Nb; // 0x44
	private int m_Nk; // 0x48
	private int[] m_encryptindex; // 0x50
	private int[] m_decryptindex; // 0x58
	private int[] m_IV; // 0x60
	private int[] m_lastBlockBuffer; // 0x68
	private byte[] m_depadBuffer; // 0x70
	private byte[] m_shiftRegister; // 0x78
	private static readonly byte[] s_Sbox; // 0x0
	private static readonly int[] s_Rcon; // 0x8
	private static readonly int[] s_T; // 0x10
	private static readonly int[] s_TF; // 0x18
	private static readonly int[] s_iT; // 0x20
	private static readonly int[] s_iTF; // 0x28

	// Properties
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }
	public bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x2EB2678 Offset: 0x2EAE678 VA: 0x2EB2678
	internal void .ctor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	// RVA: 0x2EB325C Offset: 0x2EAF25C VA: 0x2EB325C Slot: 9
	public void Dispose() { }

	// RVA: 0x2EB3264 Offset: 0x2EAF264 VA: 0x2EB3264
	private void Dispose(bool disposing) { }

	// RVA: 0x2EB338C Offset: 0x2EAF38C VA: 0x2EB338C Slot: 4
	public int get_InputBlockSize() { }

	// RVA: 0x2EB3394 Offset: 0x2EAF394 VA: 0x2EB3394 Slot: 5
	public int get_OutputBlockSize() { }

	// RVA: 0x2EB339C Offset: 0x2EAF39C VA: 0x2EB339C Slot: 6
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x2EB33A4 Offset: 0x2EAF3A4 VA: 0x2EB33A4 Slot: 7
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x2EB4CFC Offset: 0x2EB0CFC VA: 0x2EB4CFC Slot: 8
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x2EB4FCC Offset: 0x2EB0FCC VA: 0x2EB4FCC
	public void Reset() { }

	// RVA: 0x2EB3678 Offset: 0x2EAF678 VA: 0x2EB3678
	private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x2EB4260 Offset: 0x2EB0260 VA: 0x2EB4260
	private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x2EB5050 Offset: 0x2EB1050 VA: 0x2EB5050
	private void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp) { }

	// RVA: 0x2EB521C Offset: 0x2EB121C VA: 0x2EB521C
	private void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp) { }

	// RVA: 0x2EB2CC8 Offset: 0x2EAECC8 VA: 0x2EB2CC8
	private void GenerateKeyExpansion(byte[] rgbKey) { }

	// RVA: 0x2EB54FC Offset: 0x2EB14FC VA: 0x2EB54FC
	private static int rot1(int val) { }

	// RVA: 0x2EB54F4 Offset: 0x2EB14F4 VA: 0x2EB54F4
	private static int rot2(int val) { }

	// RVA: 0x2EB5404 Offset: 0x2EB1404 VA: 0x2EB5404
	private static int rot3(int val) { }

	// RVA: 0x2EB540C Offset: 0x2EB140C VA: 0x2EB540C
	private static int SubWord(int a) { }

	// RVA: 0x2EB54D0 Offset: 0x2EB14D0 VA: 0x2EB54D0
	private static int MulX(int x) { }

	// RVA: 0x2EB5504 Offset: 0x2EB1504 VA: 0x2EB5504
	private static void .cctor() { }
}
