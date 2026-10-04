// Assembly: Assembly-CSharp.dll
// Namespace: 
public class PopUpMessageCallBackWindow : PopUpMessageWindow // TypeDefIndex: 8793
{
	// Fields
	private Action<int> callback; // 0x70

	// Methods

	// RVA: 0x1E0EB5C Offset: 0x1E0AB5C VA: 0x1E0EB5C
	public void .ctor(string title, string message, Action<int> callback) { }

	// RVA: 0x1E0EC9C Offset: 0x1E0AC9C VA: 0x1E0EC9C
	public void .ctor(string title, string message, float size, Action<int> callback) { }

	// RVA: 0x1E0EDE4 Offset: 0x1E0ADE4 VA: 0x1E0EDE4
	public void .ctor(string title, string buttonMessage, Action<int> callback, PopUpMessageWindow.MessageData[] messageList) { }

	// RVA: 0x1E0EF34 Offset: 0x1E0AF34 VA: 0x1E0EF34
	public void .ctor(string title, string buttonMessage, bool buttonEneable, Action<int> callback, PopUpMessageWindow.MessageData[] messageList) { }

	// RVA: 0x1E0F098 Offset: 0x1E0B098 VA: 0x1E0F098
	public void .ctor(string title, Action<int> callback, PopUpMessageWindow.MessageData[] messageList) { }

	// RVA: 0x1E0F110 Offset: 0x1E0B110 VA: 0x1E0F110
	public void .ctor(string title, string message, bool pushButton, Action<int> callback) { }

	// RVA: 0x1E0F268 Offset: 0x1E0B268 VA: 0x1E0F268 Slot: 6
	public override void MessageAction(int id) { }
}
