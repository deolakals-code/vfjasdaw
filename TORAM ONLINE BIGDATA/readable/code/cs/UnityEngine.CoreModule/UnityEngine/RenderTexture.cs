// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/RenderBufferManager.h")]
public class RenderTexture : Texture // TypeDefIndex: 16285
{
	// Properties
	public override int width { get; set; }
	public override int height { get; set; }
	public GraphicsFormat graphicsFormat { set; }
	public GraphicsFormat depthStencilFormat { set; }
	public RenderTextureDescriptor descriptor { get; }

	// Methods

	// RVA: 0x37DD5B4 Offset: 0x37D95B4 VA: 0x37DD5B4 Slot: 4
	public override int get_width() { }

	// RVA: 0x37DD5F0 Offset: 0x37D95F0 VA: 0x37DD5F0 Slot: 5
	public override void set_width(int value) { }

	// RVA: 0x37DD634 Offset: 0x37D9634 VA: 0x37DD634 Slot: 6
	public override int get_height() { }

	// RVA: 0x37DD670 Offset: 0x37D9670 VA: 0x37DD670 Slot: 7
	public override void set_height(int value) { }

	[NativeName("SetColorFormat")]
	// RVA: 0x37DD6B4 Offset: 0x37D96B4 VA: 0x37DD6B4
	private void SetColorFormat(GraphicsFormat format) { }

	// RVA: 0x37DD6F8 Offset: 0x37D96F8 VA: 0x37DD6F8
	public void set_graphicsFormat(GraphicsFormat value) { }

	// RVA: 0x37DD73C Offset: 0x37D973C VA: 0x37DD73C
	public void set_depthStencilFormat(GraphicsFormat value) { }

	// RVA: 0x37DD780 Offset: 0x37D9780 VA: 0x37DD780
	private void SetMipMapCount(int count) { }

	// RVA: 0x37DD7C4 Offset: 0x37D97C4 VA: 0x37DD7C4
	internal void SetSRGBReadWrite(bool srgb) { }

	[FreeFunction("RenderTextureScripting::Create")]
	// RVA: 0x37DD808 Offset: 0x37D9808 VA: 0x37DD808
	private static void Internal_Create(RenderTexture rt) { }

	[NativeName("SetRenderTextureDescFromScript")]
	// RVA: 0x37DD844 Offset: 0x37D9844 VA: 0x37DD844
	private void SetRenderTextureDescriptor(RenderTextureDescriptor desc) { }

	[NativeName("GetRenderTextureDesc")]
	// RVA: 0x37DD8CC Offset: 0x37D98CC VA: 0x37DD8CC
	private RenderTextureDescriptor GetDescriptor() { }

	[RequiredByNativeCode]
	// RVA: 0x37DD988 Offset: 0x37D9988 VA: 0x37DD988
	protected internal void .ctor() { }

	// RVA: 0x37DD9DC Offset: 0x37D99DC VA: 0x37DD9DC
	public void .ctor(RenderTextureDescriptor desc) { }

	// RVA: 0x37DDEBC Offset: 0x37D9EBC VA: 0x37DDEBC
	public void .ctor(RenderTexture textureToCopy) { }

	[ExcludeFromDocs]
	// RVA: 0x37DE0A8 Offset: 0x37DA0A8 VA: 0x37DE0A8
	public void .ctor(int width, int height, int depth, DefaultFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x37DE3D0 Offset: 0x37DA3D0 VA: 0x37DE3D0
	public void .ctor(int width, int height, int depth, GraphicsFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x37DE460 Offset: 0x37DA460 VA: 0x37DE460
	public void .ctor(int width, int height, int depth, GraphicsFormat format, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x37DE1CC Offset: 0x37DA1CC VA: 0x37DE1CC
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat, int mipCount) { }

	[ExcludeFromDocs]
	// RVA: 0x37DE6F8 Offset: 0x37DA6F8 VA: 0x37DE6F8
	public void .ctor(int width, int height, GraphicsFormat colorFormat, GraphicsFormat depthStencilFormat) { }

	// RVA: 0x37DE788 Offset: 0x37DA788 VA: 0x37DE788
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite) { }

	[ExcludeFromDocs]
	// RVA: 0x37DEA10 Offset: 0x37DAA10 VA: 0x37DEA10
	public void .ctor(int width, int height, int depth, RenderTextureFormat format) { }

	[ExcludeFromDocs]
	// RVA: 0x37DEB40 Offset: 0x37DAB40 VA: 0x37DEB40
	public void .ctor(int width, int height, int depth) { }

	[ExcludeFromDocs]
	// RVA: 0x37DEAA0 Offset: 0x37DAAA0 VA: 0x37DEAA0
	public void .ctor(int width, int height, int depth, RenderTextureFormat format, int mipCount) { }

	// RVA: 0x37DE830 Offset: 0x37DA830 VA: 0x37DE830
	private void Initialize(int width, int height, int depth, RenderTextureFormat format, RenderTextureReadWrite readWrite, int mipCount) { }

	// RVA: 0x37DE674 Offset: 0x37DA674 VA: 0x37DE674
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, GraphicsFormat colorFormat) { }

	// RVA: 0x37DEC98 Offset: 0x37DAC98 VA: 0x37DEC98
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, RenderTextureFormat format) { }

	// RVA: 0x37DED24 Offset: 0x37DAD24 VA: 0x37DED24
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, DefaultFormat format) { }

	// RVA: 0x37DECA4 Offset: 0x37DACA4 VA: 0x37DECA4
	internal static GraphicsFormat GetDepthStencilFormatLegacy(int depthBits, bool requestedShadowMap) { }

	// RVA: 0x37DE024 Offset: 0x37DA024 VA: 0x37DE024
	public RenderTextureDescriptor get_descriptor() { }

	// RVA: 0x37DDAD4 Offset: 0x37D9AD4 VA: 0x37DDAD4
	private static void ValidateRenderTextureDesc(RenderTextureDescriptor desc) { }

	// RVA: 0x37DE17C Offset: 0x37DA17C VA: 0x37DE17C
	internal static GraphicsFormat GetDefaultColorFormat(DefaultFormat format) { }

	// RVA: 0x37DE1A4 Offset: 0x37DA1A4 VA: 0x37DE1A4
	internal static GraphicsFormat GetDefaultDepthStencilFormat(DefaultFormat format, int depth) { }

	// RVA: 0x37DEB48 Offset: 0x37DAB48 VA: 0x37DEB48
	internal static GraphicsFormat GetCompatibleFormat(RenderTextureFormat renderTextureFormat, RenderTextureReadWrite readWrite) { }

	// RVA: 0x37DD888 Offset: 0x37D9888 VA: 0x37DD888
	private void SetRenderTextureDescriptor_Injected(ref RenderTextureDescriptor desc) { }

	// RVA: 0x37DD944 Offset: 0x37D9944 VA: 0x37DD944
	private void GetDescriptor_Injected(out RenderTextureDescriptor ret) { }
}
