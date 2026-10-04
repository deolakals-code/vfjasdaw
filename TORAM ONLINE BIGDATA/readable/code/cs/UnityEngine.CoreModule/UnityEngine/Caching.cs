// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[StaticAccessor("GetCachingManager()", 0)]
[NativeHeader("Runtime/Misc/CachingManager.h")]
public sealed class Caching // TypeDefIndex: 16212
{
	// Properties
	public static bool ready { get; }

	// Methods

	[NativeName("GetIsReady")]
	// RVA: 0x37CDEB4 Offset: 0x37C9EB4 VA: 0x37CDEB4
	public static bool get_ready() { }

	// RVA: 0x37CDEDC Offset: 0x37C9EDC VA: 0x37CDEDC
	public static bool ClearCache() { }

	// RVA: 0x37CDF04 Offset: 0x37C9F04 VA: 0x37CDF04
	public static bool ClearAllCachedVersions(string assetBundleName) { }

	// RVA: 0x37CDF78 Offset: 0x37C9F78 VA: 0x37CDF78
	internal static bool ClearCachedVersions(string assetBundleName, Hash128 hash, bool keepInputVersion) { }

	// RVA: 0x37CE028 Offset: 0x37CA028 VA: 0x37CE028
	public static bool IsVersionCached(string url, Hash128 hash) { }

	[NativeName("IsCached")]
	// RVA: 0x37CE0E0 Offset: 0x37CA0E0 VA: 0x37CE0E0
	internal static bool IsVersionCached(string url, string assetBundleName, Hash128 hash) { }

	// RVA: 0x37CDFD4 Offset: 0x37C9FD4 VA: 0x37CDFD4
	private static bool ClearCachedVersions_Injected(string assetBundleName, ref Hash128 hash, bool keepInputVersion) { }

	// RVA: 0x37CE13C Offset: 0x37CA13C VA: 0x37CE13C
	private static bool IsVersionCached_Injected(string url, string assetBundleName, ref Hash128 hash) { }
}
