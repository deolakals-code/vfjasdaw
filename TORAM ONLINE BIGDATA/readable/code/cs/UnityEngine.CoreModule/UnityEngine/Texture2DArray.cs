// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Texture2DArray.h")]
[ExcludeFromPreset]
public sealed class Texture2DArray : Texture // TypeDefIndex: 16283
{
	// Properties
	public override bool isReadable { get; }

	// Methods

	// RVA: 0x37DC374 Offset: 0x37D8374 VA: 0x37DC374 Slot: 8
	public override bool get_isReadable() { }

	[FreeFunction("Texture2DArrayScripting::Create")]
	// RVA: 0x37DC3B0 Offset: 0x37D83B0 VA: 0x37DC3B0
	private static bool Internal_CreateImpl(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x37DC43C Offset: 0x37D843C VA: 0x37DC43C
	private static void Internal_Create(Texture2DArray mono, int w, int h, int d, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags) { }

	// RVA: 0x37DC518 Offset: 0x37D8518 VA: 0x37DC518
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x37DC5F8 Offset: 0x37D85F8 VA: 0x37DC5F8
	internal bool ValidateFormat(GraphicsFormat format, int width, int height) { }

	[ExcludeFromDocs]
	// RVA: 0x37DC724 Offset: 0x37D8724 VA: 0x37DC724
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x37DC818 Offset: 0x37D8818 VA: 0x37DC818
	public void .ctor(int width, int height, int depth, DefaultFormat format, TextureCreationFlags flags, int mipCount) { }

	[RequiredByNativeCode]
	// RVA: 0x37DC778 Offset: 0x37D8778 VA: 0x37DC778
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags) { }

	[ExcludeFromDocs]
	// RVA: 0x37DC978 Offset: 0x37D8978 VA: 0x37DC978
	public void .ctor(int width, int height, int depth, GraphicsFormat format, TextureCreationFlags flags, int mipCount) { }

	// RVA: 0x37DCA64 Offset: 0x37D8A64 VA: 0x37DCA64
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear, bool createUninitialized) { }

	// RVA: 0x37DCBE0 Offset: 0x37D8BE0 VA: 0x37DCBE0
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, int mipCount, bool linear) { }

	// RVA: 0x37DCC00 Offset: 0x37D8C00 VA: 0x37DCC00
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear, bool createUninitialized) { }

	// RVA: 0x37DCCBC Offset: 0x37D8CBC VA: 0x37DCCBC
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[ExcludeFromDocs]
	// RVA: 0x37DCD80 Offset: 0x37D8D80 VA: 0x37DCD80
	public void .ctor(int width, int height, int depth, TextureFormat textureFormat, bool mipChain) { }

	// RVA: 0x37DC924 Offset: 0x37D8924 VA: 0x37DC924
	private static void ValidateIsNotCrunched(TextureCreationFlags flags) { }
}
