// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Systems.Macro
public class DiceMacroResultData : BinaryBase // TypeDefIndex: 11259
{
	// Fields
	[CompilerGenerated]
	private short[] <ResultElements>k__BackingField; // 0x20
	[CompilerGenerated]
	private DiceMacroElement <DiceMacroElement>k__BackingField; // 0x28

	// Properties
	public short[] ResultElements { get; set; }
	public DiceMacroElement DiceMacroElement { get; set; }
	public short Total { get; }

	// Methods

	// RVA: 0x36D1C3C Offset: 0x36CDC3C VA: 0x36D1C3C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x36D1C44 Offset: 0x36CDC44 VA: 0x36D1C44
	public short[] get_ResultElements() { }

	[CompilerGenerated]
	// RVA: 0x36D1C4C Offset: 0x36CDC4C VA: 0x36D1C4C
	public void set_ResultElements(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36D1C54 Offset: 0x36CDC54 VA: 0x36D1C54
	public DiceMacroElement get_DiceMacroElement() { }

	[CompilerGenerated]
	// RVA: 0x36D1C5C Offset: 0x36CDC5C VA: 0x36D1C5C
	public void set_DiceMacroElement(DiceMacroElement value) { }

	// RVA: 0x36D19F4 Offset: 0x36CD9F4 VA: 0x36D19F4
	public short get_Total() { }

	// RVA: 0x36D1C64 Offset: 0x36CDC64 VA: 0x36D1C64 Slot: 3
	public override string ToString() { }

	// RVA: 0x36D1E10 Offset: 0x36CDE10 VA: 0x36D1E10 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D1EA4 Offset: 0x36CDEA4 VA: 0x36D1EA4 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
