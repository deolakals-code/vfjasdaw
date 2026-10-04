// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UICharacterModelManager : MonoBehaviour // TypeDefIndex: 8902
{
	// Fields
	private UICharacterStyleData styleModelData; // 0x20
	private readonly int[] weaponDB; // 0x28
	private readonly string[] customPath; // 0x30
	private UICharacterModel[] partsModel; // 0x38
	private GameObject mainAnimationObject; // 0x40
	private Animation mainAnimation; // 0x48
	private SkinnedMeshRenderer mainAnimationSkin; // 0x50
	private Transform mainAnimationHeadBone; // 0x58
	[SerializeField]
	private Camera viewportCamera; // 0x60
	private int animationId; // 0x68
	private int modelSexId; // 0x6C
	private int motionSexId; // 0x70
	private int playerSexId; // 0x74
	[SerializeField]
	private UILabel playerSexLabel; // 0x78
	private int hairId; // 0x80
	private int hairModelId; // 0x84
	[SerializeField]
	private UILabel hairLabel; // 0x88
	private int headId; // 0x90
	private int headModelId; // 0x94
	[SerializeField]
	private UILabel headLabel; // 0x98
	private int hairTailId; // 0xA0
	private int hairTailModelId; // 0xA4
	[SerializeField]
	private UILabel hairTailLabel; // 0xA8
	private int hairColorId; // 0xB0
	[SerializeField]
	private UILabel hairColorLabel; // 0xB8
	private int hairStreakColorId; // 0xC0
	[SerializeField]
	private UILabel hairStreakColorLabel; // 0xC8
	[SerializeField]
	private GameObject[] hairButton; // 0xD0
	[SerializeField]
	private UIScrollWindow hairScrollWindow; // 0xD8
	private int skinColorId; // 0xE0
	[SerializeField]
	private UILabel skinColorLabel; // 0xE8
	private int heightId; // 0xF0
	[SerializeField]
	private UILabel heightLabel; // 0xF8
	private int skinTextureId; // 0x100
	[SerializeField]
	private UILabel skinTextureLabel; // 0x108
	[SerializeField]
	private Transform baseObject; // 0x110
	private int eyeColorId; // 0x118
	[SerializeField]
	private UILabel eyeColorLabel; // 0x120
	private int oddEyeColorId; // 0x128
	[SerializeField]
	private UILabel oddEyeColorLabel; // 0x130
	private int faceId; // 0x138
	private int faceModelId; // 0x13C
	[SerializeField]
	private UILabel faceLabel; // 0x140
	private int eyeTexId; // 0x148
	[SerializeField]
	private UILabel eyeLabel; // 0x150
	private int battleStyleId; // 0x158
	private int battleMotionId; // 0x15C
	[SerializeField]
	private UILabel battleStyleLabel; // 0x160
	[SerializeField]
	private GameObject[] battleStyleButton; // 0x168
	[SerializeField]
	private UIScrollWindow scrollWindow; // 0x170
	private int bodyId; // 0x178
	private bool destoryFlag; // 0x17C
	private bool isLoadEquip; // 0x17D
	private bool isDefaultModel; // 0x17E
	private UICharacterModelManager.EquipPartsFlag equipPartsFlag; // 0x180
	private MasterModelDataManager.OptionModelFlag hideFlag; // 0x184
	[SerializeField]
	private UIIruna2AnchorSimple pageSkinPanel; // 0x188
	[SerializeField]
	private UIIruna2AnchorSimple pageAvatarPanel; // 0x190
	[SerializeField]
	private UIIruna2AnchorSimple pageHairPanel; // 0x198
	[SerializeField]
	private UIIruna2AnchorSimple pageWeaponPanel; // 0x1A0
	[SerializeField]
	private UIIruna2AnchorSimple pageWeaponMesPanel; // 0x1A8
	[SerializeField]
	private UIIruna2AnchorSimple lastPanel; // 0x1B0
	[SerializeField]
	private UIIruna2AnchorSimple nextPanel; // 0x1B8
	[SerializeField]
	private UIIruna2AnchorSimple backPanel; // 0x1C0
	[SerializeField]
	private UIIruna2AnchorSimple equipSwitchButton; // 0x1C8
	private Texture skinTex; // 0x1D0
	private Texture hairTex; // 0x1D8
	private Texture faceTex; // 0x1E0
	private SystemTextManager stManager; // 0x1E8
	private PlayerDataManager playerDataManager; // 0x1F0
	private Action<int> changePageEvent; // 0x1F8
	[SerializeField]
	private UIIruna2DragPinch dragPinch; // 0x200
	private readonly float defaultCameraDist; // 0x208
	private float cameraDist; // 0x20C
	private readonly Vector3[] startPosition; // 0x210
	private readonly Vector3[] zoomPosition; // 0x218
	private readonly Vector3[] playerCameraRotation; // 0x220
	private readonly Vector3[] heightDifference; // 0x228

	// Properties
	private SystemTextManager systemTextManager { get; }

	// Methods

	// RVA: 0x1E43DB4 Offset: 0x1E3FDB4 VA: 0x1E43DB4
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x1E43EB0 Offset: 0x1E3FEB0 VA: 0x1E43EB0
	public NewStyleData GetCharacterStyle() { }

	// RVA: 0x1E4415C Offset: 0x1E4015C VA: 0x1E4415C
	public byte GetWeaponNo() { }

	// RVA: 0x1E44168 Offset: 0x1E40168 VA: 0x1E44168
	private void Start() { }

	// RVA: 0x1E441FC Offset: 0x1E401FC VA: 0x1E441FC
	private void OnDestroy() { }

	[IteratorStateMachine(typeof(UICharacterModelManager.<Initialize>d__78))]
	// RVA: 0x1E44348 Offset: 0x1E40348 VA: 0x1E44348
	public IEnumerator Initialize(Action<int> changeAction, Camera uiMainCamera, bool isLoadEquip = False) { }

	[IteratorStateMachine(typeof(UICharacterModelManager.<InitializeLoad>d__79))]
	// RVA: 0x1E44420 Offset: 0x1E40420 VA: 0x1E44420
	public IEnumerator InitializeLoad() { }

	// RVA: 0x1E44494 Offset: 0x1E40494 VA: 0x1E44494
	private void setPlayerSex(int add) { }

	// RVA: 0x1E446B8 Offset: 0x1E406B8 VA: 0x1E446B8
	private void setHair(int add) { }

	// RVA: 0x1E448BC Offset: 0x1E408BC VA: 0x1E448BC
	private void setHead(int add) { }

	// RVA: 0x1E44AC0 Offset: 0x1E40AC0 VA: 0x1E44AC0
	private void setHairTail(int add) { }

	// RVA: 0x1E44CC4 Offset: 0x1E40CC4 VA: 0x1E44CC4
	private void setHairColor(int add) { }

	// RVA: 0x1E4511C Offset: 0x1E4111C VA: 0x1E4511C
	private void setHairStreakColor(int add) { }

	// RVA: 0x1E45274 Offset: 0x1E41274 VA: 0x1E45274
	private void setFace(int add) { }

	// RVA: 0x1E45C70 Offset: 0x1E41C70 VA: 0x1E45C70
	private void setEyeTex(int add) { }

	// RVA: 0x1E45EC0 Offset: 0x1E41EC0 VA: 0x1E45EC0
	public void setSkinTexture(int add) { }

	// RVA: 0x1E46110 Offset: 0x1E42110 VA: 0x1E46110
	private void setEyeColor(int add) { }

	// RVA: 0x1E46268 Offset: 0x1E42268 VA: 0x1E46268
	private void setOddEyeColor(int add) { }

	// RVA: 0x1E463C0 Offset: 0x1E423C0 VA: 0x1E463C0
	private void setSkinColor(int add) { }

	// RVA: 0x1E46518 Offset: 0x1E42518 VA: 0x1E46518
	private void setHeight(int add) { }

	// RVA: 0x1E46948 Offset: 0x1E42948 VA: 0x1E46948
	private void setBattleStyle(int no) { }

	// RVA: 0x1E46D2C Offset: 0x1E42D2C VA: 0x1E46D2C
	private void HideActiveSwitch(UICharacterModelManager.PartsType type) { }

	// RVA: 0x1E46EE0 Offset: 0x1E42EE0 VA: 0x1E46EE0
	private void SwitchEquipModel() { }

	// RVA: 0x1E480B0 Offset: 0x1E440B0 VA: 0x1E480B0
	private UICharacterModel EquipModelUpdate(UICharacterModel model, string parts, int id, string addlabel, byte[] colors) { }

	// RVA: 0x1E4733C Offset: 0x1E4333C VA: 0x1E4733C
	private void SwitchEquipBodyModel() { }

	// RVA: 0x1E47F50 Offset: 0x1E43F50 VA: 0x1E47F50
	private void SwitchEquipDecoModel() { }

	// RVA: 0x1E47DF0 Offset: 0x1E43DF0 VA: 0x1E47DF0
	private void SwitchEquipOptionModel() { }

	[IteratorStateMachine(typeof(UICharacterModelManager.<loadSex>d__100))]
	// RVA: 0x1E44634 Offset: 0x1E40634 VA: 0x1E44634
	private IEnumerator loadSex(int sexId) { }

	[IteratorStateMachine(typeof(UICharacterModelManager.<loadFace>d__101))]
	// RVA: 0x1E45560 Offset: 0x1E41560 VA: 0x1E45560
	private IEnumerator loadFace(int loadFaceId, int modelId) { }

	[IteratorStateMachine(typeof(UICharacterModelManager.<loadHair>d__102))]
	// RVA: 0x1E44830 Offset: 0x1E40830 VA: 0x1E44830
	private IEnumerator loadHair(int loadHairId, int modelId) { }

	[IteratorStateMachine(typeof(UICharacterModelManager.<loadHead>d__103))]
	// RVA: 0x1E44A34 Offset: 0x1E40A34 VA: 0x1E44A34
	private IEnumerator loadHead(int loadHeadId, int modelId) { }

	[IteratorStateMachine(typeof(UICharacterModelManager.<loadHairTail>d__104))]
	// RVA: 0x1E44C38 Offset: 0x1E40C38 VA: 0x1E44C38
	private IEnumerator loadHairTail(int loadHairTailId, int modelId) { }

	[IteratorStateMachine(typeof(UICharacterModelManager.<LoadBodyEquipModel>d__105))]
	// RVA: 0x1E48270 Offset: 0x1E44270 VA: 0x1E48270
	private IEnumerator LoadBodyEquipModel() { }

	[IteratorStateMachine(typeof(UICharacterModelManager.<LoadDecoModel>d__106))]
	// RVA: 0x1E482E4 Offset: 0x1E442E4 VA: 0x1E482E4
	private IEnumerator LoadDecoModel() { }

	[IteratorStateMachine(typeof(UICharacterModelManager.<LoadOptionModel>d__107))]
	// RVA: 0x1E48358 Offset: 0x1E44358 VA: 0x1E48358
	private IEnumerator LoadOptionModel() { }

	[IteratorStateMachine(typeof(UICharacterModelManager.<cacheModel>d__108))]
	// RVA: 0x1E483CC Offset: 0x1E443CC VA: 0x1E483CC
	private IEnumerator cacheModel(ModelManager.LoadModelType type, int id, string filePath, UnityAction<UICharacterModel> act) { }

	// RVA: 0x1E48488 Offset: 0x1E44488 VA: 0x1E48488
	private UICharacterModel changeModel(string parts, int id, string addlabel) { }

	// RVA: 0x1E46B38 Offset: 0x1E42B38 VA: 0x1E46B38
	private UICharacterModel updateModel(UICharacterModel model, string parts, int id, string addlabel) { }

	// RVA: 0x1E455E8 Offset: 0x1E415E8 VA: 0x1E455E8
	private void updateModel(int motionId, int motionQueuedId) { }

	// RVA: 0x1E48A64 Offset: 0x1E44A64 VA: 0x1E48A64
	private void SetGroundPosition() { }

	// RVA: 0x1E48D00 Offset: 0x1E44D00 VA: 0x1E48D00
	public void EmotionPlay(float timer) { }

	// RVA: 0x1E48D5C Offset: 0x1E44D5C VA: 0x1E48D5C
	public void EmotionPlay() { }

	// RVA: 0x1E44E1C Offset: 0x1E40E1C VA: 0x1E44E1C
	private void changeModelSkinColor() { }

	// RVA: 0x1E48D94 Offset: 0x1E44D94 VA: 0x1E48D94
	private void nextPage() { }

	// RVA: 0x1E48DB4 Offset: 0x1E44DB4 VA: 0x1E48DB4
	private void backPage() { }

	// RVA: 0x1E48DD4 Offset: 0x1E44DD4 VA: 0x1E48DD4
	public void ChangePage(UICharacterModelManager.PanelSettingFlag setting) { }

	// RVA: 0x1E4674C Offset: 0x1E4274C VA: 0x1E4674C
	public void SetSexCameraPosition(bool zoom) { }

	// RVA: 0x1E495AC Offset: 0x1E455AC VA: 0x1E495AC
	public void SetCameraPosition(Vector3 position, Vector3 rot) { }

	// RVA: 0x1E49734 Offset: 0x1E45734 VA: 0x1E49734
	private void Update() { }

	// RVA: 0x1E49994 Offset: 0x1E45994 VA: 0x1E49994
	private void LateUpdate() { }

	// RVA: 0x1E49AB0 Offset: 0x1E45AB0 VA: 0x1E49AB0
	private void OnWillRenderObject() { }

	// RVA: 0x1E49998 Offset: 0x1E45998 VA: 0x1E49998
	private void HeadUpdate() { }

	// RVA: 0x1E46C74 Offset: 0x1E42C74 VA: 0x1E46C74
	private void playAnimationChildren(int motionId, bool queued) { }

	// RVA: 0x1E49AB4 Offset: 0x1E45AB4 VA: 0x1E49AB4
	private void OnSwitchModel() { }

	// RVA: 0x1E49AC4 Offset: 0x1E45AC4 VA: 0x1E49AC4
	public void .ctor() { }
}
