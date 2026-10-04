// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPlayerStatus.NewIconData // TypeDefIndex: 6552
{
	// Fields
	protected readonly float newsScalingTime; // 0x10
	private Vector2 size; // 0x14
	private Rect uv; // 0x1C
	private Func<bool> checkFunc; // 0x30
	private float scale; // 0x38
	protected Color setColor; // 0x3C
	protected float realtimeSinceStartup; // 0x4C
	[CompilerGenerated]
	private bool <Enabled>k__BackingField; // 0x50

	// Properties
	public bool Enabled { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x197FE54 Offset: 0x197BE54 VA: 0x197FE54
	public bool get_Enabled() { }

	[CompilerGenerated]
	// RVA: 0x197FE5C Offset: 0x197BE5C VA: 0x197FE5C
	private void set_Enabled(bool value) { }

	// RVA: 0x197E974 Offset: 0x197A974 VA: 0x197E974
	public void .ctor(UIAtlas atlas, string sprite, float scaling, Func<bool> check) { }

	// RVA: 0x197FE68 Offset: 0x197BE68 VA: 0x197FE68 Slot: 4
	public virtual bool Update(float nowTime) { }

	// RVA: 0x197FAB0 Offset: 0x197BAB0 VA: 0x197FAB0
	public void DrawIcon(Vector3 pos, Vector3 transScale) { }
}
