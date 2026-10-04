// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Experimental.Rendering
[NativeHeader("Runtime/Graphics/Format.h")]
[NativeHeader("Runtime/Graphics/GraphicsFormatUtility.bindings.h")]
[NativeHeader("Runtime/Graphics/TextureFormat.h")]
public class GraphicsFormatUtility // TypeDefIndex: 16691
{
	// Fields
	private static readonly GraphicsFormat[] tableNoStencil; // 0x0
	private static readonly GraphicsFormat[] tableStencil; // 0x8

	// Methods

	// RVA: 0x37FFBF4 Offset: 0x37FBBF4 VA: 0x37FFBF4
	public static GraphicsFormat GetGraphicsFormat(TextureFormat format, bool isSRGB) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x37FFC78 Offset: 0x37FBC78 VA: 0x37FFC78
	private static GraphicsFormat GetGraphicsFormat_Native_TextureFormat(TextureFormat format, bool isSRGB) { }

	// RVA: 0x37FFCBC Offset: 0x37FBCBC VA: 0x37FFCBC
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, bool isSRGB) { }

	[FreeFunction(IsThreadSafe = False)]
	// RVA: 0x37FFD40 Offset: 0x37FBD40 VA: 0x37FFD40
	private static GraphicsFormat GetGraphicsFormat_Native_RenderTextureFormat(RenderTextureFormat format, bool isSRGB) { }

	// RVA: 0x37FFD84 Offset: 0x37FBD84 VA: 0x37FFD84
	public static GraphicsFormat GetGraphicsFormat(RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x37FFE0C Offset: 0x37FBE0C VA: 0x37FFE0C
	private static GraphicsFormat GetDepthStencilFormatFromBitsLegacy_Native(int minimumDepthBits) { }

	// RVA: 0x37FFE48 Offset: 0x37FBE48 VA: 0x37FFE48
	internal static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits) { }

	// RVA: 0x37FFEBC Offset: 0x37FBEBC VA: 0x37FFEBC
	public static GraphicsFormat GetDepthStencilFormat(int minimumDepthBits, int minimumStencilBits) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x38000B4 Offset: 0x37FC0B4 VA: 0x38000B4
	public static bool IsSRGBFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x38000F0 Offset: 0x37FC0F0 VA: 0x38000F0
	private static bool IsCompressedFormat_Native_TextureFormat(TextureFormat format) { }

	// RVA: 0x380012C Offset: 0x37FC12C VA: 0x380012C
	public static bool IsCompressedFormat(TextureFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x38001A0 Offset: 0x37FC1A0 VA: 0x38001A0
	private static bool CanDecompressFormat(GraphicsFormat format, bool wholeImage) { }

	// RVA: 0x38001E4 Offset: 0x37FC1E4 VA: 0x38001E4
	internal static bool CanDecompressFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x380025C Offset: 0x37FC25C VA: 0x380025C
	public static bool IsDepthStencilFormat(GraphicsFormat format) { }

	[FreeFunction(IsThreadSafe = True)]
	// RVA: 0x3800298 Offset: 0x37FC298 VA: 0x3800298
	public static bool IsPVRTCFormat(GraphicsFormat format) { }

	[FreeFunction("IsCompressedCrunchTextureFormat", IsThreadSafe = True)]
	// RVA: 0x38002D4 Offset: 0x37FC2D4 VA: 0x38002D4
	public static bool IsCrunchFormat(TextureFormat format) { }

	// RVA: 0x3800310 Offset: 0x37FC310 VA: 0x3800310
	private static void .cctor() { }
}
