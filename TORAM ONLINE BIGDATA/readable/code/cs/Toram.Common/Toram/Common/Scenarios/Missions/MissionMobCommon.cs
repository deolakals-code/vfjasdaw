// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Scenarios.Missions
public class MissionMobCommon : BinaryBase, IScenarioMob // TypeDefIndex: 11097
{
	// Fields
	[CompilerGenerated]
	private byte <No>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <FieldId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <MonsterUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Current>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <SubdueNum>k__BackingField; // 0x26

	// Properties
	[BinaryParameter]
	public byte No { get; set; }
	[BinaryParameter]
	public int FieldId { get; set; }
	[BinaryParameter]
	public int MonsterUuid { get; set; }
	[BinaryParameter]
	public short Current { get; set; }
	[BinaryParameter]
	public short SubdueNum { get; set; }

	// Methods

	// RVA: 0x35B8574 Offset: 0x35B4574 VA: 0x35B8574
	public void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x35B96E0 Offset: 0x35B56E0 VA: 0x35B96E0 Slot: 8
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x35B96E8 Offset: 0x35B56E8 VA: 0x35B96E8 Slot: 14
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35B96F0 Offset: 0x35B56F0 VA: 0x35B96F0 Slot: 9
	public int get_FieldId() { }

	[CompilerGenerated]
	// RVA: 0x35B96F8 Offset: 0x35B56F8 VA: 0x35B96F8 Slot: 15
	public void set_FieldId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B9700 Offset: 0x35B5700 VA: 0x35B9700 Slot: 10
	public int get_MonsterUuid() { }

	[CompilerGenerated]
	// RVA: 0x35B9708 Offset: 0x35B5708 VA: 0x35B9708 Slot: 16
	public void set_MonsterUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B9710 Offset: 0x35B5710 VA: 0x35B9710 Slot: 11
	public short get_Current() { }

	[CompilerGenerated]
	// RVA: 0x35B9718 Offset: 0x35B5718 VA: 0x35B9718 Slot: 12
	public void set_Current(short value) { }

	[CompilerGenerated]
	// RVA: 0x35B9720 Offset: 0x35B5720 VA: 0x35B9720 Slot: 13
	public short get_SubdueNum() { }

	[CompilerGenerated]
	// RVA: 0x35B9728 Offset: 0x35B5728 VA: 0x35B9728 Slot: 17
	public void set_SubdueNum(short value) { }

	// RVA: 0x35B9730 Offset: 0x35B5730 VA: 0x35B9730 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B9878 Offset: 0x35B5878 VA: 0x35B9878 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
