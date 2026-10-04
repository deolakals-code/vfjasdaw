// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpLoadingWaitWindow : PopBaseWindow // TypeDefIndex: 8790
{
	// Fields
	private string titleText; // 0x20
	private string messageText; // 0x28
	private int messageAction; // 0x30
	private float timer; // 0x34
	private float waitTime; // 0x38
	private UISlider timerSlider; // 0x40
	private GameObject cancelButton; // 0x48
	private bool buttonEnable; // 0x50

	// Methods

	// RVA: 0x1E0D2A8 Offset: 0x1E092A8 VA: 0x1E0D2A8
	public void .ctor(string title, string mesaage, float waitTime) { }

	// RVA: 0x1E0D364 Offset: 0x1E09364 VA: 0x1E0D364
	public void .ctor(string title, string mesaage, float waitTime, bool buttonEnable) { }

	// RVA: 0x1E0D434 Offset: 0x1E09434 VA: 0x1E0D434 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E0D718 Offset: 0x1E09718 VA: 0x1E0D718 Slot: 5
	public override void Update() { }

	// RVA: 0x1E0D7B0 Offset: 0x1E097B0 VA: 0x1E0D7B0 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E0D7C4 Offset: 0x1E097C4 VA: 0x1E0D7C4 Slot: 7
	public override int MessageCheck() { }

	// RVA: 0x1E0D7CC Offset: 0x1E097CC VA: 0x1E0D7CC Slot: 8
	public override void Close() { }
}
