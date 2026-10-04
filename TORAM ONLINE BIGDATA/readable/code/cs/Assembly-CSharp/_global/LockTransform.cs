// Assembly: Assembly-CSharp.dll
// Namespace: 
public class LockTransform : MonoBehaviour // TypeDefIndex: 288
{
	// Fields
	[SerializeField]
	private Transform[] lockTransform; // 0x20
	[SerializeField]
	private LockTransform.LockFlag[] lockFlag; // 0x28
	private Animation playAnimation; // 0x30
	private Vector3[] savePosition; // 0x38
	private Quaternion[] saveRotation; // 0x40
	private bool initFlag; // 0x48
	private Vector3 defaultPosition; // 0x4C
	private Vector3 defaultRotation; // 0x58

	// Methods

	// RVA: 0x22B53F8 Offset: 0x22B13F8 VA: 0x22B53F8
	private void Start() { }

	// RVA: 0x22B5408 Offset: 0x22B1408 VA: 0x22B5408
	private void Initialize() { }

	// RVA: 0x22B5628 Offset: 0x22B1628 VA: 0x22B5628
	private void OnEnable() { }

	// RVA: 0x22B5630 Offset: 0x22B1630 VA: 0x22B5630
	public void SetDefaultTransform(Vector3 pos, float rot) { }

	// RVA: 0x22B573C Offset: 0x22B173C VA: 0x22B573C
	private void Update() { }

	// RVA: 0x22B5834 Offset: 0x22B1834 VA: 0x22B5834
	private void LateUpdate() { }

	// RVA: 0x22B5D48 Offset: 0x22B1D48 VA: 0x22B5D48
	public void .ctor() { }
}
