// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Rendering
public static class RenderPipelineManager // TypeDefIndex: 16621
{
	// Fields
	internal static RenderPipelineAsset s_CurrentPipelineAsset; // 0x0
	private static List<Camera> s_Cameras; // 0x8
	private static string s_CurrentPipelineType; // 0x10
	private static RenderPipeline s_CurrentPipeline; // 0x18
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action activeRenderPipelineTypeChanged; // 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged; // 0x28
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action activeRenderPipelineCreated; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private static Action activeRenderPipelineDisposed; // 0x38

	// Properties
	public static RenderPipeline currentPipeline { get; set; }

	// Methods

	// RVA: 0x37FACC0 Offset: 0x37F6CC0 VA: 0x37FACC0
	public static RenderPipeline get_currentPipeline() { }

	// RVA: 0x37FAD18 Offset: 0x37F6D18 VA: 0x37FAD18
	private static void set_currentPipeline(RenderPipeline value) { }

	[RequiredByNativeCode]
	// RVA: 0x37FADD0 Offset: 0x37F6DD0 VA: 0x37FADD0
	internal static void OnActiveRenderPipelineTypeChanged() { }

	[RequiredByNativeCode]
	// RVA: 0x37FAE44 Offset: 0x37F6E44 VA: 0x37FAE44
	internal static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to) { }

	[RequiredByNativeCode]
	// RVA: 0x37FAF50 Offset: 0x37F6F50 VA: 0x37FAF50
	internal static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset) { }

	[RequiredByNativeCode]
	// RVA: 0x37FA9F8 Offset: 0x37F69F8 VA: 0x37FA9F8
	internal static void CleanupRenderPipeline() { }

	[RequiredByNativeCode]
	// RVA: 0x37FB0DC Offset: 0x37F70DC VA: 0x37FB0DC
	private static string GetCurrentPipelineAssetType() { }

	[RequiredByNativeCode]
	// RVA: 0x37FB134 Offset: 0x37F7134 VA: 0x37FB134
	private static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, Object renderRequest) { }

	// RVA: 0x37FABBC Offset: 0x37F6BBC VA: 0x37FABBC
	internal static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset) { }

	// RVA: 0x37FB478 Offset: 0x37F7478 VA: 0x37FB478
	private static bool IsPipelineRequireCreation() { }

	// RVA: 0x37FB5C0 Offset: 0x37F75C0 VA: 0x37FB5C0
	private static void .cctor() { }
}
