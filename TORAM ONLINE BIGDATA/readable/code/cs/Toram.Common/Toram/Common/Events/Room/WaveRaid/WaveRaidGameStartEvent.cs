// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.WaveRaid
public class WaveRaidGameStartEvent : EventSubBase // TypeDefIndex: 12781
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

	// RVA: 0x36579F0 Offset: 0x36539F0 VA: 0x36579F0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36579F8 Offset: 0x36539F8 VA: 0x36579F8 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3657A00 Offset: 0x3653A00 VA: 0x3657A00
	public byte get_GameState() { }

	[CompilerGenerated]
	// RVA: 0x3657A08 Offset: 0x3653A08 VA: 0x3657A08
	public void set_GameState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3657A10 Offset: 0x3653A10 VA: 0x3657A10
	public long get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x3657A18 Offset: 0x3653A18 VA: 0x3657A18
	public void set_StartTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x3657A20 Offset: 0x3653A20 VA: 0x3657A20
	public long get_EndTime() { }

	[CompilerGenerated]
	// RVA: 0x3657A28 Offset: 0x3653A28 VA: 0x3657A28
	public void set_EndTime(long value) { }

	// RVA: 0x3657A30 Offset: 0x3653A30 VA: 0x3657A30
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3657A38 Offset: 0x3653A38 VA: 0x3657A38 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3657BFC Offset: 0x3653BFC VA: 0x3657BFC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
