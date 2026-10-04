// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CraneGameController : MonoBehaviour // TypeDefIndex: 4308
{
	// Fields
	[SerializeField]
	private GameObject itemObject1; // 0x20
	[SerializeField]
	private GameObject itemObject2; // 0x28
	[SerializeField]
	private GameObject itemParentObject; // 0x30
	[SerializeField]
	private GeneratePosArrayData generatePosData; // 0x38
	[Space(20)]
	[SerializeField]
	private GameObject armObjectParent; // 0x40
	[SerializeField]
	private GameObject armTop; // 0x48
	[SerializeField]
	private MeshRenderer[] popOutObjects; // 0x50
	[SerializeField]
	private GameObject axisBlock; // 0x58
	[SerializeField]
	private GameObject lastJoint; // 0x60
	[SerializeField]
	private Vector3 fieldSize; // 0x68
	[SerializeField]
	private GameObject[] craneGameField; // 0x78
	[SerializeField]
	private GameObject prizeArea; // 0x80
	[SerializeField]
	private CraneGameArmHandController[] armHandControllers; // 0x88
	[SerializeField]
	private GameObject[] armHandTopObjects; // 0x90
	[SerializeField]
	private Collider[] armHandColliders; // 0x98
	[SerializeField]
	private Vector3 startPos; // 0xA0
	[SerializeField]
	private Rigidbody armsRigidbody; // 0xB0
	[SerializeField]
	private Transform armCenterObject; // 0xB8
	[SerializeField]
	private SphereCollider armCenterCollider; // 0xC0
	private int generateListIndex; // 0xC8
	private CraneGameItemStatus[] contents; // 0xD0
	private bool inputWide; // 0xD8
	private bool inputForward; // 0xD9
	private Vector3 movePower; // 0xDC
	private readonly float movePowerFloat; // 0xE8
	private float aftertasteValue_x; // 0xEC
	private float aftertasteValue_z; // 0xF0
	private float afterMovePower; // 0xF4
	private float armDownEndPosY; // 0xF8
	private bool isFinished; // 0xFC
	private CraneGameController.ArmHoldProgress armHoldProgress; // 0x100
	private Vector3 armCenterObjFirstPos; // 0x104
	private Vector3[] scoreStartPos; // 0x110
	private Vector3[] scoreEndPos; // 0x118
	private float craneProgressA; // 0x120
	private float craneProgressB; // 0x124
	private float craneProgressC; // 0x128
	private Action<int> resultAction; // 0x130
	private CraneGameController.ArmHoldProgress dropedProgress; // 0x138
	private const int ITEM_GETSCORE = 3000;
	private const int PLAY_USEMONEY = 300;
	private Vector3 dropPos; // 0x13C
	[CompilerGenerated]
	private int[] <ContentIds>k__BackingField; // 0x148
	[CompilerGenerated]
	private bool <IsArmAutoMove>k__BackingField; // 0x150

	// Properties
	private Rigidbody AxisBlockRb { get; }
	public Vector3 AxisBlockPos { get; }
	public Vector3 LastJointPos { get; }
	public Vector3 FieldSize { get; }
	public GameObject[] CraneGameField { get; }
	public GameObject PrizeArea { get; }
	public Vector3 StartPos { get; }
	public int[] ContentIds { get; set; }
	public bool IsArmAutoMove { get; set; }
	public CraneGameController.ArmHoldProgress ReadOnlyArmHoldProgress { get; }
	public Collider[] ArmHandColliders { get; }

	// Methods

	// RVA: 0x24C7C08 Offset: 0x24C3C08 VA: 0x24C7C08
	private Rigidbody get_AxisBlockRb() { }

	// RVA: 0x24C7C58 Offset: 0x24C3C58 VA: 0x24C7C58
	public Vector3 get_AxisBlockPos() { }

	// RVA: 0x24C7D20 Offset: 0x24C3D20 VA: 0x24C7D20
	public Vector3 get_LastJointPos() { }

	// RVA: 0x24C7D48 Offset: 0x24C3D48 VA: 0x24C7D48
	public Vector3 get_FieldSize() { }

	// RVA: 0x24C7D54 Offset: 0x24C3D54 VA: 0x24C7D54
	public GameObject[] get_CraneGameField() { }

	// RVA: 0x24C7D5C Offset: 0x24C3D5C VA: 0x24C7D5C
	public bool IsCheckContainsFieldObj(GameObject obj) { }

	// RVA: 0x24C7E58 Offset: 0x24C3E58 VA: 0x24C7E58
	public GameObject get_PrizeArea() { }

	// RVA: 0x24C7E60 Offset: 0x24C3E60 VA: 0x24C7E60
	public Vector3 get_StartPos() { }

	[CompilerGenerated]
	// RVA: 0x24C7E6C Offset: 0x24C3E6C VA: 0x24C7E6C
	public int[] get_ContentIds() { }

	[CompilerGenerated]
	// RVA: 0x24C7E74 Offset: 0x24C3E74 VA: 0x24C7E74
	private void set_ContentIds(int[] value) { }

	[CompilerGenerated]
	// RVA: 0x24C7E84 Offset: 0x24C3E84 VA: 0x24C7E84
	public bool get_IsArmAutoMove() { }

	[CompilerGenerated]
	// RVA: 0x24C7E8C Offset: 0x24C3E8C VA: 0x24C7E8C
	private void set_IsArmAutoMove(bool value) { }

	// RVA: 0x24C7E98 Offset: 0x24C3E98 VA: 0x24C7E98
	public List<CraneGameItemStatus> GetItemStatusList() { }

	// RVA: 0x24C7FBC Offset: 0x24C3FBC VA: 0x24C7FBC
	public CraneGameController.ArmHoldProgress get_ReadOnlyArmHoldProgress() { }

	// RVA: 0x24C7FC4 Offset: 0x24C3FC4 VA: 0x24C7FC4
	public void SetItemGetAction(Action<int> action) { }

	// RVA: 0x24C7FD4 Offset: 0x24C3FD4 VA: 0x24C7FD4
	public int GetCraneScore() { }

	// RVA: 0x24C8004 Offset: 0x24C4004 VA: 0x24C8004
	public int GetGameScore(int totalPlayCount, int getCount, int craneScore) { }

	// RVA: 0x24C801C Offset: 0x24C401C VA: 0x24C801C
	public Collider[] get_ArmHandColliders() { }

	// RVA: 0x24C8024 Offset: 0x24C4024 VA: 0x24C8024
	private void Awake() { }

	// RVA: 0x24C85E4 Offset: 0x24C45E4 VA: 0x24C85E4
	private void Start() { }

	// RVA: 0x24C8620 Offset: 0x24C4620 VA: 0x24C8620
	private void Update() { }

	// RVA: 0x24C8094 Offset: 0x24C4094 VA: 0x24C8094
	private void CreatItems() { }

	// RVA: 0x24C92D8 Offset: 0x24C52D8 VA: 0x24C92D8
	public void MoveWide() { }

	// RVA: 0x24C9364 Offset: 0x24C5364 VA: 0x24C9364
	public void MoveForward() { }

	// RVA: 0x24C9240 Offset: 0x24C5240 VA: 0x24C9240
	private float SetAftertasteValue(float aftertasteValue) { }

	// RVA: 0x24C8BBC Offset: 0x24C4BBC VA: 0x24C8BBC
	private void AutoArmDown() { }

	// RVA: 0x24C8EB4 Offset: 0x24C4EB4 VA: 0x24C8EB4
	private void AutoArmUp() { }

	// RVA: 0x24C8F50 Offset: 0x24C4F50 VA: 0x24C8F50
	private void AutoArmMove() { }

	// RVA: 0x24C9500 Offset: 0x24C5500 VA: 0x24C9500
	private bool GetRoundLocalPos(float pos) { }

	// RVA: 0x24C8B28 Offset: 0x24C4B28 VA: 0x24C8B28
	private void CheckPosPopOutObjects() { }

	// RVA: 0x24C95E4 Offset: 0x24C55E4 VA: 0x24C95E4
	public void ArmAuto() { }

	[IteratorStateMachine(typeof(CraneGameController.<AutoArmController>d__87))]
	// RVA: 0x24C9620 Offset: 0x24C5620 VA: 0x24C9620
	private IEnumerator AutoArmController() { }

	[IteratorStateMachine(typeof(CraneGameController.<ChangeProgressWaitCoroutine>d__88))]
	// RVA: 0x24C96B4 Offset: 0x24C56B4 VA: 0x24C96B4
	private IEnumerator ChangeProgressWaitCoroutine(CraneGameController.ArmHoldProgress progress, IEnumerator enumerator, float waitTime) { }

	[IteratorStateMachine(typeof(CraneGameController.<DelayCoroutine>d__89))]
	// RVA: 0x24C944C Offset: 0x24C544C VA: 0x24C944C
	private IEnumerator DelayCoroutine(float seconds, Action action) { }

	[IteratorStateMachine(typeof(CraneGameController.<Hold>d__90))]
	// RVA: 0x24C97A4 Offset: 0x24C57A4 VA: 0x24C97A4
	private IEnumerator Hold() { }

	[IteratorStateMachine(typeof(CraneGameController.<Release>d__91))]
	// RVA: 0x24C9838 Offset: 0x24C5838 VA: 0x24C9838
	private IEnumerator Release() { }

	// RVA: 0x24C98CC Offset: 0x24C58CC VA: 0x24C98CC
	private void PromoteAllProgress() { }

	// RVA: 0x24C992C Offset: 0x24C592C VA: 0x24C992C
	public bool CheckAllObstacle() { }

	// RVA: 0x24C93EC Offset: 0x24C53EC VA: 0x24C93EC
	public bool CheckExistContent(int id) { }

	// RVA: 0x24C9B18 Offset: 0x24C5B18 VA: 0x24C9B18
	public bool CheckIsContains(GameObject collisionObject) { }

	// RVA: 0x24C9BE4 Offset: 0x24C5BE4 VA: 0x24C9BE4
	public bool CheckIsContainsOtherItem(GameObject itemObj) { }

	// RVA: 0x24C9CC0 Offset: 0x24C5CC0 VA: 0x24C9CC0
	public bool CheckArmHandInside(Collider target) { }

	// RVA: 0x24C9DB0 Offset: 0x24C5DB0 VA: 0x24C9DB0
	public void ItemPosReset() { }

	// RVA: 0x24CA054 Offset: 0x24C6054 VA: 0x24CA054
	public void SetScoreProgress() { }

	// RVA: 0x24C94C8 Offset: 0x24C54C8 VA: 0x24C94C8
	public void SaveDropTiming() { }

	// RVA: 0x24CA170 Offset: 0x24C6170 VA: 0x24CA170
	public void ResetCraneProgresses() { }

	// RVA: 0x24CA17C Offset: 0x24C617C VA: 0x24CA17C
	private void ResetDropTiming() { }

	// RVA: 0x24CA184 Offset: 0x24C6184 VA: 0x24CA184
	private Vector3 PerpendicularFootPoint(Vector3 a, Vector3 b, Vector3 p) { }

	// RVA: 0x24CA2C4 Offset: 0x24C62C4 VA: 0x24CA2C4
	public void SetDownEndPos() { }

	// RVA: 0x24CA2F0 Offset: 0x24C62F0 VA: 0x24CA2F0
	public void SetRigidbodyGravity() { }

	// RVA: 0x24CA424 Offset: 0x24C6424 VA: 0x24CA424
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x24CA534 Offset: 0x24C6534 VA: 0x24CA534
	private void <AutoArmMove>b__83_0() { }

	[CompilerGenerated]
	// RVA: 0x24CA5CC Offset: 0x24C65CC VA: 0x24CA5CC
	private void <AutoArmMove>b__83_1() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(CraneGameController.<<SetScoreProgress>g__SetScore|99_0>d))]
	// RVA: 0x24CA104 Offset: 0x24C6104 VA: 0x24CA104
	private IEnumerator <SetScoreProgress>g__SetScore|99_0() { }
}
