// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Rendering
public class SupportedRenderingFeatures // TypeDefIndex: 16626
{
	// Fields
	private static SupportedRenderingFeatures s_Active; // 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private SupportedRenderingFeatures.ReflectionProbeModes <reflectionProbeModes>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private SupportedRenderingFeatures.LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private SupportedRenderingFeatures.LightmapMixedBakeModes <mixedLightingModes>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; // 0x1C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private LightmapsMode <lightmapsModes>k__BackingField; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <enlightenLightmapper>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <enlighten>k__BackingField; // 0x25
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <lightProbeProxyVolumes>k__BackingField; // 0x26
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <motionVectors>k__BackingField; // 0x27
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <receiveShadows>k__BackingField; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <reflectionProbes>k__BackingField; // 0x29
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <reflectionProbesBlendDistance>k__BackingField; // 0x2A
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <rendererPriority>k__BackingField; // 0x2B
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <rendersUIOverlay>k__BackingField; // 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesEnvironmentLighting>k__BackingField; // 0x2D
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesFog>k__BackingField; // 0x2E
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesRealtimeReflectionProbes>k__BackingField; // 0x2F
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesOtherLightingSettings>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <editableMaterialRenderQueue>k__BackingField; // 0x31
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesLODBias>k__BackingField; // 0x32
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesMaximumLODLevel>k__BackingField; // 0x33
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesEnableLODCrossFade>k__BackingField; // 0x34
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <rendererProbes>k__BackingField; // 0x35
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <particleSystemInstancing>k__BackingField; // 0x36
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <autoAmbientProbeBaking>k__BackingField; // 0x37
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <autoDefaultReflectionProbeBaking>k__BackingField; // 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesShadowmask>k__BackingField; // 0x39
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesLightProbeSystem>k__BackingField; // 0x3A
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <supportsHDR>k__BackingField; // 0x3B
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <overridesLightProbeSystemWarningMessage>k__BackingField; // 0x40

	// Properties
	public static SupportedRenderingFeatures active { get; set; }
	public SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes { get; }
	public SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes { get; }
	public LightmapBakeType lightmapBakeTypes { get; }
	public LightmapsMode lightmapsModes { get; }
	[Obsolete("Bake with the Progressive Lightmapper. The backend that uses Enlighten to bake is deprecated.", False)]
	public bool enlightenLightmapper { get; }
	public bool enlighten { get; }
	public bool rendersUIOverlay { get; }
	public bool autoAmbientProbeBaking { get; }
	public bool autoDefaultReflectionProbeBaking { get; }
	public bool overridesLightProbeSystem { get; }

	// Methods

	// RVA: 0x37FB9BC Offset: 0x37F79BC VA: 0x37FB9BC
	public static SupportedRenderingFeatures get_active() { }

	// RVA: 0x37FB074 Offset: 0x37F7074 VA: 0x37FB074
	public static void set_active(SupportedRenderingFeatures value) { }

	[CompilerGenerated]
	// RVA: 0x37FBA6C Offset: 0x37F7A6C VA: 0x37FBA6C
	public SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	[CompilerGenerated]
	// RVA: 0x37FBA74 Offset: 0x37F7A74 VA: 0x37FBA74
	public SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes() { }

	[CompilerGenerated]
	// RVA: 0x37FBA7C Offset: 0x37F7A7C VA: 0x37FBA7C
	public LightmapBakeType get_lightmapBakeTypes() { }

	[CompilerGenerated]
	// RVA: 0x37FBA84 Offset: 0x37F7A84 VA: 0x37FBA84
	public LightmapsMode get_lightmapsModes() { }

	[CompilerGenerated]
	// RVA: 0x37FBA8C Offset: 0x37F7A8C VA: 0x37FBA8C
	public bool get_enlightenLightmapper() { }

	[CompilerGenerated]
	// RVA: 0x37FBA94 Offset: 0x37F7A94 VA: 0x37FBA94
	public bool get_enlighten() { }

	[CompilerGenerated]
	// RVA: 0x37FBA9C Offset: 0x37F7A9C VA: 0x37FBA9C
	public bool get_rendersUIOverlay() { }

	[CompilerGenerated]
	// RVA: 0x37FBAA4 Offset: 0x37F7AA4 VA: 0x37FBAA4
	public bool get_autoAmbientProbeBaking() { }

	[CompilerGenerated]
	// RVA: 0x37FBAAC Offset: 0x37F7AAC VA: 0x37FBAAC
	public bool get_autoDefaultReflectionProbeBaking() { }

	[CompilerGenerated]
	// RVA: 0x37FBAB4 Offset: 0x37F7AB4 VA: 0x37FBAB4
	public bool get_overridesLightProbeSystem() { }

	[RequiredByNativeCode]
	// RVA: 0x37FBABC Offset: 0x37F7ABC VA: 0x37FBABC
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	// RVA: 0x37FBBF0 Offset: 0x37F7BF0 VA: 0x37FBBF0
	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	[RequiredByNativeCode]
	// RVA: 0x37FBC5C Offset: 0x37F7C5C VA: 0x37FBC5C
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	// RVA: 0x37FBD64 Offset: 0x37F7D64 VA: 0x37FBD64
	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	[RequiredByNativeCode]
	// RVA: 0x37FBDD0 Offset: 0x37F7DD0 VA: 0x37FBDD0
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x37FBEC0 Offset: 0x37F7EC0 VA: 0x37FBEC0
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x37FBF4C Offset: 0x37F7F4C VA: 0x37FBF4C
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x37FBFD0 Offset: 0x37F7FD0 VA: 0x37FBFD0
	internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x37FC048 Offset: 0x37F8048 VA: 0x37FC048
	internal static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x37FC0C0 Offset: 0x37F80C0 VA: 0x37FC0C0
	internal static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x37FC138 Offset: 0x37F8138 VA: 0x37FC138
	internal static void OverridesLightProbeSystem(IntPtr overridesPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x37FC1B0 Offset: 0x37F81B0 VA: 0x37FC1B0
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	// RVA: 0x37FAFE8 Offset: 0x37F6FE8 VA: 0x37FAFE8
	public void .ctor() { }

	// RVA: 0x37FC1CC Offset: 0x37F81CC VA: 0x37FC1CC
	private static void .cctor() { }
}
