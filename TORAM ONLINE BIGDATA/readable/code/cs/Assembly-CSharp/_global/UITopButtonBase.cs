// Assembly: Assembly-CSharp.dll
// Namespace: 
public class UITopButtonBase : MonoBehaviour // TypeDefIndex: 6536
{
	// Fields
	[SerializeField]
	protected Vector3 fadeInMove; // 0x20
	[SerializeField]
	protected UILabel buttonLabel; // 0x30
	protected UIIcon icon; // 0x38
	protected List<UISprite> subIcons; // 0x40
	protected SystemTextManager systemTextManager; // 0x48
	[CompilerGenerated]
	private UITopButtonBase.ActionSystemType <SystemType>k__BackingField; // 0x50

	// Properties
	public UITopButtonBase.ActionSystemType SystemType { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x19706A4 Offset: 0x196C6A4 VA: 0x19706A4
	protected void set_SystemType(UITopButtonBase.ActionSystemType value) { }

	[CompilerGenerated]
	// RVA: 0x19706AC Offset: 0x196C6AC VA: 0x19706AC
	public UITopButtonBase.ActionSystemType get_SystemType() { }

	// RVA: 0x19706B4 Offset: 0x196C6B4 VA: 0x19706B4 Slot: 4
	public virtual void SetLabel(string text, string iconSprite) { }

	// RVA: 0x19708B0 Offset: 0x196C8B0 VA: 0x19708B0 Slot: 5
	public virtual void SetLabel(string text, string[] iconSprites) { }

	// RVA: 0x1970B80 Offset: 0x196CB80 VA: 0x1970B80
	public void SetButtonLabel(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x1971048 Offset: 0x196D048 VA: 0x1971048
	public void SetButtonType(UITopButtonBase.ActionSystemType type) { }

	// RVA: 0x1971050 Offset: 0x196D050 VA: 0x1971050
	public void .ctor() { }
}
