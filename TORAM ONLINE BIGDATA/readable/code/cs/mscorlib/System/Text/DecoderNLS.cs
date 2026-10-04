// Assembly: mscorlib.dll
// Namespace: System.Text
internal class DecoderNLS : Decoder // TypeDefIndex: 10022
{
	// Fields
	private Encoding _encoding; // 0x20
	private bool _mustFlush; // 0x28
	internal bool _throwOnOverflow; // 0x29
	internal int _bytesUsed; // 0x2C

	// Properties
	public bool MustFlush { get; }
	internal virtual bool HasState { get; }

	// Methods

	// RVA: 0x3066C5C Offset: 0x3062C5C VA: 0x3066C5C
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x3068760 Offset: 0x3064760 VA: 0x3068760 Slot: 4
	public override void Reset() { }

	// RVA: 0x3068778 Offset: 0x3064778 VA: 0x3068778 Slot: 5
	public override int GetCharCount(byte[] bytes, int index, int count) { }

	// RVA: 0x3068788 Offset: 0x3064788 VA: 0x3068788 Slot: 6
	public override int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	// RVA: 0x3068954 Offset: 0x3064954 VA: 0x3068954 Slot: 7
	public override int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: 0x3068A44 Offset: 0x3064A44 VA: 0x3068A44 Slot: 8
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex) { }

	// RVA: 0x3068A54 Offset: 0x3064A54 VA: 0x3068A54 Slot: 9
	public override int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	// RVA: 0x3068CD4 Offset: 0x3064CD4 VA: 0x3068CD4 Slot: 10
	public override int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x3068DEC Offset: 0x3064DEC VA: 0x3068DEC Slot: 12
	public override void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x30690A4 Offset: 0x30650A4 VA: 0x30690A4 Slot: 13
	public override void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	// RVA: 0x306925C Offset: 0x306525C VA: 0x306925C
	public bool get_MustFlush() { }

	// RVA: 0x3069264 Offset: 0x3065264 VA: 0x3069264 Slot: 14
	internal virtual bool get_HasState() { }

	// RVA: 0x306926C Offset: 0x306526C VA: 0x306926C
	internal void ClearMustFlush() { }
}
