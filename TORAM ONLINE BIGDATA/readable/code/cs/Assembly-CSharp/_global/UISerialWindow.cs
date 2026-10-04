// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISerialWindow : UIBasePanelControl // TypeDefIndex: 7670
{
	// Fields
	[SerializeField]
	private GameObject inputWindow; // 0x58
	[SerializeField]
	private GameObject rewardWindow; // 0x60
	[SerializeField]
	private GameObject rewardLabelOrigin; // 0x68
	[SerializeField]
	private Transform rewardLabelParent; // 0x70
	[SerializeField]
	private UIImageButton rewardWindowButton; // 0x78
	[SerializeField]
	private UILabel rewardWindowButtonLabel; // 0x80
	[SerializeField]
	private UILabel inputLabel; // 0x88
	[SerializeField]
	private UILabel resultLabel; // 0x90
	[SerializeField]
	private UISprite resultIcon; // 0x98
	[SerializeField]
	private UIImageButton button; // 0xA0
	private UIInput uiInput; // 0xA8
	private string successSerialCode; // 0xB0
	private int resultOkClick; // 0xB8
	private ItemTextManager itemTextManager; // 0xC0

	// Methods

	// RVA: 0x1BDD1E8 Offset: 0x1BD91E8 VA: 0x1BDD1E8
	private void Awake() { }

	// RVA: 0x1BDD494 Offset: 0x1BD9494 VA: 0x1BDD494
	private void close() { }

	// RVA: 0x1BDD4E8 Offset: 0x1BD94E8 VA: 0x1BDD4E8
	public void OnSubmit() { }

	// RVA: 0x1BDDC00 Offset: 0x1BD9C00 VA: 0x1BDDC00
	private void sendCode() { }

	[IteratorStateMachine(typeof(UISerialWindow.<showRewardWindow>d__18))]
	// RVA: 0x1BDDCA8 Offset: 0x1BD9CA8 VA: 0x1BDDCA8
	private IEnumerator showRewardWindow(List<UIOrbShopManager.BuyOrbItemPopData> buyOrbItemData) { }

	// RVA: 0x1BDDD58 Offset: 0x1BD9D58 VA: 0x1BDDD58
	private void OnPopWindowOK() { }

	[IteratorStateMachine(typeof(UISerialWindow.<connect>d__20))]
	// RVA: 0x1BDDC3C Offset: 0x1BD9C3C VA: 0x1BDDC3C
	private IEnumerator connect() { }

	// RVA: 0x1BDD760 Offset: 0x1BD9760 VA: 0x1BDD760
	private string convertSerial(string input) { }

	// RVA: 0x1BDDD8C Offset: 0x1BD9D8C VA: 0x1BDDD8C
	public void .ctor() { }
}
