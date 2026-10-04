// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpMessageYesNoWindow : PopBaseWindow // TypeDefIndex: 8799
{
	// Fields
	protected PopUpMessageYesNoWindow.MessageData[] messageList; // 0x20
	protected string titleText; // 0x28
	protected string buttonYesText; // 0x30
	protected string buttonNoText; // 0x38
	protected bool isMessageSizeControl; // 0x40
	protected int messageControlSize; // 0x44
	protected int messageAction; // 0x48

	// Methods

	// RVA: 0x1E0F3A8 Offset: 0x1E0B3A8 VA: 0x1E0F3A8
	public void .ctor() { }

	// RVA: 0x1E0F4E4 Offset: 0x1E0B4E4 VA: 0x1E0F4E4
	public void .ctor(string title, string message) { }

	// RVA: 0x1E0F6F4 Offset: 0x1E0B6F4 VA: 0x1E0F6F4
	public void .ctor(string title, string message, float size) { }

	// RVA: 0x1E0F81C Offset: 0x1E0B81C VA: 0x1E0F81C
	public void .ctor(string title, string yesText, string noText, PopUpMessageYesNoWindow.MessageData[] messageList) { }

	// RVA: 0x1E0F940 Offset: 0x1E0B940 VA: 0x1E0F940
	public void .ctor(string title, string yesText, string noText, int messageControlSize, PopUpMessageYesNoWindow.MessageData[] messageList) { }

	// RVA: 0x1E0FA7C Offset: 0x1E0BA7C VA: 0x1E0FA7C
	public void .ctor(string title, PopUpMessageYesNoWindow.MessageData[] messageList) { }

	// RVA: 0x1E0FAC4 Offset: 0x1E0BAC4 VA: 0x1E0FAC4 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E0FE9C Offset: 0x1E0BE9C VA: 0x1E0FE9C Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E0FEB0 Offset: 0x1E0BEB0 VA: 0x1E0FEB0 Slot: 7
	public override int MessageCheck() { }
}
