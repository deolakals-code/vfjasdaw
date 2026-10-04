// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
internal sealed class InternalDecoderBestFitFallback : DecoderFallback // TypeDefIndex: 10015
{
	// Fields
	internal Encoding _encoding; // 0x10
	internal char[] _arrayBestFit; // 0x18
	internal char _cReplacement; // 0x20

	// Properties
	public override int MaxCharCount { get; }

	// Methods

	// RVA: 0x30678E0 Offset: 0x30638E0 VA: 0x30678E0
	internal void .ctor(Encoding encoding) { }

	// RVA: 0x3067920 Offset: 0x3063920 VA: 0x3067920 Slot: 4
	public override DecoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x3067ABC Offset: 0x3063ABC VA: 0x3067ABC Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x3067AC4 Offset: 0x3063AC4 VA: 0x3067AC4 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x3067B6C Offset: 0x3063B6C VA: 0x3067B6C Slot: 2
	public override int GetHashCode() { }
}
