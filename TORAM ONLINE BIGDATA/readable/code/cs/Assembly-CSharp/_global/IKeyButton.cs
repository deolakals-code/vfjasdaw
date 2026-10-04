// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IKeyButton // TypeDefIndex: 5362
{
	// Properties
	public abstract bool IsUpdateLabel { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsUpdateLabel();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void PushKeyDown();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void PushKeyUp();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void PushKey();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool CheckAction();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void GetKeyLabel(string key, bool bFound, PCInputKeyMap keymap);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void GetMouseLabel(KeyCode key, PCInputKeyMap keymap);
}
