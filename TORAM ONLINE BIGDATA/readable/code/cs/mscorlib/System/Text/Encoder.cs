// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
public abstract class Encoder // TypeDefIndex: 10025
{
	// Fields
	internal EncoderFallback _fallback; // 0x10
	internal EncoderFallbackBuffer _fallbackBuffer; // 0x18

	// Properties
	public EncoderFallback Fallback { get; }
	public EncoderFallbackBuffer FallbackBuffer { get; }
	internal bool InternalHasFallbackBuffer { get; }

	// Methods

	// RVA: 0x30697C8 Offset: 0x30657C8 VA: 0x30697C8
	protected void .ctor() { }

	// RVA: 0x30697D0 Offset: 0x30657D0 VA: 0x30697D0
	public EncoderFallback get_Fallback() { }

	// RVA: 0x30660B0 Offset: 0x30620B0 VA: 0x30660B0
	public EncoderFallbackBuffer get_FallbackBuffer() { }

	// RVA: 0x30660A0 Offset: 0x30620A0 VA: 0x30660A0
	internal bool get_InternalHasFallbackBuffer() { }

	// RVA: 0x30697D8 Offset: 0x30657D8 VA: 0x30697D8 Slot: 4
	public virtual void Reset() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int GetByteCount(char[] chars, int index, int count, bool flush);

	[CLSCompliant(False)]
	// RVA: 0x30698BC Offset: 0x30658BC VA: 0x30698BC Slot: 6
	public virtual int GetByteCount(char* chars, int count, bool flush) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush);

	[CLSCompliant(False)]
	// RVA: 0x3069A20 Offset: 0x3065A20 VA: 0x3069A20 Slot: 8
	public virtual int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush) { }

	// RVA: 0x3069C30 Offset: 0x3065C30 VA: 0x3069C30 Slot: 9
	public virtual void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }

	[CLSCompliant(False)]
	// RVA: 0x3069F0C Offset: 0x3065F0C VA: 0x3069F0C Slot: 10
	public virtual void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed) { }
}
