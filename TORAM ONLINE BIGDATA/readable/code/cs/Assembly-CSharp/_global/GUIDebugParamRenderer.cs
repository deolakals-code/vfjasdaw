// Assembly: Assembly-CSharp.dll
// Namespace: 
public class GUIDebugParamRenderer : MonoBehaviour // TypeDefIndex: 1888
{
	// Fields
	protected static readonly int screen_width; // 0x0
	protected static readonly int screen_height; // 0x4
	protected static readonly int dia_x; // 0x8
	private Vector2 scrollPosition; // 0x20
	private float scrollSpeed; // 0x28
	private List<GUIDebugParamRenderer.IRenderObject> drawTargetList; // 0x30
	[CompilerGenerated]
	private bool <VisibleWindow>k__BackingField; // 0x38
	[CompilerGenerated]
	private string <VisibleString>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <InVisibleString>k__BackingField; // 0x48

	// Properties
	protected bool VisibleWindow { get; set; }
	protected string VisibleString { get; set; }
	protected string InVisibleString { get; set; }

	// Methods

	// RVA: 0x20F9C18 Offset: 0x20F5C18 VA: 0x20F9C18
	public void SetTarget(string name, IEnumerable<string> target) { }

	// RVA: 0x20F9D2C Offset: 0x20F5D2C VA: 0x20F9D2C
	protected void SetFanc(string name, Action<float> act) { }

	// RVA: 0x20F9A08 Offset: 0x20F5A08 VA: 0x20F9A08
	protected void SetOnceFunc(string name, Action<float> act) { }

	// RVA: 0x20F9E48 Offset: 0x20F5E48 VA: 0x20F9E48
	public void ClearTarget() { }

	[CompilerGenerated]
	// RVA: 0x20F9EB4 Offset: 0x20F5EB4 VA: 0x20F9EB4
	protected bool get_VisibleWindow() { }

	[CompilerGenerated]
	// RVA: 0x20F9EBC Offset: 0x20F5EBC VA: 0x20F9EBC
	protected void set_VisibleWindow(bool value) { }

	[CompilerGenerated]
	// RVA: 0x20F9EC8 Offset: 0x20F5EC8 VA: 0x20F9EC8
	protected string get_VisibleString() { }

	[CompilerGenerated]
	// RVA: 0x20F9ED0 Offset: 0x20F5ED0 VA: 0x20F9ED0
	protected void set_VisibleString(string value) { }

	[CompilerGenerated]
	// RVA: 0x20F9ED8 Offset: 0x20F5ED8 VA: 0x20F9ED8
	protected string get_InVisibleString() { }

	[CompilerGenerated]
	// RVA: 0x20F9EE0 Offset: 0x20F5EE0 VA: 0x20F9EE0
	protected void set_InVisibleString(string value) { }

	// RVA: 0x20F9EE8 Offset: 0x20F5EE8 VA: 0x20F9EE8
	private void Awake() { }

	// RVA: 0x20F9F64 Offset: 0x20F5F64 VA: 0x20F9F64 Slot: 4
	protected virtual void OnGUI() { }

	// RVA: 0x20F9F68 Offset: 0x20F5F68 VA: 0x20F9F68 Slot: 5
	protected virtual void OnVisibleButton(bool visible) { }

	// RVA: 0x20F9F6C Offset: 0x20F5F6C VA: 0x20F9F6C Slot: 6
	protected virtual void AppendGUI() { }

	// RVA: 0x20F9534 Offset: 0x20F5534 VA: 0x20F9534
	public void .ctor() { }

	// RVA: 0x20F9F70 Offset: 0x20F5F70 VA: 0x20F9F70
	private static void .cctor() { }
}
