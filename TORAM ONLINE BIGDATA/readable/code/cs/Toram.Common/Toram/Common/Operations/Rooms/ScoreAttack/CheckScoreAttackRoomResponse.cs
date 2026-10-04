// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Rooms.ScoreAttack
public class CheckScoreAttackRoomResponse : OperationResponseBase // TypeDefIndex: 11800
{
	// Fields
	[CompilerGenerated]
	private BossSymbolData <BossSymbolData>k__BackingField; // 0x20
	[CompilerGenerated]
	private RoomLobbySetting <Setting>k__BackingField; // 0x28
	[CompilerGenerated]
	private RoomMemberData[] <Members>k__BackingField; // 0x30

	// Properties
	public BossSymbolData BossSymbolData { get; set; }
	public RoomLobbySetting Setting { get; set; }
	public RoomMemberData[] Members { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x374E2BC Offset: 0x374A2BC VA: 0x374E2BC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x374E2C4 Offset: 0x374A2C4 VA: 0x374E2C4
	public BossSymbolData get_BossSymbolData() { }

	[CompilerGenerated]
	// RVA: 0x374E2CC Offset: 0x374A2CC VA: 0x374E2CC
	public void set_BossSymbolData(BossSymbolData value) { }

	[CompilerGenerated]
	// RVA: 0x374E2D4 Offset: 0x374A2D4 VA: 0x374E2D4
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x374E2DC Offset: 0x374A2DC VA: 0x374E2DC
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x374E2E4 Offset: 0x374A2E4 VA: 0x374E2E4
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x374E2EC Offset: 0x374A2EC VA: 0x374E2EC
	public void set_Members(RoomMemberData[] value) { }

	// RVA: 0x374E2F4 Offset: 0x374A2F4 VA: 0x374E2F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x374E2FC Offset: 0x374A2FC VA: 0x374E2FC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x374E304 Offset: 0x374A304 VA: 0x374E304 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x374E3EC Offset: 0x374A3EC VA: 0x374E3EC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
