// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MiniMapBaseData // TypeDefIndex: 6453
{
	// Fields
	private readonly Transform traceObject; // 0x10
	private bool areaCheck; // 0x18
	[CompilerGenerated]
	private bool <IsDraw>k__BackingField; // 0x19
	private Vector3 position; // 0x1C
	private Rect uv; // 0x28
	private Vector2 size; // 0x38
	protected Color color; // 0x40
	protected float scaling; // 0x50
	private string spriteName; // 0x58

	// Properties
	public bool IsDraw { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1939F28 Offset: 0x1935F28 VA: 0x1939F28
	public bool get_IsDraw() { }

	[CompilerGenerated]
	// RVA: 0x1939F30 Offset: 0x1935F30 VA: 0x1939F30
	private void set_IsDraw(bool value) { }

	// RVA: 0x1939F3C Offset: 0x1935F3C VA: 0x1939F3C
	public void .ctor(GameObject traceObject, bool areaCheck) { }

	// RVA: 0x193A0A8 Offset: 0x19360A8 VA: 0x193A0A8
	public void .ctor(GameObject traceObject, bool areaCheck, Color color) { }

	// RVA: 0x193A0E8 Offset: 0x19360E8 VA: 0x193A0E8
	public void .ctor(GameObject traceObject, bool areaCheck, string spriteName) { }

	// RVA: 0x193A118 Offset: 0x1936118 VA: 0x193A118
	public bool ContainsTraceObject(GameObject target) { }

	// RVA: 0x193A198 Offset: 0x1936198 VA: 0x193A198
	public void SettingAtlas(UIAtlas atlas) { }

	// RVA: 0x193A278 Offset: 0x1936278 VA: 0x193A278 Slot: 4
	public virtual bool Update(UIMiniMap minimap) { }

	// RVA: 0x193A440 Offset: 0x1936440 VA: 0x193A440 Slot: 5
	protected virtual Vector3 TracePosition() { }

	// RVA: 0x193A280 Offset: 0x1936280 VA: 0x193A280
	protected bool UpdatePosition(UIMiniMap minimap, bool mask) { }

	// RVA: 0x193A4FC Offset: 0x19364FC VA: 0x193A4FC Slot: 6
	public virtual void Draw(Vector3 transPos, Vector3 matrixScale) { }
}
