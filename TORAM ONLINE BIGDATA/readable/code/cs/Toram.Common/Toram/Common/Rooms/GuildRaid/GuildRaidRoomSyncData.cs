// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.GuildRaid
public class GuildRaidRoomSyncData : RoomSyncDataBase // TypeDefIndex: 11340
{
	// Fields
	[CompilerGenerated]
	private GuildRaidRandomPropertyData[] <RandomPropertyList>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <StartHpCount>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <MaxHpCount>k__BackingField; // 0x31
	[CompilerGenerated]
	private int <LeftTime>k__BackingField; // 0x34
	[CompilerGenerated]
	private bool <IsEscapVote>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <CurrentHpCount>k__BackingField; // 0x39

	// Properties
	[UnityHash(Code = 15)]
	public GuildRaidRandomPropertyData[] RandomPropertyList { get; set; }
	[UnityHash(Code = 10)]
	public byte StartHpCount { get; set; }
	[UnityHash(Code = 11)]
	public byte MaxHpCount { get; set; }
	[UnityHash(Code = 12)]
	public int LeftTime { get; set; }
	[UnityHash(Code = 13)]
	public bool IsEscapVote { get; set; }
	[UnityHash(Code = 14)]
	public byte CurrentHpCount { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x36EE394 Offset: 0x36EA394 VA: 0x36EE394
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36EE39C Offset: 0x36EA39C VA: 0x36EE39C
	public GuildRaidRandomPropertyData[] get_RandomPropertyList() { }

	[CompilerGenerated]
	// RVA: 0x36EE3A4 Offset: 0x36EA3A4 VA: 0x36EE3A4
	public void set_RandomPropertyList(GuildRaidRandomPropertyData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36EE3AC Offset: 0x36EA3AC VA: 0x36EE3AC
	public byte get_StartHpCount() { }

	[CompilerGenerated]
	// RVA: 0x36EE3B4 Offset: 0x36EA3B4 VA: 0x36EE3B4
	public void set_StartHpCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36EE3BC Offset: 0x36EA3BC VA: 0x36EE3BC
	public byte get_MaxHpCount() { }

	[CompilerGenerated]
	// RVA: 0x36EE3C4 Offset: 0x36EA3C4 VA: 0x36EE3C4
	public void set_MaxHpCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36EE3CC Offset: 0x36EA3CC VA: 0x36EE3CC
	public int get_LeftTime() { }

	[CompilerGenerated]
	// RVA: 0x36EE3D4 Offset: 0x36EA3D4 VA: 0x36EE3D4
	public void set_LeftTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x36EE3DC Offset: 0x36EA3DC VA: 0x36EE3DC
	public bool get_IsEscapVote() { }

	[CompilerGenerated]
	// RVA: 0x36EE3E4 Offset: 0x36EA3E4 VA: 0x36EE3E4
	public void set_IsEscapVote(bool value) { }

	[CompilerGenerated]
	// RVA: 0x36EE3F0 Offset: 0x36EA3F0 VA: 0x36EE3F0
	public byte get_CurrentHpCount() { }

	[CompilerGenerated]
	// RVA: 0x36EE3F8 Offset: 0x36EA3F8 VA: 0x36EE3F8
	public void set_CurrentHpCount(byte value) { }

	// RVA: 0x36EE400 Offset: 0x36EA400 VA: 0x36EE400 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36EE408 Offset: 0x36EA408 VA: 0x36EE408 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36EE7E0 Offset: 0x36EA7E0 VA: 0x36EE7E0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
