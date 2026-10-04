// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds.Quest
public class GuildQuestData : UnityHashBase // TypeDefIndex: 13029
{
	// Fields
	[CompilerGenerated]
	private byte <Clear>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <Stock>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <NextType>k__BackingField; // 0x1B
	[CompilerGenerated]
	private long <RestockTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <ResetTime>k__BackingField; // 0x28

	// Properties
	public byte Clear { get; set; }
	public byte Stock { get; set; }
	public byte NextType { get; set; }
	public long RestockTime { get; set; }
	public long ResetTime { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3691D90 Offset: 0x368DD90 VA: 0x3691D90
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3691D98 Offset: 0x368DD98 VA: 0x3691D98
	public byte get_Clear() { }

	[CompilerGenerated]
	// RVA: 0x3691DA0 Offset: 0x368DDA0 VA: 0x3691DA0
	public void set_Clear(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3691DA8 Offset: 0x368DDA8 VA: 0x3691DA8
	public byte get_Stock() { }

	[CompilerGenerated]
	// RVA: 0x3691DB0 Offset: 0x368DDB0 VA: 0x3691DB0
	public void set_Stock(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3691DB8 Offset: 0x368DDB8 VA: 0x3691DB8
	public byte get_NextType() { }

	[CompilerGenerated]
	// RVA: 0x3691DC0 Offset: 0x368DDC0 VA: 0x3691DC0
	public void set_NextType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3691DC8 Offset: 0x368DDC8 VA: 0x3691DC8
	public long get_RestockTime() { }

	[CompilerGenerated]
	// RVA: 0x3691DD0 Offset: 0x368DDD0 VA: 0x3691DD0
	public void set_RestockTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x3691DD8 Offset: 0x368DDD8 VA: 0x3691DD8
	public long get_ResetTime() { }

	[CompilerGenerated]
	// RVA: 0x3691DE0 Offset: 0x368DDE0 VA: 0x3691DE0
	public void set_ResetTime(long value) { }

	// RVA: 0x3691DE8 Offset: 0x368DDE8 VA: 0x3691DE8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3691DF0 Offset: 0x368DDF0 VA: 0x3691DF0 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x3691FF8 Offset: 0x368DFF8 VA: 0x3691FF8 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
