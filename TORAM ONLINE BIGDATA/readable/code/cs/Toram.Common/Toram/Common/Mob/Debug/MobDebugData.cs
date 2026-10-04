// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Mob.Debug
public class MobDebugData : BinaryBase // TypeDefIndex: 12490
{
	// Fields
	[CompilerGenerated]
	private MobIdData <IdData>k__BackingField; // 0x20
	[CompilerGenerated]
	private HMTriggerStateData[] <HMTriggerStateList>k__BackingField; // 0x28
	[CompilerGenerated]
	private HMFlagStateData[] <HMFlagStateList>k__BackingField; // 0x30

	// Properties
	public MobIdData IdData { get; set; }
	public HMTriggerStateData[] HMTriggerStateList { get; set; }
	public HMFlagStateData[] HMFlagStateList { get; set; }

	// Methods

	// RVA: 0x360F3F8 Offset: 0x360B3F8 VA: 0x360F3F8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360F400 Offset: 0x360B400 VA: 0x360F400
	public MobIdData get_IdData() { }

	[CompilerGenerated]
	// RVA: 0x360F408 Offset: 0x360B408 VA: 0x360F408
	public void set_IdData(MobIdData value) { }

	[CompilerGenerated]
	// RVA: 0x360F410 Offset: 0x360B410 VA: 0x360F410
	public HMTriggerStateData[] get_HMTriggerStateList() { }

	[CompilerGenerated]
	// RVA: 0x360F418 Offset: 0x360B418 VA: 0x360F418
	public void set_HMTriggerStateList(HMTriggerStateData[] value) { }

	[CompilerGenerated]
	// RVA: 0x360F420 Offset: 0x360B420 VA: 0x360F420
	public HMFlagStateData[] get_HMFlagStateList() { }

	[CompilerGenerated]
	// RVA: 0x360F428 Offset: 0x360B428 VA: 0x360F428
	public void set_HMFlagStateList(HMFlagStateData[] value) { }

	// RVA: 0x360F430 Offset: 0x360B430 VA: 0x360F430 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x360F510 Offset: 0x360B510 VA: 0x360F510 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
