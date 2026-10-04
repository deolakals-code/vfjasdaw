// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.WaveRaid
public class WaveRaidNextWaveEvent : EventSubBase // TypeDefIndex: 12785
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

	// Methods

	// RVA: 0x365843C Offset: 0x365443C VA: 0x365843C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3658444 Offset: 0x3654444 VA: 0x3658444 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x365844C Offset: 0x365444C VA: 0x365844C
	public int get_NowWaveID() { }

	[CompilerGenerated]
	// RVA: 0x3658454 Offset: 0x3654454 VA: 0x3658454
	public void set_NowWaveID(int value) { }

	[CompilerGenerated]
	// RVA: 0x365845C Offset: 0x365445C VA: 0x365845C
	public byte get_GameState() { }

	[CompilerGenerated]
	// RVA: 0x3658464 Offset: 0x3654464 VA: 0x3658464
	public void set_GameState(byte value) { }

	[CompilerGenerated]
	// RVA: 0x365846C Offset: 0x365446C VA: 0x365846C
	public short get_ScriptRetval() { }

	[CompilerGenerated]
	// RVA: 0x3658474 Offset: 0x3654474 VA: 0x3658474
	public void set_ScriptRetval(short value) { }

	[CompilerGenerated]
	// RVA: 0x365847C Offset: 0x365447C VA: 0x365847C
	public WaveTargetData[] get_TargetDatas() { }

	[CompilerGenerated]
	// RVA: 0x3658484 Offset: 0x3654484 VA: 0x3658484
	public void set_TargetDatas(WaveTargetData[] value) { }

	// RVA: 0x365848C Offset: 0x365448C VA: 0x365848C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3658494 Offset: 0x3654494 VA: 0x3658494 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3658774 Offset: 0x3654774 VA: 0x3658774 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
