// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWorldTreasureChargePanel : MonoBehaviour, IWorldTreasurePanel // TypeDefIndex: 8225
{
	// Fields
	[SerializeField]
	private GameObject panelObject; // 0x20
	[SerializeField]
	private UIImageButton orbButton; // 0x28
	[SerializeField]
	private UILabel orbButtonLabel; // 0x30
	[SerializeField]
	private UILabel orbChargeMessageLabel; // 0x38
	[SerializeField]
	private UIImageButton itemButton; // 0x40
	[SerializeField]
	private UILabel itemChargeMessageLabel; // 0x48
	[SerializeField]
	private UILabel chargeItemNumLabel; // 0x50
	private static readonly int orbChargeAmount; // 0x0
	private static readonly int itemChargeAmount; // 0x4
	private static readonly int orbChargeCost; // 0x8
	private static readonly int itemChargeCost; // 0xC
	private UIWorldTreasureManager manager; // 0x58
	private bool canButtonPress; // 0x60

	// Methods

	// RVA: 0x1CFC640 Offset: 0x1CF8640 VA: 0x1CFC640
	private void Start() { }

	// RVA: 0x1CFC644 Offset: 0x1CF8644 VA: 0x1CFC644
	private void Update() { }

	// RVA: 0x1CFC648 Offset: 0x1CF8648 VA: 0x1CFC648
	private bool IsLimited() { }

	// RVA: 0x1CFC718 Offset: 0x1CF8718 VA: 0x1CFC718
	private void OnClickOrbChargeButton() { }

	// RVA: 0x1CFC9C0 Offset: 0x1CF89C0 VA: 0x1CFC9C0
	private void OnClickItemChargeButton() { }

	// RVA: 0x1CFCA70 Offset: 0x1CF8A70 VA: 0x1CFCA70 Slot: 4
	public void Initialize(UIWorldTreasureManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x1CFCE94 Offset: 0x1CF8E94 VA: 0x1CFCE94 Slot: 5
	public void Close() { }

	// RVA: 0x1CFCEB4 Offset: 0x1CF8EB4 VA: 0x1CFCEB4 Slot: 6
	public bool PushLeftTopButton() { }

	[IteratorStateMachine(typeof(UIWorldTreasureChargePanel.<WaitButton>d__21))]
	// RVA: 0x1CFCE28 Offset: 0x1CF8E28 VA: 0x1CFCE28
	private IEnumerator WaitButton() { }

	// RVA: 0x1CFCF50 Offset: 0x1CF8F50 VA: 0x1CFCF50
	public void .ctor() { }

	// RVA: 0x1CFCF58 Offset: 0x1CF8F58 VA: 0x1CFCF58
	private static void .cctor() { }
}
