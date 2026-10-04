// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Skill.SummonDemonic
public class ChangeSummonDemonic : OperationRequestBase // TypeDefIndex: 12117
{
	// Fields
	[CompilerGenerated]
	private byte <SelectNo>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Color>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Flag>k__BackingField; // 0x28

	// Properties
	public byte SelectNo { get; set; }
	public int Color { get; set; }
	public int Flag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x378ACEC Offset: 0x3786CEC VA: 0x378ACEC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x378ACF4 Offset: 0x3786CF4 VA: 0x378ACF4
	public byte get_SelectNo() { }

	[CompilerGenerated]
	// RVA: 0x378ACFC Offset: 0x3786CFC VA: 0x378ACFC
	public void set_SelectNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x378AD04 Offset: 0x3786D04 VA: 0x378AD04
	public int get_Color() { }

	[CompilerGenerated]
	// RVA: 0x378AD0C Offset: 0x3786D0C VA: 0x378AD0C
	public void set_Color(int value) { }

	[CompilerGenerated]
	// RVA: 0x378AD14 Offset: 0x3786D14 VA: 0x378AD14
	public int get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x378AD1C Offset: 0x3786D1C VA: 0x378AD1C
	public void set_Flag(int value) { }

	// RVA: 0x378AD24 Offset: 0x3786D24 VA: 0x378AD24 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x378AD2C Offset: 0x3786D2C VA: 0x378AD2C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x378AD34 Offset: 0x3786D34 VA: 0x378AD34 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x378AE40 Offset: 0x3786E40 VA: 0x378AE40 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
