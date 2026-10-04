// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UISkillEquipLimitIcon : UIIcon // TypeDefIndex: 9033
{
	// Fields
	[SerializeField]
	private UIWidget[] widgetList; // 0x48
	[SerializeField]
	private UILabel typeText; // 0x50
	[SerializeField]
	private GameObject unavailableObj; // 0x58
	[CompilerGenerated]
	private string <LimitText>k__BackingField; // 0x60
	[CompilerGenerated]
	private bool <IsImpossible>k__BackingField; // 0x68

	// Properties
	public string LimitText { get; set; }
	public bool IsImpossible { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E9B0AC Offset: 0x1E970AC VA: 0x1E9B0AC
	public string get_LimitText() { }

	[CompilerGenerated]
	// RVA: 0x1E9B0B4 Offset: 0x1E970B4 VA: 0x1E9B0B4
	public void set_LimitText(string value) { }

	[CompilerGenerated]
	// RVA: 0x1E9B0BC Offset: 0x1E970BC VA: 0x1E9B0BC
	public bool get_IsImpossible() { }

	[CompilerGenerated]
	// RVA: 0x1E9B0C4 Offset: 0x1E970C4 VA: 0x1E9B0C4
	public void set_IsImpossible(bool value) { }

	// RVA: 0x1E9B0D0 Offset: 0x1E970D0 VA: 0x1E9B0D0
	public void SetLimitIcon(ItemType type, int ability = 0, string text = "") { }

	// RVA: 0x1E9B10C Offset: 0x1E9710C VA: 0x1E9B10C
	public void SetLimitIcon(string spriteName, string text = "") { }

	// RVA: 0x1E9B144 Offset: 0x1E97144 VA: 0x1E9B144
	public void SetUnavailableIconActive(bool isActive) { }

	// RVA: 0x1E9B164 Offset: 0x1E97164 VA: 0x1E9B164
	public void SetIconAlpha(float alpha) { }

	// RVA: 0x1E9B1D4 Offset: 0x1E971D4 VA: 0x1E9B1D4
	public void IconTweenAlpha(float duration, float alpha) { }

	// RVA: 0x1E9B254 Offset: 0x1E97254 VA: 0x1E9B254
	public void .ctor() { }
}
