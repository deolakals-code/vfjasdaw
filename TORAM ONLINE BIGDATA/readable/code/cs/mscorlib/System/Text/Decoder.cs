// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
public abstract class Decoder // TypeDefIndex: 10014
{
	// Fields
	internal DecoderFallback _fallback; // 0x10
	internal DecoderFallbackBuffer _fallbackBuffer; // 0x18

	// Properties
	public DecoderFallback Fallback { get; }
	public DecoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x3066E48 Offset: 0x3062E48 VA: 0x3066E48
	protected void .ctor() { }

	// RVA: 0x3066E50 Offset: 0x3062E50 VA: 0x3066E50
	public DecoderFallback get_Fallback() { }

	// RVA: 0x306671C Offset: 0x306271C VA: 0x306671C
	public DecoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x3066E58 Offset: 0x3062E58 VA: 0x3066E58
	internal bool get_InternalHasFallbackBuffer() { }

	// RVA: 0x3066E68 Offset: 0x3062E68 VA: 0x3066E68 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetCharCount(byte[] bytes, int index, int count);

	// RVA: 0x3066F80 Offset: 0x3062F80 VA: 0x3066F80 Slot: 6
	public virtual int GetCharCount(byte[] bytes, int index, int count, bool flush) { }

	[CLSCompliant(False)]
	// RVA: 0x3066F8C Offset: 0x3062F8C VA: 0x3066F8C Slot: 7
	public virtual int GetCharCount(byte* bytes, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

	// RVA: 0x30670E8 Offset: 0x30630E8 VA: 0x30670E8 Slot: 9
	public virtual int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, bool flush) { }

	[CLSCompliant(False)]
	// RVA: 0x30670F4 Offset: 0x30630F4 VA: 0x30670F4 Slot: 10
	public virtual int GetChars(byte* bytes, int byteCount, char* chars, int charCount, bool flush) { }

	// RVA: 0x3067304 Offset: 0x3063304 VA: 0x3067304 Slot: 11
	public virtual int GetChars(ReadOnlySpan<byte> bytes, Span<char> chars, bool flush) { }

	// RVA: 0x30673E4 Offset: 0x30633E4 VA: 0x30673E4 Slot: 12
	public virtual void Convert(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }

	[CLSCompliant(False)]
	// RVA: 0x30676C0 Offset: 0x30636C0 VA: 0x30676C0 Slot: 13
	public virtual void Convert(byte* bytes, int byteCount, char* chars, int charCount, bool flush, out int bytesUsed, out int charsUsed, out bool completed) { }
}
