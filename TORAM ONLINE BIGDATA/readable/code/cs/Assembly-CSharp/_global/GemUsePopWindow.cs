// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GemUsePopWindow : MonoBehaviour // TypeDefIndex: 5760
{
	// Fields
	[SerializeField]
	private GameObject windowPanel; // 0x20
	private bool isOpen; // 0x28
	[SerializeField]
	private UILabel titleLabel; // 0x30
	[SerializeField]
	private UILabel gemProperty; // 0x38
	private int itemId; // 0x40
	private ItemTextManager itemTextManager; // 0x48
	private SystemTextManager systemTextManager; // 0x50
	private Action<int> buttonAction; // 0x58

	// Properties
	public bool IsOpen { get; }

	// Methods

	// RVA: 0x17DF6C8 Offset: 0x17DB6C8 VA: 0x17DF6C8
	public bool get_IsOpen() { }

	// RVA: 0x17DF6D0 Offset: 0x17DB6D0 VA: 0x17DF6D0
	public void Initialize(int itemId, Action<int> buttonAction) { }

	// RVA: 0x17DFF84 Offset: 0x17DBF84 VA: 0x17DFF84
	private void onOk() { }

	// RVA: 0x17E0004 Offset: 0x17DC004 VA: 0x17E0004
	public void CloseWindow() { }

	[IteratorStateMachine(typeof(GemUsePopWindow.<PanelEnableToFalse>d__13))]
	// RVA: 0x17E0084 Offset: 0x17DC084 VA: 0x17E0084
	private IEnumerator PanelEnableToFalse() { }

	// RVA: 0x17E0118 Offset: 0x17DC118 VA: 0x17E0118
	public void .ctor() { }
}
