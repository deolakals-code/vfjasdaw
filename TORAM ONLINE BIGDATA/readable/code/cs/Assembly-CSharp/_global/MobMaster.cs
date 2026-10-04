// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MobMaster : Singleton<MobMaster> // TypeDefIndex: 963
{
	// Fields
	public const string TagField = "OnField";
	public const string TagPet = "Pet";
	private readonly Dictionary<int, MobStatusMaster> mobMasters; // 0x20
	private readonly Dictionary<int, int[]> mobDropMasters; // 0x28
	private MobModelCacheManager modelCacheManager; // 0x30
	private bool isLevelWarning; // 0x38
	private List<MobHyperModeGroup> hyperModeGroups; // 0x40

	// Methods

	// RVA: 0x1F282BC Offset: 0x1F242BC VA: 0x1F282BC
	private void Awake() { }

	// RVA: 0x1F28378 Offset: 0x1F24378 VA: 0x1F28378
	private void Start() { }

	// RVA: 0x1F28434 Offset: 0x1F24434 VA: 0x1F28434
	public MobStatusMaster GetMobMaster(int id) { }

	// RVA: 0x1F0DF14 Offset: 0x1F09F14 VA: 0x1F0DF14
	public bool TryGetMaster(int id, out MobStatusMaster master) { }

	// RVA: 0x1F28524 Offset: 0x1F24524 VA: 0x1F28524
	public MobStatusMaster GetUidMobMaster(int uid) { }

	// RVA: 0x1F28628 Offset: 0x1F24628 VA: 0x1F28628
	public MobStatusMaster GetUidMobMaster(int uid, byte roomId) { }

	// RVA: 0x1F28734 Offset: 0x1F24734 VA: 0x1F28734
	public bool ReadMaster(int fieldId, TextAsset mobDbAsset, int[] popMobList) { }

	// RVA: 0x1F29A30 Offset: 0x1F25A30 VA: 0x1F29A30
	public bool TryGetDropMaster(int id, out int[] dropMaster) { }

	[IteratorStateMachine(typeof(MobMaster.<LoadMobResource>d__15))]
	// RVA: 0x1F29A98 Offset: 0x1F25A98 VA: 0x1F29A98
	public IEnumerator LoadMobResource(int[] popMobList, Action<bool> callback) { }

	[IteratorStateMachine(typeof(MobMaster.<LoadMobResource>d__16))]
	// RVA: 0x1F29B5C Offset: 0x1F25B5C VA: 0x1F29B5C
	public IEnumerator LoadMobResource(int modelId, Action<bool> result) { }

	[IteratorStateMachine(typeof(MobMaster.<LoadMobResource>d__17))]
	// RVA: 0x1F29C14 Offset: 0x1F25C14 VA: 0x1F29C14
	public IEnumerator LoadMobResource(int modelId, string tag, Action<bool> result) { }

	// RVA: 0x1F29CE8 Offset: 0x1F25CE8 VA: 0x1F29CE8
	public void RemoveMobResourceTag(string tag) { }

	// RVA: 0x1F29E00 Offset: 0x1F25E00 VA: 0x1F29E00
	public bool CheckLoadedMobResource(int modelId) { }

	// RVA: 0x1F29E8C Offset: 0x1F25E8C VA: 0x1F29E8C
	public void CheckMobLevelExpWarning(int playerLevel, int mobId) { }

	// RVA: 0x1F29F44 Offset: 0x1F25F44 VA: 0x1F29F44
	public void .ctor() { }
}
