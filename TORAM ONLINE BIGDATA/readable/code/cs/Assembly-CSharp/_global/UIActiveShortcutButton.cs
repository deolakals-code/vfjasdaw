// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIActiveShortcutButton : UIActiveBaseShortcutButton // TypeDefIndex: 6476
{
	// Fields
	[SerializeField]
	private GameObject shortcutIconObject; // 0x60
	[SerializeField]
	private UISprite shortcutButtonSprite; // 0x68
	private UIIcon shortcutIcon; // 0x70
	[SerializeField]
	private UILabel shortcutTypeLabel; // 0x78
	[SerializeField]
	private UILabel extensionLabel; // 0x80

	// Properties
	private UIIcon ShortcutIcon { get; }

	// Methods

	// RVA: 0x194C580 Offset: 0x1948580 VA: 0x194C580
	private UIIcon get_ShortcutIcon() { }

	// RVA: 0x194C630 Offset: 0x1948630 VA: 0x194C630 Slot: 4
	protected override void Awake() { }

	// RVA: 0x194C650 Offset: 0x1948650 VA: 0x194C650 Slot: 5
	protected override void SetSprite(string name) { }

	// RVA: 0x194C6E8 Offset: 0x19486E8 VA: 0x194C6E8
	public void SetAlpha(float alpha) { }

	// RVA: 0x194C7A0 Offset: 0x19487A0 VA: 0x194C7A0
	public void .ctor() { }
}
