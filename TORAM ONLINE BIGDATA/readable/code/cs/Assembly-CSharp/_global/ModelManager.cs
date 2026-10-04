// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ModelManager : Singleton<ModelManager>, ISceneChangeManager // TypeDefIndex: 5355
{
	// Fields
	private Dictionary<ModelManager.CommonType, Dictionary<int, Object>> commonManager; // 0x20
	private Dictionary<int, BoneData> boneManager; // 0x28
	private List<int> boneAnimationFullManager; // 0x30
	private Dictionary<string, AnimationClip> playerBoneAnimationManager; // 0x38
	private Dictionary<int, Dictionary<string, AnimationClip>> boneAnimationManager; // 0x40
	private Dictionary<ModelManager.LoadModelType, Dictionary<int, ModelData>> modelManager; // 0x48
	private Dictionary<ModelManager.LoadModelType, Dictionary<int, ModelData>> modelRemoveManager; // 0x50
	private ModelData shadowModel; // 0x58
	private List<ModelData> cacheStatckManager; // 0x60
	private List<GameObject> poolObjext; // 0x68
	private List<GameObject> destroyBonePoolObjext; // 0x70
	private bool loadingAssets; // 0x78
	private int memoryStep; // 0x7C
	private float memoryStepWait; // 0x80
	private MultiWorkerThread thread; // 0x88
	private Shader[] loadedShader; // 0x90
	private readonly int[] StartEnterLoadMotionIds; // 0x98
	private readonly int[] CharacterCreateMotionIds; // 0xA0
	private int mergeCount; // 0xA8

	// Methods

	// RVA: 0x2632C18 Offset: 0x262EC18 VA: 0x2632C18
	private void Awake() { }

	// RVA: 0x2632C70 Offset: 0x262EC70 VA: 0x2632C70
	private void Start() { }

	// RVA: 0x2633174 Offset: 0x262F174 VA: 0x2633174
	public void DestoryModel(GameObject model) { }

	// RVA: 0x263358C Offset: 0x262F58C VA: 0x263358C
	private GameObject NewObject(string name) { }

	// RVA: 0x263381C Offset: 0x262F81C VA: 0x263381C
	public GameObject GetPoolObject(string name) { }

	// RVA: 0x2633820 Offset: 0x262F820 VA: 0x2633820
	public static byte EyeTextureID(byte id) { }

	// RVA: 0x263385C Offset: 0x262F85C VA: 0x263385C
	public static void GetModelSize(GameObject model, out Vector3 center, out Vector3 size) { }

	// RVA: 0x2633C60 Offset: 0x262FC60 VA: 0x2633C60
	public static bool SetModelColor(GameObject model, Color colorR, Color colorG, Color colorB) { }

	[IteratorStateMachine(typeof(ModelManager.<StartEnterLoadData>d__30))]
	// RVA: 0x2633F08 Offset: 0x262FF08 VA: 0x2633F08
	public IEnumerator StartEnterLoadData(Action<bool> callBack) { }

	[IteratorStateMachine(typeof(ModelManager.<StartEnterLoadCharacterCreateData>d__31))]
	// RVA: 0x2633F98 Offset: 0x262FF98 VA: 0x2633F98
	public IEnumerator StartEnterLoadCharacterCreateData(Action<bool> callBack) { }

	// RVA: 0x2634028 Offset: 0x2630028 VA: 0x2634028
	private void LoadCharacterBoneData(int boneId) { }

	// RVA: 0x2634900 Offset: 0x2630900 VA: 0x2634900
	public bool CheckCacheModelData(ModelManager.LoadModelType type, int id) { }

	[IteratorStateMachine(typeof(ModelManager.<EneterFieldLoadData>d__34))]
	// RVA: 0x2634B38 Offset: 0x2630B38 VA: 0x2634B38
	public IEnumerator EneterFieldLoadData(ModelManager.LoadModelType type, int id) { }

	[IteratorStateMachine(typeof(ModelManager.<EneterFieldNPCBoneLoadData>d__35))]
	// RVA: 0x2634BC0 Offset: 0x2630BC0 VA: 0x2634BC0
	public IEnumerator EneterFieldNPCBoneLoadData(bool isRemove, Dictionary<int, List<int>> motion, Action<bool> callback) { }

	[IteratorStateMachine(typeof(ModelManager.<EneterFieldNPCBoneLoadData>d__36))]
	// RVA: 0x2634C78 Offset: 0x2630C78 VA: 0x2634C78
	public IEnumerator EneterFieldNPCBoneLoadData(int id, Action<bool> callback, int[] motionIdList) { }

	// RVA: 0x2634D2C Offset: 0x2630D2C VA: 0x2634D2C
	public void AddEnterFieldMotion(int boneId, GameObject motion) { }

	// RVA: 0x26351A8 Offset: 0x26311A8 VA: 0x26351A8
	private Object GetLoadCommonData(ModelManager.CommonType type, int id) { }

	// RVA: 0x2635278 Offset: 0x2631278 VA: 0x2635278
	private ModelData GetLoadModelData(bool priority, ModelManager.LoadModelType type, int id) { }

	// RVA: 0x26358CC Offset: 0x26318CC VA: 0x26358CC
	private ModelData GetLoadModelData(bool priority, ModelManager.LoadModelType type, int id, string assetPath, string file) { }

	// RVA: 0x2635B58 Offset: 0x2631B58 VA: 0x2635B58
	private void LoadModelData(bool priority, ModelData modelData) { }

	[IteratorStateMachine(typeof(ModelManager.<LoadData>d__42))]
	// RVA: 0x2635CB0 Offset: 0x2631CB0 VA: 0x2635CB0
	public IEnumerator LoadData(string assetPath, string file, CacheObjectFlag flag, Action<bool, Object> callBack) { }

	[IteratorStateMachine(typeof(ModelManager.<LoadAssetData>d__43))]
	// RVA: 0x2635D78 Offset: 0x2631D78 VA: 0x2635D78
	public IEnumerator LoadAssetData(string assetPath, string file, CacheObjectFlag flag, Action<bool, Object> callBack) { }

	// RVA: 0x2632CD4 Offset: 0x262ECD4 VA: 0x2632CD4
	private void initShaderLoad() { }

	// RVA: 0x2635E40 Offset: 0x2631E40 VA: 0x2635E40
	private Shader getShader(ModelManager.ShaderTypes type) { }

	// RVA: 0x2635E78 Offset: 0x2631E78 VA: 0x2635E78
	private Vector3 CheckOffsetBone(int baseBoneId, int addBoneId, string[] boneName) { }

	// RVA: 0x26362C8 Offset: 0x26322C8 VA: 0x26362C8
	private MasterModelDataManager.OptionModelFlag AddBodyData(List<MergeList> mergeList, int bodyTopId, int bodyBottomId, byte sex, BodyCustomType bodyCustom, int bodyTopColor, int bodyBottomColor) { }

	// RVA: 0x2636F70 Offset: 0x2632F70 VA: 0x2636F70
	private MasterModelDataManager.OptionModelFlag AddOptionData(List<MergeList> mergeList, bool avatar, int id, int color) { }

	// RVA: 0x2637148 Offset: 0x2633148 VA: 0x2637148
	private int ConvertOptionSkinColorData(bool isOptionAvater, int optionId, bool isDecoAvater, int decoId) { }

	// RVA: 0x26371A0 Offset: 0x26331A0 VA: 0x26371A0
	private bool TryGetOptionGroupId(bool avater, int id, out int groupId) { }

	// RVA: 0x2637230 Offset: 0x2633230 VA: 0x2637230
	private void AddHairData(List<MergeList> mergeList, int hairFrontId, int hairId, int hairTailId, MasterModelDataManager.OptionModelFlag optionFlag) { }

	// RVA: 0x2637460 Offset: 0x2633460 VA: 0x2637460
	public void WeaponModelMerge(bool priority, int mainWeapon, int mainWeaponColor, int subWeapon, int subWeaponColor, float height, Action<GameObject, float> callback) { }

	// RVA: 0x2637BAC Offset: 0x2633BAC VA: 0x2637BAC
	public void DualWeaponModelMerge(bool priority, int mainWeapon, int mainWeaponColor, float height, Action<GameObject, float> callback) { }

	// RVA: 0x263829C Offset: 0x263429C VA: 0x263829C
	public void NonWeaponModelMerge(bool priority, NewArchetypeProperties property, float height, bool addAvatar, Action<GameObject, float> callback) { }

	// RVA: 0x26388BC Offset: 0x26348BC VA: 0x26388BC
	private void ChangeShaderMerge(GameObject model, NPCPartsData shader) { }

	// RVA: 0x2638AD8 Offset: 0x2634AD8 VA: 0x2638AD8
	public void ModelMerge(bool priority, NewArchetypeProperties property, Action<GameObject, float> callback) { }

	// RVA: 0x2639458 Offset: 0x2635458 VA: 0x2639458
	public void ModelMerge(bool priority, BCRankingPropertiesData property, Action<GameObject, float> callback) { }

	// RVA: 0x2639DD8 Offset: 0x2635DD8 VA: 0x2639DD8
	public void ModelMerge(bool priority, GameObject topModel, NPCModelData npc, Action<GameObject> callback) { }

	[IteratorStateMachine(typeof(ModelManager.<ModelMerge>d__60))]
	// RVA: 0x263B704 Offset: 0x2637704 VA: 0x263B704
	public IEnumerator ModelMerge(NPCModelData npc, GameObject topModel, Action<GameObject> callback) { }

	[IteratorStateMachine(typeof(ModelManager.<MergeLoadModel>d__61))]
	// RVA: 0x26379D8 Offset: 0x26339D8 VA: 0x26379D8
	private IEnumerator MergeLoadModel(bool player, bool priority, int baseBoneId, float height, int skinTextureId, int hairTextureId, int eyeTextureId, Color skinColor, Color hairColor, Color eyeColor, Color oddEyeColor, Color hairStreakColor, List<MergeList> mergeList, Dictionary<string, Vector3> boneScaleList, Action<GameObject, float> callback) { }

	// RVA: 0x263B7C4 Offset: 0x26377C4 VA: 0x263B7C4
	private GameObject CreateBoneData(string name, BoneData.BoneTrans boneData, SkinnedMeshRenderer rootSkin, Dictionary<string, Vector3> boneScaleList) { }

	// RVA: 0x263BB24 Offset: 0x2637B24 VA: 0x263BB24
	public Texture2D GetSkinTexture(int id) { }

	// RVA: 0x263BB8C Offset: 0x2637B8C VA: 0x263BB8C
	public Texture2D GetHairTexture(byte id) { }

	// RVA: 0x263BBF4 Offset: 0x2637BF4 VA: 0x263BBF4
	public Texture2D GetFaceTexture(byte id) { }

	// RVA: 0x263BC5C Offset: 0x2637C5C VA: 0x263BC5C
	public GameObject GetCacheEffectModel(int modelId, int motionId, CacheObjectFlag flag, bool cache, CacheObjectManager.CacheType type) { }

	// RVA: 0x263BFF4 Offset: 0x2637FF4 VA: 0x263BFF4
	public GameObject GetCacheGameObject(ModelManager.LoadModelType type, int id, string file, Action<bool, GameObject> callback) { }

	// RVA: 0x263D520 Offset: 0x2639520 VA: 0x263D520
	public bool GetGameObjects(byte[] binary, Action<GameObject[]> callback) { }

	[IteratorStateMachine(typeof(ModelManager.<GetGameObject>d__69))]
	// RVA: 0x263D83C Offset: 0x263983C VA: 0x263D83C
	public IEnumerator GetGameObject(ModelManager.LoadModelType type, int id, string file, Action<bool, GameObject> callback) { }

	// RVA: 0x263C118 Offset: 0x2638118 VA: 0x263C118
	private GameObject GetGameObject(ModelData modelData, MeshData meshData, string file) { }

	// RVA: 0x263D8F4 Offset: 0x26398F4 VA: 0x263D8F4
	private Material CreateMaterial(Dictionary<MaterialProperty, object> property, ModelData modelData) { }

	// RVA: 0x263E460 Offset: 0x263A460 VA: 0x263E460
	public void SetCopyEffectUpdate(int id, GameObject effect) { }

	// RVA: 0x263E860 Offset: 0x263A860 VA: 0x263E860
	public void ChangeEffectAreaShader(GameObject effect, float inR, float line) { }

	// RVA: 0x263EAB8 Offset: 0x263AAB8 VA: 0x263EAB8
	public bool GetAnimationClip(int boneId, string clipName, out AnimationClip clip) { }

	// RVA: 0x263EBB0 Offset: 0x263ABB0 VA: 0x263EBB0
	public bool AddAnimationClip(int boneId, Animation addAnimation) { }

	// RVA: 0x263EF20 Offset: 0x263AF20 VA: 0x263EF20
	public byte GetBoneIndex(int boneId, string boneName) { }

	// RVA: 0x263F058 Offset: 0x263B058 VA: 0x263F058
	public string GetBoneName(int boneId, byte boneIndex) { }

	// RVA: 0x263F13C Offset: 0x263B13C VA: 0x263F13C
	public bool TryGetBoneIndexList(int boneId, out Dictionary<byte, string> nameList) { }

	// RVA: 0x263F228 Offset: 0x263B228 VA: 0x263F228
	public void UpdatePlayerPropertyModel(List<GameObject> model, NewArchetypeProperties properties) { }

	// RVA: 0x263F804 Offset: 0x263B804 VA: 0x263F804
	private void CheckWarningMemory(float timer) { }

	// RVA: 0x263FAC0 Offset: 0x263BAC0 VA: 0x263FAC0
	private void Update() { }

	// RVA: 0x263FDB8 Offset: 0x263BDB8 VA: 0x263FDB8
	private void LateUpdate() { }

	// RVA: 0x263FE6C Offset: 0x263BE6C VA: 0x263FE6C Slot: 4
	public void OnEnter() { }

	// RVA: 0x263FE74 Offset: 0x263BE74 VA: 0x263FE74 Slot: 5
	public void OnLeave() { }

	// RVA: 0x263FE7C Offset: 0x263BE7C VA: 0x263FE7C
	public void .ctor() { }
}
