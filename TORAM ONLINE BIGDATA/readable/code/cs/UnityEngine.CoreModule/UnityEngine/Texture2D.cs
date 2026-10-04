// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/GeneratedTextures.h")]
[ExcludeFromPreset]
[HelpURL("texture-type-default")]
[NativeHeader("Runtime/Graphics/Texture2D.h")]
[UsedByNativeCode]
public sealed class Texture2D : Texture // TypeDefIndex: 16280
{
	// Fields
	internal const int streamingMipmapsPriorityMin = -128;
	internal const int streamingMipmapsPriorityMax = 127;

	// Properties
	public TextureFormat format { get; }
	[StaticAccessor("builtintex", 2)]
	public static Texture2D blackTexture { get; }
	public override bool isReadable { get; }

	// Methods

	[NativeName("GetTextureFormat")]
	// RVA: 0x37DA220 Offset: 0x37D6220 VA: 0x37DA220
	public TextureFormat get_format() { }

	// RVA: 0x37DA25C Offset: 0x37D625C VA: 0x37DA25C
	public static Texture2D get_blackTexture() { }

	[FreeFunction("Texture2DScripting::Create")]
	// RVA: 0x37DA284 Offset: 0x37D6284 VA: 0x37DA284
	private static bool Internal_CreateImpl(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x37DA320 Offset: 0x37D6320 VA: 0x37DA320
	private static void Internal_Create(Texture2D mono, int w, int h, int mipCount, GraphicsFormat format, TextureColorSpace colorSpace, TextureCreationFlags flags, IntPtr nativeTex, string mipmapLimitGroupName) { }

	// RVA: 0x37DA414 Offset: 0x37D6414 VA: 0x37DA414 Slot: 8
	public override bool get_isReadable() { }

	[NativeName("Apply")]
	// RVA: 0x37DA450 Offset: 0x37D6450 VA: 0x37DA450
	private void ApplyImpl(bool updateMipmaps, bool makeNoLongerReadable) { }

	[NativeName("Reinitialize")]
	// RVA: 0x37DA4A4 Offset: 0x37D64A4 VA: 0x37DA4A4
	private bool ReinitializeImpl(int width, int height) { }

	[NativeName("SetPixel")]
	// RVA: 0x37DA4F8 Offset: 0x37D64F8 VA: 0x37DA4F8
	private void SetPixelImpl(int image, int mip, int x, int y, Color color) { }

	[NativeName("GetPixel")]
	// RVA: 0x37DA5F0 Offset: 0x37D65F0 VA: 0x37DA5F0
	private Color GetPixelImpl(int image, int mip, int x, int y) { }

	[FreeFunction(Name = "Texture2DScripting::SetPixels", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x37DA6EC Offset: 0x37D66EC VA: 0x37DA6EC
	private void SetPixelsImpl(int x, int y, int w, int h, Color[] pixel, int miplevel, int frame) { }

	[FreeFunction("Texture2DScripting::SetAllPixels32", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x37DA778 Offset: 0x37D6778 VA: 0x37DA778
	private void SetAllPixels32(Color32[] colors, int miplevel) { }

	[FreeFunction("Texture2DScripting::GetPixels", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x37DA7CC Offset: 0x37D67CC VA: 0x37DA7CC
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight, int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x37DA840 Offset: 0x37D6840 VA: 0x37DA840
	public Color[] GetPixels(int x, int y, int blockWidth, int blockHeight) { }

	[FreeFunction("Texture2DScripting::GetPixels32", HasExplicitThis = True, ThrowsException = True)]
	// RVA: 0x37DA8B0 Offset: 0x37D68B0 VA: 0x37DA8B0
	public Color32[] GetPixels32(int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x37DA8F4 Offset: 0x37D68F4 VA: 0x37DA8F4
	public Color32[] GetPixels32() { }

	[FreeFunction("Texture2DScripting::PackTextures", HasExplicitThis = True)]
	// RVA: 0x37DA934 Offset: 0x37D6934 VA: 0x37DA934
	public Rect[] PackTextures(Texture2D[] textures, int padding, int maximumAtlasSize, bool makeNoLongerReadable) { }

	// RVA: 0x37DA9A0 Offset: 0x37D69A0 VA: 0x37DA9A0
	internal bool ValidateFormat(TextureFormat format, int width, int height) { }

	// RVA: 0x37DAA80 Offset: 0x37D6A80 VA: 0x37DAA80
	internal void .ctor(int width, int height, TextureFormat textureFormat, int mipCount, bool linear, IntPtr nativeTex, bool createUninitialized, bool ignoreMipmapLimit, string mipmapLimitGroupName) { }

	// RVA: 0x37DAC24 Offset: 0x37D6C24 VA: 0x37DAC24
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain, bool linear) { }

	[ExcludeFromDocs]
	// RVA: 0x37DACE4 Offset: 0x37D6CE4 VA: 0x37DACE4
	public void .ctor(int width, int height, TextureFormat textureFormat, bool mipChain) { }

	[ExcludeFromDocs]
	// RVA: 0x37DADA0 Offset: 0x37D6DA0 VA: 0x37DADA0
	public void .ctor(int width, int height) { }

	[ExcludeFromDocs]
	// RVA: 0x37DAE3C Offset: 0x37D6E3C VA: 0x37DAE3C
	public void SetPixel(int x, int y, Color color) { }

	// RVA: 0x37DAED8 Offset: 0x37D6ED8 VA: 0x37DAED8
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors, int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x37DAF98 Offset: 0x37D6F98 VA: 0x37DAF98
	public void SetPixels(int x, int y, int blockWidth, int blockHeight, Color[] colors) { }

	[ExcludeFromDocs]
	// RVA: 0x37DAFA0 Offset: 0x37D6FA0 VA: 0x37DAFA0
	public void SetPixels(Color[] colors) { }

	[ExcludeFromDocs]
	// RVA: 0x37DAFFC Offset: 0x37D6FFC VA: 0x37DAFFC
	public Color GetPixel(int x, int y) { }

	// RVA: 0x37DB068 Offset: 0x37D7068 VA: 0x37DB068
	public void Apply(bool updateMipmaps, bool makeNoLongerReadable) { }

	[ExcludeFromDocs]
	// RVA: 0x37DB0F4 Offset: 0x37D70F4 VA: 0x37DB0F4
	public void Apply(bool updateMipmaps) { }

	[ExcludeFromDocs]
	// RVA: 0x37DB100 Offset: 0x37D7100 VA: 0x37DB100
	public void Apply() { }

	// RVA: 0x37DB10C Offset: 0x37D710C VA: 0x37DB10C
	public bool Reinitialize(int width, int height) { }

	// RVA: 0x37DB198 Offset: 0x37D7198 VA: 0x37DB198
	public void SetPixels32(Color32[] colors, int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x37DB1EC Offset: 0x37D71EC VA: 0x37DB1EC
	public void SetPixels32(Color32[] colors) { }

	// RVA: 0x37DB234 Offset: 0x37D7234 VA: 0x37DB234
	public Color[] GetPixels(int miplevel) { }

	[ExcludeFromDocs]
	// RVA: 0x37DB2C0 Offset: 0x37D72C0 VA: 0x37DB2C0
	public Color[] GetPixels() { }

	// RVA: 0x37DA57C Offset: 0x37D657C VA: 0x37DA57C
	private void SetPixelImpl_Injected(int image, int mip, int x, int y, ref Color color) { }

	// RVA: 0x37DA678 Offset: 0x37D6678 VA: 0x37DA678
	private void GetPixelImpl_Injected(int image, int mip, int x, int y, out Color ret) { }
}
