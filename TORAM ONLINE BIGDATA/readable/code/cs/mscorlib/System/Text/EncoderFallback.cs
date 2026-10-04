// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
public abstract class EncoderFallback // TypeDefIndex: 10031
{
	// Fields
	private static EncoderFallback s_replacementFallback; // 0x0
	private static EncoderFallback s_exceptionFallback; // 0x8

	// Properties
	public static EncoderFallback ReplacementFallback { get; }
	public static EncoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x3064C84 Offset: 0x3060C84 VA: 0x3064C84
	public static EncoderFallback get_ReplacementFallback() { }

	// RVA: 0x306AEA4 Offset: 0x3066EA4 VA: 0x306AEA4
	public static EncoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract EncoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x306A15C Offset: 0x306615C VA: 0x306A15C
	protected void .ctor() { }
}
