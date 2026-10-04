// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.U2D
[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
[NativeHeader("Runtime/2D/SpriteAtlas/SpriteAtlasManager.h")]
[StaticAccessor("GetSpriteAtlasManager()", 0)]
public class SpriteAtlasManager // TypeDefIndex: 16408
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<string, Action<SpriteAtlas>> atlasRequested; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action<SpriteAtlas> atlasRegistered; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x37F4414 Offset: 0x37F0414 VA: 0x37F4414
	private static bool RequestAtlas(string tag) { }

	[RequiredByNativeCode]
	// RVA: 0x37F44C8 Offset: 0x37F04C8 VA: 0x37F44C8
	private static void PostRegisteredAtlas(SpriteAtlas spriteAtlas) { }

	// RVA: 0x37F4534 Offset: 0x37F0534 VA: 0x37F4534
	internal static void Register(SpriteAtlas spriteAtlas) { }
}
