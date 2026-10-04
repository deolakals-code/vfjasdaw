// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMapMainPanelManager : UIBasePanel // TypeDefIndex: 7379
{
	// Fields
	private GameObject frameObject; // 0x30
	private Animation frameAnimation; // 0x38
	private GameObject frameBackObject; // 0x40
	private GameObject mapObj; // 0x48
	[SerializeField]
	private UIIruna2DragPinch dragPinch; // 0x50
	[SerializeField]
	private UILabel changeLabel; // 0x58
	[SerializeField]
	private UILabel smallChangeLabel; // 0x60
	[SerializeField]
	private UIIruna2Anchor changeButton; // 0x68
	[SerializeField]
	private UIMapBasePanel[] basePanel; // 0x70
	private int selectedPanel; // 0x78
	private bool initFlag; // 0x7C
	private bool errFieldMap; // 0x7D
	private Vector3 changeButtonPosition; // 0x80
	private GmEventData[] roomGmMobEventData; // 0x90
	private bool isRoomGmMobEventData; // 0x98

	// Properties
	public UIMapMainPanelManager.MapType ActivedType { get; }

	// Methods

	// RVA: 0x1B30594 Offset: 0x1B2C594 VA: 0x1B30594
	public UIMapMainPanelManager.MapType get_ActivedType() { }

	[IteratorStateMachine(typeof(UIMapMainPanelManager.<Start>d__18))]
	// RVA: 0x1B3059C Offset: 0x1B2C59C VA: 0x1B3059C
	private IEnumerator Start() { }

	// RVA: 0x1B30630 Offset: 0x1B2C630 VA: 0x1B30630
	private void OnDestroy() { }

	// RVA: 0x1B30708 Offset: 0x1B2C708 VA: 0x1B30708
	private void Update() { }

	// RVA: 0x1B3076C Offset: 0x1B2C76C VA: 0x1B3076C
	private void ChangeMapView() { }

	// RVA: 0x1B308C0 Offset: 0x1B2C8C0 VA: 0x1B308C0
	private void UpdateMapView(int id, string label, string slabel, string layer) { }

	// RVA: 0x1B309FC Offset: 0x1B2C9FC VA: 0x1B309FC
	public void ActiveChangeButton(bool isActive) { }

	// RVA: 0x1B30A3C Offset: 0x1B2CA3C VA: 0x1B30A3C
	public void ChangeFrameAnimation() { }

	// RVA: 0x1B30AD8 Offset: 0x1B2CAD8 VA: 0x1B30AD8
	public void ReceiveRoomGMMobData(GmEventData[] data) { }

	// RVA: 0x1B30AFC Offset: 0x1B2CAFC VA: 0x1B30AFC Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1B30BD0 Offset: 0x1B2CBD0 VA: 0x1B30BD0 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1B30C5C Offset: 0x1B2CC5C VA: 0x1B30C5C
	public void OnPress(bool pressed) { }

	// RVA: 0x1B30CA0 Offset: 0x1B2CCA0 VA: 0x1B30CA0
	public void OnClick() { }

	// RVA: 0x1B30CE0 Offset: 0x1B2CCE0 VA: 0x1B30CE0
	public void OnDrag(Vector2 delta) { }

	// RVA: 0x1B30D20 Offset: 0x1B2CD20 VA: 0x1B30D20
	public void OnScroll(float delta) { }

	// RVA: 0x1B30D24 Offset: 0x1B2CD24 VA: 0x1B30D24
	public void .ctor() { }
}
