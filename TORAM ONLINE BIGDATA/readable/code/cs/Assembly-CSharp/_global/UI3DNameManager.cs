// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UI3DNameManager : MonoBehaviour // TypeDefIndex: 6468
{
	// Fields
	private List<UINameLabel> nameLabelList; // 0x20
	private List<UINameLabel> removeNameList; // 0x28
	[SerializeField]
	private GameObject nameLabel; // 0x30
	[SerializeField]
	private GameObject playerLabel; // 0x38
	[SerializeField]
	private GameObject mobLabel; // 0x40
	[SerializeField]
	private GameObject guildRaidMobLabel; // 0x48
	[SerializeField]
	private GameObject fieldMotionLabel; // 0x50
	[SerializeField]
	private GameObject petLabel; // 0x58
	[SerializeField]
	private GameObject houseCookingLabel; // 0x60
	[SerializeField]
	private GameObject houseJukeboxLabel; // 0x68
	[SerializeField]
	private GameObject houseRhythmGameLabel; // 0x70
	[SerializeField]
	private GameObject searchPotumLabel; // 0x78
	[SerializeField]
	private GameObject guildStaffLabel; // 0x80
	[SerializeField]
	private GameObject houseBlackKnightLabel; // 0x88
	[SerializeField]
	private GameObject houseCardGameLabel; // 0x90
	[SerializeField]
	private GameObject houseCraneGameLabel; // 0x98
	[SerializeField]
	private GameObject houseRodLabel; // 0xA0
	[SerializeField]
	private GameObject housePetRaceLabel; // 0xA8
	[SerializeField]
	private GameObject waveCristalLabel; // 0xB0
	[SerializeField]
	private GameObject houseMahjongLabel; // 0xB8
	private ItemTextManager itemTextManager; // 0xC0
	private PlayerDataManager playerDataManager; // 0xC8
	private int houseNearItemUid; // 0xD0
	private int haouseUpdateNearItemUid; // 0xD4
	private float houseUpdateNearItemDist; // 0xD8

	// Methods

	// RVA: 0x193B28C Offset: 0x193728C VA: 0x193B28C
	public void Initialize(ItemTextManager itemTextManager, PlayerDataManager playerDataManager) { }

	// RVA: 0x193C9AC Offset: 0x19389AC VA: 0x193C9AC
	public bool TryGetTraceTargetLabel(Transform traceTarget, out Transform parent) { }

	// RVA: 0x1941034 Offset: 0x193D034 VA: 0x1941034
	public void AddMobNameLabel(GameObject traceMobObject) { }

	// RVA: 0x1941300 Offset: 0x193D300 VA: 0x1941300
	public void ChangeMobNameLabel(GameObject tracePlayerObject) { }

	// RVA: 0x19416D4 Offset: 0x193D6D4 VA: 0x19416D4
	public void AddEventNameLabel(GameObject traceEventObject) { }

	// RVA: 0x19418F0 Offset: 0x193D8F0 VA: 0x19418F0
	public void AddFieldMotionObjectLabel(GameObject traceObject, int id) { }

	// RVA: 0x1941AF0 Offset: 0x193DAF0 VA: 0x1941AF0
	public void AddItemNameLabel(GameObject traceItemObject, int itemId) { }

	// RVA: 0x1941D94 Offset: 0x193DD94 VA: 0x1941D94
	public void AddPlayerNameLabel(GameObject tracePlayerObject, string name, byte heightId) { }

	// RVA: 0x1942164 Offset: 0x193E164 VA: 0x1942164
	public void ChangePlayerNameLabel(GameObject tracePlayerObject, string name, byte heightId, bool tapEnabled) { }

	// RVA: 0x1942438 Offset: 0x193E438 VA: 0x1942438
	public void AddHousePetLabel(long uid, GameObject tracePlayerObject, string name, byte scale) { }

	// RVA: 0x1942674 Offset: 0x193E674 VA: 0x1942674
	public void ChangeHousePetLabel(long uid, GameObject tracePlayerObject, string name, byte scale) { }

	// RVA: 0x194293C Offset: 0x193E93C VA: 0x194293C
	public void AddHouseCookingLabel(GameObject tracePlayerObject, int uid, byte scale, Vector3 size, HouseCuisineManager.CuisineType type) { }

	// RVA: 0x1942C38 Offset: 0x193EC38 VA: 0x1942C38
	public void AddHouseJukeboxLabel(GameObject tracePlayerObject, int uid, byte scale) { }

	// RVA: 0x1942ED0 Offset: 0x193EED0 VA: 0x1942ED0
	public void AddHouseFishingRodLabel(GameObject tracePlayerObject, int uid, byte scale) { }

	// RVA: 0x1943168 Offset: 0x193F168 VA: 0x1943168
	public void AddHouseMahjongLabel(GameObject tracePlayerObject, int uid, byte scale) { }

	// RVA: 0x19433A4 Offset: 0x193F3A4 VA: 0x19433A4
	public void AddHouseRhythmGameLabel(GameObject tracePlayerObject, int uid) { }

	// RVA: 0x19435CC Offset: 0x193F5CC VA: 0x19435CC
	public void AddHouseBlackKnightLabel(GameObject tracePlayerObject, int uid) { }

	// RVA: 0x19437F4 Offset: 0x193F7F4 VA: 0x19437F4
	public void AddHouseCardGameLabel(GameObject tracePlayerObject, int uid) { }

	// RVA: 0x1943A1C Offset: 0x193FA1C VA: 0x1943A1C
	public void AddHouseCraneGameLabel(GameObject tracePlayerObject, int uid) { }

	// RVA: 0x1943C44 Offset: 0x193FC44 VA: 0x1943C44
	public void AddHousePetRaceGameLabel(GameObject tracePlayerObject, int uid) { }

	// RVA: 0x1943E80 Offset: 0x193FE80 VA: 0x1943E80
	public void AddHousePetShopLabel(Transform traceObject, int uid) { }

	// RVA: 0x1944144 Offset: 0x1940144 VA: 0x1944144
	public void AddCaptureMobLabel(GameObject traceMobObject, ICaptureTimer cap) { }

	// RVA: 0x1944384 Offset: 0x1940384 VA: 0x1944384
	public void AddSearchPotumLabel(GameObject tracecPlayerObject, int manageId, float scale) { }

	// RVA: 0x19445AC Offset: 0x19405AC VA: 0x19445AC
	public void AddGuildStaffLabel(Transform tracecPlayerObject, float scale, bool isMyGuild) { }

	// RVA: 0x19447AC Offset: 0x19407AC VA: 0x19447AC
	public void AddWaveCristalLabel(Transform traceObject, int uid, string text) { }

	// RVA: 0x19449C0 Offset: 0x19409C0 VA: 0x19449C0
	public void ChangeWaveCristalLabel(Transform traceObject, int uid, string text) { }

	// RVA: 0x1944CD4 Offset: 0x1940CD4 VA: 0x1944CD4
	public UIMobaChestLabel AddMobaChestLabel(Transform traceObject, int uniqueId) { }

	// RVA: 0x19451A8 Offset: 0x19411A8 VA: 0x19451A8
	public UIMobaTreasureDropLabel AddMobaTreasureDropLabel(Transform traceObject, int uniqueId) { }

	// RVA: 0x19456AC Offset: 0x19416AC VA: 0x19456AC
	public void AddPetRecoveryLabel(Transform traceObject) { }

	// RVA: 0x1945ADC Offset: 0x1941ADC VA: 0x1945ADC
	public void RemovePetRecoveryLabel(Transform traceObject) { }

	// RVA: 0x193C094 Offset: 0x1938094 VA: 0x193C094
	public void LeaveField() { }

	// RVA: 0x1946CE0 Offset: 0x1942CE0 VA: 0x1946CE0
	public bool CheckHouseItemNearObject(int uid, float dist) { }

	// RVA: 0x193B374 Offset: 0x1937374 VA: 0x193B374
	public void UpdateList(bool playerNameLabelHideFlag) { }

	// RVA: 0x1946D04 Offset: 0x1942D04 VA: 0x1946D04
	public void .ctor() { }
}
