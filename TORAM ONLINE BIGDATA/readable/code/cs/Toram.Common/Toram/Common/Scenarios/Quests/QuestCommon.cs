// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Scenarios.Quests
public class QuestCommon : BinaryBase, IScenario // TypeDefIndex: 11089
{
	// Fields
	protected List<IScenarioKey> keys; // 0x20
	protected List<IScenarioMob> mobs; // 0x28
	protected List<IScenarioItem> items; // 0x30
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
	[CompilerGenerated]
	private bool <IsContinuousReward>k__BackingField; // 0x45

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
	[BinaryParameter]
	public bool IsContinuousReward { get; set; }

	// Methods

	// RVA: 0x35B6220 Offset: 0x35B2220 VA: 0x35B6220
	public void .ctor() { }

	// RVA: 0x35B6414 Offset: 0x35B2414 VA: 0x35B6414
	public void .ctor(byte[] binary) { }

	// RVA: 0x35B641C Offset: 0x35B241C VA: 0x35B641C
	public void .ctor(MemoryStream ms) { }

	[CompilerGenerated]
	// RVA: 0x35B6424 Offset: 0x35B2424 VA: 0x35B6424 Slot: 8
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x35B642C Offset: 0x35B242C VA: 0x35B642C Slot: 9
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B6434 Offset: 0x35B2434 VA: 0x35B6434 Slot: 21
	public short get_OrderLevel() { }

	[CompilerGenerated]
	// RVA: 0x35B643C Offset: 0x35B243C VA: 0x35B643C Slot: 22
	public void set_OrderLevel(short value) { }

	[CompilerGenerated]
	// RVA: 0x35B6444 Offset: 0x35B2444 VA: 0x35B6444 Slot: 10
	public short get_KeySetting() { }

	[CompilerGenerated]
	// RVA: 0x35B644C Offset: 0x35B244C VA: 0x35B644C Slot: 11
	public void set_KeySetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x35B6454 Offset: 0x35B2454 VA: 0x35B6454 Slot: 12
	public short get_ItemSetting() { }

	[CompilerGenerated]
	// RVA: 0x35B645C Offset: 0x35B245C VA: 0x35B645C Slot: 13
	public void set_ItemSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x35B6464 Offset: 0x35B2464 VA: 0x35B6464 Slot: 14
	public short get_MobSetting() { }

	[CompilerGenerated]
	// RVA: 0x35B646C Offset: 0x35B246C VA: 0x35B646C Slot: 15
	public void set_MobSetting(short value) { }

	[CompilerGenerated]
	// RVA: 0x35B6474 Offset: 0x35B2474 VA: 0x35B6474 Slot: 16
	public byte get_InfoNo() { }

	[CompilerGenerated]
	// RVA: 0x35B647C Offset: 0x35B247C VA: 0x35B647C Slot: 17
	public void set_InfoNo(byte value) { }

	// RVA: 0x35B6484 Offset: 0x35B2484 VA: 0x35B6484 Slot: 18
	public List<IScenarioKey> get_KeyList() { }

	// RVA: 0x35B648C Offset: 0x35B248C VA: 0x35B648C Slot: 19
	public List<IScenarioItem> get_ItemList() { }

	// RVA: 0x35B6494 Offset: 0x35B2494 VA: 0x35B6494 Slot: 20
	public List<IScenarioMob> get_MobList() { }

	[CompilerGenerated]
	// RVA: 0x35B649C Offset: 0x35B249C VA: 0x35B649C
	public bool get_IsContinuousReward() { }

	[CompilerGenerated]
	// RVA: 0x35B64A4 Offset: 0x35B24A4 VA: 0x35B64A4
	public void set_IsContinuousReward(bool value) { }

	// RVA: 0x35B623C Offset: 0x35B223C VA: 0x35B623C
	protected void Init() { }

	// RVA: 0x35B64B0 Offset: 0x35B24B0 VA: 0x35B64B0 Slot: 23
	protected virtual void SetClass(MemoryStream ms) { }

	// RVA: 0x35B674C Offset: 0x35B274C VA: 0x35B674C Slot: 24
	protected virtual void GetClass(MemoryStream ms) { }

	// RVA: 0x35B7004 Offset: 0x35B3004 VA: 0x35B7004 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35B7198 Offset: 0x35B3198 VA: 0x35B7198 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
