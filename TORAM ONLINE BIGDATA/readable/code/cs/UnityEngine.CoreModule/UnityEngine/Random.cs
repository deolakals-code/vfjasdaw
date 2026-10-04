// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Export/Random/Random.bindings.h")]
public static class Random // TypeDefIndex: 16322
{
	// Properties
	public static float value { get; }
	public static Vector2 insideUnitCircle { get; }

	// Methods

	[FreeFunction]
	// RVA: 0x37E9404 Offset: 0x37E5404 VA: 0x37E9404
	public static float Range(float minInclusive, float maxInclusive) { }

	// RVA: 0x37E9444 Offset: 0x37E5444 VA: 0x37E9444
	public static int Range(int minInclusive, int maxExclusive) { }

	[FreeFunction]
	// RVA: 0x37E9488 Offset: 0x37E5488 VA: 0x37E9488
	private static int RandomRangeInt(int minInclusive, int maxExclusive) { }

	[FreeFunction]
	// RVA: 0x37E94CC Offset: 0x37E54CC VA: 0x37E94CC
	public static float get_value() { }

	[FreeFunction]
	// RVA: 0x37E94F4 Offset: 0x37E54F4 VA: 0x37E94F4
	private static void GetRandomUnitCircle(out Vector2 output) { }

	// RVA: 0x37E9530 Offset: 0x37E5530 VA: 0x37E9530
	public static Vector2 get_insideUnitCircle() { }
}
