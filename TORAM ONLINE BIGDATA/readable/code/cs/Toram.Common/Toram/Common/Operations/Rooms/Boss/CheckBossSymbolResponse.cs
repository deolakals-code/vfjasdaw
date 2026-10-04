// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Boss
public class CheckBossSymbolResponse : PacketBase // TypeDefIndex: 11783
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private BossSymbolData <BossSymbolData>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomSetting <RoomSetting>k__BackingField; // 0x30
	[CompilerGenerated]
	private RoomGroupSetting <GroupSetting>k__BackingField; // 0x38
	[CompilerGenerated]
	private RoomGroupMemberStateData[] <Members>k__BackingField; // 0x40
	[CompilerGenerated]
	private MonsterDropDetailData[] <DetailDatas>k__BackingField; // 0x48

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketClass(Code = 182, IsOptional = True)]
	public BossSymbolData BossSymbolData { get; set; }
	[PacketClass(Code = 187, IsOptional = True)]
	public RoomSetting RoomSetting { get; set; }
	[PacketClass(Code = 188, IsOptional = True)]
	public RoomGroupSetting GroupSetting { get; set; }
	[PacketClass(Code = 95, IsOptional = True)]
	public RoomGroupMemberStateData[] Members { get; set; }
	[PacketClass(Code = 132, IsOptional = True)]
	public MonsterDropDetailData[] DetailDatas { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x374A018 Offset: 0x3746018 VA: 0x374A018
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x374A020 Offset: 0x3746020 VA: 0x374A020
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x374A028 Offset: 0x3746028 VA: 0x374A028
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x374A030 Offset: 0x3746030 VA: 0x374A030
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x374A038 Offset: 0x3746038 VA: 0x374A038
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x374A040 Offset: 0x3746040 VA: 0x374A040
	public BossSymbolData get_BossSymbolData() { }

	[CompilerGenerated]
	// RVA: 0x374A048 Offset: 0x3746048 VA: 0x374A048
	public void set_BossSymbolData(BossSymbolData value) { }

	[CompilerGenerated]
	// RVA: 0x374A050 Offset: 0x3746050 VA: 0x374A050
	public RoomSetting get_RoomSetting() { }

	[CompilerGenerated]
	// RVA: 0x374A058 Offset: 0x3746058 VA: 0x374A058
	public void set_RoomSetting(RoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x374A060 Offset: 0x3746060 VA: 0x374A060
	public RoomGroupSetting get_GroupSetting() { }

	[CompilerGenerated]
	// RVA: 0x374A068 Offset: 0x3746068 VA: 0x374A068
	public void set_GroupSetting(RoomGroupSetting value) { }

	[CompilerGenerated]
	// RVA: 0x374A070 Offset: 0x3746070 VA: 0x374A070
	public RoomGroupMemberStateData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x374A078 Offset: 0x3746078 VA: 0x374A078
	public void set_Members(RoomGroupMemberStateData[] value) { }

	[CompilerGenerated]
	// RVA: 0x374A080 Offset: 0x3746080 VA: 0x374A080
	public MonsterDropDetailData[] get_DetailDatas() { }

	[CompilerGenerated]
	// RVA: 0x374A088 Offset: 0x3746088 VA: 0x374A088
	public void set_DetailDatas(MonsterDropDetailData[] value) { }

	// RVA: 0x374A090 Offset: 0x3746090 VA: 0x374A090
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374A434 Offset: 0x3746434 VA: 0x374A434
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x374A580 Offset: 0x3746580 VA: 0x374A580 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374A588 Offset: 0x3746588 VA: 0x374A588 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x374A710 Offset: 0x3746710 VA: 0x374A710 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
