// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetModelPanel : MonoBehaviour // TypeDefIndex: 7813
{
	// Fields
	[SerializeField]
	private Camera cameraView; // 0x20
	[SerializeField]
	private UIIruna2DragPinch dragPinch; // 0x28
	[SerializeField]
	private Transform modelParent; // 0x30
	private SystemTextManager systemTextManager; // 0x38
	private EnemyTextManager EnemyTextManager; // 0x40
	private Dictionary<long, GameObject> petModelObjectList; // 0x48
	private PetModelLoader petModelLoader; // 0x50
	private MobAnimation mobAnimation; // 0x58
	private const float defaultAngle = 225;
	private float modelAngle; // 0x60
	private Dictionary<long, bool> checkedPetFlag; // 0x68
	private PetModelData model; // 0x70
	protected long petUuid; // 0x78
	private MobAnimationType animeType; // 0x80
	private bool moveRightFlag; // 0x84
	private Vector3 petModelFirstPos; // 0x88
	private float moveTimer; // 0x94
	private bool nameChangePanelFlag; // 0x98
	private UICamera uiCamera; // 0xA0
	private bool isRotateModel; // 0xA8

	// Properties
	public GameObject GetPetModel { get; }
	public Transform GetModelTrans { get; }
	public Transform GetModelRootBone { get; }
	public bool NameChangePanelFlag { set; }

	// Methods

	// RVA: 0x1C26440 Offset: 0x1C22440 VA: 0x1C26440
	public void SetPetViewData(long uid, PetModelData model) { }

	// RVA: 0x1C26450 Offset: 0x1C22450 VA: 0x1C26450
	public void SetCameraActive(bool flag) { }

	// RVA: 0x1C26470 Offset: 0x1C22470 VA: 0x1C26470
	public void SetActiveModel(bool flag) { }

	// RVA: 0x1C264D8 Offset: 0x1C224D8 VA: 0x1C264D8
	public void SetModelParent(Transform parent) { }

	// RVA: 0x1C2654C Offset: 0x1C2254C VA: 0x1C2654C
	public GameObject get_GetPetModel() { }

	// RVA: 0x1C265A0 Offset: 0x1C225A0 VA: 0x1C265A0
	public void ResetModelParent() { }

	// RVA: 0x1C26610 Offset: 0x1C22610 VA: 0x1C26610
	public Transform get_GetModelTrans() { }

	// RVA: 0x1C26670 Offset: 0x1C22670 VA: 0x1C26670
	public Transform get_GetModelRootBone() { }

	// RVA: 0x1C266F0 Offset: 0x1C226F0 VA: 0x1C266F0
	public Transform GetModelBoneTrans(string name) { }

	// RVA: 0x1C26784 Offset: 0x1C22784 VA: 0x1C26784
	public void SetModelAlpha(float alpha) { }

	// RVA: 0x1C2686C Offset: 0x1C2286C VA: 0x1C2686C
	public void ChangeModelAnimation(MobAnimationType type) { }

	// RVA: 0x1C268DC Offset: 0x1C228DC VA: 0x1C268DC
	public void NameChangeMove() { }

	// RVA: 0x1C26BCC Offset: 0x1C22BCC VA: 0x1C26BCC
	public void SetModelNowPos() { }

	// RVA: 0x1C26C84 Offset: 0x1C22C84 VA: 0x1C26C84
	public void SetModelPos(Vector3 pos) { }

	// RVA: 0x1C26B40 Offset: 0x1C22B40 VA: 0x1C26B40
	public void SetTweenPosModel(Vector3 pos, float time) { }

	// RVA: 0x1C26D18 Offset: 0x1C22D18 VA: 0x1C26D18
	public void SetTweenPosZModel(float posZ, float time) { }

	// RVA: 0x1C26DD0 Offset: 0x1C22DD0 VA: 0x1C26DD0
	public void ResetPosModel() { }

	// RVA: 0x1C26E44 Offset: 0x1C22E44 VA: 0x1C26E44
	public void ResetTweenPosModel(float time) { }

	// RVA: 0x1C26990 Offset: 0x1C22990 VA: 0x1C26990
	public void SetRotModel(float angle) { }

	// RVA: 0x1C26A5C Offset: 0x1C22A5C VA: 0x1C26A5C
	public void SetTweenRotModel(float angle, float time) { }

	// RVA: 0x1C26EB8 Offset: 0x1C22EB8 VA: 0x1C26EB8
	public void SetTweenScaleModel(float time, Vector3 scale) { }

	// RVA: 0x1C26F44 Offset: 0x1C22F44 VA: 0x1C26F44
	public void ChangeDragEnable(bool enable) { }

	// RVA: 0x1C26F50 Offset: 0x1C22F50 VA: 0x1C26F50
	public void set_NameChangePanelFlag(bool value) { }

	// RVA: 0x1C26F5C Offset: 0x1C22F5C VA: 0x1C26F5C
	public void SetUICamera(UICamera value) { }

	// RVA: 0x1C26F64 Offset: 0x1C22F64 VA: 0x1C26F64 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x1C270DC Offset: 0x1C230DC VA: 0x1C270DC
	private void OnEnable() { }

	// RVA: 0x1C2753C Offset: 0x1C2353C VA: 0x1C2753C Slot: 5
	protected virtual void Update() { }

	// RVA: 0x1C27968 Offset: 0x1C23968 VA: 0x1C27968
	public void CheckLoadPetModel(bool flag = True) { }

	// RVA: 0x1C27D68 Offset: 0x1C23D68 VA: 0x1C27D68
	public void DeleteModel() { }

	[IteratorStateMachine(typeof(UIPetModelPanel.<LoadModel>d__53))]
	// RVA: 0x1C27CBC Offset: 0x1C23CBC VA: 0x1C27CBC
	private IEnumerator LoadModel(long Uuid, string modelId, int[] color, byte scale) { }

	// RVA: 0x1C270E0 Offset: 0x1C230E0 VA: 0x1C270E0
	public void InitModelSetting() { }

	// RVA: 0x1C27F04 Offset: 0x1C23F04 VA: 0x1C27F04
	private void ChangePetAnimation(long id, string anime, WrapMode mode) { }

	[IteratorStateMachine(typeof(UIPetModelPanel.<ModelFadeIn>d__56))]
	// RVA: 0x1C28030 Offset: 0x1C24030 VA: 0x1C28030
	private IEnumerator ModelFadeIn() { }

	// RVA: 0x1C280C4 Offset: 0x1C240C4 VA: 0x1C280C4
	public void .ctor() { }
}
