// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Toggle")]
public class UIToggle : UIWidgetContainer // TypeDefIndex: 59
{
	// Fields
	public static BetterList<UIToggle> list; // 0x0
	public static UIToggle current; // 0x8
	public int group; // 0x20
	public UIWidget activeSprite; // 0x28
	public Animation activeAnimation; // 0x30
	public bool startsActive; // 0x38
	public bool instantTween; // 0x39
	public bool optionCanBeNone; // 0x3A
	public List<EventDelegate> onChange; // 0x40
	[SerializeField]
	[HideInInspector]
	private Transform radioButtonRoot; // 0x48
	[HideInInspector]
	[SerializeField]
	private bool startsChecked; // 0x50
	[HideInInspector]
	[SerializeField]
	private UISprite checkSprite; // 0x58
	[HideInInspector]
	[SerializeField]
	private Animation checkAnimation; // 0x60
	[SerializeField]
	[HideInInspector]
	private GameObject eventReceiver; // 0x68
	[SerializeField]
	[HideInInspector]
	private string functionName; // 0x70
	private bool mIsActive; // 0x78
	private bool mStarted; // 0x79

	// Properties
	public bool value { get; set; }
	[Obsolete("Use 'value' instead")]
	public bool isChecked { get; set; }

	// Methods

	// RVA: 0x17272B8 Offset: 0x17232B8 VA: 0x17272B8
	public bool get_value() { }

	// RVA: 0x17272C0 Offset: 0x17232C0 VA: 0x17272C0
	public void set_value(bool value) { }

	// RVA: 0x17276DC Offset: 0x17236DC VA: 0x17276DC
	public bool get_isChecked() { }

	// RVA: 0x17276E4 Offset: 0x17236E4 VA: 0x17276E4
	public void set_isChecked(bool value) { }

	// RVA: 0x17276EC Offset: 0x17236EC VA: 0x17276EC
	private void OnEnable() { }

	// RVA: 0x172776C Offset: 0x172376C VA: 0x172776C
	private void OnDisable() { }

	// RVA: 0x17277EC Offset: 0x17237EC VA: 0x17277EC
	private void Start() { }

	// RVA: 0x1727804 Offset: 0x1723804 VA: 0x1727804
	private void OnClick() { }

	// RVA: 0x17272E8 Offset: 0x17232E8 VA: 0x17272E8
	private void Set(bool state) { }

	// RVA: 0x172786C Offset: 0x172386C VA: 0x172786C
	public void .ctor() { }

	// RVA: 0x1727920 Offset: 0x1723920 VA: 0x1727920
	private static void .cctor() { }
}
