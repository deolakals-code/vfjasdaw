// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SummonDemonicReserved : INPCPartyMemberReserve // TypeDefIndex: 489
{
	// Fields
	private readonly SummonDemonicMemberSettingBase setting; // 0x10
	private bool isUsed; // 0x18
	private ServantModelLoader loader; // 0x20

	// Methods

	// RVA: 0x1827AC8 Offset: 0x1823AC8 VA: 0x1827AC8
	public void .ctor(SummonDemonicMemberSettingBase setting) { }

	[IteratorStateMachine(typeof(SummonDemonicReserved.<LoadModel>d__4))]
	// RVA: 0x1827B50 Offset: 0x1823B50 VA: 0x1827B50 Slot: 4
	public IEnumerator LoadModel(Archetype archetype, PlayerDataManager playerDataManager) { }

	// RVA: 0x1827C14 Offset: 0x1823C14 VA: 0x1827C14
	private void CreateSummonDemonic(GameObject gameObject, Archetype archetype, PlayerDataManager playerDataManager) { }

	// RVA: 0x1827EA8 Offset: 0x1823EA8 VA: 0x1827EA8
	private static void SettingSummonDemonicModel(GameObject model, int modelId, int color) { }

	// RVA: 0x1827EB0 Offset: 0x1823EB0 VA: 0x1827EB0
	public static void SettingSummonDemonicModel(GameObject model, int modelId, int color, ServantDemonData servantData) { }
}
