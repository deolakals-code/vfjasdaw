// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Rendering
[NativeHeader("Modules/UI/Canvas.h")]
[NativeHeader("Runtime/Graphics/ScriptableRenderLoop/ScriptableDrawRenderersUtility.h")]
[NativeType("Runtime/Graphics/ScriptableRenderLoop/ScriptableRenderContext.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderPipeline.bindings.h")]
[NativeHeader("Runtime/Export/RenderPipeline/ScriptableRenderContext.bindings.h")]
[NativeHeader("Modules/UI/CanvasManager.h")]
public struct ScriptableRenderContext : IEquatable<ScriptableRenderContext> // TypeDefIndex: 16622
{
	// Fields
	private static readonly ShaderTagId kRenderTypeTag; // 0x0
	private IntPtr m_Ptr; // 0x0

	// Methods

	// RVA: 0x37FB68C Offset: 0x37F768C VA: 0x37FB68C
	private void GetCameras_Internal(Type listType, object resultList) { }

	// RVA: 0x37FB3B8 Offset: 0x37F73B8 VA: 0x37FB3B8
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x37FB3C0 Offset: 0x37F73C0 VA: 0x37FB3C0
	internal void GetCameras(List<Camera> results) { }

	// RVA: 0x37FB76C Offset: 0x37F776C VA: 0x37FB76C Slot: 4
	public bool Equals(ScriptableRenderContext other) { }

	// RVA: 0x37FB7DC Offset: 0x37F77DC VA: 0x37FB7DC Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x37FB884 Offset: 0x37F7884 VA: 0x37FB884 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x37FB88C Offset: 0x37F788C VA: 0x37FB88C
	private static void .cctor() { }

	// RVA: 0x37FB718 Offset: 0x37F7718 VA: 0x37FB718
	private static void GetCameras_Internal_Injected(ref ScriptableRenderContext _unity_self, Type listType, object resultList) { }
}
