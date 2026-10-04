// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ShopEffectController : MonoBehaviour // TypeDefIndex: 8470
{
	// Fields
	[SerializeField]
	private GameObject dragTargetObject; // 0x20
	[SerializeField]
	private float autoRotationSpeed; // 0x28
	[SerializeField]
	private float dragRotationRate; // 0x2C
	[SerializeField]
	private float autoRotationDelay; // 0x30
	[SerializeField]
	private float dragRotationDecelerationSpeed; // 0x34
	private float lastDragTime; // 0x38
	private float lastDragSpeed; // 0x3C
	private bool isPress; // 0x40

	// Methods

	// RVA: 0x1D72A60 Offset: 0x1D6EA60 VA: 0x1D72A60
	private void Update() { }

	// RVA: 0x1D72CE8 Offset: 0x1D6ECE8 VA: 0x1D72CE8
	private void OnDrag(Vector2 drag) { }

	// RVA: 0x1D72D5C Offset: 0x1D6ED5C VA: 0x1D72D5C
	private void OnPress(bool ispress) { }

	// RVA: 0x1D72D68 Offset: 0x1D6ED68 VA: 0x1D72D68
	public void Reset() { }

	// RVA: 0x1D72B34 Offset: 0x1D6EB34 VA: 0x1D72B34
	private void rotationTargetObject(float speed) { }

	// RVA: 0x1D72DBC Offset: 0x1D6EDBC VA: 0x1D72DBC
	public void .ctor() { }
}
