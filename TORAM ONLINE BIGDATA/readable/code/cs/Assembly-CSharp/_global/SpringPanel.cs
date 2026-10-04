// Assembly: Assembly-CSharp.dll
// Namespace: 
[RequireComponent(typeof(UIPanel))]
[AddComponentMenu("NGUI/Internal/Spring Panel")]
public class SpringPanel : MonoBehaviour // TypeDefIndex: 79
{
	// Fields
	public Vector3 target; // 0x20
	public float strength; // 0x2C
	public SpringPanel.OnFinished onFinished; // 0x30
	private UIPanel mPanel; // 0x38
	private Transform mTrans; // 0x40
	private float mThreshold; // 0x48
	private UIDraggablePanel mDrag; // 0x50

	// Methods

	// RVA: 0x1732D3C Offset: 0x172ED3C VA: 0x1732D3C
	private void Start() { }

	// RVA: 0x1732DE8 Offset: 0x172EDE8 VA: 0x1732DE8
	private void Update() { }

	// RVA: 0x1733084 Offset: 0x172F084 VA: 0x1733084
	public static SpringPanel Begin(GameObject go, Vector3 pos, float strength) { }

	// RVA: 0x1733190 Offset: 0x172F190 VA: 0x1733190
	public void .ctor() { }
}
