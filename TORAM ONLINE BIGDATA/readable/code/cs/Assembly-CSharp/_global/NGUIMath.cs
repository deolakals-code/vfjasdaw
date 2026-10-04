// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class NGUIMath // TypeDefIndex: 74
{
	// Methods

	// RVA: 0x172C540 Offset: 0x1728540 VA: 0x172C540
	public static float Lerp(float from, float to, float factor) { }

	// RVA: 0x172C558 Offset: 0x1728558 VA: 0x172C558
	public static int ClampIndex(int val, int max) { }

	// RVA: 0x172C574 Offset: 0x1728574 VA: 0x172C574
	public static int RepeatIndex(int val, int max) { }

	// RVA: 0x172C5A4 Offset: 0x17285A4 VA: 0x172C5A4
	public static float WrapAngle(float angle) { }

	// RVA: 0x172C600 Offset: 0x1728600 VA: 0x172C600
	public static float Wrap01(float val) { }

	// RVA: 0x172C678 Offset: 0x1728678 VA: 0x172C678
	public static int HexToDecimal(char ch) { }

	// RVA: 0x172C6A4 Offset: 0x17286A4 VA: 0x172C6A4
	public static char DecimalToHexChar(int num) { }

	// RVA: 0x172C6CC Offset: 0x17286CC VA: 0x172C6CC
	public static string DecimalToHex(int num) { }

	// RVA: 0x172C72C Offset: 0x172872C VA: 0x172C72C
	public static int ColorToInt(Color c) { }

	// RVA: 0x172CA60 Offset: 0x1728A60 VA: 0x172CA60
	public static Color IntToColor(int val) { }

	// RVA: 0x172CA9C Offset: 0x1728A9C VA: 0x172CA9C
	public static string IntToBinary(int val, int bits) { }

	// RVA: 0x172CBBC Offset: 0x1728BBC VA: 0x172CBBC
	public static Color HexToColor(uint val) { }

	// RVA: 0x172A2A4 Offset: 0x17262A4 VA: 0x172A2A4
	public static Rect ConvertToTexCoords(Rect rect, int width, int height) { }

	// RVA: 0x172CBF8 Offset: 0x1728BF8 VA: 0x172CBF8
	public static Rect ConvertToPixels(Rect rect, int width, int height, bool round) { }

	// RVA: 0x172CF9C Offset: 0x1728F9C VA: 0x172CF9C
	public static Rect MakePixelPerfect(Rect rect) { }

	// RVA: 0x172D2DC Offset: 0x17292DC VA: 0x172D2DC
	public static Rect MakePixelPerfect(Rect rect, int width, int height) { }

	// RVA: 0x172D63C Offset: 0x172963C VA: 0x172D63C
	public static Vector3 ApplyHalfPixelOffset(Vector3 pos) { }

	// RVA: 0x172D6D8 Offset: 0x17296D8 VA: 0x172D6D8
	public static Vector3 ApplyHalfPixelOffset(Vector3 pos, Vector3 scale) { }

	// RVA: 0x172DA78 Offset: 0x1729A78 VA: 0x172DA78
	public static Vector2 ConstrainRect(Vector2 minRect, Vector2 maxRect, Vector2 minArea, Vector2 maxArea) { }

	// RVA: 0x172DB78 Offset: 0x1729B78 VA: 0x172DB78
	public static Bounds CalculateAbsoluteWidgetBounds(Transform trans) { }

	// RVA: 0x1726E54 Offset: 0x1722E54 VA: 0x1726E54
	public static Bounds CalculateRelativeWidgetBounds(Transform trans) { }

	// RVA: 0x172E204 Offset: 0x172A204 VA: 0x172E204
	public static Bounds CalculateRelativeWidgetBounds(Transform trans, bool considerInactive) { }

	// RVA: 0x172E23C Offset: 0x172A23C VA: 0x172E23C
	public static Bounds CalculateRelativeWidgetBounds(Transform root, Transform child) { }

	// RVA: 0x172DF14 Offset: 0x1729F14 VA: 0x172DF14
	public static Bounds CalculateRelativeWidgetBounds(Transform root, Transform child, bool considerInactive) { }

	// RVA: 0x172E270 Offset: 0x172A270 VA: 0x172E270
	public static Bounds CalculateRelativeInnerBounds(Transform root, UISprite sprite) { }

	// RVA: 0x172E6B8 Offset: 0x172A6B8 VA: 0x172E6B8
	public static Vector3 SpringDampen(ref Vector3 velocity, float strength, float deltaTime) { }

	// RVA: 0x172E838 Offset: 0x172A838 VA: 0x172E838
	public static Vector2 SpringDampen(ref Vector2 velocity, float strength, float deltaTime) { }

	// RVA: 0x172E9A4 Offset: 0x172A9A4 VA: 0x172E9A4
	public static float SpringLerp(float strength, float deltaTime) { }

	// RVA: 0x172EAD8 Offset: 0x172AAD8 VA: 0x172EAD8
	public static float SpringLerp(float from, float to, float strength, float deltaTime) { }

	// RVA: 0x172EC18 Offset: 0x172AC18 VA: 0x172EC18
	public static Vector2 SpringLerp(Vector2 from, Vector2 to, float strength, float deltaTime) { }

	// RVA: 0x172EC7C Offset: 0x172AC7C VA: 0x172EC7C
	public static Vector3 SpringLerp(Vector3 from, Vector3 to, float strength, float deltaTime) { }

	// RVA: 0x172ECFC Offset: 0x172ACFC VA: 0x172ECFC
	public static Quaternion SpringLerp(Quaternion from, Quaternion to, float strength, float deltaTime) { }

	// RVA: 0x172ED80 Offset: 0x172AD80 VA: 0x172ED80
	public static float RotateTowards(float from, float to, float maxAngle) { }

	// RVA: 0x172EDFC Offset: 0x172ADFC VA: 0x172EDFC
	private static float DistancePointToLineSegment(Vector2 point, Vector2 a, Vector2 b) { }

	// RVA: 0x172EF20 Offset: 0x172AF20 VA: 0x172EF20
	public static float DistanceToRectangle(Vector2[] screenPoints, Vector2 mousePos) { }

	// RVA: 0x172F084 Offset: 0x172B084 VA: 0x172F084
	public static float DistanceToRectangle(Vector3[] worldPoints, Vector2 mousePos, Camera cam) { }

	// RVA: 0x172F168 Offset: 0x172B168 VA: 0x172F168
	public static Vector2 GetPivotOffset(UIWidget.Pivot pv) { }
}
