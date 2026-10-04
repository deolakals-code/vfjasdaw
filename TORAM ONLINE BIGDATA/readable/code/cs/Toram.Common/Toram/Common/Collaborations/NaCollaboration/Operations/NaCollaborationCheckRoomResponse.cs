// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NaCollaboration.Operations
public class NaCollaborationCheckRoomResponse : OperationResponseBase // TypeDefIndex: 13085
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
	[CompilerGenerated]
	private byte <SpecialRewardState>k__BackingField; // 0x41
	[CompilerGenerated]
	private byte[] <WeaponStack>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <NextResetTimeLeft>k__BackingField; // 0x50

	// Properties
	public BossSymbolData BossSymbolData { get; set; }
	public MonsterDropDetailData[] DetailDatas { get; set; }
	public RoomLobbySetting Setting { get; set; }
	public RoomMemberData[] Members { get; set; }
	public byte PointBoost { get; set; }
	public byte SpecialRewardState { get; set; }
	public byte[] WeaponStack { get; set; }
	public int NextResetTimeLeft { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x36A00D4 Offset: 0x369C0D4 VA: 0x36A00D4
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36A00DC Offset: 0x369C0DC VA: 0x36A00DC
	public BossSymbolData get_BossSymbolData() { }

	[CompilerGenerated]
	// RVA: 0x36A00E4 Offset: 0x369C0E4 VA: 0x36A00E4
	public void set_BossSymbolData(BossSymbolData value) { }

	[CompilerGenerated]
	// RVA: 0x36A00EC Offset: 0x369C0EC VA: 0x36A00EC
	public MonsterDropDetailData[] get_DetailDatas() { }

	[CompilerGenerated]
	// RVA: 0x36A00F4 Offset: 0x369C0F4 VA: 0x36A00F4
	public void set_DetailDatas(MonsterDropDetailData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A00FC Offset: 0x369C0FC VA: 0x36A00FC
	public RoomLobbySetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x36A0104 Offset: 0x369C104 VA: 0x36A0104
	public void set_Setting(RoomLobbySetting value) { }

	[CompilerGenerated]
	// RVA: 0x36A010C Offset: 0x369C10C VA: 0x36A010C
	public RoomMemberData[] get_Members() { }

	[CompilerGenerated]
	// RVA: 0x36A0114 Offset: 0x369C114 VA: 0x36A0114
	public void set_Members(RoomMemberData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A011C Offset: 0x369C11C VA: 0x36A011C
	public byte get_PointBoost() { }

	[CompilerGenerated]
	// RVA: 0x36A0124 Offset: 0x369C124 VA: 0x36A0124
	public void set_PointBoost(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A012C Offset: 0x369C12C VA: 0x36A012C
	public byte get_SpecialRewardState() { }

	[CompilerGenerated]
	// RVA: 0x36A0134 Offset: 0x369C134 VA: 0x36A0134
	public void set_SpecialRewardState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36A013C Offset: 0x369C13C VA: 0x36A013C
	public byte[] get_WeaponStack() { }

	[CompilerGenerated]
	// RVA: 0x36A0144 Offset: 0x369C144 VA: 0x36A0144
	public void set_WeaponStack(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x36A014C Offset: 0x369C14C VA: 0x36A014C
	public int get_NextResetTimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x36A0154 Offset: 0x369C154 VA: 0x36A0154
	public void set_NextResetTimeLeft(int value) { }

	// RVA: 0x36A015C Offset: 0x369C15C VA: 0x36A015C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36A0164 Offset: 0x369C164 VA: 0x36A0164 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36A016C Offset: 0x369C16C VA: 0x36A016C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36A064C Offset: 0x369C64C VA: 0x36A064C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
