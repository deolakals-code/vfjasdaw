// Assembly: Assembly-CSharp.dll
// Namespace: 
public abstract class SummerEventPanelBase : MonoBehaviour // TypeDefIndex: 6336
{
	// Fields
	protected int prev_state; // 0x20
	protected Action<int> state_change_callback; // 0x28

	// Methods

	// RVA: 0x18EB3D0 Offset: 0x18E73D0 VA: 0x18EB3D0
	private void Start() { }

	// RVA: 0x18EB3D4 Offset: 0x18E73D4 VA: 0x18EB3D4
	private void Update() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ChangeState();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Open(Action<int> _change_state_callback);

	// RVA: 0x18E85B4 Offset: 0x18E45B4 VA: 0x18E85B4 Slot: 6
	public virtual void Open(Action<int> _change_state_callback, int _add_info) { }

	// RVA: 0x18E190C Offset: 0x18DD90C VA: 0x18E190C Slot: 7
	public virtual void OpenDialog(Action<int> _change_state_callback, string[] _datas) { }

	// RVA: 0x18E2A80 Offset: 0x18DEA80 VA: 0x18E2A80 Slot: 8
	public virtual void Close() { }

	// RVA: 0x18E29B0 Offset: 0x18DE9B0 VA: 0x18E29B0 Slot: 9
	public virtual void OnLeftTopButtonPush() { }

	// RVA: 0x18E1994 Offset: 0x18DD994 VA: 0x18E1994
	protected void .ctor() { }
}
