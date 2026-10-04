// Assembly: mscorlib.dll
// Namespace: System
public abstract class FormattableString : IFormattable // TypeDefIndex: 9582
{
	// Properties
	public abstract string Format { get; }
	public abstract int ArgumentCount { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Format();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract object[] GetArguments();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_ArgumentCount();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object GetArgument(int index);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract string ToString(IFormatProvider formatProvider);

	// RVA: 0x2FCEF64 Offset: 0x2FCAF64 VA: 0x2FCEF64 Slot: 4
	private string System.IFormattable.ToString(string ignored, IFormatProvider formatProvider) { }

	// RVA: 0x2FCEF78 Offset: 0x2FCAF78 VA: 0x2FCEF78 Slot: 3
	public override string ToString() { }

	// RVA: 0x2FCEFE0 Offset: 0x2FCAFE0 VA: 0x2FCEFE0
	protected void .ctor() { }
}
