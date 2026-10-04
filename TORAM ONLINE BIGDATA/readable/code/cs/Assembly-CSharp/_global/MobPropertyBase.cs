// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class MobPropertyBase // TypeDefIndex: 1091
{
	// Fields
	protected List<MobPropertyMaster> propertys; // 0x10

	// Properties
	public abstract MonsterPropertyType PropertyType { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract MonsterPropertyType get_PropertyType();

	// RVA: 0x1F468A4 Offset: 0x1F428A4 VA: 0x1F468A4
	public bool TryAddProperty(MobPropertyMaster master) { }

	// RVA: 0x1F47D74 Offset: 0x1F43D74 VA: 0x1F47D74 Slot: 5
	public virtual bool CheckAddable(MobPropertyMaster master) { }

	// RVA: 0x1F47D7C Offset: 0x1F43D7C VA: 0x1F47D7C
	protected MobPropertyMaster GetValue() { }

	// RVA: 0x1F477F4 Offset: 0x1F437F4 VA: 0x1F477F4
	protected MobPropertyMaster GetValue(int type) { }

	// RVA: 0x1F47DCC Offset: 0x1F43DCC VA: 0x1F47DCC
	public IEnumerable<MobPropertyMaster> GetProperty() { }

	// RVA: 0x1F478C8 Offset: 0x1F438C8 VA: 0x1F478C8
	protected void .ctor() { }
}
