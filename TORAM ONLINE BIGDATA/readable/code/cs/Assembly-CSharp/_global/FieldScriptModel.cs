// Assembly: Assembly-CSharp.dll
// Namespace: 
public class FieldScriptModel : MonoBehaviour // TypeDefIndex: 4809
{
	// Fields
	private GameObject model; // 0x20
	private int motionId; // 0x28
	private int modelId; // 0x2C
	private ModelType modelType; // 0x30
	private List<AnimationClip> animationList; // 0x38
	private bool isPlayerCheck; // 0x40
	private bool fadeIn; // 0x41
	private FadeAnimationManager fadeAnimationManager; // 0x48
	private FloorLightMap lightMap; // 0x50
	private float motionChangeWait; // 0x58
	private Animation animationComponent; // 0x60
	private bool isInvisibleMiniMap; // 0x68
	private GameObject billboradView; // 0x70
	private float playMotionSpeed; // 0x78
	private Motion motionComponent; // 0x80
	private FieldScriptModel.WaitFlag actionWaitFlag; // 0x88
	private int weaponType; // 0x8C
	private int subWeaponType; // 0x90
	private bool anitmionLock; // 0x94
	private float now_alpha; // 0x98
	private BaseCloneRender cloneRender; // 0xA0
	private FieldScriptCharacterMove characterMove; // 0xA8
	private AnimationBase animationPlayer; // 0xB0
	private int nextMotionId; // 0xB8
	private FieldScriptModel.FieldScriptMotionType fieldScriptMotionType; // 0xBC
	private const int WAITCOUNT = 240;
	private Dictionary<string, FieldScriptModel.CharacterScaleObject> CharacterScaleList; // 0xC0

	// Properties
	private Animation modelAnimation { get; }
	private Motion modelMotion { get; }
	public int ActionWaitFlag { get; }
	public bool IsLoadedModel { get; }
	public bool IsInvisibleMiniMap { get; }
	public GameObject BillboradView { get; }

	// Methods

	// RVA: 0x25A8484 Offset: 0x25A4484 VA: 0x25A8484
	private Animation get_modelAnimation() { }

	// RVA: 0x25A8534 Offset: 0x25A4534 VA: 0x25A8534
	private Motion get_modelMotion() { }

	// RVA: 0x25A85E4 Offset: 0x25A45E4 VA: 0x25A85E4
	public int get_ActionWaitFlag() { }

	// RVA: 0x25A2210 Offset: 0x259E210 VA: 0x25A2210
	public bool get_IsLoadedModel() { }

	// RVA: 0x25A85EC Offset: 0x25A45EC VA: 0x25A85EC
	public bool get_IsInvisibleMiniMap() { }

	// RVA: 0x25A85F4 Offset: 0x25A45F4 VA: 0x25A85F4
	public GameObject get_BillboradView() { }

	// RVA: 0x25A1D98 Offset: 0x259DD98 VA: 0x25A1D98
	public void Initialize(ModelType modelType, int modelId, Vector3 pos, short rot, byte id, short motion, short flag) { }

	// RVA: 0x25A2AEC Offset: 0x259EAEC VA: 0x25A2AEC
	public void Initialize(Vector3 pos, short rot, byte id, short motion, short flag) { }

	// RVA: 0x25A948C Offset: 0x25A548C VA: 0x25A948C
	private void Update() { }

	// RVA: 0x25A9A0C Offset: 0x25A5A0C VA: 0x25A9A0C
	private void LateUpdate() { }

	// RVA: 0x25A9E50 Offset: 0x25A5E50 VA: 0x25A9E50
	private void OnDestroy() { }

	// RVA: 0x25AA0A8 Offset: 0x25A60A8 VA: 0x25AA0A8
	private void ModelDestroy() { }

	// RVA: 0x25AA0B0 Offset: 0x25A60B0 VA: 0x25AA0B0
	private void ModelDestroy(float time) { }

	// RVA: 0x25AA144 Offset: 0x25A6144 VA: 0x25AA144
	public void ActionSkip() { }

	// RVA: 0x25AA1EC Offset: 0x25A61EC VA: 0x25AA1EC
	public void SetMiniMapInvisible(bool invisible) { }

	// RVA: 0x25AA1F8 Offset: 0x25A61F8 VA: 0x25AA1F8
	public void SetBillboardView(GameObject viewTrans) { }

	[IteratorStateMachine(typeof(FieldScriptModel.<AddShadowBoneEffect>d__44))]
	// RVA: 0x25AA378 Offset: 0x25A6378 VA: 0x25AA378
	public IEnumerator AddShadowBoneEffect(string boneName) { }

	[IteratorStateMachine(typeof(FieldScriptModel.<LoadNPC>d__45))]
	// RVA: 0x25A2DE0 Offset: 0x259EDE0 VA: 0x25A2DE0
	public IEnumerator LoadNPC(NPCModelData npc, int eventIndex) { }

