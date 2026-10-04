// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeClass("Rectf", "template<typename T> class RectT; typedef RectT<float> Rectf;")]
[NativeHeader("Runtime/Math/Rect.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
public struct Rect : IEquatable<Rect>, IFormattable // TypeDefIndex: 16230
{
	// Fields
	[NativeName("x")]
	private float m_XMin; // 0x0
	[NativeName("y")]
	private float m_YMin; // 0x4
	[NativeName("width")]
	private float m_Width; // 0x8
	[NativeName("height")]
	private float m_Height; // 0xC

	// Properties
	public static Rect zero { get; }
	public float x { get; set; }
	public float y { get; set; }
	public Vector2 center { get; }
	public float width { get; set; }
	public float height { get; set; }
	public float xMin { get; set; }
	public float yMin { get; set; }
	public float xMax { get; set; }
	public float yMax { get; set; }

	// Methods

	// RVA: 0x37D270C Offset: 0x37CE70C VA: 0x37D270C
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x37D2718 Offset: 0x37CE718 VA: 0x37D2718
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x37D2724 Offset: 0x37CE724 VA: 0x37D2724
	public static Rect get_zero() { }

	// RVA: 0x37D2738 Offset: 0x37CE738 VA: 0x37D2738
	public void Set(float x, float y, float width, float height) { }

	// RVA: 0x37D2744 Offset: 0x37CE744 VA: 0x37D2744
	public float get_x() { }

	// RVA: 0x37D274C Offset: 0x37CE74C VA: 0x37D274C
	public void set_x(float value) { }

	// RVA: 0x37D2754 Offset: 0x37CE754 VA: 0x37D2754
	public float get_y() { }

	// RVA: 0x37D275C Offset: 0x37CE75C VA: 0x37D275C
	public void set_y(float value) { }

	// RVA: 0x37D2764 Offset: 0x37CE764 VA: 0x37D2764
	public Vector2 get_center() { }

	// RVA: 0x37D277C Offset: 0x37CE77C VA: 0x37D277C
	public float get_width() { }

	// RVA: 0x37D2784 Offset: 0x37CE784 VA: 0x37D2784
	public void set_width(float value) { }

	// RVA: 0x37D278C Offset: 0x37CE78C VA: 0x37D278C
	public float get_height() { }

	// RVA: 0x37D2794 Offset: 0x37CE794 VA: 0x37D2794
	public void set_height(float value) { }

	// RVA: 0x37D279C Offset: 0x37CE79C VA: 0x37D279C
	public float get_xMin() { }

	// RVA: 0x37D27A4 Offset: 0x37CE7A4 VA: 0x37D27A4
	public void set_xMin(float value) { }

	// RVA: 0x37D27C0 Offset: 0x37CE7C0 VA: 0x37D27C0
	public float get_yMin() { }

	// RVA: 0x37D27C8 Offset: 0x37CE7C8 VA: 0x37D27C8
	public void set_yMin(float value) { }

	// RVA: 0x37D27E4 Offset: 0x37CE7E4 VA: 0x37D27E4
	public float get_xMax() { }

	// RVA: 0x37D27F4 Offset: 0x37CE7F4 VA: 0x37D27F4
	public void set_xMax(float value) { }

	// RVA: 0x37D2804 Offset: 0x37CE804 VA: 0x37D2804
	public float get_yMax() { }

	// RVA: 0x37D2814 Offset: 0x37CE814 VA: 0x37D2814
	public void set_yMax(float value) { }

	// RVA: 0x37D2824 Offset: 0x37CE824 VA: 0x37D2824
	public bool Contains(Vector2 point) { }

	// RVA: 0x37D2868 Offset: 0x37CE868 VA: 0x37D2868
	public bool Contains(Vector3 point) { }

	// RVA: 0x37D28AC Offset: 0x37CE8AC VA: 0x37D28AC
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x37D28E0 Offset: 0x37CE8E0 VA: 0x37D28E0
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x37D2914 Offset: 0x37CE914 VA: 0x37D2914 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37D299C Offset: 0x37CE99C VA: 0x37D299C Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37D2A88 Offset: 0x37CEA88 VA: 0x37D2A88 Slot: 4
	public bool Equals(Rect other) { }

	// RVA: 0x37D2B28 Offset: 0x37CEB28 VA: 0x37D2B28 Slot: 3
	public override string ToString() { }

	// RVA: 0x37D2B34 Offset: 0x37CEB34 VA: 0x37D2B34 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }
}
