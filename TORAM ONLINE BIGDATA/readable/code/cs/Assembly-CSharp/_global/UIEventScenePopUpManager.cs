// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIEventScenePopUpManager : UIBasePanel // TypeDefIndex: 6407
{
	// Fields
	[SerializeField]
	private GameObject leftButton; // 0x30
	[SerializeField]
	private GameObject rightButton; // 0x38
	private UIPopBaseWindow popWindow; // 0x40
	private bool isClose; // 0x48
	private string title; // 0x50
	private string message; // 0x58
	private string icon; // 0x60
	private bool isInit; // 0x68
	private bool isChange; // 0x69
	private UIEventSceneIcon[] uiEventSceneIcon; // 0x70
	private int selectIndex; // 0x78

	// Methods

	// RVA: 0x1928918 Offset: 0x1924918 VA: 0x1928918
	public void Initialize(UIEventSceneIcon[] uiEventSceneIcon, int index) { }

	// RVA: 0x1928AE8 Offset: 0x1924AE8 VA: 0x1928AE8
	public void OnChangeSelectButton(int add) { }

	// RVA: 0x19289B0 Offset: 0x19249B0 VA: 0x19289B0
	private bool ChagePopPanel(int index) { }

	// RVA: 0x1928844 Offset: 0x1924844 VA: 0x1928844
	public void OnChangeMessage(string title, string mes, string icon) { }

	[IteratorStateMachine(typeof(UIEventScenePopUpManager.<Start>d__15))]
	// RVA: 0x1928B68 Offset: 0x1924B68 VA: 0x1928B68
	private IEnumerator Start() { }

	// RVA: 0x1928BFC Offset: 0x1924BFC VA: 0x1928BFC Slot: 5
	public override void OnLeftTopButton() { }

	// RVA: 0x1928C94 Offset: 0x1924C94 VA: 0x1928C94 Slot: 6
	public override void OnRightTopButton() { }

	// RVA: 0x1928D2C Offset: 0x1924D2C VA: 0x1928D2C
	public void .ctor() { }
}
