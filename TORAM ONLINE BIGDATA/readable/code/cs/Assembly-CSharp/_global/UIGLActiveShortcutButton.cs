// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UIGLActiveShortcutButton : UIActiveBaseShortcutButton // TypeDefIndex: 6523
{
	// Fields
	[SerializeField]
	private UIGLIcon icon; // 0x60
	[SerializeField]
	private UIGLSpriteTransition buttonSprite; // 0x68
	[SerializeField]
	private UIGLLabel typeLabel; // 0x70
	[SerializeField]
	private UIGLLabel extensionLabel; // 0x78
	private int buttonId; // 0x80
	private const int exLeftId = 8;
	private const int exRightId = 9;

	// Properties
	private bool IsExBottom { get; }

	// Methods

	// RVA: 0x1969BEC Offset: 0x1965BEC VA: 0x1969BEC
	private bool get_IsExBottom() { }

	// RVA: 0x1969C00 Offset: 0x1965C00 VA: 0x1969C00 Slot: 4
	protected override void Awake() { }

	// RVA: 0x1969C10 Offset: 0x1965C10 VA: 0x1969C10
	public void SetAlpha(float alpha) { }

	// RVA: 0x1969CCC Offset: 0x1965CCC VA: 0x1969CCC Slot: 5
	protected override void SetSprite(string name) { }

	// RVA: 0x1969D64 Offset: 0x1965D64 VA: 0x1969D64
	public void SetShortcutButton(ShortcutData.ShortcutType type, int id, int buttonId) { }

	// RVA: 0x1969DB0 Offset: 0x1965DB0 VA: 0x1969DB0 Slot: 8
	protected override void ScreenshotButton() { }

	// RVA: 0x1969E34 Offset: 0x1965E34 VA: 0x1969E34 Slot: 7
	protected override void GuardAvoid() { }

	// RVA: 0x1969ECC Offset: 0x1965ECC VA: 0x1969ECC Slot: 9
	protected override void ItemButton(int id) { }

	// RVA: 0x1969F58 Offset: 0x1965F58 VA: 0x1969F58 Slot: 10
	protected override void EmotionButton(int id) { }

	// RVA: 0x1969FE4 Offset: 0x1965FE4 VA: 0x1969FE4 Slot: 12
	protected override void SetSkillLabelData(int skillid, out bool isOverMp, out int mpCost) { }

	// RVA: 0x196A0AC Offset: 0x19660AC VA: 0x196A0AC Slot: 16
	protected override void MenuButton(int menuId) { }

	// RVA: 0x196A1E4 Offset: 0x19661E4 VA: 0x196A1E4 Slot: 19
	protected override void ClearButton() { }

	// RVA: 0x196A268 Offset: 0x1966268 VA: 0x196A268
	public void .ctor() { }
}
