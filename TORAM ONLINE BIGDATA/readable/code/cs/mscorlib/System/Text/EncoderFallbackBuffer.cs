// Assembly: mscorlib.dll
// Namespace: System.Text
public abstract class EncoderFallbackBuffer // TypeDefIndex: 10032
{
	// Fields
	internal char* charStart; // 0x10
	internal char* charEnd; // 0x18
	internal EncoderNLS encoder; // 0x20
	internal bool setEncoder; // 0x28
	internal bool bUsedEncoder; // 0x29
	internal bool bFallingBack; // 0x2A
	internal int iRecursionCount; // 0x2C

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(char charUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Fallback(char charUnknownHigh, char charUnknownLow, int index);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool MovePrevious();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract int get_Remaining();

	// RVA: 0x306AF3C Offset: 0x3066F3C VA: 0x306AF3C Slot: 9
	public virtual void Reset() { }

	// RVA: 0x306AF64 Offset: 0x3066F64 VA: 0x306AF64
	internal void InternalReset() { }

	// RVA: 0x30660FC Offset: 0x30620FC VA: 0x30660FC
	internal void InternalInitialize(char* charStart, char* charEnd, EncoderNLS encoder, bool setEncoder) { }

	// RVA: 0x3066138 Offset: 0x3062138 VA: 0x3066138
	internal char InternalGetNextChar() { }

	// RVA: 0x306AF7C Offset: 0x3066F7C VA: 0x306AF7C Slot: 10
	internal virtual bool InternalFallback(char ch, ref char* chars) { }

	// RVA: 0x306B124 Offset: 0x3067124 VA: 0x306B124
	internal void ThrowLastCharRecursive(int charRecursive) { }

	// RVA: 0x306A484 Offset: 0x3066484 VA: 0x306A484
	protected void .ctor() { }
}
