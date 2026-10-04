// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.WaveRaid
public class WaveRaidGameEndEvent : EventSubBase // TypeDefIndex: 12780
{
	// Fields
	[CompilerGenerated]
	private byte <GameEndCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Result>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <ScriptRetval>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <GameTotalTime>k__BackingField; // 0x2A

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketClass(Code = 141)]
	public byte GameEndCode { get; set; }
	[PacketClass(Code = 78)]
	public int Result { get; set; }
	[PacketClass(Code = 195)]
	public short ScriptRetval { get; set; }
	[PacketClass(Code = 192)]
	public short GameTotalTime { get; set; }

	// Methods

	// RVA: 0x365759C Offset: 0x365359C VA: 0x365759C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36575A4 Offset: 0x36535A4 VA: 0x36575A4 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x36575AC Offset: 0x36535AC VA: 0x36575AC
	public byte get_GameEndCode() { }

	[CompilerGenerated]
	// RVA: 0x36575B4 Offset: 0x36535B4 VA: 0x36575B4
	public void set_GameEndCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36575BC Offset: 0x36535BC VA: 0x36575BC
	public int get_Result() { }

	[CompilerGenerated]
	// RVA: 0x36575C4 Offset: 0x36535C4 VA: 0x36575C4
	public void set_Result(int value) { }

	[CompilerGenerated]
	// RVA: 0x36575CC Offset: 0x36535CC VA: 0x36575CC
	public short get_ScriptRetval() { }

	[CompilerGenerated]
	// RVA: 0x36575D4 Offset: 0x36535D4 VA: 0x36575D4
	public void set_ScriptRetval(short value) { }

	[CompilerGenerated]
	// RVA: 0x36575DC Offset: 0x36535DC VA: 0x36575DC
	public short get_GameTotalTime() { }

	[CompilerGenerated]
	// RVA: 0x36575E4 Offset: 0x36535E4 VA: 0x36575E4
	public void set_GameTotalTime(short value) { }

	// RVA: 0x36575EC Offset: 0x36535EC VA: 0x36575EC
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36575F4 Offset: 0x36535F4 VA: 0x36575F4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36575F8 Offset: 0x36535F8 VA: 0x36575F8
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36575FC Offset: 0x36535FC VA: 0x36575FC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36578A4 Offset: 0x36538A4 VA: 0x36578A4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
