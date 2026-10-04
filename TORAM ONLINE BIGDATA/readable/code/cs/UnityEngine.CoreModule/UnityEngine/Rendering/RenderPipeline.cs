// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Rendering
public abstract class RenderPipeline // TypeDefIndex: 16619
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x10

	// Properties
	public bool disposed { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract void Render(ScriptableRenderContext context, Camera[] cameras);

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E7450 Offset: 0x26E3450 VA: 0x26E7450
	|-RenderPipeline.ProcessRenderRequests<object>
	|
	|-RVA: 0x26E7454 Offset: 0x26E3454 VA: 0x26E7454
	|-RenderPipeline.ProcessRenderRequests<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37FA394 Offset: 0x37F6394 VA: 0x37FA394 Slot: 6
	protected virtual void Render(ScriptableRenderContext context, List<Camera> cameras) { }

	// RVA: 0x37FA40C Offset: 0x37F640C VA: 0x37FA40C
	internal void InternalRender(ScriptableRenderContext context, List<Camera> cameras) { }

	// RVA: -1 Offset: -1
	internal void InternalProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26E7238 Offset: 0x26E3238 VA: 0x26E7238
	|-RenderPipeline.InternalProcessRenderRequests<object>
	|
	|-RVA: 0x26E72FC Offset: 0x26E32FC VA: 0x26E72FC
	|-RenderPipeline.InternalProcessRenderRequests<__Il2CppFullySharedGenericType>
	*/

	[CompilerGenerated]
	// RVA: 0x37FA48C Offset: 0x37F648C VA: 0x37FA48C
	public bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x37FA494 Offset: 0x37F6494 VA: 0x37FA494
	private void set_disposed(bool value) { }

	// RVA: 0x37FA4A0 Offset: 0x37F64A0 VA: 0x37FA4A0
	internal void Dispose() { }

	// RVA: 0x37FA518 Offset: 0x37F6518 VA: 0x37FA518 Slot: 7
	protected virtual void Dispose(bool disposing) { }
}
