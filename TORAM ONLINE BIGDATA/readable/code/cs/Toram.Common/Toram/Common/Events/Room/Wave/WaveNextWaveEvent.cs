// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Wave
public class WaveNextWaveEvent : EventSubBase // TypeDefIndex: 12764
{
	// Fields
	[CompilerGenerated]
	private int <NowWaveID>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <GameState>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <ScriptRetval>k__BackingField; // 0x26
	[CompilerGenerated]
	private WaveTargetData[] <TargetDatas>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <WrFieldId>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketClass(Code = 19)]
	public int NowWaveID { get; set; }
	[PacketClass(Code = 43)]
	public byte GameState { get; set; }
	[PacketClass(Code = 195)]
	public short ScriptRetval { get; set; }
	[PacketClass(Code = 186, IsOptional = True)]
	public WaveTargetData[] TargetDatas { get; set; }
	[PacketClass(Code = 60, IsOptional = True)]
	public int WrFieldId { get; set; }

	// Methods

	// RVA: 0x3653C88 Offset: 0x364FC88 VA: 0x3653C88 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3653C90 Offset: 0x364FC90 VA: 0x3653C90 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3653C98 Offset: 0x364FC98 VA: 0x3653C98
	public int get_NowWaveID() { }

	[CompilerGenerated]
	// RVA: 0x3653CA0 Offset: 0x364FCA0 VA: 0x3653CA0
	public void set_NowWaveID(int value) { }

	[CompilerGenerated]
	// RVA: 0x3653CA8 Offset: 0x364FCA8 VA: 0x3653CA8
	public byte get_GameState() { }

	[CompilerGenerated]
	// RVA: 0x3653CB0 Offset: 0x364FCB0 VA: 0x3653CB0
	public void set_GameState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3653CB8 Offset: 0x364FCB8 VA: 0x3653CB8
	public short get_ScriptRetval() { }

	[CompilerGenerated]
	// RVA: 0x3653CC0 Offset: 0x364FCC0 VA: 0x3653CC0
	public void set_ScriptRetval(short value) { }

	[CompilerGenerated]
	// RVA: 0x3653CC8 Offset: 0x364FCC8 VA: 0x3653CC8
	public WaveTargetData[] get_TargetDatas() { }

	[CompilerGenerated]
	// RVA: 0x3653CD0 Offset: 0x364FCD0 VA: 0x3653CD0
	public void set_TargetDatas(WaveTargetData[] value) { }

	[CompilerGenerated]
	// RVA: 0x3653CD8 Offset: 0x364FCD8 VA: 0x3653CD8
	public int get_WrFieldId() { }

	[CompilerGenerated]
	// RVA: 0x3653CE0 Offset: 0x364FCE0 VA: 0x3653CE0
	public void set_WrFieldId(int value) { }

	// RVA: 0x3653CE8 Offset: 0x364FCE8 VA: 0x3653CE8
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3653CF0 Offset: 0x364FCF0 VA: 0x3653CF0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3654044 Offset: 0x3650044 VA: 0x3654044 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
