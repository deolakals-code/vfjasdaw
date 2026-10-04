// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/IMGUI/GUISkin.bindings.h")]
[Serializable]
public sealed class GUISettings // TypeDefIndex: 17033
{
	// Fields
	[SerializeField]
	private bool m_DoubleClickSelectsWord; // 0x10
	[SerializeField]
	private bool m_TripleClickSelectsLine; // 0x11
	[SerializeField]
	private Color m_CursorColor; // 0x14
	[SerializeField]
	private float m_CursorFlashSpeed; // 0x24
	[SerializeField]
	private Color m_SelectionColor; // 0x28

	// Properties
	public bool doubleClickSelectsWord { get; }
	public bool tripleClickSelectsLine { get; }
	public Color cursorColor { get; }
	public float cursorFlashSpeed { get; }
	public Color selectionColor { get; }

	// Methods

	// RVA: 0x380B0DC Offset: 0x38070DC VA: 0x380B0DC
	private static float Internal_GetCursorFlashSpeed() { }

	// RVA: 0x38070D0 Offset: 0x38030D0 VA: 0x38070D0
	public bool get_doubleClickSelectsWord() { }

	// RVA: 0x3807160 Offset: 0x3803160 VA: 0x3807160
	public bool get_tripleClickSelectsLine() { }

	// RVA: 0x380B104 Offset: 0x3807104 VA: 0x380B104
	public Color get_cursorColor() { }

	// RVA: 0x380B110 Offset: 0x3807110 VA: 0x380B110
	public float get_cursorFlashSpeed() { }

	// RVA: 0x380B14C Offset: 0x380714C VA: 0x380B14C
	public Color get_selectionColor() { }

	// RVA: 0x380B158 Offset: 0x3807158 VA: 0x380B158
	public void .ctor() { }
}
