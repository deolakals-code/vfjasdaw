// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpMessageWindow : PopBaseWindow // TypeDefIndex: 8796
{
	// Fields
	protected PopUpMessageWindow.MessageData[] messageList; // 0x20
	protected string titleText; // 0x28
	protected string buttonText; // 0x30
	protected bool buttonActive; // 0x38
	protected bool buttonEneable; // 0x39
	protected bool buttonColorChange; // 0x3A
	protected Color setButtonColor; // 0x3C
	protected GameObject okButton; // 0x50
	protected GameObject titleIcon; // 0x58
	private string titleIconName; // 0x60
	private bool isTitleIcon; // 0x68
	protected int messageAction; // 0x6C

	// Methods

	// RVA: 0x1E091D4 Offset: 0x1E051D4 VA: 0x1E091D4
	public void .ctor() { }

	// RVA: 0x1E0EB88 Offset: 0x1E0AB88 VA: 0x1E0EB88
	public void .ctor(string title, string message) { }

	// RVA: 0x1E0ECC8 Offset: 0x1E0ACC8 VA: 0x1E0ECC8
	public void .ctor(string title, string message, float size) { }

	// RVA: 0x1E0EE14 Offset: 0x1E0AE14 VA: 0x1E0EE14
	public void .ctor(string title, string buttonMessage, PopUpMessageWindow.MessageData[] messageList) { }

	// RVA: 0x1E0EF68 Offset: 0x1E0AF68 VA: 0x1E0EF68
	public void .ctor(string title, string buttonMessage, bool buttonEneable, PopUpMessageWindow.MessageData[] messageList) { }

	// RVA: 0x1E0F0C8 Offset: 0x1E0B0C8 VA: 0x1E0F0C8
	public void .ctor(string title, PopUpMessageWindow.MessageData[] messageList) { }

	// RVA: 0x1E0F140 Offset: 0x1E0B140 VA: 0x1E0F140
	public void .ctor(string title, string message, bool pushButton) { }

	// RVA: 0x1E0F290 Offset: 0x1E0B290 VA: 0x1E0F290
	public void SetButtonColor(Color setColor) { }

	// RVA: 0x1E0F2A4 Offset: 0x1E0B2A4 VA: 0x1E0F2A4
	public void SetTitleIcon(string titleIconName) { }

	// RVA: 0x1E09B00 Offset: 0x1E05B00 VA: 0x1E09B00 Slot: 4
	protected override void Initialize() { }

	// RVA: 0x1E0F2C8 Offset: 0x1E0B2C8 VA: 0x1E0F2C8
	public void SetButtonText(string buttonText) { }

	// RVA: 0x1E0F38C Offset: 0x1E0B38C VA: 0x1E0F38C Slot: 6
	public override void MessageAction(int id) { }

	// RVA: 0x1E0F3A0 Offset: 0x1E0B3A0 VA: 0x1E0F3A0 Slot: 7
	public override int MessageCheck() { }
}
