// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IScenarioData // TypeDefIndex: 2204
{
	// Properties
	public abstract IScenario Scenario { get; }
	public abstract bool IsValid { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IScenario get_Scenario();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool get_IsValid();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool SettingRewardCheck(ItemManager itemManager);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool RewardCheck(ItemManager itemManager, short keyNoFlag, short itemNoFlag, short mobNoFlag);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int GetRewardRepeatNum(ItemManager itemManager);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool MobSubdueCountUp(int fieldId, int mobUuid);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int GetItemRestCount(ItemManager itemManager, int no);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int GetMobSubdueRestCount(int no);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SetViewFlag(byte checkFlag, short keyViewFlag, short itemViewFlag, short mobViewFlag, byte infoNo);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract IScenarioKey SetKeyitem(byte keyNo, byte current, byte max);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract int GetKeyitem(byte keyNo, byte type);
}
