// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IHistoryLogPanel // TypeDefIndex: 7179
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void OnChatInput();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void OnChatSend();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void AddChatText(HistoryLog.ChatType type, string name, string message);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void onOpenChatTypeSelect();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void onCloseChatTypeSelect();
}
