// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIShortcutUseSkillBookManager : UIBasePanel // TypeDefIndex: 6421
{
	// Fields
	private UIPopBaseWindow popWindow; // 0x30
	private PlayerDataManager playerDataManager; // 0x38
	private bool isActive; // 0x40

	// Methods

	// RVA: 0x192BAEC Offset: 0x1927AEC VA: 0x192BAEC
	private void Start() { }

	// RVA: 0x192BB7C Offset: 0x1927B7C VA: 0x192BB7C
	public void OpenCheckUseWindow(int uuid) { }

	// RVA: 0x192BFB8 Offset: 0x1927FB8 VA: 0x192BFB8
	public void OpenFailureWindow(int uuid) { }

	// RVA: 0x192BE8C Offset: 0x1927E8C VA: 0x192BE8C
	private void CreatePopWindow() { }

	[IteratorStateMachine(typeof(UIShortcutUseSkillBookManager.<PopUpWindowThread>d__7))]
	// RVA: 0x192BF30 Offset: 0x1927F30 VA: 0x192BF30
	private IEnumerator PopUpWindowThread(Action callBack) { }

	// RVA: 0x192C24C Offset: 0x192824C VA: 0x192C24C
	private void Close() { }

	// RVA: 0x192C2D0 Offset: 0x19282D0 VA: 0x192C2D0 Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x192C2D4 Offset: 0x19282D4 VA: 0x192C2D4 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x192C2D8 Offset: 0x19282D8 VA: 0x192C2D8
	public void .ctor() { }
}
