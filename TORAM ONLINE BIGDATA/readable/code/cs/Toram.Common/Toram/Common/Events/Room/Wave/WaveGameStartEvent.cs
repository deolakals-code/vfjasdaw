// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Wave
public class WaveGameStartEvent : EventSubBase // TypeDefIndex: 12761
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

	// RVA: 0x3653464 Offset: 0x364F464 VA: 0x3653464 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x365346C Offset: 0x364F46C VA: 0x365346C Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3653474 Offset: 0x364F474 VA: 0x3653474
	public byte get_GameState() { }

	[CompilerGenerated]
	// RVA: 0x365347C Offset: 0x364F47C VA: 0x365347C
	public void set_GameState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3653484 Offset: 0x364F484 VA: 0x3653484
	public long get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x365348C Offset: 0x364F48C VA: 0x365348C
	public void set_StartTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x3653494 Offset: 0x364F494 VA: 0x3653494
	public long get_EndTime() { }

	[CompilerGenerated]
	// RVA: 0x365349C Offset: 0x364F49C VA: 0x365349C
	public void set_EndTime(long value) { }

	// RVA: 0x36534A4 Offset: 0x364F4A4 VA: 0x36534A4
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36534AC Offset: 0x364F4AC VA: 0x36534AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3653670 Offset: 0x364F670 VA: 0x3653670 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
