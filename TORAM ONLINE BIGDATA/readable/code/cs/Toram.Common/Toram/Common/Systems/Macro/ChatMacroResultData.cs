// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Systems.Macro
public class ChatMacroResultData : BinaryBase // TypeDefIndex: 11258
{
	// Fields
	[CompilerGenerated]
	private byte <MacroType>k__BackingField; // 0x19
	[CompilerGenerated]
	private DiceMacroResultData[] <DiceMacroResult>k__BackingField; // 0x20

	// Properties
	public byte MacroType { get; set; }
	public DiceMacroResultData[] DiceMacroResult { get; set; }
	public short DiceMacroTotal { get; }

	// Methods

	// RVA: 0x36D1954 Offset: 0x36CD954 VA: 0x36D1954
	public void .ctor() { }

	// RVA: 0x36D195C Offset: 0x36CD95C VA: 0x36D195C
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36D1964 Offset: 0x36CD964 VA: 0x36D1964
	public byte get_MacroType() { }

	[CompilerGenerated]
	// RVA: 0x36D196C Offset: 0x36CD96C VA: 0x36D196C
	public void set_MacroType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D1974 Offset: 0x36CD974 VA: 0x36D1974
	public DiceMacroResultData[] get_DiceMacroResult() { }

	[CompilerGenerated]
	// RVA: 0x36D197C Offset: 0x36CD97C VA: 0x36D197C
	public void set_DiceMacroResult(DiceMacroResultData[] value) { }

	// RVA: 0x36D1984 Offset: 0x36CD984 VA: 0x36D1984
	public short get_DiceMacroTotal() { }

	// RVA: 0x36D1A58 Offset: 0x36CDA58 VA: 0x36D1A58 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D1ADC Offset: 0x36CDADC VA: 0x36D1ADC Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
