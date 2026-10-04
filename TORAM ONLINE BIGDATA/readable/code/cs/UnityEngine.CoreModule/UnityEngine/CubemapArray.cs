// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/CubemapArrayTexture.h")]
public sealed class CubemapArray : Texture // TypeDefIndex: 16284
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x37DCE38 Offset: 0x37D8E38 VA: 0x37DCE38 Slot: 8
	public override bool get_isReadable() { }

	[FreeFunction("CubemapArrayScripting::Create")]
	// RVA: 0x37DCE74 Offset: 0x37D8E74 VA: 0x37DCE74
	private static bool Internal_CreateImpl(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x37DCEF8 Offset: 0x37D8EF8 VA: 0x37DCEF8
	private static void Internal_Create(CubemapArray mono, int ext, int count, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x37DCFCC Offset: 0x37D8FCC VA: 0x37DCFCC
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x37DD0A8 Offset: 0x37D90A8 VA: 0x37DD0A8
	public void .ctor(int width, int cubemapCount, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	// RVA: 0x37DD018 Offset: 0x37D9018 VA: 0x37DD018
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x37DD0FC Offset: 0x37D90FC VA: 0x37DD0FC
	public void .ctor(int width, int cubemapCount, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x37DD23C Offset: 0x37D923C VA: 0x37DD23C
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x37DD3A8 Offset: 0x37D93A8 VA: 0x37DD3A8
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x37DD3B4 Offset: 0x37D93B4 VA: 0x37DD3B4
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	[ExcludeFromDocs]
	// RVA: 0x37DD468 Offset: 0x37D9468 VA: 0x37DD468
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain, bool linear) { }

	// RVA: 0x37DD510 Offset: 0x37D9510 VA: 0x37DD510
	public void .ctor(int width, int cubemapCount, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x37DD1E8 Offset: 0x37D91E8 VA: 0x37DD1E8
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }
}
