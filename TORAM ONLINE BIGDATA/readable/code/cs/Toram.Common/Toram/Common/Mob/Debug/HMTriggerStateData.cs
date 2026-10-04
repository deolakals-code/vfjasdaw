// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Mob.Debug
public class HMTriggerStateData : BinaryBase // TypeDefIndex: 12489
{
	// Fields
	[CompilerGenerated]
	private byte <ModeId>k__BackingField; // 0x19
	[CompilerGenerated]
	private short <TriggerId>k__BackingField; // 0x1A
	[CompilerGenerated]
	private long <TriggerValue>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <Value>k__BackingField; // 0x28

	// Properties
	public byte ModeId { get; set; }
	public short TriggerId { get; set; }
	public long TriggerValue { get; set; }
	public long Value { get; set; }

	// Methods

	// RVA: 0x360F270 Offset: 0x360B270 VA: 0x360F270
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360F278 Offset: 0x360B278 VA: 0x360F278
	public byte get_ModeId() { }

	[CompilerGenerated]
	// RVA: 0x360F280 Offset: 0x360B280 VA: 0x360F280
	public void set_ModeId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x360F288 Offset: 0x360B288 VA: 0x360F288
	public short get_TriggerId() { }

	[CompilerGenerated]
	// RVA: 0x360F290 Offset: 0x360B290 VA: 0x360F290
	public void set_TriggerId(short value) { }

	[CompilerGenerated]
	// RVA: 0x360F298 Offset: 0x360B298 VA: 0x360F298
	public long get_TriggerValue() { }

	[CompilerGenerated]
	// RVA: 0x360F2A0 Offset: 0x360B2A0 VA: 0x360F2A0
	public void set_TriggerValue(long value) { }

	[CompilerGenerated]
	// RVA: 0x360F2A8 Offset: 0x360B2A8 VA: 0x360F2A8
	public long get_Value() { }

	[CompilerGenerated]
	// RVA: 0x360F2B0 Offset: 0x360B2B0 VA: 0x360F2B0
	public void set_Value(long value) { }

	// RVA: 0x360F2B8 Offset: 0x360B2B8 VA: 0x360F2B8 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x360F314 Offset: 0x360B314 VA: 0x360F314 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
