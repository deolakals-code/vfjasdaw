// Assembly: mscorlib.dll
// Namespace: System.Text
internal static class StringBuilderCache // TypeDefIndex: 10041
{
	// Fields
	[ThreadStatic]
	private static StringBuilder t_cachedInstance; // 0x80000000

	// Methods

	// RVA: 0x2E8F46C Offset: 0x2E8B46C VA: 0x2E8F46C
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x2E8F540 Offset: 0x2E8B540 VA: 0x2E8F540
	public static void Release(StringBuilder sb) { }

	// RVA: 0x2E8F5C8 Offset: 0x2E8B5C8 VA: 0x2E8F5C8
	public static string GetStringAndRelease(StringBuilder sb) { }
}
