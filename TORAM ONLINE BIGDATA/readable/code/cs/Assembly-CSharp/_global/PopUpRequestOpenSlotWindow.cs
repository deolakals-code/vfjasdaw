// Assembly: Assembly-CSharp.dll
// Namespace: 
internal class PopUpRequestOpenSlotWindow : PopBaseWindow // TypeDefIndex: 8810
{
	// Fields
	private int messageAction; // 0x20
	private string needItemName; // 0x28
	private int haveGold; // 0x30
	private string inputGold; // 0x38
	private int gold; // 0x40
	private Regex numRegex; // 0x48
	private GameObject inputGoldObj; // 0x50
	private UILabel goldLabel; // 0x58
	private UIIruna2Input uiInput; // 0x60
	private GameObject attentionObj; // 0x68
	private UIImageButton imageButton; // 0x70
	private bool isCanUseSignboard; // 0x78
	private bool isThereBagSpace; // 0x79
	private string titleText; // 0x80
	private const int maxGold = 2100000000;

	// Methods

	// RVA: 0x1E12374 Offset: 0x1E0E374 VA: 0x1E12374
	public void .ctor(string title, string itemName, int gold, GameObject inputObj, GameObject attention, bool isThereBagSpace) { }

	// RVA: 0x1E124E4 Offset: 0x1E0E4E4 VA: 0x1E124E4 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E12C34 Offset: 0x1E0EC34 VA: 0x1E12C34 Slot: 5
	public override void Update() { }

	// RVA: 0x1E12E5C Offset: 0x1E0EE5C VA: 0x1E12E5C
	private bool IsNumber(string text) { }

	// RVA: 0x1E12EEC Offset: 0x1E0EEEC VA: 0x1E12EEC Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E12F00 Offset: 0x1E0EF00 VA: 0x1E12F00 Slot: 7
	public override int MessageCheck() { }
}
