// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGLShortcutButton : MonoBehaviour // TypeDefIndex: 6527
{
	// Fields
	[SerializeField]
	protected int shortcutId; // 0x20
	[SerializeField]
	protected UIGLSpriteTransition buttonSprite; // 0x28
	[SerializeField]
	protected GameObject shortcutIconObject; // 0x30
	[SerializeField]
	protected UIGLSprite shortcutIcon; // 0x38
	[SerializeField]
	protected UIGLLabel extensionLabel; // 0x40
	[SerializeField]
	protected UIGLLabel nameLabel; // 0x48
	[SerializeField]
	protected UIGLImageButton imageButton; // 0x50
	[SerializeField]
	protected UIGLActiveShortcutButton shortcutButton; // 0x58
	[SerializeField]
	private bool holdingFlag; // 0x60
	[SerializeField]
	private UIGuardGauge guardGauge; // 0x68
	[SerializeField]
	private UIAvoidGauge avoidGauge; // 0x70
	[SerializeField]
	private UIGLSprite subIcon; // 0x78
	[SerializeField]
	protected bool isExtendedButton; // 0x80
	private float holdingTime; // 0x84
	private bool holdedFlag; // 0x88
	private bool isSkipNextClick; // 0x89
	protected ShortcutData shortcutData; // 0x90
	private float animationTimer; // 0x98
	private int animationId; // 0x9C
	private GameObject targetObject; // 0xA0
	private UIGLShortcutButton.ActionButtonType actionButtonType; // 0xA8
	private TweenScale actionTweenScale; // 0xB0
	private PlayerDataManager playerManager; // 0xB8
	private SystemTextManager systemManager; // 0xC0
	private TweenScale scaleAnimation; // 0xC8
	private const int exLeftId = 8;
	private const int exRightId = 9;
	private int extensionTextNum; // 0xD0
	private GuardActionManager guardManager; // 0xD8
	private bool isGuard; // 0xE0
	private AvoidActionManager avoidManager; // 0xE8
	private float guardStartTimer; // 0xF0
	private bool isGuardHold; // 0xF4

	// Properties
	protected PlayerDataManager playerDataManager { get; }
	private SystemTextManager systemTextManager { get; }
	private TweenScale ScaleAnimation { get; }
	public bool IsGuardButton { get; }
	private bool IsExBottom { get; }

	// Methods

	// RVA: 0x196A6A8 Offset: 0x19666A8 VA: 0x196A6A8
	protected PlayerDataManager get_playerDataManager() { }

	// RVA: 0x196A72C Offset: 0x196672C VA: 0x196A72C
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x196A818 Offset: 0x1966818 VA: 0x196A818
	private TweenScale get_ScaleAnimation() { }

	// RVA: 0x196A8C8 Offset: 0x19668C8 VA: 0x196A8C8
	public bool get_IsGuardButton() { }

	// RVA: 0x196A8F4 Offset: 0x19668F4 VA: 0x196A8F4
	private bool get_IsExBottom() { }

	// RVA: 0x196A908 Offset: 0x1966908 VA: 0x196A908 Slot: 4
	protected virtual ShortcutData GetShortcutData() { }

	// RVA: 0x196A960 Offset: 0x1966960 VA: 0x196A960 Slot: 5
	protected virtual void ShortcutDataAction() { }

	// RVA: 0x196A9B8 Offset: 0x19669B8 VA: 0x196A9B8
	public void FadeUpdate(bool flag, bool isExtendedButton) { }

	// RVA: 0x196AE70 Offset: 0x1966E70 VA: 0x196AE70
	public void LabelUpdate() { }

	// RVA: 0x196B040 Offset: 0x1967040 VA: 0x196B040 Slot: 6
	protected virtual void Update() { }

	[IteratorStateMachine(typeof(UIGLShortcutButton.<DelayTimerUpdate>d__49))]
	// RVA: 0x196BE20 Offset: 0x1967E20 VA: 0x196BE20
	private IEnumerator DelayTimerUpdate(float time) { }

	// RVA: 0x196BEA0 Offset: 0x1967EA0 VA: 0x196BEA0
	private bool IsDelay() { }

	// RVA: 0x196BEA8 Offset: 0x1967EA8 VA: 0x196BEA8
	private void OnPress(bool pressed) { }

	// RVA: 0x196BF44 Offset: 0x1967F44 VA: 0x196BF44
	public void OnClick() { }

	// RVA: 0x196BFF4 Offset: 0x1967FF4 VA: 0x196BFF4 Slot: 7
	protected virtual void SetActiveShortcut(bool isActive) { }

	// RVA: 0x196C01C Offset: 0x196801C VA: 0x196C01C
	public void .ctor() { }
}
