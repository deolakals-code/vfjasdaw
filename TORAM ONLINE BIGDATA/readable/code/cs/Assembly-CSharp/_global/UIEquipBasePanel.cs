// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIEquipBasePanel : MonoBehaviour // TypeDefIndex: 6956
{
	// Fields
	protected bool popUpWindow; // 0x20
	protected bool intputLock; // 0x21

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool InputLock();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Initialize(PlayerDataManager playerDataManager, IUIEquipMainManager manager);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Open();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SelectedEquipType(ItemDBData.EquipType equipType);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool Cancel();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool Enter();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void SelectedItem(ItemData itemData);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract string GetSelectedItemText(ItemData itemData);

	[IteratorStateMachine(typeof(UIEquipBasePanel.<PopWindow>d__11))]
	// RVA: 0x1A5B1BC Offset: 0x1A571BC VA: 0x1A5B1BC
	protected IEnumerator PopWindow(UIPopBaseWindow popWindow, bool destroy, Action<int> result) { }

	[IteratorStateMachine(typeof(UIEquipBasePanel.<RecruitItemPopWindow>d__12))]
	// RVA: 0x1A5F3C4 Offset: 0x1A5B3C4 VA: 0x1A5F3C4
	protected IEnumerator RecruitItemPopWindow(UIPopBaseWindow popWindow, bool destroy, Action<int> result) { }

	[IteratorStateMachine(typeof(UIEquipBasePanel.<WaitPopWindow>d__13))]
	// RVA: 0x1A5B26C Offset: 0x1A5726C VA: 0x1A5B26C
	protected IEnumerator WaitPopWindow(UIPopBaseWindow popWindow, Action<int> result) { }

	[IteratorStateMachine(typeof(UIEquipBasePanel.<ConnectWait>d__14))]
	// RVA: 0x1A5B308 Offset: 0x1A57308 VA: 0x1A5B308
	protected IEnumerator ConnectWait(Func<bool> connectionCheck, Action resultAction) { }

	// RVA: 0x1A58E18 Offset: 0x1A54E18 VA: 0x1A58E18
	protected void .ctor() { }
}
