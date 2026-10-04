// Assembly: mscorlib.dll
// Namespace: Mono.Globalization.Unicode
internal class SortKeyBuffer // TypeDefIndex: 9469
{
	// Fields
	private byte[] l1b; // 0x10
	private byte[] l2b; // 0x18
	private byte[] l3b; // 0x20
	private byte[] l4sb; // 0x28
	private byte[] l4tb; // 0x30
	private byte[] l4kb; // 0x38
	private byte[] l4wb; // 0x40
	private byte[] l5b; // 0x48
	private string source; // 0x50
	private int l1; // 0x58
	private int l2; // 0x5C
	private int l3; // 0x60
	private int l4s; // 0x64
	private int l4t; // 0x68
	private int l4k; // 0x6C
	private int l4w; // 0x70
	private int l5; // 0x74
	private int lcid; // 0x78
	private CompareOptions options; // 0x7C
	private bool processLevel2; // 0x80
	private bool frenchSort; // 0x81
	private bool frenchSorted; // 0x82

	// Methods

	// RVA: 0x2E6C354 Offset: 0x2E68354 VA: 0x2E6C354
	public void .ctor(int lcid) { }

	// RVA: 0x2E707F4 Offset: 0x2E6C7F4 VA: 0x2E707F4
	public void Reset() { }

	// RVA: 0x2E6C35C Offset: 0x2E6835C VA: 0x2E6C35C
	internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort) { }

	// RVA: 0x2E6CE64 Offset: 0x2E68E64 VA: 0x2E6CE64
	internal void AppendCJKExtension(byte lv1msb, byte lv1lsb) { }

	// RVA: 0x2E6CFB0 Offset: 0x2E68FB0 VA: 0x2E6CFB0
	internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth) { }

	// RVA: 0x2E6CD20 Offset: 0x2E68D20 VA: 0x2E6CD20
	internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3) { }

	// RVA: 0x2E708E8 Offset: 0x2E6C8E8 VA: 0x2E708E8
	private void AppendLevel5(byte category, byte lv1) { }

	// RVA: 0x2E70808 Offset: 0x2E6C808 VA: 0x2E70808
	private void AppendBufferPrimitive(byte value, ref byte[] buf, ref int bidx) { }

	// RVA: 0x2E6C8E8 Offset: 0x2E688E8 VA: 0x2E6C8E8
	public SortKey GetResultAndReset() { }

	// RVA: 0x2E70E58 Offset: 0x2E6CE58 VA: 0x2E70E58
	private int GetOptimizedLength(byte[] data, int len, byte defaultValue) { }

	// RVA: 0x2E70980 Offset: 0x2E6C980 VA: 0x2E70980
	public SortKey GetResult() { }
}
