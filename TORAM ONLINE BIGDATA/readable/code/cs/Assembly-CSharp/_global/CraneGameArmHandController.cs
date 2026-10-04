// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CraneGameArmHandController : MonoBehaviour // TypeDefIndex: 4296
{
	// Fields
	[SerializeField]
	private CraneGameController craneGameController; // 0x20
	[SerializeField]
	private Transform rayObject; // 0x28
	private bool isMoveCompleted; // 0x30
	private bool isCollisionField; // 0x31
	private float movePowerPosX; // 0x34
	private float movePowerAngleZ; // 0x38
	private CraneGameArmHandController.ArmFlagProgress flagProgress; // 0x3C
	private GameObject collisionObject; // 0x40

	// Properties
	public Transform RayObjectReadOnly { get; }
	public GameObject CollisionObject { get; }

	// Methods

	// RVA: 0x24C692C Offset: 0x24C292C VA: 0x24C692C
	public Transform get_RayObjectReadOnly() { }

	// RVA: 0x24C6934 Offset: 0x24C2934 VA: 0x24C6934
	public GameObject get_CollisionObject() { }

	// RVA: 0x24C693C Offset: 0x24C293C VA: 0x24C693C
	private void Update() { }

	// RVA: 0x24C6D44 Offset: 0x24C2D44 VA: 0x24C6D44
	private void SetMovePower() { }

	// RVA: 0x24C6D6C Offset: 0x24C2D6C VA: 0x24C6D6C
	private Vector3[] SetHomePosition(Vector3[] transformStatus) { }

	// RVA: 0x24C6DDC Offset: 0x24C2DDC VA: 0x24C6DDC
	public void PromoteProgress() { }

	// RVA: 0x24C6E00 Offset: 0x24C2E00 VA: 0x24C6E00
	public void SetCollisionObject(GameObject obj) { }

	// RVA: 0x24C6E08 Offset: 0x24C2E08 VA: 0x24C6E08
	public void .ctor() { }
}
