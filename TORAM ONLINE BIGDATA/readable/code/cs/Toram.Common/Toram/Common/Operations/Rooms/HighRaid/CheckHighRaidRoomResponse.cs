// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.HighRaid
public class CheckHighRaidRoomResponse : OperationResponseBase // TypeDefIndex: 11789
{
	// Fields
	[CompilerGenerated]
	private BossSymbolData <BossSymbolData>k__BackingField; // 0x20
	[CompilerGenerated]
	private HighRaidMonsterDropDetailData[] <DetailDatas>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomLobbySetting <Setting>k__BackingField; // 0x30
	[CompilerGenerated]
	private RoomMemberData[] <Members>k__BackingField; // 0x38

	// Properties
	public BossSymbolData BossSymbolData { get; set; }
	public HighRaidMonsterDropDetailData[] DetailDatas { get; set; }
	public RoomLobbySetting Setting { get; set; }
	public RoomMemberData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374BB24 Offset: 0x3747B24 VA: 0x374BB24
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x374BB2C Offset: 0x3747B2C VA: 0x374BB2C
	public BossSymbolData get_BossSymbolData() { }

	[CompilerGenerated]
	// RVA: 0x374BB34 Offset: 0x3747B34 VA: 0x374BB34
	public void set_BossSymbolData(BossSymbolData value) { }

	[CompilerGenerated]
	// RVA: 0x374BB3C Offset: 0x3747B3C VA: 0x374BB3C
	public HighRaidMonsterDropDetailData[] get_DetailDatas() { }

	[CompilerGenerated]
	// RVA: 0x374BB44 Offset: 0x3747B44 VA: 0x374BB44
	public void set_DetailDatas(HighRaidMonsterDropDetailData[] value) { }

	[CompilerGenerated]
	// RVA: 0x374BB4C Offset: 0x3747B4C VA: 0x374BB4C
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x374BB54 Offset: 0x3747B54 VA: 0x374BB54
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x374BB5C Offset: 0x3747B5C VA: 0x374BB5C
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x374BB64 Offset: 0x3747B64 VA: 0x374BB64
	public void set_Members(RoomMemberData[] value) { }

	// RVA: 0x374BB6C Offset: 0x3747B6C VA: 0x374BB6C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374BB74 Offset: 0x3747B74 VA: 0x374BB74 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374BB7C Offset: 0x3747B7C VA: 0x374BB7C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x374BCA8 Offset: 0x3747CA8 VA: 0x374BCA8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
