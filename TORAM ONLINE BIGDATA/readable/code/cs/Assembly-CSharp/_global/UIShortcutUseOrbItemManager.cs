// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIShortcutUseOrbItemManager : UIBasePanel // TypeDefIndex: 6418
{
	// Fields
	private bool popActiveWindow; // 0x29
	private bool inputLock; // 0x2A
	[SerializeField]
	private GameObject orbItemPopPanelObject; // 0x30
	private UIOrbItemPanel orbItemPopPanel; // 0x38
	private UIPopBaseWindow popWindow; // 0x40
	private OrbItemManager orbItemManager; // 0x48
	private int useOrbItemId; // 0x50

	// Methods

	// RVA: 0x192A704 Offset: 0x1926704 VA: 0x192A704
	public void UseOrbItem(int orbItemId) { }

	[IteratorStateMachine(typeof(UIShortcutUseOrbItemManager.<OrbItemUseThread>d__8))]
	// RVA: 0x192AA84 Offset: 0x1926A84 VA: 0x192AA84
	private IEnumerator OrbItemUseThread() { }

	[IteratorStateMachine(typeof(UIShortcutUseOrbItemManager.<PopUpWindowThread>d__9))]
	// RVA: 0x192AB18 Offset: 0x1926B18 VA: 0x192AB18
	private IEnumerator PopUpWindowThread(Action<int> callBack) { }

	[IteratorStateMachine(typeof(UIShortcutUseOrbItemManager.<ConnectWait>d__10))]
	// RVA: 0x192ABC8 Offset: 0x1926BC8 VA: 0x192ABC8
	private IEnumerator ConnectWait(OrbManager.ConnectFlag flag) { }

	// RVA: 0x192AC6C Offset: 0x1926C6C VA: 0x192AC6C
	private void Close() { }

	// RVA: 0x192ACF0 Offset: 0x1926CF0 VA: 0x192ACF0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x192AD0C Offset: 0x1926D0C VA: 0x192AD0C Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x192AD10 Offset: 0x1926D10 VA: 0x192AD10
	public void .ctor() { }
}
