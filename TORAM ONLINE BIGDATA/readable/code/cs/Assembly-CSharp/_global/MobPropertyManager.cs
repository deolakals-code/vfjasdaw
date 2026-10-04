// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobPropertyManager // TypeDefIndex: 1084
{
	// Fields
	private Dictionary<MonsterPropertyType, MobPropertyBase> MobPropertyMasterList; // 0x10

	// Methods

	// RVA: 0x1F46774 Offset: 0x1F42774 VA: 0x1F46774
	public void SetMasterData(int mobUuid, int mobId, MobPropertyMaster[] master) { }

	// RVA: -1 Offset: -1
	public bool TryGetProperties<T>(MonsterPropertyType id, out T properties) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26DC2DC Offset: 0x26D82DC VA: 0x26DC2DC
	|-MobPropertyManager.TryGetProperties<object>
	*/

	// RVA: 0x1F46970 Offset: 0x1F42970 VA: 0x1F46970
	public MobPropertyMaster[] GetMobPropertyMasters() { }

	// RVA: 0x1F46EE4 Offset: 0x1F42EE4 VA: 0x1F46EE4
	public void Clear() { }

	// RVA: 0x1F46F34 Offset: 0x1F42F34 VA: 0x1F46F34
	public bool AddProperty(MobPropertyMaster master) { }

	// RVA: 0x1F46FF8 Offset: 0x1F42FF8 VA: 0x1F46FF8
	public void .ctor() { }
}
