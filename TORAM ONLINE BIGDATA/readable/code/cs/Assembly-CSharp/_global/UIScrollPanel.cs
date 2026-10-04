// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIScrollPanel : MonoBehaviour // TypeDefIndex: 9028
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
	private Transform scrollGrid; // 0x50
	[SerializeField]
	private UISprite VerticalScrollBarDecoration; // 0x58

	// Properties
	public Camera ScrollCamera { get; }
	public UIIruna2Viewport ViewCamera { get; }

	// Methods

	// RVA: 0x1E98B80 Offset: 0x1E94B80 VA: 0x1E98B80
	public Camera get_ScrollCamera() { }

	// RVA: 0x1E98B88 Offset: 0x1E94B88 VA: 0x1E98B88
	public UIIruna2Viewport get_ViewCamera() { }

	// RVA: 0x1E98B90 Offset: 0x1E94B90 VA: 0x1E98B90
	private void Awake() { }

	// RVA: 0x1E98C60 Offset: 0x1E94C60 VA: 0x1E98C60
	public void AllClear() { }

	// RVA: 0x1E98C68 Offset: 0x1E94C68 VA: 0x1E98C68
	public void AllClear(bool isSavCameraePosition) { }

	// RVA: 0x1E98DA8 Offset: 0x1E94DA8 VA: 0x1E98DA8
	public void CameraClear() { }

	// RVA: 0x1E98C70 Offset: 0x1E94C70 VA: 0x1E98C70
	public void CameraClear(bool isSavePosition) { }

	// RVA: 0x1E98DB0 Offset: 0x1E94DB0 VA: 0x1E98DB0
	public void ScrollArea(Vector3 position, Vector2 size) { }

	// RVA: 0x1E98FE8 Offset: 0x1E94FE8 VA: 0x1E98FE8
	public void ScrollAreaEx(Vector3 position, Vector2 size) { }

	// RVA: 0x1E99198 Offset: 0x1E95198 VA: 0x1E99198
	public void ScrollSetting(bool enabled) { }

	// RVA: 0x1E991B8 Offset: 0x1E951B8 VA: 0x1E991B8
	public float ScreenPosition(Vector3 position) { }

	// RVA: 0x1E99240 Offset: 0x1E95240 VA: 0x1E99240
	public void SetActiveScrollBar(bool isActive) { }

	// RVA: 0x1E992D8 Offset: 0x1E952D8 VA: 0x1E992D8
	public void SetViewPosition(Vector2 topLeftPosition, Vector2 bottomRightPosition) { }

	// RVA: 0x1E993F0 Offset: 0x1E953F0 VA: 0x1E993F0
	internal void Add(Transform transform) { }

	// RVA: 0x1E99414 Offset: 0x1E95414 VA: 0x1E99414
	public void .ctor() { }
}