	// RVA: 0x25A8E68 Offset: 0x25A4E68 VA: 0x25A8E68
	private void CopyPartyMember(int id) { }

	// RVA: 0x25A8CEC Offset: 0x25A4CEC VA: 0x25A8CEC
	public void LoadFieldObject(int id) { }

	// RVA: 0x25A8E64 Offset: 0x25A4E64 VA: 0x25A8E64
	public void CloneLoadFieldObject(int id) { }

	// RVA: 0x25A8A90 Offset: 0x25A4A90 VA: 0x25A8A90
	public void LoadMob(int mobId) { }

	// RVA: 0x25AA458 Offset: 0x25A6458 VA: 0x25AA458
	private void SettingMob(GameObject modelObject) { }

	// RVA: 0x25A8968 Offset: 0x25A4968 VA: 0x25A8968
	public void LoadEffect(int effectId) { }

	// RVA: 0x25AA804 Offset: 0x25A6804 VA: 0x25AA804
	private void SettingEffect(bool flag, GameObject modelObject) { }

	// RVA: 0x25A90F0 Offset: 0x25A50F0 VA: 0x25A90F0
	public void LoadProp(int propId) { }

	// RVA: 0x25AAC10 Offset: 0x25A6C10 VA: 0x25AAC10
	private void SettingProp(GameObject modelObject) { }

	[IteratorStateMachine(typeof(FieldScriptModel.<LoadModel>d__55))]
	// RVA: 0x25AADB0 Offset: 0x25A6DB0 VA: 0x25AADB0
	private IEnumerator LoadModel(string assetPath, string filePath, Action<GameObject> callBack) { }

	// RVA: 0x25A85FC Offset: 0x25A45FC VA: 0x25A85FC
	public void SetModel(GameObject modelObject) { }

	// RVA: 0x25AB7D4 Offset: 0x25A77D4 VA: 0x25AB7D4
	public GameObject CloneModel() { }

	// RVA: 0x25ABCFC Offset: 0x25A7CFC VA: 0x25ABCFC
	private void AddCharacterMove() { }

	// RVA: 0x25ABE70 Offset: 0x25A7E70 VA: 0x25ABE70
	public void AttachBone(GameObject attach, string boneName, Vector3 offsetPos, Vector3 offsetRot, Vector3 offsetScale) { }

	[IteratorStateMachine(typeof(FieldScriptModel.<AttachBoneThread>d__60))]
	// RVA: 0x25AC0E8 Offset: 0x25A80E8 VA: 0x25AC0E8
	private IEnumerator AttachBoneThread(GameObject attach, string boneName, Vector3 pos, Vector3 rot, Vector3 scale) { }

	// RVA: 0x25AC20C Offset: 0x25A820C VA: 0x25AC20C
	public bool InitNPCCloneRender(int num) { }

	// RVA: 0x25A92C8 Offset: 0x25A52C8 VA: 0x25A92C8
	public void LoadServant(int id) { }

	// RVA: 0x25AC3BC Offset: 0x25A83BC VA: 0x25AC3BC
	private void SettingServant(GameObject modelObject) { }

	// RVA: 0x25AC710 Offset: 0x25A8710 VA: 0x25AC710
	public void TargetTimeMove(float x, float z, float time, int flag) { }

	// RVA: 0x25AC8D4 Offset: 0x25A88D4 VA: 0x25AC8D4
	public void TargetTimeMove(float y, float time, int flag) { }

	// RVA: 0x25ACA60 Offset: 0x25A8A60 VA: 0x25ACA60
	public void TargetTimeMove(float x, float y, float z, float time, int flag) { }

	// RVA: 0x25ACC0C Offset: 0x25A8C0C VA: 0x25ACC0C
	public void TargetTimeParabolaMove(float x, float y, float z, float time, float rot, int flag) { }

	// RVA: 0x25ACDC4 Offset: 0x25A8DC4 VA: 0x25ACDC4
	public void TargetParabolaMove(float xEuler, float yEuler, float height, float zEuler, int flag) { }

	// RVA: 0x25AD030 Offset: 0x25A9030 VA: 0x25AD030
	public void CurveMove(float x0, float y0, float z0, float x1, float y1, float z1, float time, int flag) { }

	// RVA: 0x25AD1EC Offset: 0x25A91EC VA: 0x25AD1EC
	private void OnMoveEnd() { }

	// RVA: 0x25AD208 Offset: 0x25A9208 VA: 0x25AD208
	public bool SetNPCCloneRenderPos(byte cloneId, Vector3 pos) { }

	// RVA: 0x25AD2CC Offset: 0x25A92CC VA: 0x25AD2CC
	public void TimeScale(Vector3 scale, float timer) { }

	// RVA: 0x25AD314 Offset: 0x25A9314 VA: 0x25AD314
	public bool SetNPCCloneRenderScale(byte cloneId, Vector3 scale) { }

	// RVA: 0x25AD3D8 Offset: 0x25A93D8 VA: 0x25AD3D8
	public void TimeRotate(float rot, float time, int flag) { }

