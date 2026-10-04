// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Interaction/Drog Pinch")]
public class UIIruna2DragPinch : MonoBehaviour // TypeDefIndex: 105
{
	// Fields
	[SerializeField]
	private bool onScroll; // 0x20
	[SerializeField]
	private float scrollPower; // 0x24
	[CompilerGenerated]
	private float <mPinchDist>k__BackingField; // 0x28
	private float pinchInitDist; // 0x2C
	private float oldPinchDist; // 0x30
	[CompilerGenerated]
	private int <MainTounchId>k__BackingField; // 0x34
	private Dictionary<int, UIIruna2DragPinch.TounchData> tounchList; // 0x38
	private Vector2 firstPoint; // 0x40
	private Vector2 firstDelta; // 0x48
	private Vector2 pushingPoint; // 0x50
	[CompilerGenerated]
	private bool <IsPress>k__BackingField; // 0x58

	// Properties
	public float mPinchDist { get; set; }
	public float PinchDelta { get; }
	public int PushCount { get; }
	public int MainTounchId { get; set; }
	public Vector2 mDragVec { get; }
	public Vector2 mDragDeltaVec { get; }
	public bool IsPress { get; set; }
	public Vector2 FirstDelta { get; }
	public Vector2 CameraFirstDelta { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1ED836C Offset: 0x1ED436C VA: 0x1ED836C
	private void set_mPinchDist(float value) { }

	[CompilerGenerated]
	// RVA: 0x1ED8374 Offset: 0x1ED4374 VA: 0x1ED8374
	public float get_mPinchDist() { }

	// RVA: 0x1ED837C Offset: 0x1ED437C VA: 0x1ED837C
	public float get_PinchDelta() { }

	// RVA: 0x1ED83A8 Offset: 0x1ED43A8 VA: 0x1ED83A8
	public int get_PushCount() { }

	[CompilerGenerated]
	// RVA: 0x1ED83F8 Offset: 0x1ED43F8 VA: 0x1ED83F8
	private void set_MainTounchId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1ED8400 Offset: 0x1ED4400 VA: 0x1ED8400
	public int get_MainTounchId() { }

	// RVA: 0x1ED8408 Offset: 0x1ED4408 VA: 0x1ED8408
	public Vector2 get_mDragVec() { }

	// RVA: 0x1ED855C Offset: 0x1ED455C VA: 0x1ED855C
	public Vector2 get_mDragDeltaVec() { }

	// RVA: 0x1ED86B8 Offset: 0x1ED46B8 VA: 0x1ED86B8
	public Vector3 GetTounchData() { }

	[CompilerGenerated]
	// RVA: 0x1ED870C Offset: 0x1ED470C VA: 0x1ED870C
	public bool get_IsPress() { }

	[CompilerGenerated]
	// RVA: 0x1ED8714 Offset: 0x1ED4714 VA: 0x1ED8714
	private void set_IsPress(bool value) { }

	// RVA: 0x1ED8720 Offset: 0x1ED4720 VA: 0x1ED8720
	public Vector2 get_FirstDelta() { }

	// RVA: 0x1ED8728 Offset: 0x1ED4728 VA: 0x1ED8728
	public Vector2 get_CameraFirstDelta() { }

	// RVA: 0x1ED8740 Offset: 0x1ED4740 VA: 0x1ED8740
	public void Clear() { }

	// RVA: 0x1ED87A0 Offset: 0x1ED47A0 VA: 0x1ED87A0
	public void SetScrollSetting(bool onScroll, float power) { }

	// RVA: 0x1ED87B0 Offset: 0x1ED47B0 VA: 0x1ED87B0
	private void OnPress(bool pressed) { }

	// RVA: 0x1ED8F24 Offset: 0x1ED4F24 VA: 0x1ED8F24
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1ED8C88 Offset: 0x1ED4C88 VA: 0x1ED8C88
	private float PinchDist() { }

	// RVA: 0x1ED909C Offset: 0x1ED509C VA: 0x1ED909C
	private void LateUpdate() { }

	// RVA: 0x1ED9268 Offset: 0x1ED5268 VA: 0x1ED9268
	public void .ctor() { }
}
