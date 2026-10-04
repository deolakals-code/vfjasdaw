// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPCCraneGameShortcutKey : UIPCKeyButton // TypeDefIndex: 4332
{
	// Fields
	[SerializeField]
	private UILabel keyLabel; // 0x30
	[SerializeField]
	private bool isUpdateLabel; // 0x38
	[SerializeField]
	private bool isCheckWindow; // 0x39
	[SerializeField]
	private UICraneGameManager.DisplayStatus isWindow; // 0x3C
	private GameObject button; // 0x40
	private Collider col; // 0x48
	private UICraneGameManager uiManager; // 0x50

	// Properties
	public override bool IsUpdateLabel { get; }

	// Methods

	// RVA: 0x24D1C24 Offset: 0x24CDC24 VA: 0x24D1C24 Slot: 11
	public override bool get_IsUpdateLabel() { }

	// RVA: 0x24D1C2C Offset: 0x24CDC2C VA: 0x24D1C2C
	private void Awake() { }

	// RVA: 0x24D1CA0 Offset: 0x24CDCA0 VA: 0x24D1CA0 Slot: 13
	public override void PushKeyDown() { }

	// RVA: 0x24D1D60 Offset: 0x24CDD60 VA: 0x24D1D60 Slot: 14
	public override void PushKeyUp() { }

	// RVA: 0x24D1DF0 Offset: 0x24CDDF0 VA: 0x24D1DF0 Slot: 16
	public override bool CheckAction() { }

	// RVA: 0x24D206C Offset: 0x24CE06C VA: 0x24D206C Slot: 17
	public override void GetKeyLabel(string key, bool bFound, PCInputKeyMap keymap) { }

	// RVA: 0x24D2154 Offset: 0x24CE154 VA: 0x24D2154
	public void ChangeInputMap(PCInputKeyMap keyMap) { }

	// RVA: 0x24D215C Offset: 0x24CE15C VA: 0x24D215C
	public void .ctor() { }
}
