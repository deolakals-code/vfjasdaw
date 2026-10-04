// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
public struct RenderTextureDescriptor // TypeDefIndex: 16287
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <width>k__BackingField; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <height>k__BackingField; // 0x4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <msaaSamples>k__BackingField; // 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <volumeDepth>k__BackingField; // 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <mipCount>k__BackingField; // 0x10
	private GraphicsFormat _graphicsFormat; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private GraphicsFormat <stencilFormat>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private GraphicsFormat <depthStencilFormat>k__BackingField; // 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private TextureDimension <dimension>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private ShadowSamplingMode <shadowSamplingMode>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private VRTextureUsage <vrUsage>k__BackingField; // 0x28
	private RenderTextureCreationFlags _flags; // 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private RenderTextureMemoryless <memoryless>k__BackingField; // 0x30

	// Properties
	public int width { get; }
	public int height { get; }
	public int msaaSamples { get; }
	public int volumeDepth { get; }
	public GraphicsFormat graphicsFormat { get; }
	public GraphicsFormat depthStencilFormat { get; }
	public TextureDimension dimension { get; }

	// Methods

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x37DED38 Offset: 0x37DAD38 VA: 0x37DED38
	public int get_width() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x37DED40 Offset: 0x37DAD40 VA: 0x37DED40
	public int get_height() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x37DED48 Offset: 0x37DAD48 VA: 0x37DED48
	public int get_msaaSamples() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x37DED50 Offset: 0x37DAD50 VA: 0x37DED50
	public int get_volumeDepth() { }

	// RVA: 0x37DED30 Offset: 0x37DAD30 VA: 0x37DED30
	public GraphicsFormat get_graphicsFormat() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x37DED58 Offset: 0x37DAD58 VA: 0x37DED58
	public GraphicsFormat get_depthStencilFormat() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x37DED60 Offset: 0x37DAD60 VA: 0x37DED60
	public TextureDimension get_dimension() { }
}
