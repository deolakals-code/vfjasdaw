// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NCollaboration.Operations
public class CheckNCollaborationRoomResponse : OperationResponseBase // TypeDefIndex: 13042
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
	[CompilerGenerated]
	private byte <PointBoost>k__BackingField; // 0x40

	// Properties
	public BossSymbolData BossSymbolData { get; set; }
	public MonsterDropDetailData[] DetailDatas { get; set; }
	public RoomLobbySetting Setting { get; set; }
	public RoomMemberData[] Members { get; set; }
	public byte PointBoost { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3694FD4 Offset: 0x3690FD4 VA: 0x3694FD4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3694FDC Offset: 0x3690FDC VA: 0x3694FDC
	public BossSymbolData get_BossSymbolData() { }

	[CompilerGenerated]
	// RVA: 0x3694FE4 Offset: 0x3690FE4 VA: 0x3694FE4
	public void set_BossSymbolData(BossSymbolData value) { }

	[CompilerGenerated]
	// RVA: 0x3694FEC Offset: 0x3690FEC VA: 0x3694FEC
	public MonsterDropDetailData[] get_DetailDatas() { }

	[CompilerGenerated]
	// RVA: 0x3694FF4 Offset: 0x3690FF4 VA: 0x3694FF4
	public void set_DetailDatas(MonsterDropDetailData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3694FFC Offset: 0x3690FFC VA: 0x3694FFC
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3695004 Offset: 0x3691004 VA: 0x3695004
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x369500C Offset: 0x369100C VA: 0x369500C
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x3695014 Offset: 0x3691014 VA: 0x3695014
	public void set_Members(RoomMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x369501C Offset: 0x369101C VA: 0x369501C
	public byte get_PointBoost() { }

	[CompilerGenerated]
	// RVA: 0x3695024 Offset: 0x3691024 VA: 0x3695024
	public void set_PointBoost(byte value) { }

	// RVA: 0x369502C Offset: 0x369102C VA: 0x369502C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3695034 Offset: 0x3691034 VA: 0x3695034 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x369503C Offset: 0x369103C VA: 0x369503C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3695410 Offset: 0x3691410 VA: 0x3695410 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
