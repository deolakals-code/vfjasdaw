// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PetDataManager : MonoBehaviour // TypeDefIndex: 1301
{
	// Fields
	private PlayerDataManager playerDataManager; // 0x20
	[CompilerGenerated]
	private PetDataManager.PetViewData <StrayPet>k__BackingField; // 0x28
	[CompilerGenerated]
	private List<PetDataManager.PetViewData> <PetViewDataList>k__BackingField; // 0x30
	[CompilerGenerated]
	private List<PetDataManager.PetSummonData> <PetSummonDataList>k__BackingField; // 0x38
	[CompilerGenerated]
	private List<PetDataManager.PetViewData> <PetRecoveryList>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <BreedingMax>k__BackingField; // 0x48
	[CompilerGenerated]
	private int <KennelMax>k__BackingField; // 0x4C

	// Properties
	public PetDataManager.PetViewData StrayPet { get; set; }
	public List<PetDataManager.PetViewData> PetViewDataList { get; set; }
	public List<PetDataManager.PetSummonData> PetSummonDataList { get; set; }
	public List<PetDataManager.PetViewData> PetRecoveryList { get; set; }
	public int BreedingMax { get; set; }
	public int KennelMax { get; set; }
	public int PetBreedNum { get; }
	public int PetHungryNum { get; }
	public bool IsPetRaceEntry { get; }

	// Methods

	// RVA: 0x1FB3FC4 Offset: 0x1FAFFC4 VA: 0x1FB3FC4
	public static int GetFeedEffectTime(DateTime feedTime) { }

	[CompilerGenerated]
	// RVA: 0x1FB40B0 Offset: 0x1FB00B0 VA: 0x1FB40B0
	public PetDataManager.PetViewData get_StrayPet() { }

	[CompilerGenerated]
	// RVA: 0x1FB40B8 Offset: 0x1FB00B8 VA: 0x1FB40B8
	private void set_StrayPet(PetDataManager.PetViewData value) { }

	[CompilerGenerated]
	// RVA: 0x1FB40C0 Offset: 0x1FB00C0 VA: 0x1FB40C0
	public List<PetDataManager.PetViewData> get_PetViewDataList() { }

	[CompilerGenerated]
	// RVA: 0x1FB40C8 Offset: 0x1FB00C8 VA: 0x1FB40C8
	private void set_PetViewDataList(List<PetDataManager.PetViewData> value) { }

	[CompilerGenerated]
	// RVA: 0x1FB40D0 Offset: 0x1FB00D0 VA: 0x1FB40D0
	public List<PetDataManager.PetSummonData> get_PetSummonDataList() { }

	[CompilerGenerated]
	// RVA: 0x1FB40D8 Offset: 0x1FB00D8 VA: 0x1FB40D8
	private void set_PetSummonDataList(List<PetDataManager.PetSummonData> value) { }

	[CompilerGenerated]
	// RVA: 0x1FB40E0 Offset: 0x1FB00E0 VA: 0x1FB40E0
	public List<PetDataManager.PetViewData> get_PetRecoveryList() { }

	[CompilerGenerated]
	// RVA: 0x1FB40E8 Offset: 0x1FB00E8 VA: 0x1FB40E8
	private void set_PetRecoveryList(List<PetDataManager.PetViewData> value) { }

	[CompilerGenerated]
	// RVA: 0x1FB40F0 Offset: 0x1FB00F0 VA: 0x1FB40F0
	public int get_BreedingMax() { }

	[CompilerGenerated]
	// RVA: 0x1FB40F8 Offset: 0x1FB00F8 VA: 0x1FB40F8
	private void set_BreedingMax(int value) { }

	[CompilerGenerated]
	// RVA: 0x1FB4100 Offset: 0x1FB0100 VA: 0x1FB4100
	public int get_KennelMax() { }

	[CompilerGenerated]
	// RVA: 0x1FB4108 Offset: 0x1FB0108 VA: 0x1FB4108
	private void set_KennelMax(int value) { }

	// RVA: 0x1FB4110 Offset: 0x1FB0110 VA: 0x1FB4110
	public int get_PetBreedNum() { }

	// RVA: 0x1FB4348 Offset: 0x1FB0348 VA: 0x1FB4348
	public int get_PetHungryNum() { }

	// RVA: 0x1FB45AC Offset: 0x1FB05AC VA: 0x1FB45AC
	public bool get_IsPetRaceEntry() { }

	// RVA: 0x1FB47D4 Offset: 0x1FB07D4 VA: 0x1FB47D4
	private void Awake() { }

	// RVA: 0x1FB48C8 Offset: 0x1FB08C8 VA: 0x1FB48C8
	private void Update() { }

	// RVA: 0x1FB4B68 Offset: 0x1FB0B68 VA: 0x1FB4B68
	public void Init(PlayerDataManager playerDataManager) { }

	// RVA: 0x1FB4B70 Offset: 0x1FB0B70 VA: 0x1FB4B70
	public void SetPetData(PetEnterData data) { }

	// RVA: 0x1FB4DB4 Offset: 0x1FB0DB4 VA: 0x1FB4DB4
	public void RemovePetData(long uuid) { }

	// RVA: 0x1FB4EE8 Offset: 0x1FB0EE8 VA: 0x1FB4EE8
	public void AddPetData(PetInfoData data) { }

	// RVA: 0x1FB4FEC Offset: 0x1FB0FEC VA: 0x1FB4FEC
	public void SetPetSummonData(PetData[] data) { }

	// RVA: 0x1FB5184 Offset: 0x1FB1184 VA: 0x1FB5184
	public void SetStray(PetLoginEvent stray) { }

	// RVA: 0x1FB5498 Offset: 0x1FB1498 VA: 0x1FB5498
	public void RemoveStray() { }

	// RVA: 0x1FB4DA4 Offset: 0x1FB0DA4 VA: 0x1FB4DA4
	public void SetBreedingMax(int breedingMax) { }

	// RVA: 0x1FB4DAC Offset: 0x1FB0DAC VA: 0x1FB4DAC
	public void SetKennelMax(int kennelMax) { }

	// RVA: 0x1FB5504 Offset: 0x1FB1504 VA: 0x1FB5504
	public IEnumerable<ItemData> GetPetInCage() { }

	// RVA: 0x1FB5628 Offset: 0x1FB1628 VA: 0x1FB5628
	public static string ReplaceMobName(string name, int monsterUuid) { }

	// RVA: 0x1FB5758 Offset: 0x1FB1758 VA: 0x1FB5758
	public void SetPetRecoveryList(PetInfoData[] petLlist) { }

	// RVA: 0x1FB58D4 Offset: 0x1FB18D4 VA: 0x1FB58D4
	public void RemovePetRecoveryList(long uuid) { }

	// RVA: 0x1FB59F0 Offset: 0x1FB19F0 VA: 0x1FB59F0
	public PetDataManager.PetViewData GetPetRecoveryPet(long uuid) { }

	// RVA: 0x1FB5AE4 Offset: 0x1FB1AE4 VA: 0x1FB5AE4
	public PetDataManager.PetViewData GetPetViewData(long uuid) { }

	// RVA: 0x1FB5BC0 Offset: 0x1FB1BC0 VA: 0x1FB5BC0
	public List<PetDataManager.PetViewData> KennelPetList() { }

	// RVA: 0x1FB5E64 Offset: 0x1FB1E64 VA: 0x1FB5E64
	private int CompareDateTime(PetDataManager.PetViewData x, PetDataManager.PetViewData y) { }

	// RVA: 0x1FB5F3C Offset: 0x1FB1F3C VA: 0x1FB5F3C
	public static bool TryGetPetShopPassword(string inputText, out int password) { }

	// RVA: 0x1FB6034 Offset: 0x1FB2034 VA: 0x1FB6034
	public void .ctor() { }
}
