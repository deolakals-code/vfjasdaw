// Assembly: mscorlib.dll
// Namespace: System
[IsReadOnly]
[DefaultMember("Item")]
internal struct ParamsArray // TypeDefIndex: 9651
{
	// Fields
	private static readonly object[] s_oneArgArray; // 0x0
	private static readonly object[] s_twoArgArray; // 0x8
	private static readonly object[] s_threeArgArray; // 0x10
	private readonly object _arg0; // 0x0
	private readonly object _arg1; // 0x8
	private readonly object _arg2; // 0x10
	private readonly object[] _args; // 0x18

	// Properties
	public int Length { get; }
	public object Item { get; }

	// Methods

	// RVA: 0x2FF48E8 Offset: 0x2FF08E8 VA: 0x2FF48E8
	public void .ctor(object arg0) { }

	// RVA: 0x2FF4988 Offset: 0x2FF0988 VA: 0x2FF4988
	public void .ctor(object arg0, object arg1) { }

	// RVA: 0x2FF4A2C Offset: 0x2FF0A2C VA: 0x2FF4A2C
	public void .ctor(object arg0, object arg1, object arg2) { }

	// RVA: 0x2FF4ADC Offset: 0x2FF0ADC VA: 0x2FF4ADC
	public void .ctor(object[] args) { }

	// RVA: 0x2FF4B94 Offset: 0x2FF0B94 VA: 0x2FF4B94
	public int get_Length() { }

	// RVA: 0x2FF4BB0 Offset: 0x2FF0BB0 VA: 0x2FF4BB0
	public object get_Item(int index) { }

	// RVA: 0x2FF4C20 Offset: 0x2FF0C20 VA: 0x2FF4C20
	private object GetAtSlow(int index) { }

	// RVA: 0x2FF4C74 Offset: 0x2FF0C74 VA: 0x2FF4C74
	private static void .cctor() { }
}
