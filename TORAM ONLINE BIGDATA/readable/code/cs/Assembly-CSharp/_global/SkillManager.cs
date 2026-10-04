// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillManager : MonoBehaviour // TypeDefIndex: 3596
{
	// Fields
	private MasterSkillDataManager masterSkillManager; // 0x20
	private Dictionary<SkillId, SkillData> skillList; // 0x28
	private Dictionary<SkillId, SkillData> availableSkillList; // 0x30
	private Dictionary<SkillId, SkillMasteryBase> skillMasteryList; // 0x38
	private Dictionary<SkillTreeType, byte> skillTreeList; // 0x40
	private Dictionary<SkillId, SkillData> equipSkillList; // 0x48
	private Dictionary<SkillId, SkillData> availableEquipSkillList; // 0x50
	private Dictionary<SkillId, SkillMasteryBase> equipSkillMasteryList; // 0x58
	private Dictionary<SkillId, MobaSkillData> mobaSkillMasterList; // 0x60
	[CompilerGenerated]
	private Dictionary<SkillId, SkillMasteryBase> <SkillMasteryList>k__BackingField; // 0x68

	// Properties
	public Dictionary<SkillId, SkillData> SkillList { get; }
	public Dictionary<SkillId, SkillData> AvailableSkillList { get; }
	public Dictionary<SkillId, SkillMasteryBase> SkillMasteryList { get; set; }
	public List<SkillTreeType> SkillTreeList { get; }
	public Dictionary<SkillId, SkillData> EquipSkillList { get; }
	public Dictionary<SkillId, SkillData> AvailableEquipSkillList { get; }
	public IList<MobaSkillData> EnableMobaSkillList { get; }

	// Methods

	// RVA: 0x239EC94 Offset: 0x239AC94 VA: 0x239EC94
	public Dictionary<SkillId, SkillData> get_SkillList() { }

	// RVA: 0x239EC9C Offset: 0x239AC9C VA: 0x239EC9C
	public Dictionary<SkillId, SkillData> get_AvailableSkillList() { }

	[CompilerGenerated]
	// RVA: 0x239ECA4 Offset: 0x239ACA4 VA: 0x239ECA4
	public Dictionary<SkillId, SkillMasteryBase> get_SkillMasteryList() { }

	[CompilerGenerated]
	// RVA: 0x239ECAC Offset: 0x239ACAC VA: 0x239ECAC
	private void set_SkillMasteryList(Dictionary<SkillId, SkillMasteryBase> value) { }

	// RVA: 0x239ECB4 Offset: 0x239ACB4 VA: 0x239ECB4
	public List<SkillTreeType> get_SkillTreeList() { }

	// RVA: 0x239ED54 Offset: 0x239AD54 VA: 0x239ED54
	public Dictionary<SkillId, SkillData> get_EquipSkillList() { }

	// RVA: 0x239ED5C Offset: 0x239AD5C VA: 0x239ED5C
	public Dictionary<SkillId, SkillData> get_AvailableEquipSkillList() { }

	// RVA: 0x239ED64 Offset: 0x239AD64 VA: 0x239ED64
	public IList<MobaSkillData> get_EnableMobaSkillList() { }

	// RVA: 0x239EDF0 Offset: 0x239ADF0 VA: 0x239EDF0
	public void .ctor() { }

	// RVA: 0x239F028 Offset: 0x239B028 VA: 0x239F028
	private void Awake() { }

	[IteratorStateMachine(typeof(SkillManager.<GetParam>d__27))]
	// RVA: 0x239F07C Offset: 0x239B07C VA: 0x239F07C
	public IEnumerable<string> GetParam() { }

	// RVA: 0x239F0D4 Offset: 0x239B0D4 VA: 0x239F0D4
	public void UpdateSkillList(Dictionary<short, byte> skill) { }

	// RVA: 0x239FDDC Offset: 0x239BDDC VA: 0x239FDDC
	public void UpdateSkillLv(SkillId id, SkillTreeType skillTreeType, byte lv) { }

	// RVA: 0x23A021C Offset: 0x239C21C VA: 0x23A021C
	public bool AddSkill(SkillId skillId) { }

	// RVA: 0x23A00DC Offset: 0x239C0DC VA: 0x23A00DC
	public bool AddSkill(SkillId skillId, SkillTreeType skillTreeType) { }

	// RVA: 0x239F9E0 Offset: 0x239B9E0 VA: 0x239F9E0
	private void updateAvailableSkill() { }

	// RVA: 0x23A0224 Offset: 0x239C224 VA: 0x23A0224
	public int GetSkillTreeLv(SkillTreeType type, bool checkEquipSkill = False) { }

	// RVA: 0x23A073C Offset: 0x239C73C VA: 0x23A073C
	public int GetSkillTreePoint(SkillTreeType type) { }

	// RVA: 0x23A0924 Offset: 0x239C924 VA: 0x23A0924
	public int GetSkillTreePoint() { }

	// RVA: 0x23A0A98 Offset: 0x239CA98 VA: 0x23A0A98
	public int GetSkillTreeCount() { }

	// RVA: 0x23A0AE8 Offset: 0x239CAE8 VA: 0x23A0AE8
	public int GetSkillType(SkillId id) { }

	// RVA: 0x2391784 Offset: 0x238D784 VA: 0x2391784
	public int GetSkillLv(SkillId id, bool checkEquipSkill = True) { }

	// RVA: 0x23A0B48 Offset: 0x239CB48 VA: 0x23A0B48
	public int GetAllSkillLvInTree(SkillTreeType id, bool checkEquipSkill = True) { }

	// RVA: 0x23A0CC8 Offset: 0x239CCC8 VA: 0x23A0CC8
	public int GetSkillNumInTree(SkillTreeType id, bool checkEquipSkill = True) { }

	// RVA: 0x23A0E48 Offset: 0x239CE48 VA: 0x23A0E48
	public List<int> GetSkillTakeList(CharacterActionManagerBase actionManager) { }

	// RVA: 0x23A1070 Offset: 0x239D070 VA: 0x23A1070
	public List<int> GetSkillTakeList(SkillId skillId, CharacterActionManagerBase actionManager) { }

	// RVA: 0x23A1268 Offset: 0x239D268 VA: 0x23A1268
	public List<SkillActionBase> GetEquipAcitveSkillList(ItemDBData.ItemType main, ItemDBData.ItemType sub) { }

	// RVA: 0x23A1854 Offset: 0x239D854 VA: 0x23A1854
	public bool CheckEquipAcitveSkill(SkillId skillId, SkillEqLimitFlag flag) { }

	// RVA: 0x23A18A4 Offset: 0x239D8A4 VA: 0x23A18A4
	public bool CheckEquipAcitveSkill(SkillId skillId, PlayerStatusBase status, SkillType[] exclusionSkillTypes) { }

	// RVA: 0x23A19A8 Offset: 0x239D9A8 VA: 0x23A19A8
	public List<SkillId> GetEquipEnableSkillList(bool checkEquipSkill) { }

	// RVA: 0x23A1AAC Offset: 0x239DAAC VA: 0x23A1AAC
	public List<SkillMasteryBase> GetEquipPassiveSkillList(SkillEqLimitFlag flag) { }

	// RVA: 0x23A1BC4 Offset: 0x239DBC4 VA: 0x23A1BC4
	public bool IsAvailableSkill(SkillType type, bool checkEquip = False) { }

	// RVA: 0x23A1CFC Offset: 0x239DCFC VA: 0x23A1CFC
	public List<SkillTreeType> GetSkillTreeType(bool checkEquipSkill = False) { }

	// RVA: 0x23A1FB0 Offset: 0x239DFB0 VA: 0x23A1FB0
	public SkillActionBase GetAvailableSkill(PlayerActionManagerBase playerAction, bool starGemLoack, short skillId, out int popType) { }

	// RVA: 0x23A2D5C Offset: 0x239ED5C VA: 0x23A2D5C
	private void CacheSkillEffect(List<short> skillIdList) { }

	// RVA: 0x239FDD8 Offset: 0x239BDD8 VA: 0x239FDD8
	private void learnDefaultSkill() { }

	// RVA: 0x23A2DA8 Offset: 0x239EDA8 VA: 0x23A2DA8
	public void UpdateStarGemSkill(SkillData[] skills) { }

	// RVA: 0x23A38F0 Offset: 0x239F8F0 VA: 0x23A38F0
	public void UpdateAvatarSkill(SkillData[] skills) { }

	// RVA: 0x23A3EC4 Offset: 0x239FEC4 VA: 0x23A3EC4
	public void UpdateNinjaSkill(SkillData[] skills) { }

	// RVA: 0x23A4498 Offset: 0x23A0498 VA: 0x23A4498
	public void UpdateMobaSkillData(MobaSkillData[] mobaSkillMasters) { }

	// RVA: 0x23A337C Offset: 0x239F37C VA: 0x23A337C
	private void UpdateEquipSkill(SkillData[] skills) { }

	// RVA: 0x23A0458 Offset: 0x239C458 VA: 0x23A0458
	private void CreateMasteryList() { }

	// RVA: 0x23A0B34 Offset: 0x239CB34 VA: 0x23A0B34
	public static bool IsAvatarSkill(short skillId) { }

	// RVA: 0x23A072C Offset: 0x239C72C VA: 0x23A072C
	public static bool IsAvatarSkillTreeType(SkillTreeType type) { }

	// RVA: 0x23A455C Offset: 0x23A055C VA: 0x23A455C
	public static int GetAvatarSkillId(int bonusValue) { }

	[CompilerGenerated]
	// RVA: 0x23A457C Offset: 0x23A057C VA: 0x23A457C
	private int <UpdateSkillList>b__28_3(KeyValuePair<SkillTreeType, byte> x) { }

	[CompilerGenerated]
	// RVA: 0x23A45E4 Offset: 0x23A05E4 VA: 0x23A45E4
	private bool <GetEquipAcitveSkillList>b__43_0(SkillId eq) { }
}
