// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIFishingPanelAnchorController : MonoBehaviour // TypeDefIndex: 7052
{
	// Fields
	[SerializeField]
	private UIFishingPanelManager panelManager; // 0x20
	[SerializeField]
	private float anchorMove; // 0x28
	[SerializeField]
	private UIIruna2Anchor rightAnchor; // 0x30
	[SerializeField]
	private UIIruna2Anchor leftAnchor; // 0x38
	[SerializeField]
	private UIIruna2Anchor rightArrowAnchor; // 0x40
	[SerializeField]
	private UIIruna2Anchor leftArrowAnchor; // 0x48
	[SerializeField]
	private UISprite rightArrowsButton; // 0x50
	[SerializeField]
	private UISprite leftArrowsButton; // 0x58
	private bool isMoveAnchor; // 0x60
	private bool isRightSideDisplay; // 0x61
	private bool isLeftSideDisplay; // 0x62

	// Properties
	public bool IsMoveAnchor { get; }
	public bool IsRightSideDisplay { get; }
	public bool IsLeftSideDisplay { get; }

	// Methods

	// RVA: 0x1A82B98 Offset: 0x1A7EB98 VA: 0x1A82B98
	public bool get_IsMoveAnchor() { }

	// RVA: 0x1A82BA0 Offset: 0x1A7EBA0 VA: 0x1A82BA0
	public bool get_IsRightSideDisplay() { }

	// RVA: 0x1A82BA8 Offset: 0x1A7EBA8 VA: 0x1A82BA8
	public bool get_IsLeftSideDisplay() { }

	// RVA: 0x1A82BB0 Offset: 0x1A7EBB0 VA: 0x1A82BB0
	private void Start() { }

	// RVA: 0x1A82BBC Offset: 0x1A7EBBC VA: 0x1A82BBC
	public void MoveAllAnchor(bool isMainPanel) { }

	// RVA: 0x1A82D90 Offset: 0x1A7ED90 VA: 0x1A82D90
	public void MoveRightAnchor() { }

	// RVA: 0x1A82F0C Offset: 0x1A7EF0C VA: 0x1A82F0C
	public void MoveLeftAnchor() { }

	// RVA: 0x1A8308C Offset: 0x1A7F08C VA: 0x1A8308C
	public void .ctor() { }
}
