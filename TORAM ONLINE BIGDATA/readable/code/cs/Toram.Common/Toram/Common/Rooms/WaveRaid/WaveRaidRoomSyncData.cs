// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.WaveRaid
public class WaveRaidRoomSyncData : RoomSyncDataBase // TypeDefIndex: 11314
{
	// Fields
	[CompilerGenerated]
	private WaveMobData[] <MobList>k__BackingField; // 0x28
	[CompilerGenerated]
	private WaveTargetData[] <TargetList>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <GameState>k__BackingField; // 0x38
	[CompilerGenerated]
	private long <StartTime>k__BackingField; // 0x40
	[CompilerGenerated]
	private long <EndTime>k__BackingField; // 0x48
	[CompilerGenerated]
	private long <TimeLeft>k__BackingField; // 0x50
	[CompilerGenerated]
	private short[] <PopMaxIds>k__BackingField; // 0x58
	[CompilerGenerated]
	private short <Retval>k__BackingField; // 0x60

	// Properties
	[UnityHash(Code = 89, IsOptional = True)]
	public WaveMobData[] MobList { get; set; }
	[UnityHash(Code = 186, IsOptional = True)]
	public WaveTargetData[] TargetList { get; set; }
	[UnityHash(Code = 44)]
	public byte GameState { get; set; }
	[UnityHash(Code = 172)]
	public long StartTime { get; set; }
	[UnityHash(Code = 189)]
	public long EndTime { get; set; }
	[UnityHash(Code = 190)]
	public long TimeLeft { get; set; }
	[UnityHash(Code = 185, IsOptional = True)]
	public short[] PopMaxIds { get; set; }
	[UnityHash(Code = 195, IsOptional = True)]
	public short Retval { get; set; }
	public override byte Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36DDBBC Offset: 0x36D9BBC VA: 0x36DDBBC
	public WaveMobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x36DDBC4 Offset: 0x36D9BC4 VA: 0x36DDBC4
	public void set_MobList(WaveMobData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36DDBCC Offset: 0x36D9BCC VA: 0x36DDBCC
	public WaveTargetData[] get_TargetList() { }

	[CompilerGenerated]
	// RVA: 0x36DDBD4 Offset: 0x36D9BD4 VA: 0x36DDBD4
	public void set_TargetList(WaveTargetData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36DDBDC Offset: 0x36D9BDC VA: 0x36DDBDC
	public byte get_GameState() { }

	[CompilerGenerated]
	// RVA: 0x36DDBE4 Offset: 0x36D9BE4 VA: 0x36DDBE4
	public void set_GameState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DDBEC Offset: 0x36D9BEC VA: 0x36DDBEC
	public long get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x36DDBF4 Offset: 0x36D9BF4 VA: 0x36DDBF4
	public void set_StartTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x36DDBFC Offset: 0x36D9BFC VA: 0x36DDBFC
	public long get_EndTime() { }

	[CompilerGenerated]
	// RVA: 0x36DDC04 Offset: 0x36D9C04 VA: 0x36DDC04
	public void set_EndTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x36DDC0C Offset: 0x36D9C0C VA: 0x36DDC0C
	public long get_TimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x36DDC14 Offset: 0x36D9C14 VA: 0x36DDC14
	public void set_TimeLeft(long value) { }

	[CompilerGenerated]
	// RVA: 0x36DDC1C Offset: 0x36D9C1C VA: 0x36DDC1C
	public short[] get_PopMaxIds() { }

	[CompilerGenerated]
	// RVA: 0x36DDC24 Offset: 0x36D9C24 VA: 0x36DDC24
	public void set_PopMaxIds(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36DDC2C Offset: 0x36D9C2C VA: 0x36DDC2C
	public short get_Retval() { }

	[CompilerGenerated]
	// RVA: 0x36DDC34 Offset: 0x36D9C34 VA: 0x36DDC34
	public void set_Retval(short value) { }

	// RVA: 0x36DDC3C Offset: 0x36D9C3C VA: 0x36DDC3C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36DDC44 Offset: 0x36D9C44 VA: 0x36DDC44
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36DDC4C Offset: 0x36D9C4C VA: 0x36DDC4C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36DE1E4 Offset: 0x36DA1E4 VA: 0x36DE1E4 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36DDF48 Offset: 0x36D9F48 VA: 0x36DDF48
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36DE3DC Offset: 0x36DA3DC VA: 0x36DE3DC
	private void GetClass(Dictionary<object, object> parameters) { }
}
