// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("Iruna2/Render/UV2DAnimation")]
public class UV2DAnimation : MonoBehaviour // TypeDefIndex: 4007
{
	// Fields
	private Vector2 uvAdd; // 0x20
	private Vector2 uvPosition; // 0x28
	[SerializeField]
	public Vector2 UVadd; // 0x30
	[SerializeField]
	public float Speed; // 0x38
	private float nextSpeed; // 0x3C
	[SerializeField]
	public string MatrialName; // 0x40
	private Material mat; // 0x48
	private WaitForSeconds waitTimer; // 0x50
	private Vector2 addOffset; // 0x58

	// Methods

	// RVA: 0x246F1E8 Offset: 0x246B1E8 VA: 0x246F1E8
	private void Start() { }

	// RVA: 0x246F4D8 Offset: 0x246B4D8 VA: 0x246F4D8
	private void OnEnable() { }

	// RVA: 0x246F4F8 Offset: 0x246B4F8 VA: 0x246F4F8
	private void OnDestroy() { }

	[IteratorStateMachine(typeof(UV2DAnimation.<UVAnimation>d__12))]
	// RVA: 0x246F46C Offset: 0x246B46C VA: 0x246F46C
	private IEnumerator UVAnimation() { }

	// RVA: 0x246F5C0 Offset: 0x246B5C0 VA: 0x246F5C0
	public void .ctor() { }
}
