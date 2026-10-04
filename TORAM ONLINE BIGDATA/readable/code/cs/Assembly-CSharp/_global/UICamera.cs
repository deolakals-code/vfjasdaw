// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/UI/Camera")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class UICamera : MonoBehaviour // TypeDefIndex: 159
{
	// Fields
	public static List<UICamera> list; // 0x0
	public LayerMask eventReceiverMask; // 0x20
	public bool debug; // 0x24
	public bool useMouse; // 0x25
	private const int useMouseKeyNum = 3;
	public bool useTouch; // 0x26
	public bool allowMultiTouch; // 0x27
	public bool useKeyboard; // 0x28
	public bool useController; // 0x29
	public bool stickyPress; // 0x2A
	public bool clipRaycasts; // 0x2B
	public bool stickyTooltip; // 0x2C
	public float tooltipDelay; // 0x30
	public float mouseDragThreshold; // 0x34
	public float mouseClickThreshold; // 0x38
	public float touchDragThreshold; // 0x3C
	public float touchClickThreshold; // 0x40
	public float rangeDistance; // 0x44
	public string scrollAxisName; // 0x48
	public string verticalAxisName; // 0x50
	public string horizontalAxisName; // 0x58
	public KeyCode submitKey0; // 0x60
	public KeyCode submitKey1; // 0x64
	public KeyCode cancelKey0; // 0x68
	public KeyCode cancelKey1; // 0x6C
	public static UICamera.OnCustomInput onCustomInput; // 0x8
	public static bool showTooltips; // 0x10
	public static Vector2 lastTouchPosition; // 0x14
	public static RaycastHit lastHit; // 0x1C
	public static UICamera current; // 0x48
	public static Camera currentCamera; // 0x50
	public static int currentTouchID; // 0x58
	public static UICamera.MouseOrTouch currentTouch; // 0x60
	public static bool inputHasFocus; // 0x68
	public static GameObject genericEventHandler; // 0x70
	public static GameObject fallThrough; // 0x78
	private static List<UICamera.Highlighted> mHighlighted; // 0x80
	private static GameObject mSel; // 0x88
	private static UICamera.MouseOrTouch[] mMouse; // 0x90
	private static GameObject mHover; // 0x98
	private static UICamera.MouseOrTouch mController; // 0xA0
	private static float mNextEvent; // 0xA8
	private static Dictionary<int, UICamera.MouseOrTouch> mTouches; // 0xB0
	private GameObject mTooltip; // 0x70
	private Camera mCam; // 0x78
	private LayerMask mLayerMask; // 0x80
	private float mTooltipTime; // 0x84
	private bool mIsEditor; // 0x88
	public static bool isDragging; // 0xB8
	public static GameObject hoveredObject; // 0xC0
	private static RaycastHit mEmpty; // 0xC8

	// Properties
	private bool handlesEvents { get; }
	public Camera cachedCamera { get; }
	public static GameObject selectedObject { get; set; }
	public static int touchCount { get; }
	public static int dragCount { get; }
	public static Camera mainCamera { get; }
	public static UICamera eventHandler { get; }

	// Methods

	// RVA: 0x1FC7B5C Offset: 0x1FC3B5C VA: 0x1FC7B5C
	private bool get_handlesEvents() { }

	// RVA: 0x1FC7D60 Offset: 0x1FC3D60 VA: 0x1FC7D60
	public Camera get_cachedCamera() { }

	// RVA: 0x1FC7E08 Offset: 0x1FC3E08 VA: 0x1FC7E08
	public static GameObject get_selectedObject() { }

	// RVA: 0x1FC7E60 Offset: 0x1FC3E60 VA: 0x1FC7E60
	public static void set_selectedObject(GameObject value) { }

	// RVA: 0x1FC8844 Offset: 0x1FC4844 VA: 0x1FC8844
	public static void SetSelectedObject(GameObject obj) { }

	// RVA: 0x1FC88A4 Offset: 0x1FC48A4 VA: 0x1FC88A4
	public static int get_touchCount() { }

	// RVA: 0x1FC8B54 Offset: 0x1FC4B54 VA: 0x1FC8B54
	public static int get_dragCount() { }

	// RVA: 0x1FC8E04 Offset: 0x1FC4E04 VA: 0x1FC8E04
	private void OnApplicationQuit() { }

	// RVA: 0x1FC8E9C Offset: 0x1FC4E9C VA: 0x1FC8E9C
	public static Camera get_mainCamera() { }

	// RVA: 0x1FC7BE8 Offset: 0x1FC3BE8 VA: 0x1FC7BE8
	public static UICamera get_eventHandler() { }

	// RVA: 0x1FC8F48 Offset: 0x1FC4F48 VA: 0x1FC8F48
	private static int CompareFunc(UICamera a, UICamera b) { }

	// RVA: 0x1FC8FF0 Offset: 0x1FC4FF0 VA: 0x1FC8FF0
	public static bool Raycast(Vector3 inPos, out RaycastHit hit) { }

	// RVA: 0x1FC9550 Offset: 0x1FC5550 VA: 0x1FC9550
	private static bool IsVisible(ref RaycastHit hit) { }

	// RVA: 0x1FC8210 Offset: 0x1FC4210 VA: 0x1FC8210
	public static UICamera FindCameraForLayer(int layer) { }

	// RVA: 0x1FC9658 Offset: 0x1FC5658 VA: 0x1FC9658
	private static int GetDirection(KeyCode up, KeyCode down) { }

	// RVA: 0x1FC9690 Offset: 0x1FC5690 VA: 0x1FC9690
	private static int GetDirection(KeyCode up0, KeyCode up1, KeyCode down0, KeyCode down1) { }

	// RVA: 0x1FC96FC Offset: 0x1FC56FC VA: 0x1FC96FC
	private static int GetDirection(string axis) { }

	// RVA: 0x1FC97F0 Offset: 0x1FC57F0 VA: 0x1FC97F0
	public static bool IsHighlighted(GameObject go) { }

	// RVA: 0x1FC84D8 Offset: 0x1FC44D8 VA: 0x1FC84D8
	private static void Highlight(GameObject go, bool highlighted) { }

	// RVA: 0x1FC835C Offset: 0x1FC435C VA: 0x1FC835C
	public static void Notify(GameObject go, string funcName, object obj) { }

	// RVA: 0x1FC9918 Offset: 0x1FC5918 VA: 0x1FC9918
	public static UICamera.MouseOrTouch GetTouch(int id) { }

	// RVA: 0x1FC9A48 Offset: 0x1FC5A48 VA: 0x1FC9A48
	public static void RemoveTouch(int id) { }

	// RVA: 0x1FC9AC8 Offset: 0x1FC5AC8 VA: 0x1FC9AC8
	private void Awake() { }

	// RVA: 0x1FC9CB4 Offset: 0x1FC5CB4 VA: 0x1FC9CB4
	private void OnEnable() { }

	// RVA: 0x1FC9E04 Offset: 0x1FC5E04 VA: 0x1FC9E04
	private void OnDisable() { }

	// RVA: 0x1FC9E84 Offset: 0x1FC5E84 VA: 0x1FC9E84
	private void FixedUpdate() { }

	// RVA: 0x1FCA08C Offset: 0x1FC608C VA: 0x1FCA08C
	private void Update() { }

	// RVA: 0x1FCA568 Offset: 0x1FC6568 VA: 0x1FCA568
	public void ProcessMouse() { }

	// RVA: 0x1FCADA8 Offset: 0x1FC6DA8 VA: 0x1FCADA8
	public void ProcessTouches() { }

	// RVA: 0x1FCB3DC Offset: 0x1FC73DC VA: 0x1FCB3DC
	public void ProcessOthers() { }

	// RVA: 0x1FCB92C Offset: 0x1FC792C VA: 0x1FCB92C
	public void ProcessTouch(bool pressed, bool unpressed) { }

	// RVA: 0x1FCB308 Offset: 0x1FC7308 VA: 0x1FCB308
	public void ShowTooltip(bool val) { }

	// RVA: 0x1FCC6E4 Offset: 0x1FC86E4 VA: 0x1FCC6E4
	public void .ctor() { }

	// RVA: 0x1FCC7C8 Offset: 0x1FC87C8 VA: 0x1FCC7C8
	private static void .cctor() { }
}
