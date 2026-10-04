// Assembly: mscorlib.dll
// Namespace: 
private sealed class FormattableStringFactory.ConcreteFormattableString : FormattableString // TypeDefIndex: 10496
{
	// Fields
	private readonly string _format; // 0x10
	private readonly object[] _arguments; // 0x18

	// Properties
	public override string Format { get; }
	public override int ArgumentCount { get; }

	// Methods

	// RVA: 0x2F1FFF8 Offset: 0x2F1BFF8 VA: 0x2F1FFF8
	internal void .ctor(string format, object[] arguments) { }

	// RVA: 0x2F2003C Offset: 0x2F1C03C VA: 0x2F2003C Slot: 5
	public override string get_Format() { }

	// RVA: 0x2F20044 Offset: 0x2F1C044 VA: 0x2F20044 Slot: 6
	public override object[] GetArguments() { }

	// RVA: 0x2F2004C Offset: 0x2F1C04C VA: 0x2F2004C Slot: 7
	public override int get_ArgumentCount() { }

	// RVA: 0x2F20068 Offset: 0x2F1C068 VA: 0x2F20068 Slot: 8
	public override object GetArgument(int index) { }

	// RVA: 0x2F20098 Offset: 0x2F1C098 VA: 0x2F20098 Slot: 9
	public override string ToString(IFormatProvider formatProvider) { }
}
