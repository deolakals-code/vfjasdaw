// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill
public class GetHuntingOneResponse : OperationResponseBase // TypeDefIndex: 12098
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

	// RVA: 0x3786B6C Offset: 0x3782B6C VA: 0x3786B6C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3786B74 Offset: 0x3782B74 VA: 0x3786B74
	public byte get_SelectNo() { }

	[CompilerGenerated]
	// RVA: 0x3786B7C Offset: 0x3782B7C VA: 0x3786B7C
	public void set_SelectNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3786B84 Offset: 0x3782B84 VA: 0x3786B84
	public int get_Color() { }

	[CompilerGenerated]
	// RVA: 0x3786B8C Offset: 0x3782B8C VA: 0x3786B8C
	public void set_Color(int value) { }

	[CompilerGenerated]
	// RVA: 0x3786B94 Offset: 0x3782B94 VA: 0x3786B94
	public long get_Model() { }

	[CompilerGenerated]
	// RVA: 0x3786B9C Offset: 0x3782B9C VA: 0x3786B9C
	public void set_Model(long value) { }

	[CompilerGenerated]
	// RVA: 0x3786BA4 Offset: 0x3782BA4 VA: 0x3786BA4
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x3786BAC Offset: 0x3782BAC VA: 0x3786BAC
	public void set_Flag(int value) { }

	// RVA: 0x3786BB4 Offset: 0x3782BB4 VA: 0x3786BB4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3786BBC Offset: 0x3782BBC VA: 0x3786BBC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3786BC4 Offset: 0x3782BC4 VA: 0x3786BC4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3786D0C Offset: 0x3782D0C VA: 0x3786D0C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
