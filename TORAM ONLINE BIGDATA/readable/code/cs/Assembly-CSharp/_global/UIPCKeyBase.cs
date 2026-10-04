// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPCKeyBase : IKeyButton // TypeDefIndex: 8752
{
	// Fields
	private PCInputKeyMap inputMap; // 0x10
	private PlayerDataManager pDataManager; // 0x18

	// Properties
	protected PlayerDataManager playerDataManager { get; }
	protected virtual bool IsMobaMatching { get; }
	public virtual bool IsUpdateLabel { get; }

	// Methods

	// RVA: 0x1E0125C Offset: 0x1DFD25C VA: 0x1E0125C
	protected PlayerDataManager get_playerDataManager() { }

	// RVA: 0x1E012E0 Offset: 0x1DFD2E0 VA: 0x1E012E0 Slot: 11
	protected virtual bool get_IsMobaMatching() { }

	// RVA: 0x1E01304 Offset: 0x1DFD304 VA: 0x1E01304 Slot: 12
	public virtual bool get_IsUpdateLabel() { }

	// RVA: 0x1E0130C Offset: 0x1DFD30C VA: 0x1E0130C
	public void .ctor() { }

	// RVA: 0x1E01314 Offset: 0x1DFD314 VA: 0x1E01314
	public void .ctor(PCInputKeyMap key) { }

	// RVA: 0x1E01340 Offset: 0x1DFD340 VA: 0x1E01340
	protected void SetKeymap(PCInputKeyMap key) { }

	// RVA: 0x1E013B4 Offset: 0x1DFD3B4 VA: 0x1E013B4 Slot: 13
	public virtual void PushKeyDown() { }

	// RVA: 0x1E013B8 Offset: 0x1DFD3B8 VA: 0x1E013B8 Slot: 14
	public virtual void PushKeyUp() { }

	// RVA: 0x1E013BC Offset: 0x1DFD3BC VA: 0x1E013BC Slot: 15
	public virtual void PushKey() { }

	// RVA: 0x1E013C0 Offset: 0x1DFD3C0 VA: 0x1E013C0 Slot: 16
	protected virtual bool IsActivePanel(UIActiveState now) { }

	// RVA: 0x1E013CC Offset: 0x1DFD3CC VA: 0x1E013CC Slot: 17
	public virtual bool CheckAction() { }

	// RVA: 0x1E0150C Offset: 0x1DFD50C VA: 0x1E0150C Slot: 18
	public virtual void GetKeyLabel(string key, bool bFound, PCInputKeyMap keymap) { }

	// RVA: 0x1E01510 Offset: 0x1DFD510 VA: 0x1E01510 Slot: 19
	public virtual void GetMouseLabel(KeyCode key, PCInputKeyMap keymap) { }
}
