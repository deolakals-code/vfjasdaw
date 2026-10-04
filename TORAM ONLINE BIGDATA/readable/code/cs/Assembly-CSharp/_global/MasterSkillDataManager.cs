// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MasterSkillDataManager : Singleton<MasterSkillDataManager> // TypeDefIndex: 3384
{
	// Fields
	private Dictionary<short, SkillMasterData> masterSkillDataList; // 0x20
	private Dictionary<SkillId, SkillMasterData> masterSkillIdDataList; // 0x28
	private Dictionary<SkillId, List<SkillMasterData>> reverseList; // 0x30
	private Dictionary<SkillId, int[]> maseterSkillVoice; // 0x38
	private SkillTreeType[] SortSkillTreeTypeList; // 0x40

	// Methods

	// RVA: 0x2354878 Offset: 0x2350878 VA: 0x2354878
	public bool ReadSkillData(byte[] data) { }

	// RVA: 0x23550F4 Offset: 0x23510F4 VA: 0x23550F4
	public SkillMasterData GetSkillMaster(SkillId id) { }

	// RVA: 0x2355188 Offset: 0x2351188 VA: 0x2355188
	public bool ContainsSkillMaster(SkillId id) { }

	// RVA: 0x23551E0 Offset: 0x23511E0 VA: 0x23551E0
	public List<SkillMasterData> GetSkillTreeMaster(SkillTreeType type) { }

	// RVA: 0x2355300 Offset: 0x2351300 VA: 0x2355300
	public List<SkillMasterData> GetSkillTreeMaster(SkillTreeType type, int lv) { }

	// RVA: 0x2355424 Offset: 0x2351424 VA: 0x2355424
	public List<SkillMasterData> GetNextSkillMaster(SkillId premiseId) { }

	// RVA: 0x23554B8 Offset: 0x23514B8 VA: 0x23554B8
	public bool TryGetSkillVoice(SkillId skillId, out int voiceId) { }

	// RVA: 0x2355594 Offset: 0x2351594 VA: 0x2355594
	public bool CheckValidSkill(SkillId skillId, int skillLv) { }

	// RVA: 0x23555BC Offset: 0x23515BC VA: 0x23555BC
	public List<SkillMasterData> GetAllSkillData() { }

	// RVA: 0x23557C0 Offset: 0x23517C0 VA: 0x23557C0
	public SkillTreeType[] GetSortSkillTreeTypes() { }

	// RVA: 0x2355980 Offset: 0x2351980 VA: 0x2355980
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x2355B18 Offset: 0x2351B18 VA: 0x2355B18
	private int <GetSortSkillTreeTypes>b__14_0(SkillTreeType x) { }
}