	// RVA: 0x25AD658 Offset: 0x25A9658 VA: 0x25AD658
	public void TimeRotateEx(Vector3 rot, float time, int flag) { }

	// RVA: 0x25AD88C Offset: 0x25A988C VA: 0x25AD88C
	private void OnRotEnd() { }

	// RVA: 0x25AD8A8 Offset: 0x25A98A8 VA: 0x25AD8A8
	public bool SetNPCCloneRenderRot(byte cloneId, Vector3 rot) { }

	// RVA: 0x25AD970 Offset: 0x25A9970 VA: 0x25AD970
	public void MotionPlay(int playId, int nextId, int type) { }

	// RVA: 0x25AD97C Offset: 0x25A997C VA: 0x25AD97C
	public void MotionPlay(int playId, int nextId, int type, byte weaponFlag) { }

	// RVA: 0x25AD984 Offset: 0x25A9984 VA: 0x25AD984
	public void MotionPlay(int playId, int nextId, int type, byte weaponFlag, float playMotionSpeed) { }

	// RVA: 0x25AAE90 Offset: 0x25A6E90 VA: 0x25AAE90
	private void StartPlayMotion() { }

	// RVA: 0x25A95D8 Offset: 0x25A55D8 VA: 0x25A95D8
	private void NextPlayMotion() { }

	// RVA: 0x25ADBC0 Offset: 0x25A9BC0 VA: 0x25ADBC0
	private int CheckSexMotion(int id) { }

	// RVA: 0x25ADB30 Offset: 0x25A9B30 VA: 0x25ADB30
	private int WeaponMotionCheck(int baseId, bool weaponCheck) { }

	// RVA: 0x25ADC5C Offset: 0x25A9C5C VA: 0x25ADC5C
	public void PlayFieldLinkMotion(int id) { }

	// RVA: 0x25ADCCC Offset: 0x25A9CCC VA: 0x25ADCCC
	public void RemoveFieldLinkMotion() { }

	// RVA: 0x25ADD24 Offset: 0x25A9D24 VA: 0x25ADD24
	public void CharacterScaleBoneAllClear() { }

	// RVA: 0x25ADE68 Offset: 0x25A9E68 VA: 0x25ADE68
	public void SetCharacterScale(string name, Vector3 scale, float time, short flag = 0) { }

	[IteratorStateMachine(typeof(FieldScriptModel.<Co_SetCharacterScale>d__97))]
	// RVA: 0x25ADE88 Offset: 0x25A9E88 VA: 0x25ADE88
	private IEnumerator Co_SetCharacterScale(string name, Vector3 scale, float time, short flag = 0) { }

	// RVA: 0x25ADF60 Offset: 0x25A9F60 VA: 0x25ADF60
	private Transform GetChildrenNameToTransform(string name) { }

	// RVA: 0x25AE02C Offset: 0x25AA02C VA: 0x25AE02C
	public void ModelFadeIn(float time) { }

	// RVA: 0x25AE27C Offset: 0x25AA27C VA: 0x25AE27C
	public void ModelFadeOut(float time, bool fDestroy = False) { }

	// RVA: 0x25AE208 Offset: 0x25AA208 VA: 0x25AE208
	private void EnableObject() { }

	// RVA: 0x25AE4E4 Offset: 0x25AA4E4 VA: 0x25AE4E4
	private void DisableObject() { }

	// RVA: -1 Offset: -1
	public static Component GetFieldScriptModelComponent<T>(GameObject model) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C2108 Offset: 0x26BE108 VA: 0x26C2108
	|-FieldScriptModel.GetFieldScriptModelComponent<object>
	|
	|-RVA: 0x26C2218 Offset: 0x26BE218 VA: 0x26C2218
	|-FieldScriptModel.GetFieldScriptModelComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void EnabledComponentInChildren<T>(GameObject model, bool flag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C1D90 Offset: 0x26BDD90 VA: 0x26C1D90
	|-FieldScriptModel.EnabledComponentInChildren<object>
	|
	|-RVA: 0x26C1EB8 Offset: 0x26BDEB8 VA: 0x26C1EB8
	|-FieldScriptModel.EnabledComponentInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void EnabledComponentsInChildren<T>(GameObject model, bool flag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26C1FE0 Offset: 0x26BDFE0 VA: 0x26C1FE0
	|-FieldScriptModel.EnabledComponentsInChildren<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x25AE520 Offset: 0x25AA520 VA: 0x25AE520
	public void SetAlpha(float alpha, int nBitFlag) { }

	// RVA: 0x25AE6D4 Offset: 0x25AA6D4 VA: 0x25AE6D4
	public void SetBrightness(float brightness, int nBitFlag) { }

	// RVA: 0x25AEB08 Offset: 0x25AAB08 VA: 0x25AEB08
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x25AEBB0 Offset: 0x25AABB0 VA: 0x25AEBB0
	private void <LoadNPC>b__45_0(GameObject x) { }
}
