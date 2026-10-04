// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UILeftStick : MonoBehaviour // TypeDefIndex: 6534
{
	// Fields
	[CompilerGenerated]
	private float <InputMoveRate>k__BackingField; // 0x20
	private bool pressed; // 0x24
	private bool keyPressed; // 0x25
	private Vector2 firstPoint; // 0x28
	private Vector2 pushingPoint; // 0x30
	private Vector2 firstDelta; // 0x38
	private Vector3[] stickPos; // 0x40
	[SerializeField]
	private UIAtlas stickAtlas; // 0x48
	private Material stickMaterial; // 0x50
	private Vector2 inputStick; // 0x58
	private UIIruna2Anchor anchor; // 0x60
	private bool activeStick; // 0x68
	private readonly float frameTime; // 0x6C
	private Rect sitckUV; // 0x70
	[SerializeField]
	private BoxCollider stickSaveCollider; // 0x80
	private GuardActionManager guardManager; // 0x88
	private PlayerDataManager playerDataManager; // 0x90
	private bool isGuardCrashInput; // 0x98
	private bool isOverMoveGuardRate; // 0x99

	// Properties
	public bool Pressed { get; }
	public Vector2 InputStick { get; }
	public bool stickSaveColliderEnable { get; set; }
	public float InputMoveRate { get; set; }
	public bool IsGuardCrashInput { get; }

	// Methods

	// RVA: 0x196F690 Offset: 0x196B690 VA: 0x196F690
	public bool get_Pressed() { }

	// RVA: 0x196F6A0 Offset: 0x196B6A0 VA: 0x196F6A0
	public Vector2 get_InputStick() { }

	// RVA: 0x196F714 Offset: 0x196B714 VA: 0x196F714
	public void set_stickSaveColliderEnable(bool value) { }

	// RVA: 0x196F734 Offset: 0x196B734 VA: 0x196F734
	public bool get_stickSaveColliderEnable() { }

	[CompilerGenerated]
	// RVA: 0x196F750 Offset: 0x196B750 VA: 0x196F750
	public float get_InputMoveRate() { }

	[CompilerGenerated]
	// RVA: 0x196F758 Offset: 0x196B758 VA: 0x196F758
	private void set_InputMoveRate(float value) { }

	// RVA: 0x196F760 Offset: 0x196B760 VA: 0x196F760
	public bool get_IsGuardCrashInput() { }

	// RVA: 0x196F768 Offset: 0x196B768 VA: 0x196F768
	private void Start() { }

	// RVA: 0x196F898 Offset: 0x196B898 VA: 0x196F898 Slot: 4
	protected virtual void Update() { }

	// RVA: 0x196FE40 Offset: 0x196BE40 VA: 0x196FE40
	private Vector2 correctPosition(Vector2 pos) { }

	// RVA: 0x196FED0 Offset: 0x196BED0 VA: 0x196FED0
	private void OnPress(bool pres) { }

	// RVA: 0x196FF90 Offset: 0x196BF90 VA: 0x196FF90
	private void OnDrag(Vector2 delta) { }

	// RVA: 0x19700CC Offset: 0x196C0CC VA: 0x19700CC
	public void Fade(bool flag) { }

	// RVA: 0x197023C Offset: 0x196C23C VA: 0x197023C
	public void OnRenderObject() { }

	// RVA: 0x1970514 Offset: 0x196C514 VA: 0x1970514
	protected void SetShortcutMoveKey(Vector2 input, bool press) { }

	// RVA: 0x197057C Offset: 0x196C57C VA: 0x197057C
	public void .ctor() { }
}
