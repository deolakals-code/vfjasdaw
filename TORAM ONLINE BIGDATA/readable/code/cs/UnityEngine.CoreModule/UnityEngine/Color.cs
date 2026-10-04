// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Math/Color.h")]
[RequiredByNativeCode(Optional = True, GenerateProxy = True)]
[DefaultMember("Item")]
[NativeClass("ColorRGBAf")]
public struct Color : IEquatable<Color>, IFormattable // TypeDefIndex: 16296
{
	// Fields
	public float r; // 0x0
	public float g; // 0x4
	public float b; // 0x8
	public float a; // 0xC

	// Properties
	public static Color red { get; }
	public static Color green { get; }
	public static Color blue { get; }
	public static Color white { get; }
	public static Color black { get; }
	public static Color yellow { get; }
	public static Color cyan { get; }
	public static Color magenta { get; }
	public static Color gray { get; }
	public static Color grey { get; }
	public static Color clear { get; }
	public Color linear { get; }
	public float maxColorComponent { get; }

	// Methods

	// RVA: 0x37DFF74 Offset: 0x37DBF74 VA: 0x37DFF74
	public void .ctor(float r, float g, float b, float a) { }

	// RVA: 0x37DFF80 Offset: 0x37DBF80 VA: 0x37DFF80
	public void .ctor(float r, float g, float b) { }

	// RVA: 0x37DFF94 Offset: 0x37DBF94 VA: 0x37DFF94 Slot: 3
	public override string ToString() { }

	// RVA: 0x37DFFA4 Offset: 0x37DBFA4 VA: 0x37DFFA4 Slot: 5
	public string ToString(string format, IFormatProvider formatProvider) { }

	// RVA: 0x37E01DC Offset: 0x37DC1DC VA: 0x37E01DC Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37E0260 Offset: 0x37DC260 VA: 0x37E0260 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x37E0334 Offset: 0x37DC334 VA: 0x37E0334 Slot: 4
	public bool Equals(Color other) { }

	// RVA: 0x37E03B4 Offset: 0x37DC3B4 VA: 0x37E03B4
	public static Color op_Addition(Color a, Color b) { }

	// RVA: 0x37E03C8 Offset: 0x37DC3C8 VA: 0x37E03C8
	public static Color op_Subtraction(Color a, Color b) { }

	// RVA: 0x37E03DC Offset: 0x37DC3DC VA: 0x37E03DC
	public static Color op_Multiply(Color a, Color b) { }

	// RVA: 0x37E03F0 Offset: 0x37DC3F0 VA: 0x37E03F0
	public static Color op_Multiply(Color a, float b) { }

	// RVA: 0x37E0404 Offset: 0x37DC404 VA: 0x37E0404
	public static Color op_Division(Color a, float b) { }

	// RVA: 0x37E0418 Offset: 0x37DC418 VA: 0x37E0418
	public static bool op_Equality(Color lhs, Color rhs) { }

	// RVA: 0x37E0458 Offset: 0x37DC458 VA: 0x37E0458
	public static Color Lerp(Color a, Color b, float t) { }

	// RVA: 0x37E04A4 Offset: 0x37DC4A4 VA: 0x37E04A4
	internal Color RGBMultiplied(float multiplier) { }

	// RVA: 0x37E04C0 Offset: 0x37DC4C0 VA: 0x37E04C0
	public static Color get_red() { }

	// RVA: 0x37E04D4 Offset: 0x37DC4D4 VA: 0x37E04D4
	public static Color get_green() { }

	// RVA: 0x37E04E8 Offset: 0x37DC4E8 VA: 0x37E04E8
	public static Color get_blue() { }

	// RVA: 0x37E04FC Offset: 0x37DC4FC VA: 0x37E04FC
	public static Color get_white() { }

	// RVA: 0x37E0510 Offset: 0x37DC510 VA: 0x37E0510
	public static Color get_black() { }

	// RVA: 0x37E0524 Offset: 0x37DC524 VA: 0x37E0524
	public static Color get_yellow() { }

	// RVA: 0x37E0540 Offset: 0x37DC540 VA: 0x37E0540
	public static Color get_cyan() { }

	// RVA: 0x37E0554 Offset: 0x37DC554 VA: 0x37E0554
	public static Color get_magenta() { }

	// RVA: 0x37E0568 Offset: 0x37DC568 VA: 0x37E0568
	public static Color get_gray() { }

	// RVA: 0x37E057C Offset: 0x37DC57C VA: 0x37E057C
	public static Color get_grey() { }

	// RVA: 0x37E0590 Offset: 0x37DC590 VA: 0x37E0590
	public static Color get_clear() { }

	// RVA: 0x37E05A4 Offset: 0x37DC5A4 VA: 0x37E05A4
	public Color get_linear() { }

	// RVA: 0x37E0600 Offset: 0x37DC600 VA: 0x37E0600
	public float get_maxColorComponent() { }

	// RVA: 0x37E061C Offset: 0x37DC61C VA: 0x37E061C
	public static Vector4 op_Implicit(Color c) { }

	// RVA: 0x37E0620 Offset: 0x37DC620 VA: 0x37E0620
	public static Color op_Implicit(Vector4 v) { }
}
