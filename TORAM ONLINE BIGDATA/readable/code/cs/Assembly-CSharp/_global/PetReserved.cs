// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetReserved : INPCPartyMemberReserve // TypeDefIndex: 485
{
	// Fields
	private bool isUsed; // 0x10
	private PetMemberSettingBase setting; // 0x18
	private PetModelLoader loader; // 0x20

	// Methods

	// RVA: 0x182718C Offset: 0x182318C VA: 0x182718C
	public void .ctor(PetMemberSettingBase setting) { }

	[IteratorStateMachine(typeof(PetReserved.<LoadModel>d__4))]
	// RVA: 0x1827214 Offset: 0x1823214 VA: 0x1827214 Slot: 4
	public IEnumerator LoadModel(Archetype archetype, PlayerDataManager playerDataManager) { }

	// RVA: 0x18272D8 Offset: 0x18232D8 VA: 0x18272D8
	private void CreatePet(GameObject gameObject, Archetype archetype, PlayerDataManager playerDataManager) { }
}
