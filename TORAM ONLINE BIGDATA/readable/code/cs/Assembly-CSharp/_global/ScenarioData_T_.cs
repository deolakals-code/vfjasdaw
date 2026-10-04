// Assembly: Assembly-CSharp.dll
// Namespace: 
[Serializable]
public class ScenarioData<T> : IScenarioData // TypeDefIndex: 2236
{
	// Fields
	private T scenarioData; // 0x0
	private Dictionary<int, bool> mobClearFlag; // 0x0
	private Dictionary<int, bool> itemClearFlag; // 0x0
	private List<IScenarioMob> mobClearList; // 0x0
	private List<IScenarioItem> itemClearList; // 0x0
	private int[] itemNumAchieveList; // 0x0
	private bool isUpdateViewFlag; // 0x0
	private bool isUpdateSetKey; // 0x0
	private int repeatNum; // 0x0
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x0
	[CompilerGenerated]
	private bool <IsValid>k__BackingField; // 0x0
	[CompilerGenerated]
	private int <UpdateCount>k__BackingField; // 0x0

	// Properties
	public int Id { get; set; }
	public bool IsValid { get; set; }
	public IScenario Scenario { get; }
	public List<IScenarioMob> MobClearList { get; }
	public List<IScenarioItem> ItemClearList { get; }
	public int UpdateCount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_Id() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C55C04 Offset: 0x2C51C04 VA: 0x2C55C04
	|-ScenarioData<object>.get_Id
	|
	|-RVA: 0x2C5BA10 Offset: 0x2C57A10 VA: 0x2C5BA10
	|-ScenarioData<__Il2CppFullySharedGenericType>.get_Id
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_Id(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C55C0C Offset: 0x2C51C0C VA: 0x2C55C0C
	|-ScenarioData<object>.set_Id
	|
	|-RVA: 0x2C5BA38 Offset: 0x2C57A38 VA: 0x2C5BA38
	|-ScenarioData<__Il2CppFullySharedGenericType>.set_Id
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 5
	public bool get_IsValid() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C55C14 Offset: 0x2C51C14 VA: 0x2C55C14
	|-ScenarioData<object>.get_IsValid
	|
	|-RVA: 0x2C5BA58 Offset: 0x2C57A58 VA: 0x2C5BA58
	|-ScenarioData<__Il2CppFullySharedGenericType>.get_IsValid
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_IsValid(bool value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C55C1C Offset: 0x2C51C1C VA: 0x2C55C1C
	|-ScenarioData<object>.set_IsValid
	|
	|-RVA: 0x2C5BA80 Offset: 0x2C57A80 VA: 0x2C5BA80
	|-ScenarioData<__Il2CppFullySharedGenericType>.set_IsValid
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IScenario get_Scenario() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C55C28 Offset: 0x2C51C28 VA: 0x2C55C28
	|-ScenarioData<object>.get_Scenario
	|
	|-RVA: 0x2C5BAA0 Offset: 0x2C57AA0 VA: 0x2C5BAA0
	|-ScenarioData<__Il2CppFullySharedGenericType>.get_Scenario
	*/

	// RVA: -1 Offset: -1
	public List<IScenarioMob> get_MobClearList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C55C30 Offset: 0x2C51C30 VA: 0x2C55C30
	|-ScenarioData<object>.get_MobClearList
	|
	|-RVA: 0x2C5BB3C Offset: 0x2C57B3C VA: 0x2C5BB3C
	|-ScenarioData<__Il2CppFullySharedGenericType>.get_MobClearList
	*/

	// RVA: -1 Offset: -1
	public List<IScenarioItem> get_ItemClearList() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C55C38 Offset: 0x2C51C38 VA: 0x2C55C38
	|-ScenarioData<object>.get_ItemClearList
	|
	|-RVA: 0x2C5BB64 Offset: 0x2C57B64 VA: 0x2C5BB64
	|-ScenarioData<__Il2CppFullySharedGenericType>.get_ItemClearList
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public int get_UpdateCount() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C55C40 Offset: 0x2C51C40 VA: 0x2C55C40
	|-ScenarioData<object>.get_UpdateCount
	|
	|-RVA: 0x2C5BB8C Offset: 0x2C57B8C VA: 0x2C5BB8C
	|-ScenarioData<__Il2CppFullySharedGenericType>.get_UpdateCount
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	private void set_UpdateCount(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C55C48 Offset: 0x2C51C48 VA: 0x2C55C48
	|-ScenarioData<object>.set_UpdateCount
	|
	|-RVA: 0x2C5BBB4 Offset: 0x2C57BB4 VA: 0x2C5BBB4
	|-ScenarioData<__Il2CppFullySharedGenericType>.set_UpdateCount
	*/

	// RVA: -1 Offset: -1
	public void .ctor(bool repeat, int id, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C55C50 Offset: 0x2C51C50 VA: 0x2C55C50
	|-ScenarioData<object>..ctor
	|
	|-RVA: 0x2C5BBD4 Offset: 0x2C57BD4 VA: 0x2C5BBD4
	|-ScenarioData<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void UpdateRepeatData(bool repeat) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C56414 Offset: 0x2C52414 VA: 0x2C56414
	|-ScenarioData<object>.UpdateRepeatData
	|
	|-RVA: 0x2C5C638 Offset: 0x2C58638 VA: 0x2C5C638
	|-ScenarioData<__Il2CppFullySharedGenericType>.UpdateRepeatData
	*/

	// RVA: -1 Offset: -1
	public void UpdateData(QuestManager.ReceiveType type, T data) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C56438 Offset: 0x2C52438 VA: 0x2C56438
	|-ScenarioData<object>.UpdateData
	|
	|-RVA: 0x2C5C66C Offset: 0x2C5866C VA: 0x2C5C66C
	|-ScenarioData<__Il2CppFullySharedGenericType>.UpdateData
	*/

	// RVA: -1 Offset: -1
	public void SetId(int id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C577E0 Offset: 0x2C537E0 VA: 0x2C577E0
	|-ScenarioData<object>.SetId
	|
	|-RVA: 0x2C5E16C Offset: 0x2C5A16C VA: 0x2C5E16C
	|-ScenarioData<__Il2CppFullySharedGenericType>.SetId
	*/

	// RVA: -1 Offset: -1
	private void temporaryDataCreate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C577EC Offset: 0x2C537EC VA: 0x2C577EC
	|-ScenarioData<object>.temporaryDataCreate
	|
	|-RVA: 0x2C5E1B4 Offset: 0x2C5A1B4 VA: 0x2C5E1B4
	|-ScenarioData<__Il2CppFullySharedGenericType>.temporaryDataCreate
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool SettingRewardCheck(ItemManager itemManager) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C578D0 Offset: 0x2C538D0 VA: 0x2C578D0
	|-ScenarioData<object>.SettingRewardCheck
	|
	|-RVA: 0x2C5E388 Offset: 0x2C5A388 VA: 0x2C5E388
	|-ScenarioData<__Il2CppFullySharedGenericType>.SettingRewardCheck
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public bool RewardCheck(ItemManager itemManager, short keyNoFlag, short itemNoFlag, short mobNoFlag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C57AA0 Offset: 0x2C53AA0 VA: 0x2C57AA0
	|-ScenarioData<object>.RewardCheck
	|
	|-RVA: 0x2C5E674 Offset: 0x2C5A674 VA: 0x2C5E674
	|-ScenarioData<__Il2CppFullySharedGenericType>.RewardCheck
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public int GetRewardRepeatNum(ItemManager itemManager) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C58520 Offset: 0x2C54520 VA: 0x2C58520
	|-ScenarioData<object>.GetRewardRepeatNum
	|
	|-RVA: 0x2C5F260 Offset: 0x2C5B260 VA: 0x2C5F260
	|-ScenarioData<__Il2CppFullySharedGenericType>.GetRewardRepeatNum
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public int GetItemRestCount(ItemManager itemManager, int no) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C58DC8 Offset: 0x2C54DC8 VA: 0x2C58DC8
	|-ScenarioData<object>.GetItemRestCount
	|
	|-RVA: 0x2C5FCB8 Offset: 0x2C5BCB8 VA: 0x2C5FCB8
	|-ScenarioData<__Il2CppFullySharedGenericType>.GetItemRestCount
	*/

	// RVA: -1 Offset: -1
	public int[] GetCheckItemId() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C59028 Offset: 0x2C55028 VA: 0x2C59028
	|-ScenarioData<object>.GetCheckItemId
	|
	|-RVA: 0x2C5FF68 Offset: 0x2C5BF68 VA: 0x2C5FF68
	|-ScenarioData<__Il2CppFullySharedGenericType>.GetCheckItemId
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public int GetMobSubdueRestCount(int no) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C59498 Offset: 0x2C55498 VA: 0x2C59498
	|-ScenarioData<object>.GetMobSubdueRestCount
	|
	|-RVA: 0x2C604F8 Offset: 0x2C5C4F8 VA: 0x2C604F8
	|-ScenarioData<__Il2CppFullySharedGenericType>.GetMobSubdueRestCount
	*/

	// RVA: -1 Offset: -1
	public bool ItemClearCheck(ItemManager itemManager) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C596D4 Offset: 0x2C556D4 VA: 0x2C596D4
	|-ScenarioData<object>.ItemClearCheck
	|
	|-RVA: 0x2C6078C Offset: 0x2C5C78C VA: 0x2C6078C
	|-ScenarioData<__Il2CppFullySharedGenericType>.ItemClearCheck
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public bool MobSubdueCountUp(int fieldId, int mobUuid) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C59EB4 Offset: 0x2C55EB4 VA: 0x2C59EB4
	|-ScenarioData<object>.MobSubdueCountUp
	|
	|-RVA: 0x2C61158 Offset: 0x2C5D158 VA: 0x2C61158
	|-ScenarioData<__Il2CppFullySharedGenericType>.MobSubdueCountUp
	*/

	// RVA: -1 Offset: -1
	public void UpdateMobSubdue(byte mobNo, short updateVal) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C5A968 Offset: 0x2C56968 VA: 0x2C5A968
	|-ScenarioData<object>.UpdateMobSubdue
	|
	|-RVA: 0x2C61D44 Offset: 0x2C5DD44 VA: 0x2C61D44
	|-ScenarioData<__Il2CppFullySharedGenericType>.UpdateMobSubdue
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void SetViewFlag(byte checkFlag, short keyViewFlag, short itemViewFlag, short mobViewFlag, byte infoNo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C5ABBC Offset: 0x2C56BBC VA: 0x2C5ABBC
	|-ScenarioData<object>.SetViewFlag
	|
	|-RVA: 0x2C62074 Offset: 0x2C5E074 VA: 0x2C62074
	|-ScenarioData<__Il2CppFullySharedGenericType>.SetViewFlag
	*/

	// RVA: -1 Offset: -1
	public void SetFailedViewFlag(short keyViewFlag, short itemViewFlag, short mobViewFlag, byte infoNo) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C5AE3C Offset: 0x2C56E3C VA: 0x2C5AE3C
	|-ScenarioData<object>.SetFailedViewFlag
	|
	|-RVA: 0x2C62450 Offset: 0x2C5E450 VA: 0x2C62450
	|-ScenarioData<__Il2CppFullySharedGenericType>.SetFailedViewFlag
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public IScenarioKey SetKeyitem(byte keyNo, byte current, byte max) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C5B03C Offset: 0x2C5703C VA: 0x2C5B03C
	|-ScenarioData<object>.SetKeyitem
	|
	|-RVA: 0x2C6276C Offset: 0x2C5E76C VA: 0x2C6276C
	|-ScenarioData<__Il2CppFullySharedGenericType>.SetKeyitem
	*/

	// RVA: -1 Offset: -1
	public void SetFailedKeyitem(IScenarioKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C5B4CC Offset: 0x2C574CC VA: 0x2C5B4CC
	|-ScenarioData<object>.SetFailedKeyitem
	|
	|-RVA: 0x2C62D7C Offset: 0x2C5ED7C VA: 0x2C62D7C
	|-ScenarioData<__Il2CppFullySharedGenericType>.SetFailedKeyitem
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public int GetKeyitem(byte keyNo, byte type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C5B7D0 Offset: 0x2C577D0 VA: 0x2C5B7D0
	|-ScenarioData<object>.GetKeyitem
	|
	|-RVA: 0x2C63130 Offset: 0x2C5F130 VA: 0x2C63130
	|-ScenarioData<__Il2CppFullySharedGenericType>.GetKeyitem
	*/
}
