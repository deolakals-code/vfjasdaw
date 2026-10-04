// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Scenarios
public class ScenarioList : UnityHashBase // TypeDefIndex: 11087
{
	// Fields
	[CompilerGenerated]
	private int <AccountProgress>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <ScenarioProgress>k__BackingField; // 0x20
	[CompilerGenerated]
	private MissionCommon <MissionData>k__BackingField; // 0x28
	[CompilerGenerated]
	private QuestCommon[] <QuestList>k__BackingField; // 0x30

	// Properties
	public override byte Code { get; }
	[UnityHash(Code = 157, IsOptional = True)]
	public int AccountProgress { get; set; }
	[UnityHash(Code = 158)]
	public int ScenarioProgress { get; set; }
	[UnityHash(Code = 155, IsOptional = True)]
	public MissionCommon MissionData { get; set; }
	[UnityHash(Code = 117, IsOptional = True)]
	public QuestCommon[] QuestList { get; set; }

	// Methods

	// RVA: 0x35B58C8 Offset: 0x35B18C8 VA: 0x35B58C8
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x35B58D0 Offset: 0x35B18D0 VA: 0x35B58D0 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x35B58D8 Offset: 0x35B18D8 VA: 0x35B58D8
	public int get_AccountProgress() { }

	[CompilerGenerated]
	// RVA: 0x35B58E0 Offset: 0x35B18E0 VA: 0x35B58E0
	public void set_AccountProgress(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B58E8 Offset: 0x35B18E8 VA: 0x35B58E8
	public int get_ScenarioProgress() { }

	[CompilerGenerated]
	// RVA: 0x35B58F0 Offset: 0x35B18F0 VA: 0x35B58F0
	public void set_ScenarioProgress(int value) { }

	[CompilerGenerated]
	// RVA: 0x35B58F8 Offset: 0x35B18F8 VA: 0x35B58F8
	public MissionCommon get_MissionData() { }

	[CompilerGenerated]
	// RVA: 0x35B5900 Offset: 0x35B1900 VA: 0x35B5900
	public void set_MissionData(MissionCommon value) { }

	[CompilerGenerated]
	// RVA: 0x35B5908 Offset: 0x35B1908 VA: 0x35B5908
	public QuestCommon[] get_QuestList() { }

	[CompilerGenerated]
	// RVA: 0x35B5910 Offset: 0x35B1910 VA: 0x35B5910
	public void set_QuestList(QuestCommon[] value) { }

	// RVA: 0x35B5918 Offset: 0x35B1918 VA: 0x35B5918
	private void SetClass(Dictionary<object, object> parameters) { }

	// RVA: 0x35B5B7C Offset: 0x35B1B7C VA: 0x35B5B7C
	private void GetClass(Dictionary<object, object> hashtable) { }

	// RVA: 0x35B5D00 Offset: 0x35B1D00 VA: 0x35B5D00 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35B5F08 Offset: 0x35B1F08 VA: 0x35B5F08 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
