// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIShortcutCustomBase // TypeDefIndex: 7518
{
	// Fields
	protected IUIShortcutCustomManager manager; // 0x10
	protected SystemTextManager systemTextManager; // 0x18
	protected UnityAction onBackButton; // 0x20

	// Properties
	public UnityAction OnBackButton { get; }
	public virtual bool IsTopMenu { get; }
	public virtual bool IsFullWindow { get; }

	// Methods

	// RVA: 0x1B82BD4 Offset: 0x1B7EBD4 VA: 0x1B82BD4
	public UnityAction get_OnBackButton() { }

	// RVA: 0x1B82BDC Offset: 0x1B7EBDC VA: 0x1B82BDC
	public void .ctor(IUIShortcutCustomManager manager) { }

	// RVA: 0x1B82CF4 Offset: 0x1B7ECF4 VA: 0x1B82CF4 Slot: 4
	public virtual bool get_IsTopMenu() { }

	// RVA: 0x1B82CFC Offset: 0x1B7ECFC VA: 0x1B82CFC Slot: 5
	public virtual bool get_IsFullWindow() { }

	// RVA: 0x1B82D04 Offset: 0x1B7ED04 VA: 0x1B82D04 Slot: 6
	public virtual void CreateList() { }

	// RVA: 0x1B835CC Offset: 0x1B7F5CC VA: 0x1B835CC Slot: 7
	public virtual string OnSelect(int id) { }

	// RVA: 0x1B83680 Offset: 0x1B7F680 VA: 0x1B83680 Slot: 8
	public virtual void OnClick(int id) { }

	// RVA: 0x1B84064 Offset: 0x1B80064 VA: 0x1B84064 Slot: 9
	public virtual void OnSwitchButton() { }

	// RVA: 0x1B82FC4 Offset: 0x1B7EFC4 VA: 0x1B82FC4
	protected bool CheckAddButon(UIShortcutCustomBase.ShortcutTypes type) { }

	// RVA: 0x1B83548 Offset: 0x1B7F548 VA: 0x1B83548
	protected bool CheckMobaAddButton(UIShortcutCustomBase.ShortcutTypes type) { }
}
