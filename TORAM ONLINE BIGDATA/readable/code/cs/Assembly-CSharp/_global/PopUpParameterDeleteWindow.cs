// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpParameterDeleteWindow : PopBaseWindow // TypeDefIndex: 8804
{
	// Fields
	private string titleText; // 0x20
	private string messageText; // 0x28
	private Transform parametaer; // 0x30
	private int messageAction; // 0x38
	private GameObject okButton; // 0x40
	private GameObject messageLabel; // 0x48

	// Methods

	// RVA: 0x1E10C0C Offset: 0x1E0CC0C VA: 0x1E10C0C
	public void .ctor(string title, string mesaage, Transform parametaer) { }

	// RVA: 0x1E10CC8 Offset: 0x1E0CCC8 VA: 0x1E10CC8 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E10F80 Offset: 0x1E0CF80 VA: 0x1E10F80 Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E10FE0 Offset: 0x1E0CFE0 VA: 0x1E10FE0 Slot: 7
	public override int MessageCheck() { }
}
