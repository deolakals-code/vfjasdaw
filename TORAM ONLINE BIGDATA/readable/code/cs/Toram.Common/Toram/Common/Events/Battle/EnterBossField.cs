// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Battle
public class EnterBossField : PacketBase // TypeDefIndex: 12714
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private RoomSetting <RoomSetting>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <DifficultyLevel>k__BackingField; // 0x30
	[CompilerGenerated]
	private BossFieldSettingData <BossFieldSettingData>k__BackingField; // 0x38
	[CompilerGenerated]
	private MobResponseData[] <MobList>k__BackingField; // 0x40
	[CompilerGenerated]
	private int[] <NpcPopIdList>k__BackingField; // 0x48

	// Properties
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 187)]
	public RoomSetting RoomSetting { get; set; }
	[PacketClass(Code = 240, IsOptional = True)]
	public short DifficultyLevel { get; set; }
	[PacketClass(Code = 139, IsOptional = True)]
	public BossFieldSettingData BossFieldSettingData { get; set; }
	[PacketClass(Code = 89, IsOptional = True)]
	public MobResponseData[] MobList { get; set; }
	[PacketParameter(Code = 213, IsOptional = True)]
	public int[] NpcPopIdList { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x364807C Offset: 0x364407C VA: 0x364807C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3648084 Offset: 0x3644084 VA: 0x3648084
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x364808C Offset: 0x364408C VA: 0x364808C
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x3648094 Offset: 0x3644094 VA: 0x3648094
	public RoomSetting get_RoomSetting() { }

	[CompilerGenerated]
	// RVA: 0x364809C Offset: 0x364409C VA: 0x364809C
	public void set_RoomSetting(RoomSetting value) { }

	[CompilerGenerated]
	// RVA: 0x36480A4 Offset: 0x36440A4 VA: 0x36480A4
	public short get_DifficultyLevel() { }

	[CompilerGenerated]
	// RVA: 0x36480AC Offset: 0x36440AC VA: 0x36480AC
	public void set_DifficultyLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x36480B4 Offset: 0x36440B4 VA: 0x36480B4
	public BossFieldSettingData get_BossFieldSettingData() { }

	[CompilerGenerated]
	// RVA: 0x36480BC Offset: 0x36440BC VA: 0x36480BC
	public void set_BossFieldSettingData(BossFieldSettingData value) { }

	[CompilerGenerated]
	// RVA: 0x36480C4 Offset: 0x36440C4 VA: 0x36480C4
	public MobResponseData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x36480CC Offset: 0x36440CC VA: 0x36480CC
	public void set_MobList(MobResponseData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36480D4 Offset: 0x36440D4 VA: 0x36480D4
	public int[] get_NpcPopIdList() { }

	[CompilerGenerated]
	// RVA: 0x36480DC Offset: 0x36440DC VA: 0x36480DC
	public void set_NpcPopIdList(int[] value) { }

	// RVA: 0x36480E4 Offset: 0x36440E4 VA: 0x36480E4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x364834C Offset: 0x364434C VA: 0x364834C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3648430 Offset: 0x3644430 VA: 0x3648430 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3648438 Offset: 0x3644438 VA: 0x3648438 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3648678 Offset: 0x3644678 VA: 0x3648678 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
