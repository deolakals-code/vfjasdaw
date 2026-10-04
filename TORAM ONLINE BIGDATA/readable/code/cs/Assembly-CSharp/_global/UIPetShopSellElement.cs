// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPetShopSellElement : MonoBehaviour // TypeDefIndex: 7728
{
	// Fields
	[SerializeField]
	private GameObject emptyPanel; // 0x20
	[SerializeField]
	private UILabel emptyButtonLabel; // 0x28
	[SerializeField]
	private GameObject infoPanel; // 0x30
	[SerializeField]
	private UISprite icon; // 0x38
	[SerializeField]
	private UILabel lvLabel; // 0x40
	[SerializeField]
	private UILabel nameLabel; // 0x48
	[SerializeField]
	private UILabel goldLabel; // 0x50
	[SerializeField]
	private UILabel buttonLabel; // 0x58
	[SerializeField]
	private GameObject targetObj; // 0x60
	[SerializeField]
	private UILabel targetLabel; // 0x68
	private int no; // 0x70
	private Action<int> registAction; // 0x78
	private Action infoAction; // 0x80
	private Action addSlotAction; // 0x88
	private PetModelLoader petModelLoader; // 0x90
	private PetModelData modelData; // 0x98

	// Methods

	// RVA: 0x1BF3FE8 Offset: 0x1BEFFE8 VA: 0x1BF3FE8
	public void SetButton(int no, Action<int> registAction) { }

	// RVA: 0x1BF4110 Offset: 0x1BF0110 VA: 0x1BF4110
	public void SetButton(Action addSlotAction) { }

	// RVA: 0x1BF4230 Offset: 0x1BF0230 VA: 0x1BF4230
	public void SetButton(int no, byte weaponType, string lv, string name, int price, PetModelData modelData, byte exhabitType, int password, Action infoAction) { }

	// RVA: 0x1BF45C0 Offset: 0x1BF05C0 VA: 0x1BF45C0
	public void OnEmpty() { }

	// RVA: 0x1BF4600 Offset: 0x1BF0600 VA: 0x1BF4600
	public void OnInfo() { }

	[IteratorStateMachine(typeof(UIPetShopSellElement.<LoadModel>d__21))]
	// RVA: 0x1BF4554 Offset: 0x1BF0554 VA: 0x1BF4554
	private IEnumerator LoadModel() { }

	// RVA: 0x1BF447C Offset: 0x1BF047C VA: 0x1BF447C
	private string GetExhabitText(SystemTextManager systemTextManager, byte type) { }

	// RVA: 0x1BF4644 Offset: 0x1BF0644 VA: 0x1BF4644
	public void .ctor() { }
}
