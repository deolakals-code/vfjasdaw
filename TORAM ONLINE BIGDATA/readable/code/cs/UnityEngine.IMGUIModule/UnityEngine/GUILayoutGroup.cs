// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
[VisibleToOtherModules(new[] { "UnityEngine.UIElementsModule", "Unity.UIElements" })]
internal class GUILayoutGroup : GUILayoutEntry // TypeDefIndex: 17045
{
	// Fields
	public List<GUILayoutEntry> entries; // 0x48
	public bool isVertical; // 0x50
	public bool resetCoords; // 0x51
	public float spacing; // 0x54
	public bool sameSize; // 0x58
	public bool isWindow; // 0x59
	public int windowID; // 0x5C
	private int m_Cursor; // 0x60
	protected int m_StretchableCountX; // 0x64
	protected int m_StretchableCountY; // 0x68
	protected bool m_UserSpecifiedWidth; // 0x6C
	protected bool m_UserSpecifiedHeight; // 0x6D
	protected float m_ChildMinWidth; // 0x70
	protected float m_ChildMaxWidth; // 0x74
	protected float m_ChildMinHeight; // 0x78
	protected float m_ChildMaxHeight; // 0x7C
	protected int m_MarginLeft; // 0x80
	protected int m_MarginRight; // 0x84
	protected int m_MarginTop; // 0x88
	protected int m_MarginBottom; // 0x8C
	private static readonly GUILayoutEntry none; // 0x0

	// Properties
	public override int marginLeft { get; }
	public override int marginRight { get; }
	public override int marginTop { get; }
	public override int marginBottom { get; }

	// Methods

	// RVA: 0x38108A8 Offset: 0x380C8A8 VA: 0x38108A8 Slot: 4
	public override int get_marginLeft() { }

	// RVA: 0x38108B0 Offset: 0x380C8B0 VA: 0x38108B0 Slot: 5
	public override int get_marginRight() { }

	// RVA: 0x38108B8 Offset: 0x380C8B8 VA: 0x38108B8 Slot: 6
	public override int get_marginTop() { }

	// RVA: 0x38108C0 Offset: 0x380C8C0 VA: 0x38108C0 Slot: 7
	public override int get_marginBottom() { }

	// RVA: 0x3809F80 Offset: 0x3805F80 VA: 0x3809F80
	public void .ctor() { }

	// RVA: 0x38108C8 Offset: 0x380C8C8 VA: 0x38108C8 Slot: 13
	public override void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x38109E8 Offset: 0x380C9E8 VA: 0x38109E8 Slot: 12
	protected override void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x380A63C Offset: 0x380663C VA: 0x380A63C
	public void ResetCursor() { }

	// RVA: 0x380ACDC Offset: 0x3806CDC VA: 0x380ACDC
	public GUILayoutEntry GetNext() { }

	// RVA: 0x380AB3C Offset: 0x3806B3C VA: 0x380AB3C
	public void Add(GUILayoutEntry e) { }

	// RVA: 0x3810A5C Offset: 0x380CA5C VA: 0x3810A5C Slot: 8
	public override void CalcWidth() { }

	// RVA: 0x3811108 Offset: 0x380D108 VA: 0x3811108 Slot: 10
	public override void SetHorizontal(float x, float width) { }

	// RVA: 0x3811944 Offset: 0x380D944 VA: 0x3811944 Slot: 9
	public override void CalcHeight() { }

	// RVA: 0x3811F40 Offset: 0x380DF40 VA: 0x3811F40 Slot: 11
	public override void SetVertical(float y, float height) { }

	// RVA: 0x3812788 Offset: 0x380E788 VA: 0x3812788 Slot: 3
	public override string ToString() { }

	// RVA: 0x3812B60 Offset: 0x380EB60 VA: 0x3812B60
	private static void .cctor() { }
}
