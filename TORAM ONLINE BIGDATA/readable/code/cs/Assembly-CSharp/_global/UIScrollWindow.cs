// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScrollWindow : MonoBehaviour // TypeDefIndex: 9029
{
	// Fields
	[SerializeField]
	private Camera dragCameraObject; // 0x20
	private UIDraggableCamera dragCamera; // 0x28
	private UICamera uiCamera; // 0x30
	private UIIruna2Viewport viewCamera; // 0x38
	[SerializeField]
	private UISprite topBar; // 0x40
	[SerializeField]
	private UISprite bottomBar; // 0x48
	[SerializeField]
	private Transform scrollGriad; // 0x50
	[SerializeField]
	private UILabel messageText; // 0x58
	private List<GameObject> dragButtonList; // 0x60

	// Properties
	public Camera ScrollCamera { get; }
	public UIIruna2Viewport ViewCamera { get; }
	public Transform ScrollGrid { get; }
	public int ButtonCount { get; }
	public List<GameObject> DragButtonList { get; }

	// Methods

	// RVA: 0x1E9941C Offset: 0x1E9541C VA: 0x1E9941C
	public Camera get_ScrollCamera() { }

	// RVA: 0x1E99424 Offset: 0x1E95424 VA: 0x1E99424
	public UIIruna2Viewport get_ViewCamera() { }

	// RVA: 0x1E9942C Offset: 0x1E9542C VA: 0x1E9942C
	public Transform get_ScrollGrid() { }

	// RVA: 0x1E99434 Offset: 0x1E95434 VA: 0x1E99434
	public int get_ButtonCount() { }

	// RVA: 0x1E9947C Offset: 0x1E9547C VA: 0x1E9947C
	public List<GameObject> get_DragButtonList() { }

	// RVA: 0x1E99484 Offset: 0x1E95484 VA: 0x1E99484
	private void Awake() { }

	// RVA: 0x1E99554 Offset: 0x1E95554 VA: 0x1E99554
	public void AllClear() { }

	// RVA: 0x1E9955C Offset: 0x1E9555C VA: 0x1E9955C
	public void AllClear(bool isSavCameraePosition) { }

	// RVA: 0x1E99974 Offset: 0x1E95974 VA: 0x1E99974
	public void CameraClear() { }

	// RVA: 0x1E99748 Offset: 0x1E95748 VA: 0x1E99748
	public void CameraClear(bool isSavePosition) { }

	// RVA: 0x1E9997C Offset: 0x1E9597C VA: 0x1E9997C
	public void AddButton(GameObject button) { }

	// RVA: 0x1E99CB4 Offset: 0x1E95CB4 VA: 0x1E99CB4
	public void AddButton(GameObject button, bool screenCheck) { }

	// RVA: 0x1E99CC4 Offset: 0x1E95CC4 VA: 0x1E99CC4
	public void AddButton(GameObject button, bool screenCheck, bool fadeIn) { }

	// RVA: 0x1E9998C Offset: 0x1E9598C VA: 0x1E9998C
	public void AddButton(GameObject button, bool screenCheck, bool fadeIn, bool isNoDrag) { }

	// RVA: 0x1E99CD4 Offset: 0x1E95CD4 VA: 0x1E99CD4
	public void SetButton(GameObject button) { }

	// RVA: 0x1E99CE0 Offset: 0x1E95CE0 VA: 0x1E99CE0
	public void SetButton(GameObject button, bool screenCheck, bool isNoDrag) { }

	// RVA: 0x1E99FA0 Offset: 0x1E95FA0 VA: 0x1E99FA0
	public void ScrollArea(Vector3 position, Vector2 size) { }

	// RVA: 0x1E9A1D8 Offset: 0x1E961D8 VA: 0x1E9A1D8
	public void ScrollAreaEx(Vector3 position, Vector2 size) { }

	// RVA: 0x1E9A388 Offset: 0x1E96388 VA: 0x1E9A388
	public void ScrollSetting(bool enabled) { }

	// RVA: 0x1E99880 Offset: 0x1E95880 VA: 0x1E99880
	public void MessageText(string text) { }

	// RVA: 0x1E9A3A8 Offset: 0x1E963A8 VA: 0x1E9A3A8
	public float ScreenPosition(Vector3 position) { }

	// RVA: 0x1E9A430 Offset: 0x1E96430 VA: 0x1E9A430
	public void SetActiveScrollBar(bool isActive) { }

	// RVA: 0x1E9A4C8 Offset: 0x1E964C8 VA: 0x1E9A4C8
	public void .ctor() { }
}
