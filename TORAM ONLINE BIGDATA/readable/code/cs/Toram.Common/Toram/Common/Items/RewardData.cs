// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Items
public class RewardData : BinaryBase // TypeDefIndex: 12510
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Num>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <EquipRandomFlag>k__BackingField; // 0x24

	// Properties
	[BinaryParameter]
	public byte Type { get; set; }
	[BinaryParameter]
	public int Value { get; set; }
	[BinaryParameter]
	public int Num { get; set; }
	protected byte EquipRandomFlag { set; }

	// Methods

	// RVA: 0x361535C Offset: 0x361135C VA: 0x361535C
	public void .ctor() { }

	// RVA: 0x3615364 Offset: 0x3611364 VA: 0x3615364
	public void .ctor(byte[] binary) { }

	// RVA: 0x361536C Offset: 0x361136C VA: 0x361536C
	public void .ctor(byte type, int value, int num) { }

	[CompilerGenerated]
	// RVA: 0x36153AC Offset: 0x36113AC VA: 0x36153AC
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x36153B4 Offset: 0x36113B4 VA: 0x36153B4
	protected void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36153BC Offset: 0x36113BC VA: 0x36153BC
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x36153C4 Offset: 0x36113C4 VA: 0x36153C4
	protected void set_Value(int value) { }

	[CompilerGenerated]
	// RVA: 0x36153CC Offset: 0x36113CC VA: 0x36153CC
	public int get_Num() { }

	[CompilerGenerated]
	// RVA: 0x36153D4 Offset: 0x36113D4 VA: 0x36153D4
	protected void set_Num(int value) { }

	[CompilerGenerated]
	// RVA: 0x36153DC Offset: 0x36113DC VA: 0x36153DC
	protected void set_EquipRandomFlag(byte value) { }

	// RVA: 0x36153E4 Offset: 0x36113E4 VA: 0x36153E4 Slot: 3
	public override string ToString() { }

	// RVA: 0x36154BC Offset: 0x36114BC VA: 0x36154BC
	public void AddNum(int num) { }

	// RVA: 0x36154CC Offset: 0x36114CC VA: 0x36154CC Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36155EC Offset: 0x36115EC VA: 0x36155EC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
