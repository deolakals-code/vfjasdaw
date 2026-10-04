// Assembly: UnityEngine.AssetBundleModule.dll
// Namespace: UnityEngine
[NativeHeader("Modules/AssetBundle/Public/AssetBundleUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromMemoryAsyncOperation.h")]
[ExcludeFromPreset]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetOperation.h")]
[NativeHeader("Runtime/Scripting/ScriptingExportUtility.h")]
[NativeHeader("Runtime/Scripting/ScriptingObjectWithIntPtrField.h")]
[NativeHeader("Runtime/Scripting/ScriptingUtility.h")]
[NativeHeader("AssetBundleScriptingClasses.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleSaveAndLoadHelper.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadAssetUtility.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromManagedStreamAsyncOperation.h")]
[NativeHeader("Modules/AssetBundle/Public/AssetBundleLoadFromFileAsyncOperation.h")]
public class AssetBundle : Object // TypeDefIndex: 17825
{
	// Properties
	[Obsolete("mainAsset has been made obsolete. Please use the new AssetBundle build system introduced in 5.0 and check BuildAssetBundles documentation for details.")]
	public Object mainAsset { get; }

	// Methods

	// RVA: 0x37C9ECC Offset: 0x37C5ECC VA: 0x37C9ECC
	private void .ctor() { }

	// RVA: 0x37C9F24 Offset: 0x37C5F24 VA: 0x37C9F24
	public Object get_mainAsset() { }

	[FreeFunction("LoadMainObjectFromAssetBundle", True)]
	// RVA: 0x37C9F60 Offset: 0x37C5F60 VA: 0x37C9F60
	internal static Object returnMainAsset(AssetBundle bundle) { }

	[FreeFunction("LoadFromMemoryAsync")]
	// RVA: 0x37C9F9C Offset: 0x37C5F9C VA: 0x37C9F9C
	internal static AssetBundleCreateRequest LoadFromMemoryAsync_Internal(byte[] binary, uint crc) { }

	// RVA: 0x37C9FE0 Offset: 0x37C5FE0 VA: 0x37C9FE0
	public static AssetBundleCreateRequest LoadFromMemoryAsync(byte[] binary) { }

	[FreeFunction("LoadFromMemory")]
	// RVA: 0x37CA020 Offset: 0x37C6020 VA: 0x37CA020
	internal static AssetBundle LoadFromMemory_Internal(byte[] binary, uint crc) { }

	// RVA: 0x37CA064 Offset: 0x37C6064 VA: 0x37CA064
	public static AssetBundle LoadFromMemory(byte[] binary) { }

	[NativeMethod("Contains")]
	// RVA: 0x37CA0A4 Offset: 0x37C60A4 VA: 0x37CA0A4
	public bool Contains(string name) { }

	// RVA: 0x37CA0E8 Offset: 0x37C60E8 VA: 0x37CA0E8
	public Object LoadAsset(string name) { }

	[TypeInferenceRule(1)]
	// RVA: 0x37CA174 Offset: 0x37C6174 VA: 0x37CA174
	public Object LoadAsset(string name, Type type) { }

	[NativeThrows]
	[NativeMethod("LoadAsset_Internal")]
	[TypeInferenceRule(1)]
	// RVA: 0x37CA2BC Offset: 0x37C62BC VA: 0x37CA2BC
	private Object LoadAsset_Internal(string name, Type type) { }

	// RVA: 0x37CA310 Offset: 0x37C6310 VA: 0x37CA310
	public AssetBundleRequest LoadAssetAsync(string name, Type type) { }

	// RVA: 0x37CA4AC Offset: 0x37C64AC VA: 0x37CA4AC
	public Object[] LoadAllAssets() { }

	// RVA: 0x37CA530 Offset: 0x37C6530 VA: 0x37CA530
	public Object[] LoadAllAssets(Type type) { }

	[NativeThrows]
	[NativeMethod("LoadAssetAsync_Internal")]
	// RVA: 0x37CA458 Offset: 0x37C6458 VA: 0x37CA458
	private AssetBundleRequest LoadAssetAsync_Internal(string name, Type type) { }

	[NativeThrows]
	[NativeMethod("Unload")]
	// RVA: 0x37CA680 Offset: 0x37C6680 VA: 0x37CA680
	public void Unload(bool unloadAllLoadedObjects) { }

	[NativeThrows]
	[NativeMethod("LoadAssetWithSubAssets_Internal")]
	// RVA: 0x37CA62C Offset: 0x37C662C VA: 0x37CA62C
	internal Object[] LoadAssetWithSubAssets_Internal(string name, Type type) { }
}
