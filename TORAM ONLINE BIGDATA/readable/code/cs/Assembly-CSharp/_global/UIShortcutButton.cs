// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIShortcutButton : MonoBehaviour // TypeDefIndex: 6567
{
	// Fields
	[SerializeField]
	private bool holdingFlag; // 0x20
	private float holdingTime; // 0x24
	private bool holdedFlag; // 0x28
	private bool isSkipNextClick; // 0x29
	[SerializeField]
	private int shortcutId; // 0x2C
	[SerializeField]
	private GameObject shortcutIconObject; // 0x30
	private UIImageButton shortcutImageButton; // 0x38
	private UIIcon shortcutIcon; // 0x40
	private TweenScale scaleAnimation; // 0x48
	private UIActiveShortcutButton shortcutButton; // 0x50
	private UIIruna2Anchor shortcutButtonAnchor; // 0x58
	private ShortcutData shortcutData; // 0x60
	private PlayerDataManager playerManager; // 0x68
	private float animationTimer; // 0x70
	private int animationId; // 0x74
	private GameObject targetObject; // 0x78
	private UIShortcutButton.ActionButtonType actionButtonType; // 0x80
	private SystemTextManager systemManager; // 0x88

	// Properties
	private UIIcon ShortcutIcon { get; }
	private TweenScale ScaleAnimation { get; }
	private UIActiveShortcutButton ShortcutButton { get; }
	private UIIruna2Anchor ShortcutButtonAnchor { get; }
	private PlayerDataManager playerDataManager { get; }
	private SystemTextManager systemTextManager { get; }

	// Methods

	// RVA: 0x19843D4 Offset: 0x19803D4 VA: 0x19843D4
	private UIIcon get_ShortcutIcon() { }

	// RVA: 0x1984484 Offset: 0x1980484 VA: 0x1984484
	private TweenScale get_ScaleAnimation() { }

	// RVA: 0x1984534 Offset: 0x1980534 VA: 0x1984534
	private UIActiveShortcutButton get_ShortcutButton() { }

	// RVA: 0x19845DC Offset: 0x19805DC VA: 0x19845DC
	private UIIruna2Anchor get_ShortcutButtonAnchor() { }

	// RVA: 0x1984694 Offset: 0x1980694 VA: 0x1984694
	private PlayerDataManager get_playerDataManager() { }

	// RVA: 0x1984718 Offset: 0x1980718 VA: 0x1984718
	private SystemTextManager get_systemTextManager() { }

	// RVA: 0x1984804 Offset: 0x1980804 VA: 0x1984804
	public void Fade(bool flag) { }

	// RVA: 0x1984A98 Offset: 0x1980A98 VA: 0x1984A98
	private void Update() { }

	// RVA: 0x1984FBC Offset: 0x1980FBC VA: 0x1984FBC
	private void OnPress(bool pressed) { }

	// RVA: 0x1985058 Offset: 0x1981058 VA: 0x1985058
	private void OnClick() { }

	// RVA: 0x1985124 Offset: 0x1981124 VA: 0x1985124
	public void .ctor() { }
}
