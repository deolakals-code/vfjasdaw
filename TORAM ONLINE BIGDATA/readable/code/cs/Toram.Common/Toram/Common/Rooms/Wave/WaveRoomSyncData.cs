// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Rooms.Wave
public class WaveRoomSyncData : RoomSyncDataBase // TypeDefIndex: 11311
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
	// RVA: 0x36DC9B0 Offset: 0x36D89B0 VA: 0x36DC9B0
	public WaveMobData[] get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x36DC9B8 Offset: 0x36D89B8 VA: 0x36DC9B8
	public void set_MobList(WaveMobData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36DC9C0 Offset: 0x36D89C0 VA: 0x36DC9C0
	public WaveTargetData[] get_TargetList() { }

	[CompilerGenerated]
	// RVA: 0x36DC9C8 Offset: 0x36D89C8 VA: 0x36DC9C8
	public void set_TargetList(WaveTargetData[] value) { }

	[CompilerGenerated]
	// RVA: 0x36DC9D0 Offset: 0x36D89D0 VA: 0x36DC9D0
	public byte get_GameState() { }

	[CompilerGenerated]
	// RVA: 0x36DC9D8 Offset: 0x36D89D8 VA: 0x36DC9D8
	public void set_GameState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36DC9E0 Offset: 0x36D89E0 VA: 0x36DC9E0
	public long get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x36DC9E8 Offset: 0x36D89E8 VA: 0x36DC9E8
	public void set_StartTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x36DC9F0 Offset: 0x36D89F0 VA: 0x36DC9F0
	public long get_EndTime() { }

	[CompilerGenerated]
	// RVA: 0x36DC9F8 Offset: 0x36D89F8 VA: 0x36DC9F8
	public void set_EndTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x36DCA00 Offset: 0x36D8A00 VA: 0x36DCA00
	public long get_TimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x36DCA08 Offset: 0x36D8A08 VA: 0x36DCA08
	public void set_TimeLeft(long value) { }

	[CompilerGenerated]
	// RVA: 0x36DCA10 Offset: 0x36D8A10 VA: 0x36DCA10
	public short[] get_PopMaxIds() { }

	[CompilerGenerated]
	// RVA: 0x36DCA18 Offset: 0x36D8A18 VA: 0x36DCA18
	public void set_PopMaxIds(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x36DCA20 Offset: 0x36D8A20 VA: 0x36DCA20
	public short get_Retval() { }

	[CompilerGenerated]
	// RVA: 0x36DCA28 Offset: 0x36D8A28 VA: 0x36DCA28
	public void set_Retval(short value) { }

	// RVA: 0x36DCA30 Offset: 0x36D8A30 VA: 0x36DCA30 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36DCA38 Offset: 0x36D8A38 VA: 0x36DCA38
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x36DCA40 Offset: 0x36D8A40 VA: 0x36DCA40 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36DCFD8 Offset: 0x36D8FD8 VA: 0x36DCFD8 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x36DCD3C Offset: 0x36D8D3C VA: 0x36DCD3C
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x36DD1D0 Offset: 0x36D91D0 VA: 0x36DD1D0
	private void GetClass(Dictionary<object, object> parameters) { }
}
