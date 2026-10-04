// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CraneGameItemStatus : MonoBehaviour // TypeDefIndex: 4310
{
	// Fields
	[SerializeField]
	private CraneGameController controller; // 0x20
	private int id; // 0x28
	private bool isGet; // 0x2C
	private bool isGeted; // 0x2D
	private bool isTouchArm; // 0x2E
	private bool isCatchArm; // 0x2F
	private bool isFieldCollision; // 0x30
	private bool isTriggerOperable; // 0x31
	private bool canSaveDropOutProgress; // 0x32
	private Collider[] colliders; // 0x38
	private Rigidbody rb; // 0x40
	private CraneGameController.ArmHoldProgress getProgress; // 0x48

	// Properties
	public int Id { get; set; }
	public bool IsGet { get; set; }
	public bool IsGeted { get; set; }
	public bool IsTouchArm { get; set; }
	public bool IsCatchArm { get; }
	public bool IsFieldCollision { get; }
	public bool IsTriggerOperable { get; set; }
	public Collider[] Colliders { get; }
	public Rigidbody Rigidbody { get; }
	public CraneGameController.ArmHoldProgress GetProgress { get; }

	// Methods

	// RVA: 0x24CBE38 Offset: 0x24C7E38 VA: 0x24CBE38
	public int get_Id() { }

	// RVA: 0x24CBE40 Offset: 0x24C7E40 VA: 0x24CBE40
	public void set_Id(int value) { }

	// RVA: 0x24CBE48 Offset: 0x24C7E48 VA: 0x24CBE48
	public bool get_IsGet() { }

	// RVA: 0x24CBE50 Offset: 0x24C7E50 VA: 0x24CBE50
	public void set_IsGet(bool value) { }

	// RVA: 0x24CBE5C Offset: 0x24C7E5C VA: 0x24CBE5C
	public bool get_IsGeted() { }

	// RVA: 0x24CBE64 Offset: 0x24C7E64 VA: 0x24CBE64
	public void set_IsGeted(bool value) { }

	// RVA: 0x24CBE70 Offset: 0x24C7E70 VA: 0x24CBE70
	public bool get_IsTouchArm() { }

	// RVA: 0x24CBE78 Offset: 0x24C7E78 VA: 0x24CBE78
	public void set_IsTouchArm(bool value) { }

	// RVA: 0x24CBE84 Offset: 0x24C7E84 VA: 0x24CBE84
	public bool get_IsCatchArm() { }

	// RVA: 0x24CBE8C Offset: 0x24C7E8C VA: 0x24CBE8C
	public bool get_IsFieldCollision() { }

	// RVA: 0x24CBE94 Offset: 0x24C7E94 VA: 0x24CBE94
	public bool get_IsTriggerOperable() { }

	// RVA: 0x24CBE9C Offset: 0x24C7E9C VA: 0x24CBE9C
	public void set_IsTriggerOperable(bool value) { }

	// RVA: 0x24CBEA8 Offset: 0x24C7EA8 VA: 0x24CBEA8
	public Collider[] get_Colliders() { }

	// RVA: 0x24CBEB0 Offset: 0x24C7EB0 VA: 0x24CBEB0
	public Rigidbody get_Rigidbody() { }

	// RVA: 0x24CBEB8 Offset: 0x24C7EB8 VA: 0x24CBEB8
	public CraneGameController.ArmHoldProgress get_GetProgress() { }

	// RVA: 0x24CBEC0 Offset: 0x24C7EC0 VA: 0x24CBEC0
	private void Start() { }

	// RVA: 0x24CC320 Offset: 0x24C8320 VA: 0x24CC320
	private void Update() { }

	// RVA: 0x24CC4AC Offset: 0x24C84AC VA: 0x24CC4AC
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x24CC5BC Offset: 0x24C85BC VA: 0x24CC5BC
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0x24CC758 Offset: 0x24C8758 VA: 0x24CC758
	private void OnCollisionStay(Collision collision) { }

	// RVA: 0x24CC7DC Offset: 0x24C87DC VA: 0x24CC7DC
	private void OnCollisionExit(Collision collision) { }

	[IteratorStateMachine(typeof(CraneGameItemStatus.<GetToChangeActiveStatus>d__43))]
	// RVA: 0x24CB258 Offset: 0x24C7258 VA: 0x24CB258
	public IEnumerator GetToChangeActiveStatus(bool acitveFlag, int waitTime) { }

	// RVA: 0x24C9280 Offset: 0x24C5280 VA: 0x24C9280
	public void SetRigidbodyVariable(Vector3 velocity, Vector3 inertiaTensor) { }

	// RVA: 0x24CA038 Offset: 0x24C6038 VA: 0x24CA038
	public void SetSleepRigidBody() { }

	// RVA: 0x24CC444 Offset: 0x24C8444 VA: 0x24CC444
	public void ChangeItemColliderTrigger(bool isTrigger) { }

	// RVA: 0x24CBDBC Offset: 0x24C7DBC VA: 0x24CBDBC
	public void ResetDropFlag() { }

	// RVA: 0x24CBDC8 Offset: 0x24C7DC8 VA: 0x24CBDC8
	public void SetIsGet(bool flag) { }

	// RVA: 0x24CB0A8 Offset: 0x24C70A8 VA: 0x24CB0A8
	public void CheckOverlapCollider() { }

	// RVA: 0x24CC900 Offset: 0x24C8900 VA: 0x24CC900
	public void .ctor() { }
}
