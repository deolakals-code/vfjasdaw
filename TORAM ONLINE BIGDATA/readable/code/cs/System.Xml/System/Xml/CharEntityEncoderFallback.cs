// Assembly: System.Xml.dll
// Namespace: System.Xml
internal class CharEntityEncoderFallback : EncoderFallback // TypeDefIndex: 13274
{
	// Fields
	private CharEntityEncoderFallbackBuffer fallbackBuffer; // 0x10
	private int[] textContentMarks; // 0x18
	private int endMarkPos; // 0x20
	private int curMarkPos; // 0x24
	private int startOffset; // 0x28

	// Properties
	public override int MaxCharCount { get; }
	internal int StartOffset { set; }

	// Methods

	// RVA: 0x32B758C Offset: 0x32B358C VA: 0x32B758C
	internal void .ctor() { }

	// RVA: 0x32B7594 Offset: 0x32B3594 VA: 0x32B7594 Slot: 4
	public override EncoderFallbackBuffer CreateFallbackBuffer() { }

	// RVA: 0x32B768C Offset: 0x32B368C VA: 0x32B768C Slot: 5
	public override int get_MaxCharCount() { }

	// RVA: 0x32B7694 Offset: 0x32B3694 VA: 0x32B7694
	internal void set_StartOffset(int value) { }

	// RVA: 0x32B769C Offset: 0x32B369C VA: 0x32B769C
	internal void Reset(int[] textContentMarks, int endMarkPos) { }

	// RVA: 0x32B76C8 Offset: 0x32B36C8 VA: 0x32B76C8
	internal bool CanReplaceAt(int index) { }
}
