// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Systems.Macro
public class DiceMacroElement : BinaryBase // TypeDefIndex: 11260
{
	// Fields
	[CompilerGenerated]
	private byte <DiceNum>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <DiceMax>k__BackingField; // 0x1C
	[CompilerGenerated]
	private bool <IsDiceMinus>k__BackingField; // 0x20

	// Properties
	public byte DiceNum { get; set; }
	public int DiceMax { get; set; }
	public bool IsDiceMinus { get; set; }

	// Methods

	// RVA: 0x36D2024 Offset: 0x36CE024 VA: 0x36D2024
	public void .ctor() { }

	// RVA: 0x36D201C Offset: 0x36CE01C VA: 0x36D201C
	public void .ctor(byte[] binary) { }

	// RVA: 0x36D15F8 Offset: 0x36CD5F8 VA: 0x36D15F8
	public void .ctor(byte diceNum, int diceMax, bool isDiceMinus) { }

	[CompilerGenerated]
	// RVA: 0x36D202C Offset: 0x36CE02C VA: 0x36D202C
	public byte get_DiceNum() { }

	[CompilerGenerated]
	// RVA: 0x36D2034 Offset: 0x36CE034 VA: 0x36D2034
	protected void set_DiceNum(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36D203C Offset: 0x36CE03C VA: 0x36D203C
	public int get_DiceMax() { }

	[CompilerGenerated]
	// RVA: 0x36D2044 Offset: 0x36CE044 VA: 0x36D2044
	protected void set_DiceMax(int value) { }

	[CompilerGenerated]
	// RVA: 0x36D204C Offset: 0x36CE04C VA: 0x36D204C
	public bool get_IsDiceMinus() { }

	[CompilerGenerated]
	// RVA: 0x36D2054 Offset: 0x36CE054 VA: 0x36D2054
	protected void set_IsDiceMinus(bool value) { }

	// RVA: 0x36D2060 Offset: 0x36CE060 VA: 0x36D2060 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D20AC Offset: 0x36CE0AC VA: 0x36D20AC Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36D21D8 Offset: 0x36CE1D8 VA: 0x36D21D8 Slot: 3
	public override string ToString() { }
}
