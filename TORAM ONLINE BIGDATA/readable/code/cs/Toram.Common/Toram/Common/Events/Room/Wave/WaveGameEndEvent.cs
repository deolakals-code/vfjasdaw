// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Wave
public class WaveGameEndEvent : EventSubBase // TypeDefIndex: 12760
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
	[CompilerGenerated]
	private int <WrFieldId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <WrNowWaveID>k__BackingField; // 0x30

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
	[PacketClass(Code = 60, IsOptional = True)]
	public int WrFieldId { get; set; }
	[PacketClass(Code = 19)]
	public int WrNowWaveID { get; set; }

	// Methods

	// RVA: 0x3652EC0 Offset: 0x364EEC0 VA: 0x3652EC0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3652EC8 Offset: 0x364EEC8 VA: 0x3652EC8 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3652ED0 Offset: 0x364EED0 VA: 0x3652ED0
	public byte get_GameEndCode() { }

	[CompilerGenerated]
	// RVA: 0x3652ED8 Offset: 0x364EED8 VA: 0x3652ED8
	public void set_GameEndCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3652EE0 Offset: 0x364EEE0 VA: 0x3652EE0
	public int get_Result() { }

	[CompilerGenerated]
	// RVA: 0x3652EE8 Offset: 0x364EEE8 VA: 0x3652EE8
	public void set_Result(int value) { }

	[CompilerGenerated]
	// RVA: 0x3652EF0 Offset: 0x364EEF0 VA: 0x3652EF0
	public short get_ScriptRetval() { }

	[CompilerGenerated]
	// RVA: 0x3652EF8 Offset: 0x364EEF8 VA: 0x3652EF8
	public void set_ScriptRetval(short value) { }

	[CompilerGenerated]
	// RVA: 0x3652F00 Offset: 0x364EF00 VA: 0x3652F00
	public short get_GameTotalTime() { }

	[CompilerGenerated]
	// RVA: 0x3652F08 Offset: 0x364EF08 VA: 0x3652F08
	public void set_GameTotalTime(short value) { }

	[CompilerGenerated]
	// RVA: 0x3652F10 Offset: 0x364EF10 VA: 0x3652F10
	public int get_WrFieldId() { }

	[CompilerGenerated]
	// RVA: 0x3652F18 Offset: 0x364EF18 VA: 0x3652F18
	public void set_WrFieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3652F20 Offset: 0x364EF20 VA: 0x3652F20
	public int get_WrNowWaveID() { }

	[CompilerGenerated]
	// RVA: 0x3652F28 Offset: 0x364EF28 VA: 0x3652F28
	public void set_WrNowWaveID(int value) { }

	// RVA: 0x3652F30 Offset: 0x364EF30 VA: 0x3652F30
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3652F38 Offset: 0x364EF38 VA: 0x3652F38
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3652F3C Offset: 0x364EF3C VA: 0x3652F3C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3652F40 Offset: 0x364EF40 VA: 0x3652F40 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36532C0 Offset: 0x364F2C0 VA: 0x36532C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
