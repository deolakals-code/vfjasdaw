// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
internal class InternalEncoderBestFitFallback : EncoderFallback // TypeDefIndex: 10026
{
	// Fields
	internal Encoding _encoding; // 0x10
	internal char[] _arrayBestFit; // 0x18

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x306A12C Offset: 0x306612C VA: 0x306A12C
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x306A164 Offset: 0x3066164 VA: 0x306A164 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x306A300 Offset: 0x3066300 VA: 0x306A300 Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x306A308 Offset: 0x3066308 VA: 0x306A308 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x306A3CC Offset: 0x30663CC VA: 0x306A3CC Slot: 2
	public override int GetHashCode() { }
}
