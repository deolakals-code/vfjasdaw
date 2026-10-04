// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIOrbBuyRefreshWindow : MonoBehaviour // TypeDefIndex: 7562
{
	// Fields
	[SerializeField]
	private GameObject windowObj; // 0x20
	[SerializeField]
	private UILabel mainTextLabel; // 0x28
	[SerializeField]
	private UILabel buttonLabel; // 0x30
	[SerializeField]
	private UISlider progressBar; // 0x38
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x40
	private UIOrbBuyRefreshWindow.PanelState panelState; // 0x44
	private Action callBack; // 0x48
	private float waitSeconds; // 0x50
	private Coroutine closeCoroutine; // 0x58
	private Coroutine checkCoroutine; // 0x60
	private AndroidPluginManager pluginManager; // 0x68
	private SystemTextManager systemTextManager; // 0x70

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1BACAD8 Offset: 0x1BA8AD8 VA: 0x1BACAD8
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x1BACAE0 Offset: 0x1BA8AE0 VA: 0x1BACAE0
	private void set_IsOpen(bool value) { }

	// RVA: 0x1BACAEC Offset: 0x1BA8AEC VA: 0x1BACAEC
	private void Awake() { }

	// RVA: 0x1BAA924 Offset: 0x1BA6924 VA: 0x1BAA924
	public void Open(Action callBack) { }

	// RVA: 0x1BAAAA8 Offset: 0x1BA6AA8 VA: 0x1BAAAA8
	public void Close() { }

	[IteratorStateMachine(typeof(UIOrbBuyRefreshWindow.<PanelClose>d__19))]
	// RVA: 0x1BACF6C Offset: 0x1BA8F6C VA: 0x1BACF6C
	private IEnumerator PanelClose() { }

	// RVA: 0x1BACCEC Offset: 0x1BA8CEC VA: 0x1BACCEC
	private void ChangePanel(UIOrbBuyRefreshWindow.PanelState panelState) { }

	// RVA: 0x1BAD06C Offset: 0x1BA906C VA: 0x1BAD06C
	private void OnButtonClick() { }

	[IteratorStateMachine(typeof(UIOrbBuyRefreshWindow.<CheckRefresh>d__22))]
	// RVA: 0x1BAD000 Offset: 0x1BA9000 VA: 0x1BAD000
	private IEnumerator CheckRefresh() { }

	// RVA: 0x1BAD1F4 Offset: 0x1BA91F4 VA: 0x1BAD1F4
	public void .ctor() { }
}
