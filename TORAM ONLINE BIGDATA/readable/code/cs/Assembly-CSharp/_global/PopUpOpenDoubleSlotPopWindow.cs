// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpOpenDoubleSlotPopWindow : PopBaseWindow // TypeDefIndex: 8801
{
	// Fields
	private int messageAction; // 0x20
	private string titleText; // 0x28
	private string slotText; // 0x30
	private string equipNameText; // 0x38
	private string itemNameText; // 0x40
	private int orbItemId1; // 0x48
	private int orbItemId2; // 0x4C
	private bool itemFlag; // 0x50
	private UILabel itemLabel; // 0x58
	private bool isCanRequest; // 0x60
	private GameObject selectButtonObj; // 0x68
	private UIImageButton imageButton; // 0x70
	private UILabel buttonLabel; // 0x78
	private ItemTextManager itemTextManager; // 0x80
	private bool isBan; // 0x88

	// Methods

	// RVA: 0x1E0FEB8 Offset: 0x1E0BEB8 VA: 0x1E0FEB8
	public void .ctor(string title, string slot, string equipName, int orbItemId1, int orbItemId2, bool isCanRequest, bool isBan, GameObject selectButtonObj) { }

	// RVA: 0x1E10020 Offset: 0x1E0C020 VA: 0x1E10020 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E106B8 Offset: 0x1E0C6B8 VA: 0x1E106B8 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E10A08 Offset: 0x1E0CA08 VA: 0x1E10A08 Slot: 7
	public override int MessageCheck() { }
}
