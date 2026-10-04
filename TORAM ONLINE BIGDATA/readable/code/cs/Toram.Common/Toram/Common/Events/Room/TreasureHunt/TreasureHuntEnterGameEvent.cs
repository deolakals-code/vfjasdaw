// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.TreasureHunt
public class TreasureHuntEnterGameEvent : EventSubBase // TypeDefIndex: 12791
{
	// Fields
	[CompilerGenerated]
	private RaidRoomSetting <Setting>k__BackingField; // 0x20
	[CompilerGenerated]
	private BossFieldSettingData <BossFieldSettingData>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte[] <TreasureHuntData>k__BackingField; // 0x30
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x38
	[CompilerGenerated]
	private TreasureHuntTreasureData[] <TreasureList>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <TimeLeft>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsGameEnd>k__BackingField; // 0x4C

	// Properties
	[PacketClass(Code = 29, IsOptional = True)]
	public RaidRoomSetting Setting { get; set; }
	[PacketClass(Code = 30, IsOptional = True)]
	public BossFieldSettingData BossFieldSettingData { get; set; }
	[PacketClass(Code = 31, IsOptional = True)]
	public byte[] TreasureHuntData { get; set; }
	[PacketClass(Code = 15, IsOptional = True)]
	public MobResponseData[] MobList { get; set; }
	[PacketClass(Code = 16, IsOptional = True)]
	public TreasureHuntTreasureData[] TreasureList { get; set; }
	[PacketClass(Code = 28, IsOptional = True)]
	public int TimeLeft { get; set; }
	[PacketClass(Code = 20, IsOptional = True)]
	public bool IsGameEnd { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3659B5C Offset: 0x3655B5C VA: 0x3659B5C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3659B64 Offset: 0x3655B64 VA: 0x3659B64
	public RaidRoomSetting get_Setting() { }

	[CompilerGenerated]
	// RVA: 0x3659B6C Offset: 0x3655B6C VA: 0x3659B6C
	public void set_Setting(RaidRoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x3659B74 Offset: 0x3655B74 VA: 0x3659B74
	public BossFieldSettingData get_BossFieldSettingData() { }

	[CompilerGenerated]
	// RVA: 0x3659B7C Offset: 0x3655B7C VA: 0x3659B7C
	public void set_BossFieldSettingData(BossFieldSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x3659B84 Offset: 0x3655B84 VA: 0x3659B84
	public byte[] get_TreasureHuntData() { }

	[CompilerGenerated]
	// RVA: 0x3659B8C Offset: 0x3655B8C VA: 0x3659B8C
	public void set_TreasureHuntData(byte[] value) { }

	[CompilerGenerated]
	// RVA: 0x3659B94 Offset: 0x3655B94 VA: 0x3659B94
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x3659B9C Offset: 0x3655B9C VA: 0x3659B9C
	public void set_MobList(MobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3659BA4 Offset: 0x3655BA4 VA: 0x3659BA4
	public TreasureHuntTreasureData[] get_TreasureList() { }

	[CompilerGenerated]
	// RVA: 0x3659BAC Offset: 0x3655BAC VA: 0x3659BAC
	public void set_TreasureList(TreasureHuntTreasureData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3659BB4 Offset: 0x3655BB4 VA: 0x3659BB4
	public int get_TimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x3659BBC Offset: 0x3655BBC VA: 0x3659BBC
	public void set_TimeLeft(int value) { }

	[CompilerGenerated]
	// RVA: 0x3659BC4 Offset: 0x3655BC4 VA: 0x3659BC4
	public bool get_IsGameEnd() { }

	[CompilerGenerated]
	// RVA: 0x3659BCC Offset: 0x3655BCC VA: 0x3659BCC
	public void set_IsGameEnd(bool value) { }

	// RVA: 0x3659BD8 Offset: 0x3655BD8 VA: 0x3659BD8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3659BE0 Offset: 0x3655BE0 VA: 0x3659BE0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3659BE8 Offset: 0x3655BE8 VA: 0x3659BE8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3659DB4 Offset: 0x3655DB4 VA: 0x3659DB4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
