// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NewWave.Events
public class NewWaveGameStartEvent : EventSubBase // TypeDefIndex: 13050
{
	// Fields
	[CompilerGenerated]
	private byte <GameState>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <StartTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <EndTime>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketClass(Code = 43)]
	public byte GameState { get; set; }
	[PacketClass(Code = 172)]
	public long StartTime { get; set; }
	[PacketClass(Code = 189)]
	public long EndTime { get; set; }

	// Methods

	// RVA: 0x3697F1C Offset: 0x3693F1C VA: 0x3697F1C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3697F24 Offset: 0x3693F24 VA: 0x3697F24 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3697F2C Offset: 0x3693F2C VA: 0x3697F2C
	public byte get_GameState() { }

	[CompilerGenerated]
	// RVA: 0x3697F34 Offset: 0x3693F34 VA: 0x3697F34
	public void set_GameState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3697F3C Offset: 0x3693F3C VA: 0x3697F3C
	public long get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x3697F44 Offset: 0x3693F44 VA: 0x3697F44
	public void set_StartTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x3697F4C Offset: 0x3693F4C VA: 0x3697F4C
	public long get_EndTime() { }

	[CompilerGenerated]
	// RVA: 0x3697F54 Offset: 0x3693F54 VA: 0x3697F54
	public void set_EndTime(long value) { }

	// RVA: 0x3697F5C Offset: 0x3693F5C VA: 0x3697F5C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3697F64 Offset: 0x3693F64 VA: 0x3697F64 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3698128 Offset: 0x3694128 VA: 0x3698128 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
