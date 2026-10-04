// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIBasePanelConnection : UIBasePanel // TypeDefIndex: 8863
{
	// Fields
	private bool isPopWindow; // 0x29
	private bool isOnlyCloseWindow; // 0x2A
	private bool isConnection; // 0x2B

	// Properties
	protected bool IsConnection { get; }
	protected bool IsPopWindow { get; }
	protected virtual Transform PopParent { get; }

	// Methods

	// RVA: 0x1E39F3C Offset: 0x1E35F3C VA: 0x1E39F3C
	protected bool get_IsConnection() { }

	// RVA: 0x1E39F44 Offset: 0x1E35F44 VA: 0x1E39F44
	protected bool get_IsPopWindow() { }

	// RVA: 0x1E39F4C Offset: 0x1E35F4C VA: 0x1E39F4C Slot: 7
	protected virtual Transform get_PopParent() { }

	// RVA: 0x1E39F54 Offset: 0x1E35F54 VA: 0x1E39F54
	protected void SetConnection(IReconnectionSubData data, Action callback) { }

	[IteratorStateMachine(typeof(UIBasePanelConnection.<Connection>d__10))]
	// RVA: 0x1E3A064 Offset: 0x1E36064 VA: 0x1E3A064
	protected IEnumerator Connection(Func<bool> check, Action callback) { }

	[IteratorStateMachine(typeof(UIBasePanelConnection.<popUpMessage>d__11))]
	// RVA: 0x1E3A128 Offset: 0x1E36128 VA: 0x1E3A128
	protected IEnumerator popUpMessage(string titleText, string messageText, Action callback) { }

	[IteratorStateMachine(typeof(UIBasePanelConnection.<popUpMessage>d__12))]
	// RVA: 0x1E3A208 Offset: 0x1E36208 VA: 0x1E3A208
	protected IEnumerator popUpMessage(string titleText, string messageText, Action<int> callback) { }

	[IteratorStateMachine(typeof(UIBasePanelConnection.<popUpMessage>d__13))]
	// RVA: 0x1E3A2E8 Offset: 0x1E362E8 VA: 0x1E3A2E8
	protected IEnumerator popUpMessage(GameObject titleObject, GameObject messageObject, Action callback, string buttonText = "") { }

	// RVA: 0x1E3A3DC Offset: 0x1E363DC VA: 0x1E3A3DC
	protected void PopWindow() { }

	// RVA: 0x1E3A3E8 Offset: 0x1E363E8 VA: 0x1E3A3E8
	protected bool CloseWindow() { }

	// RVA: 0x1E3A3F8 Offset: 0x1E363F8 VA: 0x1E3A3F8
	protected bool OnlyCloseWindow() { }

	// RVA: 0x1E3A414 Offset: 0x1E36414 VA: 0x1E3A414
	protected void .ctor() { }
}
