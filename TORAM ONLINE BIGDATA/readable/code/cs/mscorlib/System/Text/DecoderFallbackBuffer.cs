// Assembly: mscorlib.dll
// Namespace: System.Text
public abstract class DecoderFallbackBuffer // TypeDefIndex: 10021
{
	// Fields
	internal byte* byteStart; // 0x10
	internal char* charEnd; // 0x18

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(byte[] bytesUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_Remaining();

	// RVA: 0x3068248 Offset: 0x3064248 VA: 0x3068248 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x30669F8 Offset: 0x30629F8 VA: 0x30669F8
	internal void InternalReset() { }

	// RVA: 0x3066768 Offset: 0x3062768 VA: 0x3066768
	internal void InternalInitialize(byte* byteStart, char* charEnd) { }

	// RVA: 0x3068270 Offset: 0x3064270 VA: 0x3068270 Slot: 8
	internal virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

	// RVA: 0x30683FC Offset: 0x30643FC VA: 0x30683FC Slot: 9
	internal virtual int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x3068568 Offset: 0x3064568 VA: 0x3068568
	internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

	// RVA: 0x3067C24 Offset: 0x3063C24 VA: 0x3067C24
	protected void .ctor() { }
}
