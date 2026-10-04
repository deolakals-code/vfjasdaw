// Assembly: Assembly-CSharp.dll
// Namespace: 
public static class SkeletonRouteSearch // TypeDefIndex: 2893
{
	// Fields
	private static float gridSize; // 0x0
	private static float moveHeightLimit; // 0x4
	private static List<ValueTuple<short, short>> shiftDir; // 0x8

	// Methods

	// RVA: 0x22BD9D4 Offset: 0x22B99D4 VA: 0x22BD9D4
	public static void CheckRoute(Vector3 start, Vector3 end, float targetSize, out List<Vector3> routePointList) { }

	// RVA: 0x22BF338 Offset: 0x22BB338 VA: 0x22BF338
	private static List<SkeletonRouteSearch.PointData> ShorteningRoute(List<SkeletonRouteSearch.PointData> pointRoute) { }

	// RVA: 0x22BEEBC Offset: 0x22BAEBC VA: 0x22BEEBC
	private static bool CheckFloor(ValueTuple<short, short> gridPos, float posY, out float floorY) { }

	// RVA: 0x22BF0D8 Offset: 0x22BB0D8 VA: 0x22BF0D8
	private static bool CheckWall(Vector3 start, ValueTuple<int, int> endPos, float posY) { }

	// RVA: 0x22BF888 Offset: 0x22BB888 VA: 0x22BF888
	private static void .cctor() { }
}
