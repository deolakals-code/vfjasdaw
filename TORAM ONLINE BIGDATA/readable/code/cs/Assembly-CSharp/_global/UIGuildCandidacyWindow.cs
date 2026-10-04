// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGuildCandidacyWindow : MonoBehaviour // TypeDefIndex: 7102
{
	// Fields
	[SerializeField]
	private UILabel mainLabel; // 0x20
	[SerializeField]
	private UISlider progressSlider; // 0x28
	[SerializeField]
	private GameObject checkObject; // 0x30
	[SerializeField]
	private GameObject progressObject; // 0x38
	[SerializeField]
	private UILabel progressTextLabel; // 0x40
	[SerializeField]
	private UILabel cancelButtonLabel; // 0x48
	[SerializeField]
	private UIButtonMessage cancelButtonMessage; // 0x50
	private Action<string> callback; // 0x58
	private Action<string> inputCallback; // 0x60
	private UIBasePanelControl TopControl; // 0x68
	private SystemTextManager systemTextManager; // 0x70

	// Properties
	public bool IsActive { get; }

	// Methods

	// RVA: 0x1A9549C Offset: 0x1A9149C VA: 0x1A9549C
	public bool get_IsActive() { }

	// RVA: 0x1A954BC Offset: 0x1A914BC VA: 0x1A954BC
	private void Awake() { }

	// RVA: 0x1A955A4 Offset: 0x1A915A4 VA: 0x1A955A4
	public void Open(string memberName, UIBasePanelControl topControl) { }

	// RVA: 0x1A95740 Offset: 0x1A91740 VA: 0x1A95740
	public void OnClose() { }

	[IteratorStateMachine(typeof(UIGuildCandidacyWindow.<StartProgress>d__16))]
	// RVA: 0x1A95764 Offset: 0x1A91764 VA: 0x1A95764
	public IEnumerator StartProgress(int id, Action<int> callback) { }

	// RVA: 0x1A9581C Offset: 0x1A9181C VA: 0x1A9581C
	public void FinishTrans(string mainText) { }

	// RVA: 0x1A958C8 Offset: 0x1A918C8 VA: 0x1A958C8
	public void OnCancel() { }

	// RVA: 0x1A958CC Offset: 0x1A918CC VA: 0x1A958CC
	public void .ctor() { }
}
