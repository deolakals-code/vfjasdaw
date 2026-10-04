// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Tween/Spring Position")]
public class SpringPosition : MonoBehaviour // TypeDefIndex: 131
{
	// Fields
	public Vector3 target; // 0x20
	public float strength; // 0x2C
	public bool worldSpace; // 0x30
	public bool ignoreTimeScale; // 0x31
	public GameObject eventReceiver; // 0x38
	public string callWhenFinished; // 0x40
	public SpringPosition.OnFinished onFinished; // 0x48
	private Transform mTrans; // 0x50
	private float mThreshold; // 0x58

	// Methods

	// RVA: 0x1EDE730 Offset: 0x1EDA730 VA: 0x1EDE730
	private void Start() { }

	// RVA: 0x1EDE754 Offset: 0x1EDA754 VA: 0x1EDE754
	private void Update() { }

	// RVA: 0x1EDEB5C Offset: 0x1EDAB5C VA: 0x1EDEB5C
	public static SpringPosition Begin(GameObject go, Vector3 pos, float strength) { }

	// RVA: 0x1EDEC78 Offset: 0x1EDAC78 VA: 0x1EDEC78
	public void .ctor() { }
}
