// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/UI/Root")]
[ExecuteInEditMode]
public class UIRoot : MonoBehaviour // TypeDefIndex: 177
{
	// Fields
	public static List<UIRoot> list; // 0x0
	public UIRoot.Scaling scalingStyle; // 0x20
	public int manualHeight; // 0x24
	public int minimumHeight; // 0x28
	public int maximumHeight; // 0x2C
	private Transform mTrans; // 0x30

	// Properties
	public int activeHeight { get; }
	public float pixelSizeAdjustment { get; }

	// Methods

	// RVA: 0x20D3930 Offset: 0x20CF930 VA: 0x20D3930
	public int get_activeHeight() { }

	// RVA: 0x20D3984 Offset: 0x20CF984 VA: 0x20D3984
	public float get_pixelSizeAdjustment() { }

	// RVA: 0x20D39FC Offset: 0x20CF9FC VA: 0x20D39FC
	public static float GetPixelSizeAdjustment(GameObject go) { }

	// RVA: 0x20D39A4 Offset: 0x20CF9A4 VA: 0x20D39A4
	public float GetPixelSizeAdjustment(int height) { }

	// RVA: 0x20D3AD4 Offset: 0x20CFAD4 VA: 0x20D3AD4 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x20D3AF8 Offset: 0x20CFAF8 VA: 0x20D3AF8 Slot: 5
	protected virtual void OnEnable() { }

	// RVA: 0x20D3BCC Offset: 0x20CFBCC VA: 0x20D3BCC Slot: 6
	protected virtual void OnDisable() { }

	// RVA: 0x20D3C4C Offset: 0x20CFC4C VA: 0x20D3C4C Slot: 7
	protected virtual void Start() { }

	// RVA: 0x20D3DA4 Offset: 0x20CFDA4 VA: 0x20D3DA4
	private void Update() { }

	// RVA: 0x20D3EAC Offset: 0x20CFEAC VA: 0x20D3EAC
	public static void Broadcast(string funcName) { }

	// RVA: 0x20D3FE4 Offset: 0x20CFFE4 VA: 0x20D3FE4
	public static void Broadcast(string funcName, object param) { }

	// RVA: 0x20D4164 Offset: 0x20D0164 VA: 0x20D4164
	public void .ctor() { }

	// RVA: 0x20D4178 Offset: 0x20D0178 VA: 0x20D4178
	private static void .cctor() { }
}
