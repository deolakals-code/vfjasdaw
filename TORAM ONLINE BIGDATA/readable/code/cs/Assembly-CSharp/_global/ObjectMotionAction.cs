// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ObjectMotionAction : MonoBehaviour // TypeDefIndex: 3974
{
	// Fields
	private Animation animationCom; // 0x20
	private int playId; // 0x28
	private GameObject player; // 0x30
	[SerializeField]
	private bool autoCreate; // 0x38
	[SerializeField]
	private Vector3 position; // 0x3C
	[SerializeField]
	private float rad; // 0x48
	[SerializeField]
	private Vector3 size; // 0x4C
	[SerializeField]
	private Quaternion rot; // 0x58
	[SerializeField]
	private ObjectMotionAction.DecisionType decision; // 0x68
	private Cylinder cylinder; // 0x70
	private OBB obb; // 0x78

	// Methods

	// RVA: 0x2429D88 Offset: 0x2425D88 VA: 0x2429D88
	private void Start() { }

	// RVA: 0x242A06C Offset: 0x242606C VA: 0x242A06C
	public void Initialize(Vector3 pos, Vector3 size, float rot) { }

	// RVA: 0x242A0BC Offset: 0x24260BC VA: 0x242A0BC
	public void Initialize(Vector3 pos, float rad, float size) { }

	// RVA: 0x242A0D8 Offset: 0x24260D8 VA: 0x242A0D8
	private void Update() { }

	// RVA: 0x242A204 Offset: 0x2426204 VA: 0x242A204
	private int CheckMotionId() { }

	// RVA: 0x2429E58 Offset: 0x2425E58 VA: 0x2429E58
	private void createDecision() { }

	// RVA: 0x242A3C4 Offset: 0x24263C4 VA: 0x242A3C4
	public bool CheckDecision(Vector3 pos, float rad) { }

	// RVA: 0x242A3FC Offset: 0x24263FC VA: 0x242A3FC
	public void .ctor() { }
}
