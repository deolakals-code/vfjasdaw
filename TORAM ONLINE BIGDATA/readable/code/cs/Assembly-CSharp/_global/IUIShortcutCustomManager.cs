// Assembly: Assembly-CSharp.dll
// Namespace: 
public interface IUIShortcutCustomManager // TypeDefIndex: 7529
{
	// Properties
	public abstract bool IsSelectList { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool get_IsSelectList();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void CreateList(UIShortcutCustomBase data);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract GameObject SetButton(string label, int id);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract UIIcon SetIconButton(string label, int id);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract UIIcon SetIconButton(string label, int id, UnityAction<int> infoCallback);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void SetShortcutData(ShortcutData.ShortcutType type, int id);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void SetLowerShortcutLabel(ShortcutData.ShortcutType type, int id);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void PageSwitchButtonSetActive(bool isActive);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void PageDownButtonSetActive(bool isActive);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool PopUpConfirmationMessage(int id, PopBaseWindow popWindow, Action<int, int> callBack);
}
