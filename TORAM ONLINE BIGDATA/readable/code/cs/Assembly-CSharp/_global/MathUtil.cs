// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class MathUtil // TypeDefIndex: 5292
{
	// Methods

	// RVA: 0x2623CA0 Offset: 0x261FCA0 VA: 0x2623CA0
	public static byte[] Int32RGBAColorToByte(int param) { }

	// RVA: 0x2623D34 Offset: 0x261FD34 VA: 0x2623D34
	public static Color32 Int32RGBToColor32(int param) { }

	// RVA: 0x2623D48 Offset: 0x261FD48 VA: 0x2623D48
	public static Color Int32RGBToColor(int param) { }

	// RVA: 0x2623D7C Offset: 0x261FD7C VA: 0x2623D7C
	public static int Color32ToInt32RGB(Color32 color) { }

	// RVA: 0x2623D90 Offset: 0x261FD90 VA: 0x2623D90
	public static int Color32ToInt32RGB(byte colorR, byte colorG, byte colorB) { }

	// RVA: 0x2623DA8 Offset: 0x261FDA8 VA: 0x2623DA8
	public static short[] BaseServerPosition(Vector3 param) { }

	// RVA: 0x2623E9C Offset: 0x261FE9C VA: 0x2623E9C
	public static short[] BaseServerPosition(float[] param) { }

	// RVA: 0x2623FC0 Offset: 0x261FFC0 VA: 0x2623FC0
	public static float Int16ToDiv100Float(short param) { }

	// RVA: 0x2623FD8 Offset: 0x261FFD8 VA: 0x2623FD8
	public static float Int16ToDiv10Float(short param) { }

	// RVA: -1 Offset: -1
	public static void Swap<T>(ref T param1, ref T param2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D8038 Offset: 0x26D4038 VA: 0x26D8038
	|-MathUtil.Swap<object>
	|
	|-RVA: 0x26D806C Offset: 0x26D406C VA: 0x26D806C
	|-MathUtil.Swap<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2623FEC Offset: 0x261FFEC VA: 0x2623FEC
	public static float RelativeXZAngle(Vector3 dir, Vector3 targetDir) { }

	// RVA: 0x2624124 Offset: 0x2620124 VA: 0x2624124
	public static bool IsCapsuleAndSphereHit(Vector3 s, Vector3 e, float rad1, Vector3 c, float rad2) { }

	// RVA: 0x2624188 Offset: 0x2620188 VA: 0x2624188
	public static float GetLineSegmentDist2(Vector3 p, Vector3 s, Vector3 e) { }

	// RVA: 0x2624240 Offset: 0x2620240 VA: 0x2624240
	public static float DistanceToDisplayMeter(float dist) { }

	// RVA: 0x262424C Offset: 0x262024C VA: 0x262424C
	public static float DisplayMeterToDistance(float meter) { }

	// RVA: 0x2624254 Offset: 0x2620254 VA: 0x2624254
	public static int DisplayDistance(Vector3 playerPos, Vector3 mobPos, float mobSize) { }

	// RVA: 0x262434C Offset: 0x262034C VA: 0x262434C
	public static string ColorToLabelFormat(Color32 color) { }

	// RVA: 0x262440C Offset: 0x262040C VA: 0x262440C
	public static Vector3 Direction(Vector3 mine, Vector3 target, Transform mineActor) { }

	// RVA: 0x2624610 Offset: 0x2620610 VA: 0x2624610
	public static bool IsSectorAndCircleHit(Vector3 center, Vector3 forward, float rad, float angle, Vector3 target, float size) { }

	// RVA: 0x2624C30 Offset: 0x2620C30 VA: 0x2624C30
	public static float LineAndPointDist(Vector3 s, Vector3 e, Vector3 p) { }

	// RVA: 0x2624DE4 Offset: 0x2620DE4 VA: 0x2624DE4
	public static float CalcDistanceLineAndPoint(Vector3 s, Vector3 e, Vector3 p) { }

	// RVA: 0x2624AB4 Offset: 0x2620AB4 VA: 0x2624AB4
	public static bool IsCircleAndLineHit(Vector3 s, Vector3 e, Vector3 c, float rad) { }

	// RVA: 0x2624F00 Offset: 0x2620F00 VA: 0x2624F00
	public static bool CheckPercent(int percent) { }

	// RVA: 0x2624F28 Offset: 0x2620F28 VA: 0x2624F28
	public static bool IsCubeAndLineHit(Vector3[] p, int[] index, Vector3 s, Vector3 e) { }

	// RVA: 0x2625360 Offset: 0x2621360 VA: 0x2625360
	public static bool IsPlaneAndeLineHit(Vector3 p, Vector3 n, Vector3 s, Vector3 e, out Vector3 hit) { }

	// RVA: 0x26254A8 Offset: 0x26214A8 VA: 0x26254A8
	public static bool IsPolygonAndPointHit(Vector3[] polygon, Vector3 p) { }
}
