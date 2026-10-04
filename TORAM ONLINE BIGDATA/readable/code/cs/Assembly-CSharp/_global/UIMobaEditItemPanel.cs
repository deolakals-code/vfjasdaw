// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIMobaEditItemPanel : MonoBehaviour, UIMobaEditBasePanel // TypeDefIndex: 6059
{
	// Fields
	[SerializeField]
	private UIImageButton buyButton; // 0x20
	[SerializeField]
	private UILabel buyButtonLabel; // 0x28
	[SerializeField]
	private GameObject shortcutItemIcon; // 0x30
	[SerializeField]
	private UISprite itemIcon; // 0x38
	[SerializeField]
	private UILabel itemNameLabel; // 0x40
	[SerializeField]
	private UILabel itemMesLabel; // 0x48
	[SerializeField]
	private GameObject selectButtonObj; // 0x50
	[SerializeField]
	private UILabel buyCountLabel; // 0x58
	private MobaRoomData mobaRoomData; // 0x60
	private int selectItemParam; // 0x68
	private List<GameObject> shortcutItemIconList; // 0x70
	private int[] shopItemIds; // 0x78
	private SystemTextManager systemTextManager; // 0x80
	private UIMobaMainGamePanel mainPanel; // 0x88

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x1877788 Offset: 0x1873788 VA: 0x1877788 Slot: 9
	public bool get_IsActive() { }

	// RVA: 0x18777A8 Offset: 0x18737A8 VA: 0x18777A8 Slot: 4
	public void Initialize(MobaRoomData mobaRoomData, UIMobaMainGamePanel mainPanel) { }

	[IteratorStateMachine(typeof(UIMobaEditItemPanel.<FadeIn>d__17))]
	// RVA: 0x18778D0 Offset: 0x18738D0 VA: 0x18778D0 Slot: 7
	public IEnumerator FadeIn() { }

	[IteratorStateMachine(typeof(UIMobaEditItemPanel.<FadeOut>d__18))]
	// RVA: 0x1877964 Offset: 0x1873964 VA: 0x1877964 Slot: 8
	public IEnumerator FadeOut() { }

	[IteratorStateMachine(typeof(UIMobaEditItemPanel.<PushLeftTopButton>d__19))]
	// RVA: 0x18779F8 Offset: 0x18739F8 VA: 0x18779F8 Slot: 5
	public IEnumerator PushLeftTopButton(Action<bool> stayCheck) { }

	[IteratorStateMachine(typeof(UIMobaEditItemPanel.<PushRightTopButton>d__20))]
	// RVA: 0x1877AA8 Offset: 0x1873AA8 VA: 0x1877AA8 Slot: 6
	public IEnumerator PushRightTopButton(Action<bool> stayCheck) { }

	// RVA: 0x1877B58 Offset: 0x1873B58 VA: 0x1877B58
	public void OnBuy() { }

	// RVA: 0x1877C38 Offset: 0x1873C38 VA: 0x1877C38
	public void OnSelectItemIcon(int param) { }

	// RVA: 0x1877E08 Offset: 0x1873E08 VA: 0x1877E08
	public void OnSelect(int param) { }

	[IteratorStateMachine(typeof(UIMobaEditItemPanel.<Buy>d__24))]
	// RVA: 0x1877BCC Offset: 0x1873BCC VA: 0x1877BCC
	private IEnumerator Buy() { }

	// RVA: 0x1877F34 Offset: 0x1873F34 VA: 0x1877F34
	private void UpdateBuyButton() { }

	// RVA: 0x1877CE4 Offset: 0x1873CE4 VA: 0x1877CE4
	private void UpdateItemLabel(int itemId) { }

	// RVA: 0x18780A8 Offset: 0x18740A8 VA: 0x18780A8
	private string GetItemIconName(int itemId) { }

	// RVA: 0x1878144 Offset: 0x1874144 VA: 0x1878144
	public void .ctor() { }
}
