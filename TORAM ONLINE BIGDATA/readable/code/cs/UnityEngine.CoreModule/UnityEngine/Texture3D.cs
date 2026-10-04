// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Texture3D.h")]
public sealed class Texture3D : Texture // TypeDefIndex: 16282
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x37DBB30 Offset: 0x37D7B30 VA: 0x37DBB30 Slot: 8
	public override bool get_isReadable() { }

	[FreeFunction("Texture3DScripting::Create")]
	// RVA: 0x37DBB6C Offset: 0x37D7B6C VA: 0x37DBB6C
	private static bool Internal_CreateImpl(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	// RVA: 0x37DBC08 Offset: 0x37D7C08 VA: 0x37DBC08
	private static void Internal_Create(Texture3D mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex) { }

	[ExcludeFromDocs]
	// RVA: 0x37DBCFC Offset: 0x37D7CFC VA: 0x37DBCFC
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x37DBDF0 Offset: 0x37D7DF0 VA: 0x37DBDF0
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	[ExcludeFromDocs]
	// RVA: 0x37DBD50 Offset: 0x37D7D50 VA: 0x37DBD50
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x37DBE54 Offset: 0x37D7E54 VA: 0x37DBE54
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x37DBF94 Offset: 0x37D7F94 VA: 0x37DBF94
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount) { }

	// RVA: 0x37DBFB4 Offset: 0x37D7FB4 VA: 0x37DBFB4
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex) { }

	// RVA: 0x37DBFD0 Offset: 0x37D7FD0 VA: 0x37DBFD0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, IntPtr nativeTex, bool createUninitialized) { }

	[ExcludeFromDocs]
	// RVA: 0x37DC134 Offset: 0x37D8134 VA: 0x37DC134
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x37DC1EC Offset: 0x37D81EC VA: 0x37DC1EC
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool createUninitialized) { }

	// RVA: 0x37DC2B0 Offset: 0x37D82B0 VA: 0x37DC2B0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, IntPtr nativeTex) { }

	// RVA: 0x37DBF40 Offset: 0x37D7F40 VA: 0x37DBF40
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }
}
