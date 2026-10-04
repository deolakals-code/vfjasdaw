// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Scenarios
public interface IScenario // TypeDefIndex: 11082
{
	// Properties
	public abstract int Id { get; set; }
	public abstract short KeySetting { get; set; }
	public abstract short ItemSetting { get; set; }
	public abstract short MobSetting { get; set; }
	public abstract byte InfoNo { get; set; }
	public abstract List<IScenarioKey> KeyList { get; }
	public abstract List<IScenarioItem> ItemList { get; }
	public abstract List<IScenarioMob> MobList { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Id();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Id(int value);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract short get_KeySetting();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void set_KeySetting(short value);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract short get_ItemSetting();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_ItemSetting(short value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract short get_MobSetting();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_MobSetting(short value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract byte get_InfoNo();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void set_InfoNo(byte value);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract List<IScenarioKey> get_KeyList();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract List<IScenarioItem> get_ItemList();

	// RVA: -1 Offset: -1 Slot: 12
	public abstract List<IScenarioMob> get_MobList();
}
