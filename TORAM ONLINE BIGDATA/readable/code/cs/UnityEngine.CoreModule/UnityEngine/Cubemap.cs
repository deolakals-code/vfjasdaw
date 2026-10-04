// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/CubemapTexture.h")]
[ExcludeFromPreset]
public sealed class Cubemap : Texture // TypeDefIndex: 16281
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	[FreeFunction("CubemapScripting::Create")]
	// RVA: 0x37DB2C8 Offset: 0x37D72C8 VA: 0x37DB2C8
	private static bool Internal_CreateImpl(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x37DB34C Offset: 0x37D734C VA: 0x37DB34C
	private static void Internal_Create(Cubemap mono, int ext, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x37DB420 Offset: 0x37D7420 VA: 0x37DB420 Slot: 8
	public override bool get_isReadable() { }

	// RVA: 0x37DB45C Offset: 0x37D745C VA: 0x37DB45C
	internal bool ValidateFormat(TextureFormat format, int width) { }

	// RVA: 0x37DB528 Offset: 0x37D7528 VA: 0x37DB528
	internal bool ValidateFormat(GraphicsFormat format, int width) { }

	[ExcludeFromDocs]
	// RVA: 0x37DB648 Offset: 0x37D7648 VA: 0x37DB648
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x37DB70C Offset: 0x37D770C VA: 0x37DB70C
	public void .ctor(int width, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	[RequiredByNativeCode]
	// RVA: 0x37DB684 Offset: 0x37D7684 VA: 0x37DB684
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x37DB758 Offset: 0x37D7758 VA: 0x37DB758
	public void .ctor(int width, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x37DB888 Offset: 0x37D7888 VA: 0x37DB888
	internal void .ctor(int width, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	// RVA: 0x37DB9E4 Offset: 0x37D79E4 VA: 0x37DB9E4
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x37DBA78 Offset: 0x37D7A78 VA: 0x37DBA78
	public void .ctor(int width, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x37DBB18 Offset: 0x37D7B18 VA: 0x37DBB18
	public void .ctor(int width, TextureFormat format, int mipCount) { }

	// RVA: 0x37DBB24 Offset: 0x37D7B24 VA: 0x37DBB24
	public void .ctor(int width, TextureFormat format, int mipCount, bool createUninitialized) { }

	// RVA: 0x37DB834 Offset: 0x37D7834 VA: 0x37DB834
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }
}
