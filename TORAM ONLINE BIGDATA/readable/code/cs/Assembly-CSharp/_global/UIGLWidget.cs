// Assembly: Assembly-CSharp.dll
// Namespace: 
[ExecuteInEditMode]
public abstract class UIGLWidget : MonoBehaviour, IUIWidget // TypeDefIndex: 223
{
	// Fields
	[SerializeField]
	protected UIGLPanel commanderPanel; // 0x20
	[CompilerGenerated]
	private bool <initFlag>k__BackingField; // 0x28
	[SerializeField]
	protected byte atlasId; // 0x29
	[SerializeField]
	protected byte mDepth; // 0x2A

	// Properties
	protected bool initFlag { get; set; }
	public virtual byte AtlasId { get; set; }
	public byte depth { get; }
	public virtual Color color { get; set; }
	public virtual float alpha { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x21C72C0 Offset: 0x21C32C0 VA: 0x21C72C0
	protected bool get_initFlag() { }

	[CompilerGenerated]
	// RVA: 0x21C72C8 Offset: 0x21C32C8 VA: 0x21C72C8
	private void set_initFlag(bool value) { }

	// RVA: 0x21C72D4 Offset: 0x21C32D4 VA: 0x21C72D4 Slot: 8
	public virtual byte get_AtlasId() { }

	// RVA: 0x21C72DC Offset: 0x21C32DC VA: 0x21C72DC Slot: 9
	public virtual void set_AtlasId(byte value) { }

	// RVA: 0x21C72E0 Offset: 0x21C32E0 VA: 0x21C72E0
	public byte get_depth() { }

	// RVA: 0x21C72E8 Offset: 0x21C32E8 VA: 0x21C72E8 Slot: 10
	public virtual Color get_color() { }

	// RVA: 0x21C72FC Offset: 0x21C32FC VA: 0x21C72FC Slot: 11
	public virtual void set_color(Color value) { }

	// RVA: 0x21C7300 Offset: 0x21C3300 VA: 0x21C7300 Slot: 12
	public virtual float get_alpha() { }

	// RVA: 0x21C7308 Offset: 0x21C3308 VA: 0x21C7308 Slot: 13
	public virtual void set_alpha(float value) { }

	// RVA: 0x21C7318 Offset: 0x21C3318 VA: 0x21C7318
	private void Start() { }

	// RVA: 0x21BE538 Offset: 0x21BA538 VA: 0x21BE538 Slot: 14
	protected virtual void Initialize() { }

	// RVA: 0x21C7328 Offset: 0x21C3328 VA: 0x21C7328
	private void OnDestroy() { }

	// RVA: 0x21C73AC Offset: 0x21C33AC VA: 0x21C73AC Slot: 15
	public virtual bool OnAttlas(UIAtlas atlas) { }

	// RVA: 0x21C73B4 Offset: 0x21C33B4 VA: 0x21C73B4 Slot: 16
	public virtual bool OnUpdataFontAtlas(UIFont fontAtlas) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract bool OnDraw();

	// RVA: 0x21C73BC Offset: 0x21C33BC VA: 0x21C73BC
	public void SetCommandPanel(UIGLPanel commanderPanel) { }

	// RVA: 0x21BEF80 Offset: 0x21BAF80 VA: 0x21BEF80
	protected void .ctor() { }
}
