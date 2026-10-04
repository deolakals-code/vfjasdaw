// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SnowballColorShadow : MonoBehaviour // TypeDefIndex: 4492
{
	// Fields
	private GameObject shadowObj; // 0x20
	private FieldAreaManager fieldAreaManager; // 0x28
	private FieldRayPick fieldRayPick; // 0x30
	private bool isColorLock; // 0x38
	private Renderer[] shadowRenderer; // 0x40
	private Dictionary<Material, bool> materialList; // 0x48
	private Coroutine initCoroutine; // 0x50
	private Color shadowColor; // 0x58

	// Properties
	public bool IsColorLock { get; }

	// Methods

	// RVA: 0x2503754 Offset: 0x24FF754 VA: 0x2503754
	public bool get_IsColorLock() { }

	// RVA: 0x250375C Offset: 0x24FF75C VA: 0x250375C
	private void Start() { }

	// RVA: 0x25037F8 Offset: 0x24FF7F8 VA: 0x25037F8
	private void LateUpdate() { }

	// RVA: 0x250400C Offset: 0x250000C VA: 0x250400C
	private void OnDestroy() { }

	// RVA: 0x25040AC Offset: 0x25000AC VA: 0x25040AC
	private void OnDisable() { }

	// RVA: 0x25040C4 Offset: 0x25000C4 VA: 0x25040C4
	public void SetFixColor(float r, float g, float b) { }

	// RVA: 0x25042F8 Offset: 0x25002F8 VA: 0x25042F8
	public void SetFixColorRed() { }

	// RVA: 0x250432C Offset: 0x250032C VA: 0x250432C
	public void SetFixColorBlue() { }

	// RVA: 0x2504360 Offset: 0x2500360 VA: 0x2504360
	public void SetColor(float r, float g, float b) { }

	[IteratorStateMachine(typeof(SnowballColorShadow.<Initialize>d__18))]
	// RVA: 0x250378C Offset: 0x24FF78C VA: 0x250378C
	private IEnumerator Initialize() { }

	[IteratorStateMachine(typeof(SnowballColorShadow.<CreateShadowObj>d__19))]
	// RVA: 0x2504390 Offset: 0x2500390 VA: 0x2504390
	private IEnumerator CreateShadowObj() { }

	// RVA: 0x25040E8 Offset: 0x25000E8 VA: 0x25040E8
	private bool SetShadowColor(float r, float g, float b) { }

	// RVA: 0x2504424 Offset: 0x2500424 VA: 0x2504424
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x25044B8 Offset: 0x25004B8 VA: 0x25044B8
	private void <CreateShadowObj>b__19_0(bool isCreate, GameObject shadow) { }
}
