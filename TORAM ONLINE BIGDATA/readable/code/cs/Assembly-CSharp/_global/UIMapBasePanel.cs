// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class UIMapBasePanel : MonoBehaviour // TypeDefIndex: 7380
{
	// Properties
	public abstract bool IsTapLock { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsTapLock();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract IEnumerator Initialize(UIMapMainPanelManager manager, PlayerDataManager playerDataManager, GameObject model, int fieldId, FieldTextManager fieldTextManager);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Open();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void Close();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract Vector3 Control(Vector3 drag);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool PushLeftTopButton();

	// RVA: 0x1B31B30 Offset: 0x1B2DB30 VA: 0x1B31B30 Slot: 10
	public virtual void OnPress(bool pressed) { }

	// RVA: 0x1B31B34 Offset: 0x1B2DB34 VA: 0x1B31B34 Slot: 11
	public virtual void OnClick() { }

	// RVA: 0x1B31B38 Offset: 0x1B2DB38 VA: 0x1B31B38 Slot: 12
	public virtual void OnDrag(Vector2 delta) { }

	// RVA: 0x1B31B3C Offset: 0x1B2DB3C VA: 0x1B31B3C Slot: 13
	public virtual void OnScroll(float delta) { }

	// RVA: 0x1B31B40 Offset: 0x1B2DB40 VA: 0x1B31B40
	protected void .ctor() { }
}
