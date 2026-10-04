// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class ChangeHuntingOneResponse : OperationResponseBase // TypeDefIndex: 12097
{
	// Fields
	[CompilerGenerated]
	private byte <SelectNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Color>k__BackingField; // 0x24
	[CompilerGenerated]
	private long <Model>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x30

	// Properties
	public byte SelectNo { get; set; }
	public int Color { get; set; }
	public long Model { get; set; }
	public int Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37867B0 Offset: 0x37827B0 VA: 0x37867B0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37867B8 Offset: 0x37827B8 VA: 0x37867B8
	public byte get_SelectNo() { }

	[CompilerGenerated]
	// RVA: 0x37867C0 Offset: 0x37827C0 VA: 0x37867C0
	public void set_SelectNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37867C8 Offset: 0x37827C8 VA: 0x37867C8
	public int get_Color() { }

	[CompilerGenerated]
	// RVA: 0x37867D0 Offset: 0x37827D0 VA: 0x37867D0
	public void set_Color(int value) { }

	[CompilerGenerated]
	// RVA: 0x37867D8 Offset: 0x37827D8 VA: 0x37867D8
	public long get_Model() { }

	[CompilerGenerated]
	// RVA: 0x37867E0 Offset: 0x37827E0 VA: 0x37867E0
	public void set_Model(long value) { }

	[CompilerGenerated]
	// RVA: 0x37867E8 Offset: 0x37827E8 VA: 0x37867E8
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x37867F0 Offset: 0x37827F0 VA: 0x37867F0
	public void set_Flag(int value) { }

	// RVA: 0x37867F8 Offset: 0x37827F8 VA: 0x37867F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3786800 Offset: 0x3782800 VA: 0x3786800 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3786808 Offset: 0x3782808 VA: 0x3786808 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3786950 Offset: 0x3782950 VA: 0x3786950 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
