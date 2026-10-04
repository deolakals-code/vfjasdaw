// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CallGolemReserved : INPCPartyMemberReserve // TypeDefIndex: 471
{
	// Fields
	private CallGolemMemberSettingBase setting; // 0x10
	private bool isUsed; // 0x18
	private PetModelLoader loader; // 0x20

	// Methods

	// RVA: 0x1825148 Offset: 0x1821148 VA: 0x1825148
	public void .ctor(CallGolemMemberSettingBase setting) { }

	[IteratorStateMachine(typeof(CallGolemReserved.<LoadModel>d__4))]
	// RVA: 0x18251D0 Offset: 0x18211D0 VA: 0x18251D0 Slot: 4
	public IEnumerator LoadModel(Archetype archetype, PlayerDataManager playerDataManager) { }

	// RVA: 0x1825294 Offset: 0x1821294 VA: 0x1825294
	private void CreateCallGolem(GameObject gameObject, Archetype archetype, PlayerDataManager playerDataManager) { }

	// RVA: 0x1825518 Offset: 0x1821518 VA: 0x1825518
	public static void SettingCallGolemModel(GameObject model, int modelId, int color, ServantData servamtData) { }
}
