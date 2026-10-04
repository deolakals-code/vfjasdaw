// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Mercenaries
public class MercenaryJoinResponse : OperationResponseBase // TypeDefIndex: 11478
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x34
	[CompilerGenerated]
	private byte <EmploymentType>k__BackingField; // 0x36
	[CompilerGenerated]
	private MercenaryEmployeeData <Employment>k__BackingField; // 0x38
	[CompilerGenerated]
	private DateTime <LatestTime>k__BackingField; // 0x40

	// Properties
	public int ArchetypeId { get; set; }
	public byte ArchetypeType { get; set; }
	public string Name { get; set; }
	public int Gold { get; set; }
	public short ReturnCode { get; set; }
	public byte EmploymentType { get; set; }
	public MercenaryEmployeeData Employment { get; set; }
	public DateTime LatestTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37105A0 Offset: 0x370C5A0 VA: 0x37105A0
	public void .ctor() { }

	// RVA: 0x37105A8 Offset: 0x370C5A8 VA: 0x37105A8
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37105B0 Offset: 0x370C5B0 VA: 0x37105B0
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x37105B8 Offset: 0x370C5B8 VA: 0x37105B8
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37105C0 Offset: 0x370C5C0 VA: 0x37105C0
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x37105C8 Offset: 0x370C5C8 VA: 0x37105C8
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x37105D0 Offset: 0x370C5D0 VA: 0x37105D0
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x37105D8 Offset: 0x370C5D8 VA: 0x37105D8
	public void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x37105E0 Offset: 0x370C5E0 VA: 0x37105E0
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x37105E8 Offset: 0x370C5E8 VA: 0x37105E8
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x37105F0 Offset: 0x370C5F0 VA: 0x37105F0
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x37105F8 Offset: 0x370C5F8 VA: 0x37105F8
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x3710600 Offset: 0x370C600 VA: 0x3710600
	public byte get_EmploymentType() { }

	[CompilerGenerated]
	// RVA: 0x3710608 Offset: 0x370C608 VA: 0x3710608
	public void set_EmploymentType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3710610 Offset: 0x370C610 VA: 0x3710610
	public MercenaryEmployeeData get_Employment() { }

	[CompilerGenerated]
	// RVA: 0x3710618 Offset: 0x370C618 VA: 0x3710618
	public void set_Employment(MercenaryEmployeeData value) { }

	[CompilerGenerated]
	// RVA: 0x3710620 Offset: 0x370C620 VA: 0x3710620
	public DateTime get_LatestTime() { }

	[CompilerGenerated]
	// RVA: 0x3710628 Offset: 0x370C628 VA: 0x3710628
	public void set_LatestTime(DateTime value) { }

	// RVA: 0x3710630 Offset: 0x370C630 VA: 0x3710630 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3710638 Offset: 0x370C638 VA: 0x3710638 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3710640 Offset: 0x370C640 VA: 0x3710640 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3710A84 Offset: 0x370CA84 VA: 0x3710A84 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
