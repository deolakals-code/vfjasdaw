// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIWorldTreasureResultPanel : MonoBehaviour, IWorldTreasurePanel // TypeDefIndex: 8238
{
	// Fields
	[SerializeField]
	private GameObject panelObject; // 0x20
	[SerializeField]
	private UILabel topLabel; // 0x28
	[SerializeField]
	private UILabel bottomLabel; // 0x30
	[SerializeField]
	private UIIcon bottomLabelIcon; // 0x38
	private UIWorldTreasureManager manager; // 0x40
	private SystemTextManager systemTextManager; // 0x48

	// Methods

	[IteratorStateMachine(typeof(UIWorldTreasureResultPanel.<RecoveryResuletInitialize>d__6))]
	// RVA: 0x1CFF23C Offset: 0x1CFB23C VA: 0x1CFF23C
	private IEnumerator RecoveryResuletInitialize() { }

	[IteratorStateMachine(typeof(UIWorldTreasureResultPanel.<ConnectWait>d__7))]
	// RVA: 0x1CFF2D0 Offset: 0x1CFB2D0 VA: 0x1CFF2D0
	private IEnumerator ConnectWait(Func<bool> connectCheck, Action errCheck) { }

	// RVA: 0x1CFF380 Offset: 0x1CFB380 VA: 0x1CFF380
	private void ConnectError() { }

	// RVA: 0x1CFF45C Offset: 0x1CFB45C VA: 0x1CFF45C
	private void OnClickButton() { }

	// RVA: 0x1CFF518 Offset: 0x1CFB518 VA: 0x1CFF518 Slot: 4
	public void Initialize(UIWorldTreasureManager manager, SystemTextManager systemTextManager) { }

	// RVA: 0x1CFF760 Offset: 0x1CFB760 VA: 0x1CFF760 Slot: 5
	public void Close() { }

	// RVA: 0x1CFF780 Offset: 0x1CFB780 VA: 0x1CFF780 Slot: 6
	public bool PushLeftTopButton() { }

	// RVA: 0x1CFF824 Offset: 0x1CFB824 VA: 0x1CFF824
	public void .ctor() { }
}
