// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEventControl : IUIPanelControl // TypeDefIndex: 8867
{
	// Fields
	private Stack<Action> backAction; // 0x10

	// Methods

	// RVA: 0x1E3AD54 Offset: 0x1E36D54 VA: 0x1E3AD54 Slot: 4
	public void Push(Action pushFunction) { }

	// RVA: 0x1E3ADAC Offset: 0x1E36DAC VA: 0x1E3ADAC
	public Action Pop() { }

	// RVA: 0x1E3AEC8 Offset: 0x1E36EC8 VA: 0x1E3AEC8 Slot: 5
	public void CheckPop(Action targetAction) { }

	// RVA: 0x1E3AF74 Offset: 0x1E36F74 VA: 0x1E3AF74
	public void Clear() { }

	// RVA: 0x1E3AFC4 Offset: 0x1E36FC4 VA: 0x1E3AFC4
	public bool ReturnAction() { }

	// RVA: 0x1E3B050 Offset: 0x1E37050 VA: 0x1E3B050
	public void .ctor() { }
}
