// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Center On Child")]
public class UICenterOnChild : MonoBehaviour // TypeDefIndex: 26
{
	// Fields
	public float springStrength; // 0x20
	public SpringPanel.OnFinished onFinished; // 0x28
	private UIDraggablePanel mDrag; // 0x30
	private GameObject mCenteredObject; // 0x38

	// Properties
	public GameObject centeredObject { get; }

	// Methods

	// RVA: 0x1718600 Offset: 0x1714600 VA: 0x1718600
	public GameObject get_centeredObject() { }

	// RVA: 0x1718608 Offset: 0x1714608 VA: 0x1718608
	private void OnEnable() { }

	// RVA: 0x1718CC8 Offset: 0x1714CC8 VA: 0x1718CC8
	private void OnDragFinished() { }

	// RVA: 0x171860C Offset: 0x171460C VA: 0x171860C
	public void Recenter() { }

	// RVA: 0x1718DA0 Offset: 0x1714DA0 VA: 0x1718DA0
	public void .ctor() { }
}
