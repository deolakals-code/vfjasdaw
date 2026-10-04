// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITargetListManager : UIBasePanel // TypeDefIndex: 6580
{
	// Fields
	private float checkDist; // 0x2C
	private Vector2 moveVector; // 0x30
	protected UITargetListManager.TargetSortType targetSortType; // 0x38
	[SerializeField]
	protected UITargetListButton targetButton; // 0x40
	[SerializeField]
	protected UITargetListButton targetPlayerButton; // 0x48
	[SerializeField]
	private UIIruna2Anchor listAnchor; // 0x50
	[SerializeField]
	private UISprite rightArrow; // 0x58
	[SerializeField]
	private UISprite leftArrow; // 0x60
	[SerializeField]
	protected UILabel sortLabel; // 0x68
	private float arrowTimer; // 0x70
	protected UIScrollWindow scrollWindow; // 0x78
	[SerializeField]
	private GameObject actionButton; // 0x80
	private UIIcon actionButtonIcon; // 0x88
	protected UITargetListButton selectButton; // 0x90

	// Methods

	// RVA: 0x198EB90 Offset: 0x198AB90 VA: 0x198EB90
	private void Start() { }

	// RVA: 0x198ED24 Offset: 0x198AD24 VA: 0x198ED24 Slot: 7
	protected virtual void Update() { }

	// RVA: 0x198F03C Offset: 0x198B03C VA: 0x198F03C Slot: 8
	public virtual void ListCreate() { }

	// RVA: 0x198F8D0 Offset: 0x198B8D0 VA: 0x198F8D0 Slot: 9
	public virtual void SetScrollArea() { }

	// RVA: 0x198F8D4 Offset: 0x198B8D4 VA: 0x198F8D4
	private void ListClose() { }

	// RVA: 0x198FA74 Offset: 0x198BA74 VA: 0x198FA74 Slot: 10
	public virtual void OnFlick(Vector2 flick) { }

	// RVA: 0x198FB08 Offset: 0x198BB08 VA: 0x198FB08
	private void ChangeTargetSortType() { }

	// RVA: 0x198FD18 Offset: 0x198BD18 VA: 0x198FD18 Slot: 11
	public virtual void OnTargetClick(UITargetListButton select) { }

	// RVA: 0x198FDCC Offset: 0x198BDCC VA: 0x198FDCC
	public void OnTargetAction() { }

	// RVA: 0x198FE80 Offset: 0x198BE80 VA: 0x198FE80
	private void OnPress(bool pressed) { }

	// RVA: 0x198FF84 Offset: 0x198BF84 VA: 0x198FF84
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x1990004 Offset: 0x198C004 VA: 0x1990004 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1990070 Offset: 0x198C070 VA: 0x1990070 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x19900DC Offset: 0x198C0DC VA: 0x19900DC Slot: 12
	public virtual void DeleteTargetButton(GameObject obj) { }

	// RVA: 0x19900E0 Offset: 0x198C0E0 VA: 0x19900E0 Slot: 13
	public virtual GameObject GetSubPanelRoot() { }

	// RVA: 0x19900E8 Offset: 0x198C0E8 VA: 0x19900E8 Slot: 14
	public virtual void SelectWheel(float delta) { }

	// RVA: 0x19900EC Offset: 0x198C0EC VA: 0x19900EC Slot: 15
	public virtual void SetSelectButton(GameObject obj) { }

	// RVA: 0x19900F0 Offset: 0x198C0F0 VA: 0x19900F0
	public void .ctor() { }
}
