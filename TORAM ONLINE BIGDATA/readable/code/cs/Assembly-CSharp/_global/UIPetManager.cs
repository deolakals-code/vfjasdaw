// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetManager : UIBasePanel // TypeDefIndex: 7803
{
	// Fields
	protected PlayerDataManager PlayerDataManager; // 0x30
	protected PetDataManager PetDataManager; // 0x38
	protected EnemyTextManager EnemyTextManager; // 0x40
	[CompilerGenerated]
	private PetOperationManager <PetOperation>k__BackingField; // 0x48
	private PetDataManager.PetViewData strayPet; // 0x50
	public static Dictionary<string, float> PetSizeList; // 0x0
	public static Dictionary<string, float> PetXYZSizeList; // 0x8

	// Properties
	public int OrbNum { get; }
	public PetOperationManager PetOperation { get; set; }
	public List<PetDataManager.PetViewData> PetViewDataList { get; }
	public PetDataManager.PetViewData StrayPet { get; set; }
	public List<PetDataManager.PetViewData> BreedPetDataList { get; }
	public List<PetDataManager.PetViewData> KennelPetDataList { get; }
	public List<PetDataManager.PetViewData> PetRecoveryLsit { get; }

	// Methods

	// RVA: 0x1C1BEE4 Offset: 0x1C17EE4 VA: 0x1C1BEE4
	public int get_OrbNum() { }

	[CompilerGenerated]
	// RVA: 0x1C2270C Offset: 0x1C1E70C VA: 0x1C2270C
	public PetOperationManager get_PetOperation() { }

	[CompilerGenerated]
	// RVA: 0x1C22714 Offset: 0x1C1E714 VA: 0x1C22714
	private void set_PetOperation(PetOperationManager value) { }

	// RVA: 0x1C2271C Offset: 0x1C1E71C VA: 0x1C2271C
	public List<PetDataManager.PetViewData> get_PetViewDataList() { }

	// RVA: 0x1C19FBC Offset: 0x1C15FBC VA: 0x1C19FBC
	public PetDataManager.PetViewData get_StrayPet() { }

	// RVA: 0x1C22738 Offset: 0x1C1E738 VA: 0x1C22738
	private void set_StrayPet(PetDataManager.PetViewData value) { }

	// RVA: 0x1C22740 Offset: 0x1C1E740 VA: 0x1C22740
	public void UpdateStrayPet() { }

	// RVA: 0x1C19C74 Offset: 0x1C15C74 VA: 0x1C19C74
	public List<PetDataManager.PetViewData> get_BreedPetDataList() { }

	// RVA: 0x1C22760 Offset: 0x1C1E760 VA: 0x1C22760
	public List<PetDataManager.PetViewData> BreedPetList(List<PetDataManager.PetViewData> list) { }

	// RVA: 0x1C2298C Offset: 0x1C1E98C VA: 0x1C2298C
	public void UpdateBreedData(long id, PetBreedStatusData status) { }

	// RVA: 0x1C1E24C Offset: 0x1C1A24C VA: 0x1C1E24C
	public List<PetDataManager.PetViewData> get_KennelPetDataList() { }

	// RVA: 0x1C22B20 Offset: 0x1C1EB20 VA: 0x1C22B20
	public List<PetDataManager.PetViewData> KennelPetList(List<PetDataManager.PetViewData> list) { }

	// RVA: 0x1C22DCC Offset: 0x1C1EDCC VA: 0x1C22DCC
	private int CompareDateTime(PetDataManager.PetViewData x, PetDataManager.PetViewData y) { }

	// RVA: 0x1C1BCB8 Offset: 0x1C17CB8 VA: 0x1C1BCB8 Slot: 7
	protected virtual void Start() { }

	// RVA: 0x1C1E268 Offset: 0x1C1A268 VA: 0x1C1E268
	public List<PetDataManager.PetViewData> get_PetRecoveryLsit() { }

	// RVA: 0x1C22EA4 Offset: 0x1C1EEA4 VA: 0x1C22EA4 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1C22EA8 Offset: 0x1C1EEA8 VA: 0x1C22EA8 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1C1B7EC Offset: 0x1C177EC VA: 0x1C1B7EC
	public static void SetDefaultScale(int monsterUuid, GameObject petModelObj, out float defaultSize) { }

	// RVA: 0x1C22EAC Offset: 0x1C1EEAC VA: 0x1C22EAC
	public static float GetUIModelScale(string modelId, GameObject petModelObj, float maxHeight) { }

	[IteratorStateMachine(typeof(UIPetManager.<GetUIModelScale>d__33))]
	// RVA: 0x1C1B9A0 Offset: 0x1C179A0 VA: 0x1C1B9A0
	public static IEnumerator GetUIModelScale(string modelId, GameObject petModelObj, float maxHeight, Action<float> callBack) { }

	[IteratorStateMachine(typeof(UIPetManager.<GetUIModelScaleXYZ>d__34))]
	// RVA: 0x1C23064 Offset: 0x1C1F064 VA: 0x1C23064
	public static IEnumerator GetUIModelScaleXYZ(string modelId, GameObject petModelObj, float maxSize, Action<float> callBack) { }

	// RVA: 0x1C21600 Offset: 0x1C1D600 VA: 0x1C21600
	public void .ctor() { }

	// RVA: 0x1C23138 Offset: 0x1C1F138 VA: 0x1C23138
	private static void .cctor() { }
}
