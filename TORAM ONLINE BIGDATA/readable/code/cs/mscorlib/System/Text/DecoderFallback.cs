// Assembly: mscorlib.dll
// Namespace: System.Text
[Serializable]
public abstract class DecoderFallback // TypeDefIndex: 10020
{
	// Fields
	private static DecoderFallback s_replacementFallback; // 0x0
	private static DecoderFallback s_exceptionFallback; // 0x8

	// Properties
	public static DecoderFallback ReplacementFallback { get; }
	public static DecoderFallback ExceptionFallback { get; }
	public abstract int MaxCharCount { get; }

	// Methods

	// RVA: 0x3064D14 Offset: 0x3060D14 VA: 0x3064D14
	public static DecoderFallback get_ReplacementFallback() { }

	// RVA: 0x30681AC Offset: 0x30641AC VA: 0x30681AC
	public static DecoderFallback get_ExceptionFallback() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract DecoderFallbackBuffer CreateFallbackBuffer();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_MaxCharCount();

	// RVA: 0x3067918 Offset: 0x3063918 VA: 0x3067918
	protected void .ctor() { }
}
