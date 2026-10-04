// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.Boss
public class CheckRaidBossSymbolResponse : OperationResponseBase // TypeDefIndex: 11781
{
	// Fields
	[CompilerGenerated]
	private BossSymbolData <BossSymbolData>k__BackingField; // 0x20
	[CompilerGenerated]
	private MonsterDropDetailData[] <DetailDatas>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomLobbySetting <Setting>k__BackingField; // 0x30
	[CompilerGenerated]
	private RoomMemberData[] <Members>k__BackingField; // 0x38

	// Properties
	public BossSymbolData BossSymbolData { get; set; }
	public MonsterDropDetailData[] DetailDatas { get; set; }
	public RoomLobbySetting Setting { get; set; }
	public RoomMemberData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3749630 Offset: 0x3745630 VA: 0x3749630
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3749638 Offset: 0x3745638 VA: 0x3749638
	public BossSymbolData get_BossSymbolData() { }

	[CompilerGenerated]
	// RVA: 0x3749640 Offset: 0x3745640 VA: 0x3749640
	public void set_BossSymbolData(BossSymbolData value) { }

	[CompilerGenerated]
	// RVA: 0x3749648 Offset: 0x3745648 VA: 0x3749648
	public MonsterDropDetailData[] get_DetailDatas() { }

	[CompilerGenerated]
	// RVA: 0x3749650 Offset: 0x3745650 VA: 0x3749650
	public void set_DetailDatas(MonsterDropDetailData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3749658 Offset: 0x3745658 VA: 0x3749658
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3749660 Offset: 0x3745660 VA: 0x3749660
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x3749668 Offset: 0x3745668 VA: 0x3749668
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3749670 Offset: 0x3745670 VA: 0x3749670
	public void set_Members(RoomMemberData[] value) { }

	// RVA: 0x3749678 Offset: 0x3745678 VA: 0x3749678 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3749680 Offset: 0x3745680 VA: 0x3749680 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3749688 Offset: 0x3745688 VA: 0x3749688 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3749A1C Offset: 0x3745A1C VA: 0x3749A1C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
