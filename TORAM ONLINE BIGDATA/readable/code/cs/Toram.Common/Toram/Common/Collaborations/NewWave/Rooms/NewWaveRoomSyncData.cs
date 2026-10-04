// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NewWave.Rooms
public class NewWaveRoomSyncData : RoomSyncDataBase // TypeDefIndex: 13044
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
	[CompilerGenerated]
	private byte <SpotlightPattern>k__BackingField; // 0x62
	[CompilerGenerated]
	private int <NowWaveId>k__BackingField; // 0x64
	[CompilerGenerated]
	private NewWaveGameEndEvent <GameResult>k__BackingField; // 0x68

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
	public byte SpotlightPattern { get; set; }
	public int NowWaveId { get; set; }
	public NewWaveGameEndEvent GameResult { get; set; }
	public override byte Code { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x36959C4 Offset: 0x36919C4 VA: 0x36959C4
	public WaveMobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x36959CC Offset: 0x36919CC VA: 0x36959CC
	public void set_MobList(WaveMobData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36959D4 Offset: 0x36919D4 VA: 0x36959D4
	public WaveTargetData[] get_TargetList() { }

	[CompilerGenerated]
	// RVA: 0x36959DC Offset: 0x36919DC VA: 0x36959DC
	public void set_TargetList(WaveTargetData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36959E4 Offset: 0x36919E4 VA: 0x36959E4
	public byte get_GameState() { }

	[CompilerGenerated]
	// RVA: 0x36959EC Offset: 0x36919EC VA: 0x36959EC
	public void set_GameState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36959F4 Offset: 0x36919F4 VA: 0x36959F4
	public long get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x36959FC Offset: 0x36919FC VA: 0x36959FC
	public void set_StartTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x3695A04 Offset: 0x3691A04 VA: 0x3695A04
	public long get_EndTime() { }

	[CompilerGenerated]
	// RVA: 0x3695A0C Offset: 0x3691A0C VA: 0x3695A0C
	public void set_EndTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x3695A14 Offset: 0x3691A14 VA: 0x3695A14
	public long get_TimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x3695A1C Offset: 0x3691A1C VA: 0x3695A1C
	public void set_TimeLeft(long value) { }

	[CompilerGenerated]
	// RVA: 0x3695A24 Offset: 0x3691A24 VA: 0x3695A24
	public short[] get_PopMaxIds() { }

	[CompilerGenerated]
	// RVA: 0x3695A2C Offset: 0x3691A2C VA: 0x3695A2C
	public void set_PopMaxIds(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3695A34 Offset: 0x3691A34 VA: 0x3695A34
	public short get_Retval() { }

	[CompilerGenerated]
	// RVA: 0x3695A3C Offset: 0x3691A3C VA: 0x3695A3C
	public void set_Retval(short value) { }

	[CompilerGenerated]
	// RVA: 0x3695A44 Offset: 0x3691A44 VA: 0x3695A44
	public byte get_SpotlightPattern() { }

	[CompilerGenerated]
	// RVA: 0x3695A4C Offset: 0x3691A4C VA: 0x3695A4C
	public void set_SpotlightPattern(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3695A54 Offset: 0x3691A54 VA: 0x3695A54
	public int get_NowWaveId() { }

	[CompilerGenerated]
	// RVA: 0x3695A5C Offset: 0x3691A5C VA: 0x3695A5C
	public void set_NowWaveId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3695A64 Offset: 0x3691A64 VA: 0x3695A64
	public NewWaveGameEndEvent get_GameResult() { }

	[CompilerGenerated]
	// RVA: 0x3695A6C Offset: 0x3691A6C VA: 0x3695A6C
	public void set_GameResult(NewWaveGameEndEvent value) { }

	// RVA: 0x3695A74 Offset: 0x3691A74 VA: 0x3695A74 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3695A7C Offset: 0x3691A7C VA: 0x3695A7C
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x3695A84 Offset: 0x3691A84 VA: 0x3695A84 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x3696248 Offset: 0x3692248 VA: 0x3696248 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x3695EC4 Offset: 0x3691EC4 VA: 0x3695EC4
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36964E0 Offset: 0x36924E0 VA: 0x36964E0
	private void GetClass(Dictionary<object, object> parameters) { }
}
