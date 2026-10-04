// Assembly: System.Xml.Linq.dll
// Namespace: System.Text
internal static class StringBuilderCache // TypeDefIndex: 17534
{
	// Fields
	[ThreadStatic]
	private static StringBuilder t_cachedInstance; // 0x80000000

	// Methods

	// RVA: 0x32BFAD8 Offset: 0x32BBAD8 VA: 0x32BFAD8
	public static StringBuilder Acquire(int capacity = 16) { }

	// RVA: 0x32C3B40 Offset: 0x32BFB40 VA: 0x32C3B40
	public static void Release(StringBuilder sb) { }

	// RVA: 0x32BFBA0 Offset: 0x32BBBA0 VA: 0x32BFBA0
	public static string GetStringAndRelease(StringBuilder sb) { }
}
