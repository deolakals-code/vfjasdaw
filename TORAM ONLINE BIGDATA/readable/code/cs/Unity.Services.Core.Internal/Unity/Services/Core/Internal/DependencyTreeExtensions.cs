// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
[Extension]
internal static class DependencyTreeExtensions // TypeDefIndex: 17568
{
	// Methods

	[Extension]
	// RVA: 0x37AD0C0 Offset: 0x37A90C0 VA: 0x37AD0C0
	internal static string ToJson(DependencyTree tree, ICollection<int> order) { }

	[Extension]
	// RVA: 0x37AE378 Offset: 0x37AA378 VA: 0x37AE378
	internal static bool IsOptional(DependencyTree tree, int componentTypeHash) { }

	[Extension]
	// RVA: 0x37AE3F8 Offset: 0x37AA3F8 VA: 0x37AE3F8
	internal static bool IsProvided(DependencyTree tree, int componentTypeHash) { }

	// RVA: 0x37AD880 Offset: 0x37A9880 VA: 0x37AD880
	private static JObject GetPackageJObject(DependencyTree tree, int packageHash) { }

	// RVA: 0x37ADFE8 Offset: 0x37A9FE8 VA: 0x37ADFE8
	private static JObject GetComponentJObject(DependencyTree tree, int componentHash) { }

	// RVA: 0x37AE454 Offset: 0x37AA454 VA: 0x37AE454
	private static string GetComponentIdentifier(IServiceComponent component) { }
}
