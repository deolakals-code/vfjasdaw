// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIPCKeyButton : MonoBehaviour, IKeyButton // TypeDefIndex: 8753
{
	// Fields
	[SerializeField]
	protected PCInputKeyMap inputMap; // 0x20
	private PlayerDataManager pDataManager; // 0x28

	// Properties
	protected PlayerDataManager playerDataManager { get; }
	protected bool IsMobaMatching { get; }
	public virtual bool IsUpdateLabel { get; }

	// Methods

	// RVA: 0x1E01514 Offset: 0x1DFD514 VA: 0x1E01514
	protected PlayerDataManager get_playerDataManager() { }

	// RVA: 0x1E01598 Offset: 0x1DFD598 VA: 0x1E01598
	protected bool get_IsMobaMatching() { }

	// RVA: 0x1E015BC Offset: 0x1DFD5BC VA: 0x1E015BC Slot: 11
	public virtual bool get_IsUpdateLabel() { }

	// RVA: 0x1E015C4 Offset: 0x1DFD5C4 VA: 0x1E015C4 Slot: 12
	protected virtual void Start() { }

	// RVA: 0x1E0162C Offset: 0x1DFD62C VA: 0x1E0162C
	private void OnDestroy() { }

	// RVA: 0x1E015C8 Offset: 0x1DFD5C8 VA: 0x1E015C8
	protected void SetKeymap() { }

	// RVA: 0x1E01690 Offset: 0x1DFD690 VA: 0x1E01690 Slot: 13
	public virtual void PushKeyDown() { }

	// RVA: 0x1E01694 Offset: 0x1DFD694 VA: 0x1E01694 Slot: 14
	public virtual void PushKeyUp() { }

	// RVA: 0x1E01698 Offset: 0x1DFD698 VA: 0x1E01698 Slot: 15
	public virtual void PushKey() { }

	// RVA: 0x1E0169C Offset: 0x1DFD69C VA: 0x1E0169C Slot: 16
	public virtual bool CheckAction() { }

	// RVA: 0x1E016A4 Offset: 0x1DFD6A4 VA: 0x1E016A4 Slot: 17
	public virtual void GetKeyLabel(string key, bool bFound, PCInputKeyMap keymap) { }

	// RVA: 0x1E016A8 Offset: 0x1DFD6A8 VA: 0x1E016A8 Slot: 18
	public virtual void GetMouseLabel(KeyCode key, PCInputKeyMap keymap) { }

	// RVA: 0x1E016AC Offset: 0x1DFD6AC VA: 0x1E016AC
	public void .ctor() { }
}
