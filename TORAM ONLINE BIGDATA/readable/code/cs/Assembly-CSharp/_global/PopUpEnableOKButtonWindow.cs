// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpEnableOKButtonWindow : PopBaseWindow // TypeDefIndex: 8786
{
	// Fields
	private Func<bool> enableCheck; // 0x20
	private string titleText; // 0x28
	private string messageText; // 0x30
	private string enableOKButtonText; // 0x38
	private string disableOKButtonText; // 0x40
	private UIImageButton imageOKButton; // 0x48
	private UILabel okButtonLabel; // 0x50
	protected int messageAction; // 0x58

	// Methods

	// RVA: 0x1E0BDC0 Offset: 0x1E07DC0 VA: 0x1E0BDC0
	public void .ctor(string title, string message, Func<bool> enableCheck, string enableOKButtonText, string disableOKButtonText) { }

	// RVA: 0x1E0BF34 Offset: 0x1E07F34 VA: 0x1E0BF34
	public void .ctor(Func<bool> enableCheck, string enableOKButtonText, string disableOKButtonText) { }

	// RVA: 0x1E0C034 Offset: 0x1E08034 VA: 0x1E0C034 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E0C2B8 Offset: 0x1E082B8 VA: 0x1E0C2B8 Slot: 5
	public override void Update() { }

	// RVA: 0x1E0C33C Offset: 0x1E0833C VA: 0x1E0C33C Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E0C350 Offset: 0x1E08350 VA: 0x1E0C350 Slot: 7
	public override int MessageCheck() { }
}
