// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICharacterModelBaseManager : MonoBehaviour // TypeDefIndex: 8879
{
	// Fields
	private UICharacterModel[] modelObject; // 0x20
	private int[] modelIndex; // 0x28
	private int optionFlag; // 0x30
	private int decoFlag; // 0x34
	private int avatarOptionFlag; // 0x38
	private int avatarDecoFlag; // 0x3C
	private int avatarTopHairFlag; // 0x40
	private Dictionary<string, UICharacterModel> cacheObjectList; // 0x48
	private Texture skinTex; // 0x50
	private byte skinTextureId; // 0x58
	private Color skinColor; // 0x5C
	private byte skinColorId; // 0x6C
	private int skinGroupId; // 0x70
	private int skinGroupEquipFlag; // 0x74
	private Texture hairTex; // 0x78
	private Color hairColor; // 0x80
	private byte hairStreakColorId; // 0x90
	private Color hairStreakColor; // 0x94
	private Texture eyeTex; // 0xA8
	private byte eyeColorId; // 0xB0
	private Color eyeColor; // 0xB4
	private byte oddEyeColorId; // 0xC4
	private Color oddEyeColor; // 0xC8
	private int loadingCount; // 0xD8
	private GameObject mainAnimationObject; // 0xE0
	private Animation mainAnimation; // 0xE8
	private SkinnedMeshRenderer mainAnimationSkin; // 0xF0
	private Transform mainAnimationHeadBone; // 0xF8
	[SerializeField]
	private Transform modelParent; // 0x100
	private float charHeight; // 0x108
	private bool isMan; // 0x10C
	private bool isManAnimation; // 0x10D
	private int bodyModelId; // 0x110
	private short bodyAbility; // 0x114
	private byte[] bodyColor; // 0x118
	private int topAvatarModelId; // 0x120
	private byte[] topAvatarColor; // 0x128
	private int bottomAvatarModelId; // 0x130
	private byte[] bottomAvatarColor; // 0x138
	private int faceModelId; // 0x140
	private bool innerwearTopCheck; // 0x144
	private bool innerwearBottomCheck; // 0x145
	private int innerwearModelId; // 0x148
	private bool allAvatarCheck; // 0x14C
	private int mainHandWeaponModelId; // 0x150
	private int subHandWeaponModelId; // 0x154
	private UICharacterModelBaseManager.ModelPartsType changeSkinColorType; // 0x158
	private int changeSkinColorModelId; // 0x15C
	[SerializeField]
	private float playerAngle; // 0x160
	[SerializeField]
	private float positionWidth; // 0x164
	[SerializeField]
	private float positionHeight; // 0x168
	[SerializeField]
	private float addHeightPosition; // 0x16C
	[SerializeField]
	private float scaleSpeed; // 0x170
	[SerializeField]
	private float cameraZoomDist; // 0x174
	[SerializeField]
	private float cameraMaxDist; // 0x178
	[SerializeField]
	private float cameraMinDist; // 0x17C
	private GameObject loadingObject; // 0x180
	private Animation loadingObjectAnimation; // 0x188
	private float loadingWait; // 0x190
	[SerializeField]
	private UIIruna2DragPinch dragPinch; // 0x198
	private bool initCheck; // 0x1A0
	private bool destroyFlag; // 0x1A1
	private Transform weaponObj; // 0x1A8

	// Properties
	public bool IsLoading { get; }
	public Transform ModelParent { get; }
	public bool IsMan { get; }
	public float CameraDistPercent { get; }

	// Methods

	// RVA: 0x1E3D1B8 Offset: 0x1E391B8 VA: 0x1E3D1B8
	public bool get_IsLoading() { }

	// RVA: 0x1E3D1C8 Offset: 0x1E391C8 VA: 0x1E3D1C8
	public Transform get_ModelParent() { }

	// RVA: 0x1E3D1D0 Offset: 0x1E391D0 VA: 0x1E3D1D0
	public bool get_IsMan() { }

	// RVA: 0x1E3D1D8 Offset: 0x1E391D8 VA: 0x1E3D1D8
	public float get_CameraDistPercent() { }

	// RVA: 0x1E3D214 Offset: 0x1E39214 VA: 0x1E3D214
	public void Initialize() { }

	// RVA: 0x1E3D7F4 Offset: 0x1E397F4 VA: 0x1E3D7F4
	public void Initialize(NewArchetypeProperties properties) { }

	// RVA: 0x1E3E7C8 Offset: 0x1E3A7C8 VA: 0x1E3E7C8
	public void InitializeAvaterAll(NewArchetypeProperties properties) { }

	// RVA: 0x1E3EC0C Offset: 0x1E3AC0C VA: 0x1E3EC0C
	private void Start() { }

	// RVA: 0x1E3ED10 Offset: 0x1E3AD10 VA: 0x1E3ED10 Slot: 4
	protected virtual void Update() { }

	// RVA: 0x1E3EFEC Offset: 0x1E3AFEC VA: 0x1E3EFEC Slot: 5
	protected virtual void LateUpdate() { }

	// RVA: 0x1E3F0F8 Offset: 0x1E3B0F8 VA: 0x1E3F0F8
	private void OnDestroy() { }

	// RVA: 0x1E3F48C Offset: 0x1E3B48C VA: 0x1E3F48C
	public void Clear() { }

	// RVA: 0x1E3F87C Offset: 0x1E3B87C VA: 0x1E3F87C
	public void AddAnimationClip(AnimationClip[] animationClip) { }

	// RVA: 0x1E3F960 Offset: 0x1E3B960 VA: 0x1E3F960
	public bool PlayAnimation(int animationId) { }

	// RVA: 0x1E3F998 Offset: 0x1E3B998 VA: 0x1E3F998
	public bool PlayAnimation(string animationId) { }

	// RVA: 0x1E3FA38 Offset: 0x1E3BA38 VA: 0x1E3FA38
	public bool PlayAnimationQueued(int animationId, float fadeLength) { }

	// RVA: 0x1E3FA78 Offset: 0x1E3BA78 VA: 0x1E3FA78
	public bool PlayAnimationQueued(string animationId, float fadeLength) { }

	// RVA: 0x1E3FB28 Offset: 0x1E3BB28 VA: 0x1E3FB28
	public void PlayGuiterAnim() { }

	// RVA: 0x1E3D9A0 Offset: 0x1E399A0 VA: 0x1E3D9A0
	public void ChangeHeight(byte height) { }

	// RVA: 0x1E3FC84 Offset: 0x1E3BC84 VA: 0x1E3FC84
	public void SetMan(bool man) { }

	// RVA: 0x1E40C30 Offset: 0x1E3CC30 VA: 0x1E40C30
	private bool checkSkinGroupFlag(UICharacterModelBaseManager.ModelPartsType parts) { }

	// RVA: 0x1E40C40 Offset: 0x1E3CC40 VA: 0x1E40C40
	public bool CheckSkinConvertGroupId(int groupId) { }

	// RVA: 0x1E40C68 Offset: 0x1E3CC68 VA: 0x1E40C68
	public bool CheckSkinConvertGroupId(int groupId, ItemDBData.EquipType partsType) { }

	// RVA: 0x1E40CEC Offset: 0x1E3CCEC VA: 0x1E40CEC
	public void RemoveSkinGroupEquip() { }

	// RVA: 0x1E3DA2C Offset: 0x1E39A2C VA: 0x1E3DA2C
	public void ChangeSkinColor(byte skinColorId) { }

	// RVA: 0x1E3DAA8 Offset: 0x1E39AA8 VA: 0x1E3DAA8
	public void ChangeSkinTexture(byte skinTextureId) { }

	// RVA: 0x1E40E98 Offset: 0x1E3CE98 VA: 0x1E40E98
	private bool CheckConvertModelSkinGroup(UICharacterModelBaseManager.ModelPartsType type, int id) { }

	// RVA: 0x1E3DCD8 Offset: 0x1E39CD8 VA: 0x1E3DCD8
	public void ChangeHairColor(byte hairColorId) { }

	// RVA: 0x1E3DDC8 Offset: 0x1E39DC8 VA: 0x1E3DDC8
	public void ChangeHairStreakColor(byte hairStreakColorId) { }

	// RVA: 0x1E3DD4C Offset: 0x1E39D4C VA: 0x1E3DD4C
	public void ChangeHairTexture(byte hairTextureId) { }

	// RVA: 0x1E3DBA4 Offset: 0x1E39BA4 VA: 0x1E3DBA4
	public void ChangeEyeColor(byte eyeColorId) { }

	// RVA: 0x1E3DC44 Offset: 0x1E39C44 VA: 0x1E3DC44
	public void ChangeOddEyeColor(byte oddEyeColoeId) { }

	// RVA: 0x1E3DB28 Offset: 0x1E39B28 VA: 0x1E3DB28
	public void ChangeEyeTexture(byte eyeTextureId) { }

	// RVA: 0x1E40D78 Offset: 0x1E3CD78 VA: 0x1E40D78
	private void OnChangeBaseData() { }

	// RVA: 0x1E41068 Offset: 0x1E3D068 VA: 0x1E41068
	public void ChangeEquipItemId(int itemId) { }

	// RVA: 0x1E411A0 Offset: 0x1E3D1A0 VA: 0x1E411A0
	public void ChangeEquipItemData(ItemData itemData) { }

	// RVA: 0x1E410F0 Offset: 0x1E3D0F0 VA: 0x1E410F0
	public void ChangeEquipItemData(ItemDBData.ItemType type, int modelId, byte color1, byte color2, byte color3, byte ability) { }

	// RVA: 0x1E3E16C Offset: 0x1E3A16C VA: 0x1E3E16C
	public void ChangeFaceModel(int modelId) { }

	// RVA: 0x1E41880 Offset: 0x1E3D880 VA: 0x1E41880
	public void ChangeFaceModel(int modelId, bool man) { }

	// RVA: 0x1E3DE48 Offset: 0x1E39E48 VA: 0x1E3DE48
	public void ChangeHairModel(int modelId) { }

	// RVA: 0x1E3DF58 Offset: 0x1E39F58 VA: 0x1E3DF58
	public void ChangeHeadModel(int modelId) { }

	// RVA: 0x1E3E05C Offset: 0x1E3A05C VA: 0x1E3E05C
	public void ChangeHairTailModel(int modelId) { }

	// RVA: 0x1E418CC Offset: 0x1E3D8CC VA: 0x1E418CC
	private bool HideFlag(MasterModelDataManager.OptionModelFlag flag) { }

	// RVA: 0x1E41A08 Offset: 0x1E3DA08 VA: 0x1E41A08
	private void OnAvatarHideStyleModel(UICharacterModelBaseManager.ModelPartsType type, UICharacterModel model, int index) { }

	// RVA: 0x1E42090 Offset: 0x1E3E090 VA: 0x1E42090
	private void HideCheck() { }

	// RVA: 0x1E3E30C Offset: 0x1E3A30C VA: 0x1E3E30C
	public void ChangeBodyModel(int modelId, short ability, int color) { }

	// RVA: 0x1E3FD54 Offset: 0x1E3BD54 VA: 0x1E3FD54
	public void ChangeBodyModel(int modelId, short ability, byte colorR, byte colorG, byte colorB) { }

	// RVA: 0x1E42240 Offset: 0x1E3E240 VA: 0x1E42240
	private void OnChangeBodyTopModel(UICharacterModelBaseManager.ModelPartsType type, UICharacterModel model, int index) { }

	// RVA: 0x1E42354 Offset: 0x1E3E354 VA: 0x1E42354
	private void OnChangeBodyBottomModel(UICharacterModelBaseManager.ModelPartsType type, UICharacterModel model, int index) { }

	// RVA: 0x1E3E9CC Offset: 0x1E3A9CC VA: 0x1E3E9CC
	public void ChangeWeaponModel(int modelId, int color) { }

	// RVA: 0x1E4120C Offset: 0x1E3D20C VA: 0x1E4120C
	public void ChangeWeaponModel(int modelId, byte colorR, byte colorG, byte colorB) { }

	// RVA: 0x1E3EA2C Offset: 0x1E3AA2C VA: 0x1E3EA2C
	public void ChangeSubWeaponModel(int modelId, int color) { }

	// RVA: 0x1E4135C Offset: 0x1E3D35C VA: 0x1E4135C
	public void ChangeSubWeaponModel(int modelId, byte colorR, byte colorG, byte colorB) { }

	// RVA: 0x1E427D0 Offset: 0x1E3E7D0 VA: 0x1E427D0
	private void OnWeaponModel(UICharacterModelBaseManager.ModelPartsType type, UICharacterModel model, int index) { }

	// RVA: 0x1E42480 Offset: 0x1E3E480 VA: 0x1E42480
	private void UpdateCheckWeaponModel() { }

	// RVA: 0x1E427F8 Offset: 0x1E3E7F8 VA: 0x1E427F8
	private void SetWeaponBoneLink(UICharacterModelBaseManager.ModelPartsType type, string boneName, string[] changeBone) { }

	// RVA: 0x1E3EAEC Offset: 0x1E3AAEC VA: 0x1E3EAEC
	public void ChangeOpstionModel(int modelId, int color) { }

	// RVA: 0x1E4148C Offset: 0x1E3D48C VA: 0x1E4148C
	public void ChangeOpstionModel(int modelId, byte colorR, byte colorG, byte colorB) { }

	// RVA: 0x1E42B9C Offset: 0x1E3EB9C VA: 0x1E42B9C
	private void OnChangeOpstionModel(UICharacterModelBaseManager.ModelPartsType type, UICharacterModel model, int index) { }

	// RVA: 0x1E42C4C Offset: 0x1E3EC4C VA: 0x1E42C4C
	public void ChangeSpecialModel(int modelId, byte colorR, byte colorG, byte colorB) { }

	// RVA: 0x1E3EBAC Offset: 0x1E3ABAC VA: 0x1E3EBAC
	public void ChangeDecoModel(int modelId, int color) { }

	// RVA: 0x1E42C50 Offset: 0x1E3EC50 VA: 0x1E42C50
	public void ChangeDecoModel(int modelId, byte colorR, byte colorG, byte colorB) { }

	// RVA: 0x1E42DC8 Offset: 0x1E3EDC8 VA: 0x1E42DC8
	private void OnChangeDecoModel(UICharacterModelBaseManager.ModelPartsType type, UICharacterModel model, int index) { }

	// RVA: 0x1E3E2AC Offset: 0x1E3A2AC VA: 0x1E3E2AC
	public void ChangeAvatarTopModel(int modelId, int color) { }

	// RVA: 0x1E40618 Offset: 0x1E3C618 VA: 0x1E40618
	public void ChangeAvatarTopModel(int modelId, byte colorR, byte colorG, byte colorB) { }

	// RVA: 0x1E42E78 Offset: 0x1E3EE78 VA: 0x1E42E78
	private void OnChangeAvatarTopModel(UICharacterModelBaseManager.ModelPartsType type, UICharacterModel model, int index) { }

	// RVA: 0x1E3E374 Offset: 0x1E3A374 VA: 0x1E3E374
	public void ChangeAvatarBottomModel(int modelId, int color) { }

	// RVA: 0x1E409AC Offset: 0x1E3C9AC VA: 0x1E409AC
	public void ChangeAvatarBottomModel(int modelId, byte colorR, byte colorG, byte colorB) { }

	// RVA: 0x1E43028 Offset: 0x1E3F028 VA: 0x1E43028
	private void OnChangeAvatarBottomModel(UICharacterModelBaseManager.ModelPartsType type, UICharacterModel model, int index) { }

	// RVA: 0x1E430C0 Offset: 0x1E3F0C0 VA: 0x1E430C0
	public void FocusAvatarBottomView() { }

	// RVA: 0x1E3EA8C Offset: 0x1E3AA8C VA: 0x1E3EA8C
	public void ChangeAvatarOptionModel(int modelId, int color) { }

	// RVA: 0x1E41604 Offset: 0x1E3D604 VA: 0x1E41604
	public void ChangeAvatarOptionModel(int modelId, byte colorR, byte colorG, byte colorB) { }

	// RVA: 0x1E430D8 Offset: 0x1E3F0D8 VA: 0x1E430D8
	private void OnChangeAvatarOptionModel(UICharacterModelBaseManager.ModelPartsType type, UICharacterModel model, int index) { }

	// RVA: 0x1E3EB4C Offset: 0x1E3AB4C VA: 0x1E3EB4C
	public void ChangeAvatarDecModel(int modelId, int color) { }

	// RVA: 0x1E43108 Offset: 0x1E3F108 VA: 0x1E43108
	public void ChangeAvatarDecModel(int modelId, byte colorR, byte colorG, byte colorB) { }

	// RVA: 0x1E432A4 Offset: 0x1E3F2A4 VA: 0x1E432A4
	private void OnChangeAvatarDecModel(UICharacterModelBaseManager.ModelPartsType type, UICharacterModel model, int index) { }

	// RVA: 0x1E3E3D4 Offset: 0x1E3A3D4 VA: 0x1E3E3D4
	public bool ChangeInnerwearTopModel() { }

	// RVA: 0x1E432D4 Offset: 0x1E3F2D4 VA: 0x1E432D4
	private void OnChangeInnerwearTopModel(UICharacterModelBaseManager.ModelPartsType type, UICharacterModel model, int index) { }

	// RVA: 0x1E3E5CC Offset: 0x1E3A5CC VA: 0x1E3E5CC
	public bool ChangeInnerwearBottomModel() { }

	// RVA: 0x1E434C4 Offset: 0x1E3F4C4 VA: 0x1E434C4
	private void OnChangeInnerwearBottomModel(UICharacterModelBaseManager.ModelPartsType type, UICharacterModel model, int index) { }

	// RVA: 0x1E41884 Offset: 0x1E3D884 VA: 0x1E41884
	private bool ClearModelCheck(UICharacterModelBaseManager.ModelPartsType parts, int model) { }

	// RVA: 0x1E421E8 Offset: 0x1E3E1E8 VA: 0x1E421E8
	private int CountUpModelIndexId(UICharacterModelBaseManager.ModelPartsType parts) { }

	[IteratorStateMachine(typeof(UICharacterModelBaseManager.<LoadObject>d__151))]
	// RVA: 0x1E417A0 Offset: 0x1E3D7A0 VA: 0x1E417A0
	private IEnumerator LoadObject(UICharacterModelBaseManager.ModelPartsType parts, ModelManager.LoadModelType loadModelType, int modelId, string filePath, byte colorRId, byte colorGId, byte colorBId, Action<UICharacterModelBaseManager.ModelPartsType, UICharacterModel, int> ationEvent) { }

	// RVA: 0x1E4370C Offset: 0x1E3F70C VA: 0x1E4370C
	private void OnAvatarModel(UICharacterModelBaseManager.ModelPartsType type, UICharacterModel model, int index) { }

	// RVA: 0x1E41A6C Offset: 0x1E3DA6C VA: 0x1E41A6C
	private bool ModelUpdate(UICharacterModelBaseManager.ModelPartsType parts, UICharacterModel model, int index, bool active) { }

	// RVA: 0x1E42108 Offset: 0x1E3E108 VA: 0x1E42108
	private void SetActive(UICharacterModelBaseManager.ModelPartsType type, bool flag) { }

	// RVA: 0x1E43714 Offset: 0x1E3F714 VA: 0x1E43714
	public void .ctor() { }
}
