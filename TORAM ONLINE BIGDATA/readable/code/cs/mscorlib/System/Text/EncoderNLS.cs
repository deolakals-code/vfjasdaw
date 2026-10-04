// Assembly: mscorlib.dll
// Namespace: System.Text
internal class EncoderNLS : Encoder // TypeDefIndex: 10033
{
	// Fields
	internal char _charLeftOver; // 0x20
	private Encoding _encoding; // 0x28
	private bool _mustFlush; // 0x30
	internal bool _throwOnOverflow; // 0x31
	internal int _charsUsed; // 0x34

	// Properties
	public Encoding Encoding { get; }
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x3066D14 Offset: 0x3062D14 VA: 0x3066D14
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x306B1B0 Offset: 0x30671B0 VA: 0x306B1B0 Slot: 4
	public override void Reset() { }

	// RVA: 0x306B1D0 Offset: 0x30671D0 VA: 0x306B1D0 Slot: 5
	public override int GetByteCount(char[] chars, int index, int count, bool flush) { }

	// RVA: 0x306B39C Offset: 0x306739C VA: 0x306B39C Slot: 6
	public override int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: 0x306B48C Offset: 0x306748C VA: 0x306B48C Slot: 7
	public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush) { }

	// RVA: 0x306B70C Offset: 0x306770C VA: 0x306B70C Slot: 8
	public override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x306B824 Offset: 0x3067824 VA: 0x306B824 Slot: 9
	public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x306BAD8 Offset: 0x3067AD8 VA: 0x306BAD8 Slot: 10
	public override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	// RVA: 0x306BC8C Offset: 0x3067C8C VA: 0x306BC8C
	public Encoding get_Encoding() { }

	// RVA: 0x306BC94 Offset: 0x3067C94 VA: 0x306BC94
	public bool get_MustFlush() { }

	// RVA: 0x306BC9C Offset: 0x3067C9C VA: 0x306BC9C Slot: 11
	internal virtual bool get_HasState() { }

	// RVA: 0x306BCAC Offset: 0x3067CAC VA: 0x306BCAC
	internal void ClearMustFlush() { }
}
