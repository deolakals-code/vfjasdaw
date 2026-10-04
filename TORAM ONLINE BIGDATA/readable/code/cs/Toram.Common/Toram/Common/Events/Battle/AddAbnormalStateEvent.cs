// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class AddAbnormalStateEvent : PacketBase // TypeDefIndex: 12705
{
	// Fields
	[CompilerGenerated]
	private byte <ArcehtypeType>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x24
	[CompilerGenerated]
	private MobIdData <TargetMobId>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <TargetArchetypeType>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <TargetArchetypeId>k__BackingField; // 0x34
	[CompilerGenerated]
	private AbnormalData[] <AbnormalDatas>k__BackingField; // 0x38
	[CompilerGenerated]
	private ActionAppendData <AppendData>k__BackingField; // 0x40

	// Properties
	public byte ArcehtypeType { get; set; }
	public int ArchetypeId { get; set; }
	public MobIdData TargetMobId { get; set; }
	public byte TargetArchetypeType { get; set; }
	public int TargetArchetypeId { get; set; }
	public AbnormalData[] AbnormalDatas { get; set; }
	public ActionAppendData AppendData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36454EC Offset: 0x36414EC VA: 0x36454EC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36454F4 Offset: 0x36414F4 VA: 0x36454F4
	public byte get_ArcehtypeType() { }

	[CompilerGenerated]
	// RVA: 0x36454FC Offset: 0x36414FC VA: 0x36454FC
	public void set_ArcehtypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3645504 Offset: 0x3641504 VA: 0x3645504
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x364550C Offset: 0x364150C VA: 0x364550C
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3645514 Offset: 0x3641514 VA: 0x3645514
	public MobIdData get_TargetMobId() { }

	[CompilerGenerated]
	// RVA: 0x364551C Offset: 0x364151C VA: 0x364551C
	public void set_TargetMobId(MobIdData value) { }

	[CompilerGenerated]
	// RVA: 0x3645524 Offset: 0x3641524 VA: 0x3645524
	public byte get_TargetArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x364552C Offset: 0x364152C VA: 0x364552C
	public void set_TargetArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3645534 Offset: 0x3641534 VA: 0x3645534
	public int get_TargetArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x364553C Offset: 0x364153C VA: 0x364553C
	public void set_TargetArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3645544 Offset: 0x3641544 VA: 0x3645544
	public AbnormalData[] get_AbnormalDatas() { }

	[CompilerGenerated]
	// RVA: 0x364554C Offset: 0x364154C VA: 0x364554C
	public void set_AbnormalDatas(AbnormalData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3645554 Offset: 0x3641554 VA: 0x3645554
	public ActionAppendData get_AppendData() { }

	[CompilerGenerated]
	// RVA: 0x364555C Offset: 0x364155C VA: 0x364555C
	public void set_AppendData(ActionAppendData value) { }

	// RVA: 0x3645564 Offset: 0x3641564 VA: 0x3645564 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x364556C Offset: 0x364156C VA: 0x364556C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x364575C Offset: 0x364175C VA: 0x364575C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
