// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NewWave.Events
public class NewWaveNextWaveEvent : EventSubBase // TypeDefIndex: 13053
{
	// Fields
	[CompilerGenerated]
	private int <NowWaveID>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <GameState>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <ScriptRetval>k__BackingField; // 0x26

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketClass(Code = 19)]
	public int NowWaveID { get; set; }
	[PacketClass(Code = 43)]
	public byte GameState { get; set; }
	[PacketClass(Code = 195)]
	public short ScriptRetval { get; set; }

	// Methods

	// RVA: 0x36987A8 Offset: 0x36947A8 VA: 0x36987A8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36987B0 Offset: 0x36947B0 VA: 0x36987B0 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x36987B8 Offset: 0x36947B8 VA: 0x36987B8
	public int get_NowWaveID() { }

	[CompilerGenerated]
	// RVA: 0x36987C0 Offset: 0x36947C0 VA: 0x36987C0
	public void set_NowWaveID(int value) { }

	[CompilerGenerated]
	// RVA: 0x36987C8 Offset: 0x36947C8 VA: 0x36987C8
	public byte get_GameState() { }

	[CompilerGenerated]
	// RVA: 0x36987D0 Offset: 0x36947D0 VA: 0x36987D0
	public void set_GameState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36987D8 Offset: 0x36947D8 VA: 0x36987D8
	public short get_ScriptRetval() { }

	[CompilerGenerated]
	// RVA: 0x36987E0 Offset: 0x36947E0 VA: 0x36987E0
	public void set_ScriptRetval(short value) { }

	// RVA: 0x36987E8 Offset: 0x36947E8 VA: 0x36987E8
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x36987F0 Offset: 0x36947F0 VA: 0x36987F0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3698A2C Offset: 0x3694A2C VA: 0x3698A2C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
