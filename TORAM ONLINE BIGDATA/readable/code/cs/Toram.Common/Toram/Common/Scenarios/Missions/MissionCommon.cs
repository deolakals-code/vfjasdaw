// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Scenarios.Missions
public class MissionCommon : BinaryBase, IScenario // TypeDefIndex: 11094
{
	// Fields
	private List<IScenarioKey> keys; // 0x20
	private List<IScenarioMob> mobs; // 0x28
	private List<IScenarioItem> items; // 0x30
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <OrderLevel>k__BackingField; // 0x3C
	[CompilerGenerated]
	private short <KeySetting>k__BackingField; // 0x3E
	[CompilerGenerated]
	private short <ItemSetting>k__BackingField; // 0x40
	[CompilerGenerated]
	private short <MobSetting>k__BackingField; // 0x42
	[CompilerGenerated]
	private byte <InfoNo>k__BackingField; // 0x44

	// Properties
	[BinaryParameter]
	public int Id { get; set; }
	[BinaryParameter]
	public short OrderLevel { get; set; }
	[BinaryParameter]
	public short KeySetting { get; set; }
	[BinaryParameter]
	public short ItemSetting { get; set; }
	[BinaryParameter]
	public short MobSetting { get; set; }
	[BinaryParameter]
	public byte InfoNo { get; set; }
	[BinaryClass]
	public List<IScenarioKey> KeyList { get; }
	[BinaryClass]
	public List<IScenarioItem> ItemList { get; }
	[BinaryClass]
	public List<IScenarioMob> MobList { get; }

	// Methods

	// RVA: 0x35B8068 Offset: 0x35B4068 VA: 0x35B8068
	public void .ctor() { }

	// RVA: 0x35B5B04 Offset: 0x35B1B04 VA: 0x35B5B04
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35B8090 Offset: 0x35B4090 VA: 0x35B8090 Slot: 8
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35B8098 Offset: 0x35B4098 VA: 0x35B8098 Slot: 9
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B80A0 Offset: 0x35B40A0 VA: 0x35B80A0 Slot: 21
	public short get_OrderLevel() { }

	[CompilerGenerated]
	// RVA: 0x35B80A8 Offset: 0x35B40A8 VA: 0x35B80A8 Slot: 22
	public void set_OrderLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x35B80B0 Offset: 0x35B40B0 VA: 0x35B80B0 Slot: 10
	public short get_KeySetting() { }

	[CompilerGenerated]
	// RVA: 0x35B80B8 Offset: 0x35B40B8 VA: 0x35B80B8 Slot: 11
	public void set_KeySetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x35B80C0 Offset: 0x35B40C0 VA: 0x35B80C0 Slot: 12
	public short get_ItemSetting() { }

	[CompilerGenerated]
	// RVA: 0x35B80C8 Offset: 0x35B40C8 VA: 0x35B80C8 Slot: 13
	public void set_ItemSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x35B80D0 Offset: 0x35B40D0 VA: 0x35B80D0 Slot: 14
	public short get_MobSetting() { }

	[CompilerGenerated]
	// RVA: 0x35B80D8 Offset: 0x35B40D8 VA: 0x35B80D8 Slot: 15
	public void set_MobSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x35B80E0 Offset: 0x35B40E0 VA: 0x35B80E0 Slot: 16
	public byte get_InfoNo() { }

	[CompilerGenerated]
	// RVA: 0x35B80E8 Offset: 0x35B40E8 VA: 0x35B80E8 Slot: 17
	public void set_InfoNo(byte value) { }

	// RVA: 0x35B80F0 Offset: 0x35B40F0 VA: 0x35B80F0 Slot: 18
	public List<IScenarioKey> get_KeyList() { }

	// RVA: 0x35B80F8 Offset: 0x35B40F8 VA: 0x35B80F8 Slot: 19
	public List<IScenarioItem> get_ItemList() { }

	// RVA: 0x35B8100 Offset: 0x35B4100 VA: 0x35B8100 Slot: 20
	public List<IScenarioMob> get_MobList() { }

	// RVA: 0x35B8108 Offset: 0x35B4108 VA: 0x35B8108 Slot: 23
	public virtual void Init() { }

	// RVA: 0x35B82E0 Offset: 0x35B42E0 VA: 0x35B82E0 Slot: 24
	protected virtual void SetClass(MemoryStream ms) { }

	// RVA: 0x35B857C Offset: 0x35B457C VA: 0x35B857C Slot: 25
	protected virtual void GetClass(MemoryStream ms) { }

	// RVA: 0x35B8E34 Offset: 0x35B4E34 VA: 0x35B8E34 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B8FC0 Offset: 0x35B4FC0 VA: 0x35B8FC0 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
