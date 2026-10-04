// Assembly: UnityEngine.IMGUIModule.dll
// Namespace: UnityEngine
internal class GUILayoutEntry // TypeDefIndex: 17043
{
	// Fields
	public float minWidth; // 0x10
	public float maxWidth; // 0x14
	public float minHeight; // 0x18
	public float maxHeight; // 0x1C
	public Rect rect; // 0x20
	public int stretchWidth; // 0x30
	public int stretchHeight; // 0x34
	public bool consideredForMargin; // 0x38
	private GUIStyle m_Style; // 0x40
	internal static Rect kDummyRect; // 0x0
	protected static int indent; // 0x10

	// Properties
	public GUIStyle style { get; set; }
	public virtual int marginLeft { get; }
	public virtual int marginRight { get; }
	public virtual int marginTop { get; }
	public virtual int marginBottom { get; }
	public int marginHorizontal { get; }
	public int marginVertical { get; }

	// Methods

	// RVA: 0x380FBD8 Offset: 0x380BBD8 VA: 0x380FBD8
	public GUIStyle get_style() { }

	// RVA: 0x380A09C Offset: 0x380609C VA: 0x380A09C
	public void set_style(GUIStyle value) { }

	// RVA: 0x380FBE0 Offset: 0x380BBE0 VA: 0x380FBE0 Slot: 4
	public virtual int get_marginLeft() { }

	// RVA: 0x380FC04 Offset: 0x380BC04 VA: 0x380FC04 Slot: 5
	public virtual int get_marginRight() { }

	// RVA: 0x380FC28 Offset: 0x380BC28 VA: 0x380FC28 Slot: 6
	public virtual int get_marginTop() { }

	// RVA: 0x380FC4C Offset: 0x380BC4C VA: 0x380FC4C Slot: 7
	public virtual int get_marginBottom() { }

	// RVA: 0x380FC70 Offset: 0x380BC70 VA: 0x380FC70
	public int get_marginHorizontal() { }

	// RVA: 0x380FCAC Offset: 0x380BCAC VA: 0x380FCAC
	public int get_marginVertical() { }

	// RVA: 0x380FCE8 Offset: 0x380BCE8 VA: 0x380FCE8
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style) { }

	// RVA: 0x380ABEC Offset: 0x3806BEC VA: 0x380ABEC
	public void .ctor(float _minWidth, float _maxWidth, float _minHeight, float _maxHeight, GUIStyle _style, GUILayoutOption[] options) { }

	// RVA: 0x380FDD8 Offset: 0x380BDD8 VA: 0x380FDD8 Slot: 8
	public virtual void CalcWidth() { }

	// RVA: 0x380FDDC Offset: 0x380BDDC VA: 0x380FDDC Slot: 9
	public virtual void CalcHeight() { }

	// RVA: 0x380FDE0 Offset: 0x380BDE0 VA: 0x380FDE0 Slot: 10
	public virtual void SetHorizontal(float x, float width) { }

	// RVA: 0x380FDEC Offset: 0x380BDEC VA: 0x380FDEC Slot: 11
	public virtual void SetVertical(float y, float height) { }

	// RVA: 0x380FDF8 Offset: 0x380BDF8 VA: 0x380FDF8 Slot: 12
	protected virtual void ApplyStyleSettings(GUIStyle style) { }

	// RVA: 0x380FEFC Offset: 0x380BEFC VA: 0x380FEFC Slot: 13
	public virtual void ApplyOptions(GUILayoutOption[] options) { }

	// RVA: 0x38101D0 Offset: 0x380C1D0 VA: 0x38101D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x3810744 Offset: 0x380C744 VA: 0x3810744
	private static void .cctor() { }
}
