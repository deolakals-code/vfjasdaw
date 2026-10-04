// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FamiliaReserved : INPCPartyMemberReserve // TypeDefIndex: 475
{
	// Fields
	private bool isUsed; // 0x10
	private FamiliaMemberSettingBase setting; // 0x18
	private ServantModelLoader loader; // 0x20

	// Methods

	// RVA: 0x18258C4 Offset: 0x18218C4 VA: 0x18258C4
	public static void SettingFamiliaModel(GameObject model, int color) { }

	// RVA: 0x18258CC Offset: 0x18218CC VA: 0x18258CC
	public static void SettingFamiliaModel(GameObject model, int color, ServantData servantData) { }

	// RVA: 0x1825B9C Offset: 0x1821B9C VA: 0x1825B9C
	public void .ctor(FamiliaMemberSettingBase setting) { }

	[IteratorStateMachine(typeof(FamiliaReserved.<LoadModel>d__6))]
	// RVA: 0x1825C24 Offset: 0x1821C24 VA: 0x1825C24 Slot: 4
	public IEnumerator LoadModel(Archetype archetype, PlayerDataManager playerDataManager) { }

	// RVA: 0x1825CE8 Offset: 0x1821CE8 VA: 0x1825CE8
	private void CreateFamilia(GameObject gameObject, Archetype archetype, PlayerDataManager playerDataManager) { }
}
