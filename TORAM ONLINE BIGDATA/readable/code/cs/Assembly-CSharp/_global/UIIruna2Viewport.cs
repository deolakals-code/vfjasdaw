// Assembly: Assembly-CSharp.dll
// Namespace: 
[AddComponentMenu("NGUI/Iruna2/Iruna2 Viewport")]
public class UIIruna2Viewport : MonoBehaviour // TypeDefIndex: 119
{
	// Fields
	public Camera sourceCamera; // 0x20
	public Transform topLeft; // 0x28
	public Transform bottomRight; // 0x30
	public float fullSize; // 0x38
	private bool initCheck; // 0x3C
	private bool anchorCheck; // 0x3D
	private float colorA; // 0x40
	private Camera mCam; // 0x48
	[SerializeField]
	private UIScrollBar horizontalScrollBar; // 0x50
	[SerializeField]
	private UISprite horizontalOverRunSprite; // 0x58
	[SerializeField]
	private UIScrollBar verticalScrollBar; // 0x60
	[SerializeField]
	private UISprite verticalOverRunSprite; // 0x68
	private Vector3 scrollPoint; // 0x70
	private Vector2 scrollSize; // 0x7C
	private Vector2 screenSize; // 0x84
	[CompilerGenerated]
	private Vector2 <OriginalScrollSize>k__BackingField; // 0x8C

	// Properties
	public Vector2 ScreenSize { get; }
	public Vector2 ScrollSize { get; }
	public int VerticalOverRunSpriteHeight { get; }
	public Vector2 OriginalScrollSize { get; set; }

	// Methods

	// RVA: 0x1EDBF24 Offset: 0x1ED7F24 VA: 0x1EDBF24
	public Vector2 get_ScreenSize() { }

	// RVA: 0x1EDC0C8 Offset: 0x1ED80C8 VA: 0x1EDC0C8
	private void Start() { }

	// RVA: 0x1EDC1A8 Offset: 0x1ED81A8 VA: 0x1EDC1A8
	private void LateUpdate() { }

	// RVA: 0x1EDC1AC Offset: 0x1ED81AC VA: 0x1EDC1AC
	public void ViewAreaUpdate() { }

	// RVA: 0x1EDC8FC Offset: 0x1ED88FC VA: 0x1EDC8FC
	public void SetViewPosition(Vector2 topLeftPos, Vector2 bottomRightPos) { }

	// RVA: 0x1EDCB74 Offset: 0x1ED8B74 VA: 0x1EDCB74
	public void Initialize() { }

	// RVA: 0x1EDCC84 Offset: 0x1ED8C84 VA: 0x1EDCC84
	public Vector2 get_ScrollSize() { }

	// RVA: 0x1EDCC8C Offset: 0x1ED8C8C VA: 0x1EDCC8C
	public int get_VerticalOverRunSpriteHeight() { }

	[CompilerGenerated]
	// RVA: 0x1EDCCA8 Offset: 0x1ED8CA8 VA: 0x1EDCCA8
	public Vector2 get_OriginalScrollSize() { }

	[CompilerGenerated]
	// RVA: 0x1EDCCB0 Offset: 0x1ED8CB0 VA: 0x1EDCCB0
	private void set_OriginalScrollSize(Vector2 value) { }

	// RVA: 0x1EDCCB8 Offset: 0x1ED8CB8 VA: 0x1EDCCB8
	public void SetActiveScrollBar(bool isActive) { }

	// RVA: 0x1EDCDA4 Offset: 0x1ED8DA4 VA: 0x1EDCDA4
	public void ScrollArea(Vector3 scrollPoint, Vector2 scrollSize) { }

	// RVA: 0x1EDC3C0 Offset: 0x1ED83C0 VA: 0x1EDC3C0
	private void Scroll() { }

	// RVA: 0x1EDCF3C Offset: 0x1ED8F3C VA: 0x1EDCF3C
	public void .ctor() { }
}
