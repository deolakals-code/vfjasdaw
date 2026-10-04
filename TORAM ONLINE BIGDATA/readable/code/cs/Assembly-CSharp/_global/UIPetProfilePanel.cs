// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetProfilePanel : MonoBehaviour // TypeDefIndex: 7820
{
	// Fields
	[SerializeField]
	private Transform cameraView; // 0x20
	[SerializeField]
	private UIIruna2Anchor mainAnchor; // 0x28
	[SerializeField]
	private GameObject breedObj; // 0x30
	[SerializeField]
	private GameObject petNameLabelObj; // 0x38
	[SerializeField]
	private UILabel[] typePersonalLabel; // 0x40
	[SerializeField]
	private GameObject holdObj; // 0x48
	[SerializeField]
	private UISprite staminaIcon; // 0x50
	[SerializeField]
	private UISprite staminaOtherIcon; // 0x58
	[SerializeField]
	private GameObject skillObj; // 0x60
	[SerializeField]
	private UIImageButton mainButton; // 0x68
	[SerializeField]
	private UILabel mainButtonLabel; // 0x70
	[SerializeField]
	private GameObject statusObject; // 0x78
	private UISlider[] statusSliderObj; // 0x80
	[SerializeField]
	private UILabel[] potentialLabel; // 0x88
	[SerializeField]
	private UISlider[] potentialSlider; // 0x90
	[SerializeField]
	private GameObject battlePowerObject; // 0x98
	[SerializeField]
	private UILabel educationLabel; // 0xA0
	[SerializeField]
	private UIIruna2DragPinch dragPinch; // 0xA8
	[SerializeField]
	private Transform modelParent; // 0xB0
	[SerializeField]
	private UILabel fusionLabel; // 0xB8
	[SerializeField]
	private GameObject petCageObj; // 0xC0
	[SerializeField]
	private UILabel[] petCageLabels; // 0xC8
	[SerializeField]
	private GameObject windowFrameObj; // 0xD0
	[SerializeField]
	private GameObject longFrameObj; // 0xD8
	[SerializeField]
	private GameObject[] scrollAreaObjs; // 0xE0
	private SystemTextManager systemTextManagerBase; // 0xE8
	private EnemyTextManager enemyTextManager; // 0xF0
	private Dictionary<long, UIPetProfilePanel.PetModelData> petModelObjectList; // 0xF8
	private PetModelLoader petModelLoader; // 0x100
	private MobAnimation mobAnimation; // 0x108
	private const float defaultAngle = 225;
	private float modelAngle; // 0x110
	private Dictionary<long, bool> checkedPetFlag; // 0x118
	private PetDataManager.PetViewData petViewData; // 0x120
	private PetDataManager.PetSummonData petSummonData; // 0x128
	private long petUuid; // 0x130
	private MobAnimationType animeType; // 0x138
	private bool moveRightFlag; // 0x13C
	private Vector3 petModelFirstPos; // 0x140
	private float moveTimer; // 0x14C
	private bool nameChangePanelFlag; // 0x150
	private UICamera uiCamera; // 0x158
	private bool isRotateModel; // 0x160
	private ItemPetData itemPetData; // 0x168

	// Properties
	public UIIruna2Anchor MainAnchor { get; }
	public UIImageButton MainButton { get; }
	public GameObject GetPetModel { get; }
	public Transform GetModelTrans { get; }
	public Transform GetModelRootBone { get; }
	private SystemTextManager systemTextManager { get; }
	private EnemyTextManager EnemyTextManager { get; }
	public bool NameChangePanelFlag { set; }

	// Methods

	// RVA: 0x1C28BFC Offset: 0x1C24BFC VA: 0x1C28BFC
	public static UIPetProfilePanel CreatePanel(Transform parent) { }

	// RVA: 0x1C28D4C Offset: 0x1C24D4C VA: 0x1C28D4C
	public UIIruna2Anchor get_MainAnchor() { }

	// RVA: 0x1C28D54 Offset: 0x1C24D54 VA: 0x1C28D54
	public void SetPetViewData(PetDataManager.PetViewData data) { }

	// RVA: 0x1C28D64 Offset: 0x1C24D64 VA: 0x1C28D64
	public UIImageButton get_MainButton() { }

	// RVA: 0x1C1C084 Offset: 0x1C18084 VA: 0x1C1C084
	public void SetCameraActive(bool flag) { }

	// RVA: 0x1C1D4C0 Offset: 0x1C194C0 VA: 0x1C1D4C0
	public void SetStaminaIcon(string name, bool isOther = False) { }

	// RVA: 0x1C28D6C Offset: 0x1C24D6C VA: 0x1C28D6C
	public void SetActiveModel(bool flag) { }

	// RVA: 0x1C28DDC Offset: 0x1C24DDC VA: 0x1C28DDC
	public void SetModelParent(Transform parent) { }

	// RVA: 0x1C28E58 Offset: 0x1C24E58 VA: 0x1C28E58
	public GameObject get_GetPetModel() { }

	// RVA: 0x1C28EB8 Offset: 0x1C24EB8 VA: 0x1C28EB8
	public void ResetModelParent() { }

	// RVA: 0x1C28F30 Offset: 0x1C24F30 VA: 0x1C28F30
	public Transform get_GetModelTrans() { }

	// RVA: 0x1C28F98 Offset: 0x1C24F98 VA: 0x1C28F98
	public Transform get_GetModelRootBone() { }

	// RVA: 0x1C29020 Offset: 0x1C25020 VA: 0x1C29020
	public Transform GetModelBoneTrans(string name) { }

	// RVA: 0x1C290BC Offset: 0x1C250BC VA: 0x1C290BC
	public void SetModelAlpha(float alpha) { }

	// RVA: 0x1C291AC Offset: 0x1C251AC VA: 0x1C291AC
	public void ChangeModelAnimation(MobAnimationType type) { }

	// RVA: 0x1C2921C Offset: 0x1C2521C VA: 0x1C2921C
	public void NameChangeMove() { }

	// RVA: 0x1C29520 Offset: 0x1C25520 VA: 0x1C29520
	public void SetModelNowPos() { }

	// RVA: 0x1C295E8 Offset: 0x1C255E8 VA: 0x1C295E8
	public void SetModelPos(Vector3 pos) { }

	// RVA: 0x1C2948C Offset: 0x1C2548C VA: 0x1C2948C
	public void SetTweenPosModel(Vector3 pos, float time) { }

	// RVA: 0x1C29684 Offset: 0x1C25684 VA: 0x1C29684
	public void SetTweenPosZModel(float posZ, float time) { }

	// RVA: 0x1C2974C Offset: 0x1C2574C VA: 0x1C2974C
	public void ResetPosModel() { }

	// RVA: 0x1C297CC Offset: 0x1C257CC VA: 0x1C297CC
	public void ResetTweenPosModel(float time) { }

	// RVA: 0x1C292D0 Offset: 0x1C252D0 VA: 0x1C292D0
	public void SetRotModel(float angle) { }

	// RVA: 0x1C293A4 Offset: 0x1C253A4 VA: 0x1C293A4
	public void SetTweenRotModel(float angle, float time) { }

	// RVA: 0x1C2984C Offset: 0x1C2584C VA: 0x1C2984C
	public void SetTweenScaleModel(float time, Vector3 scale) { }

	// RVA: 0x1C298E0 Offset: 0x1C258E0 VA: 0x1C298E0
	public void ChangeDragEnable(bool enable) { }

	// RVA: 0x1C298EC Offset: 0x1C258EC VA: 0x1C298EC
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x1C299D8 Offset: 0x1C259D8 VA: 0x1C299D8
	private EnemyTextManager get_EnemyTextManager() { }

	// RVA: 0x1C29AC4 Offset: 0x1C25AC4 VA: 0x1C29AC4
	public void set_NameChangePanelFlag(bool value) { }

	// RVA: 0x1C29AD0 Offset: 0x1C25AD0 VA: 0x1C29AD0
	public void SetUICamera(UICamera value) { }

	// RVA: 0x1C29AE0 Offset: 0x1C25AE0 VA: 0x1C29AE0
	private void Start() { }

	// RVA: 0x1C29AE4 Offset: 0x1C25AE4 VA: 0x1C29AE4
	private void Update() { }

	// RVA: 0x1C1EC14 Offset: 0x1C1AC14 VA: 0x1C1EC14
	public void SetPetProfile(PetDataManager.PetViewData data) { }

	// RVA: 0x1C2A980 Offset: 0x1C26980 VA: 0x1C2A980
	public void SetPetProfile(PetDataManager.PetSummonData data) { }

	[IteratorStateMachine(typeof(UIPetProfilePanel.<SetTimeLabelPos>d__87))]
	// RVA: 0x1C29F34 Offset: 0x1C25F34 VA: 0x1C29F34
	private IEnumerator SetTimeLabelPos(UILabel onLabel, UILabel underLabel) { }

	// RVA: 0x1C2B81C Offset: 0x1C2781C VA: 0x1C2B81C
	public void SetStrayPetProfile(PetDataManager.PetViewData data) { }

	// RVA: 0x1C2BDCC Offset: 0x1C27DCC VA: 0x1C2BDCC
	public void SetPetCageProfile(ItemData itemData) { }

	// RVA: 0x1C2A8E8 Offset: 0x1C268E8 VA: 0x1C2A8E8
	private void ChangeActivePetCageObj(bool isActive) { }

	// RVA: 0x1C2C2FC Offset: 0x1C282FC VA: 0x1C2C2FC
	public void SetMainButtonText(string text) { }

	// RVA: 0x1C2C394 Offset: 0x1C28394 VA: 0x1C2C394
	public void ToggleShopView(bool isShop) { }

	// RVA: 0x1C2C5CC Offset: 0x1C285CC VA: 0x1C2C5CC
	public void ToggleShopBuyView(bool isShopBuy) { }

	// RVA: 0x1C2A544 Offset: 0x1C26544 VA: 0x1C2A544
	private void ChangePotentialSliderValue(PetPotentialData data) { }

	// RVA: 0x1C29FC4 Offset: 0x1C25FC4 VA: 0x1C29FC4
	private void UpdatePetStatus(PetDataManager.PetViewStatus primaryStatus) { }

	// RVA: 0x1C2C638 Offset: 0x1C28638 VA: 0x1C2C638
	private void SetPetStatusBar(int type, int param, int maxparam) { }

	// RVA: 0x1C2C7F4 Offset: 0x1C287F4 VA: 0x1C2C7F4
	public void LoadPetModel(bool useViewData) { }

	// RVA: 0x1C2CCA4 Offset: 0x1C28CA4 VA: 0x1C2CCA4
	public void LoadPetCageModel() { }

	// RVA: 0x1C1FAE4 Offset: 0x1C1BAE4 VA: 0x1C1FAE4
	public void CheckLoadPetModel(bool flag) { }

	// RVA: 0x1C1D034 Offset: 0x1C19034 VA: 0x1C1D034
	public void DeleteModel() { }

	[IteratorStateMachine(typeof(UIPetProfilePanel.<LoadModel>d__101))]
	// RVA: 0x1C2CBE8 Offset: 0x1C28BE8 VA: 0x1C2CBE8
	private IEnumerator LoadModel(long Uuid, int monsterUid, string modelId, int[] color, byte scale) { }

	// RVA: 0x1C2D084 Offset: 0x1C29084 VA: 0x1C2D084
	public void InitModelSetting() { }

	// RVA: 0x1C2D22C Offset: 0x1C2922C VA: 0x1C2D22C
	private void ChangePetAnimation(long id, string anime, WrapMode mode) { }

	[IteratorStateMachine(typeof(UIPetProfilePanel.<ModelFadeIn>d__104))]
	// RVA: 0x1C2D318 Offset: 0x1C29318 VA: 0x1C2D318
	private IEnumerator ModelFadeIn() { }

	// RVA: 0x1C2D38C Offset: 0x1C2938C VA: 0x1C2D38C
	public void .ctor() { }
}
