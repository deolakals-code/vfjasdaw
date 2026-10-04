// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents
public class MiniGameStartEvent : EventSubBase // TypeDefIndex: 12690
{
	// Fields
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <LeftEndTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private DateTime <StartTime>k__BackingField; // 0x30

	// Properties
	public byte State { get; set; }
	public long LeftEndTime { get; set; }
	public DateTime StartTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3642E30 Offset: 0x363EE30 VA: 0x3642E30
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3642E38 Offset: 0x363EE38 VA: 0x3642E38
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x3642E40 Offset: 0x363EE40 VA: 0x3642E40
	public void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3642E48 Offset: 0x363EE48 VA: 0x3642E48
	public long get_LeftEndTime() { }

	[CompilerGenerated]
	// RVA: 0x3642E50 Offset: 0x363EE50 VA: 0x3642E50
	public void set_LeftEndTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x3642E58 Offset: 0x363EE58 VA: 0x3642E58
	public DateTime get_StartTime() { }

	[CompilerGenerated]
	// RVA: 0x3642E60 Offset: 0x363EE60 VA: 0x3642E60
	public void set_StartTime(DateTime value) { }

	// RVA: 0x3642E68 Offset: 0x363EE68 VA: 0x3642E68 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3642E70 Offset: 0x363EE70 VA: 0x3642E70 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3642E78 Offset: 0x363EE78 VA: 0x3642E78 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3643054 Offset: 0x363F054 VA: 0x3643054 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
