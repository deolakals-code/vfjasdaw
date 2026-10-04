// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Events
public class BCollaborationEnterField : EventSubBase // TypeDefIndex: 13075
{
	// Fields
	[CompilerGenerated]
	private int <TeamId>k__BackingField; // 0x20
	[CompilerGenerated]
	private RaidRoomSetting <Setting>k__BackingField; // 0x28
	[CompilerGenerated]
	private BossFieldSettingData <BossFieldSettingData>k__BackingField; // 0x30
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <CurrentHpCount>k__BackingField; // 0x40
	[CompilerGenerated]
	private short <Level>k__BackingField; // 0x42

	// Properties
	[PacketClass(Code = 200)]
	public int TeamId { get; set; }
	[PacketClass(Code = 187)]
	public RaidRoomSetting Setting { get; set; }
	[PacketClass(Code = 139)]
	public BossFieldSettingData BossFieldSettingData { get; set; }
	[PacketClass(Code = 89)]
	public MobResponseData[] MobList { get; set; }
	public byte CurrentHpCount { get; set; }
	public short Level { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x369D528 Offset: 0x3699528 VA: 0x369D528
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x369D530 Offset: 0x3699530 VA: 0x369D530
	public int get_TeamId() { }

	[CompilerGenerated]
	// RVA: 0x369D538 Offset: 0x3699538 VA: 0x369D538
	public void set_TeamId(int value) { }

	[CompilerGenerated]
	// RVA: 0x369D540 Offset: 0x3699540 VA: 0x369D540
	public RaidRoomSetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x369D548 Offset: 0x3699548 VA: 0x369D548
	public void set_Setting(RaidRoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x369D550 Offset: 0x3699550 VA: 0x369D550
	public BossFieldSettingData get_BossFieldSettingData() { }

	[CompilerGenerated]
	// RVA: 0x369D558 Offset: 0x3699558 VA: 0x369D558
	public void set_BossFieldSettingData(BossFieldSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x369D560 Offset: 0x3699560 VA: 0x369D560
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x369D568 Offset: 0x3699568 VA: 0x369D568
	public void set_MobList(MobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x369D570 Offset: 0x3699570 VA: 0x369D570
	public byte get_CurrentHpCount() { }

	[CompilerGenerated]
	// RVA: 0x369D578 Offset: 0x3699578 VA: 0x369D578
	public void set_CurrentHpCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x369D580 Offset: 0x3699580 VA: 0x369D580
	public short get_Level() { }

	[CompilerGenerated]
	// RVA: 0x369D588 Offset: 0x3699588 VA: 0x369D588
	public void set_Level(short value) { }

	// RVA: 0x369D590 Offset: 0x3699590 VA: 0x369D590 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369D598 Offset: 0x3699598 VA: 0x369D598 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x369D5A0 Offset: 0x36995A0 VA: 0x369D5A0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x369D748 Offset: 0x3699748 VA: 0x369D748 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
