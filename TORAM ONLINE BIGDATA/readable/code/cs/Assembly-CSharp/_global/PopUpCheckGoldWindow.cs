// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpCheckGoldWindow : PopBaseWindow // TypeDefIndex: 8780
{
	// Fields
	private int messageAction; // 0x20
	private string titleText; // 0x28
	private string mainText; // 0x30
	private int settingGold; // 0x38
	private GameObject goldObj; // 0x40
	private UIImageButton imageButton; // 0x48

	// Methods

	// RVA: 0x1E0A6B0 Offset: 0x1E066B0 VA: 0x1E0A6B0
	public void .ctor(string titleText, string mainText, int settingGold, GameObject goldObj) { }

	// RVA: 0x1E0A784 Offset: 0x1E06784 VA: 0x1E0A784 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E0AAEC Offset: 0x1E06AEC VA: 0x1E0AAEC Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E0AB00 Offset: 0x1E06B00 VA: 0x1E0AB00 Slot: 7
	public override int MessageCheck() { }
}
