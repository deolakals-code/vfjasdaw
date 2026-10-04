// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPCMenuKey : UIPCKeyButton // TypeDefIndex: 8754
{
	// Fields
	[SerializeField]
	private UIActiveState[] pushActiveState; // 0x30
	[SerializeField]
	private bool isUpdateLabel; // 0x38
	private GameObject button; // 0x40
	private Collider col; // 0x48
	private UIActiveState changeState; // 0x50
	[SerializeField]
	private UILabel keyLabel; // 0x58

	// Properties
	public override bool IsUpdateLabel { get; }

	// Methods

	// RVA: 0x1E016B4 Offset: 0x1DFD6B4 VA: 0x1E016B4 Slot: 11
	public override bool get_IsUpdateLabel() { }

	// RVA: 0x1E016BC Offset: 0x1DFD6BC VA: 0x1E016BC
	protected void Awake() { }

	// RVA: 0x1E017A8 Offset: 0x1DFD7A8 VA: 0x1E017A8 Slot: 13
	public override void PushKeyDown() { }

	// RVA: 0x1E018F8 Offset: 0x1DFD8F8 VA: 0x1E018F8 Slot: 14
	public override void PushKeyUp() { }

	// RVA: 0x1E019C4 Offset: 0x1DFD9C4 VA: 0x1E019C4 Slot: 16
	public override bool CheckAction() { }

	// RVA: 0x1E01C68 Offset: 0x1DFDC68 VA: 0x1E01C68 Slot: 17
	public override void GetKeyLabel(string key, bool bFound, PCInputKeyMap keymap) { }

	// RVA: 0x1E01D50 Offset: 0x1DFDD50 VA: 0x1E01D50
	public void .ctor() { }
}
