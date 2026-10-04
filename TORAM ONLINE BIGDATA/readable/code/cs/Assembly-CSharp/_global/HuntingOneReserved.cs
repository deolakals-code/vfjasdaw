// Assembly: Assembly-CSharp.dll
// Namespace: 
public class HuntingOneReserved : INPCPartyMemberReserve // TypeDefIndex: 479
{
	// Fields
	private readonly HuntingOneMemberSettingBase setting; // 0x10
	private bool isUsed; // 0x18
	private ServantModelLoader loader; // 0x20

	// Methods

	// RVA: 0x182637C Offset: 0x182237C VA: 0x182637C
	public void .ctor(HuntingOneMemberSettingBase setting) { }

	[IteratorStateMachine(typeof(HuntingOneReserved.<LoadModel>d__4))]
	// RVA: 0x1826404 Offset: 0x1822404 VA: 0x1826404 Slot: 4
	public IEnumerator LoadModel(Archetype archetype, PlayerDataManager playerDataManager) { }

	// RVA: 0x18264C8 Offset: 0x18224C8 VA: 0x18264C8
	private void CreateHuntingOne(GameObject gameObject, Archetype archetype, PlayerDataManager playerDataManager) { }

	// RVA: 0x182675C Offset: 0x182275C VA: 0x182675C
	public static void SettingHuntingOneModel(GameObject model, int color) { }

	// RVA: 0x1826764 Offset: 0x1822764 VA: 0x1826764
	public static void SettingHuntingOneModel(GameObject model, int color, ServantData servantData) { }
}
