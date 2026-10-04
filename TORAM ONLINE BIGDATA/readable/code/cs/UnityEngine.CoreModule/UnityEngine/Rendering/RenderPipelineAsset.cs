// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine.Rendering
public abstract class RenderPipelineAsset : ScriptableObject // TypeDefIndex: 16620
{
	// Properties
	public virtual string[] renderingLayerMaskNames { get; }
	public virtual string[] prefixedRenderingLayerMaskNames { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Shader autodeskInteractiveShader { get; }
	public virtual Shader autodeskInteractiveTransparentShader { get; }
	public virtual Shader autodeskInteractiveMaskedShader { get; }
	public virtual Shader terrainDetailLitShader { get; }
	public virtual Shader terrainDetailGrassShader { get; }
	public virtual Shader terrainDetailGrassBillboardShader { get; }
	public virtual Material defaultParticleMaterial { get; }
	public virtual Material defaultLineMaterial { get; }
	public virtual Material defaultTerrainMaterial { get; }
	public virtual Material defaultUIMaterial { get; }
	public virtual Material defaultUIOverdrawMaterial { get; }
	public virtual Material defaultUIETC1SupportedMaterial { get; }
	public virtual Material default2DMaterial { get; }
	public virtual Material default2DMaskMaterial { get; }
	public virtual Shader defaultShader { get; }
	public virtual Shader defaultSpeedTree7Shader { get; }
	public virtual Shader defaultSpeedTree8Shader { get; }
	public virtual string renderPipelineShaderTag { get; }

	// Methods

	// RVA: 0x37FA51C Offset: 0x37F651C VA: 0x37FA51C
	internal RenderPipeline InternalCreatePipeline() { }

	// RVA: 0x37FA814 Offset: 0x37F6814 VA: 0x37FA814 Slot: 4
	public virtual string[] get_renderingLayerMaskNames() { }

	// RVA: 0x37FA81C Offset: 0x37F681C VA: 0x37FA81C Slot: 5
	public virtual string[] get_prefixedRenderingLayerMaskNames() { }

	// RVA: 0x37FA824 Offset: 0x37F6824 VA: 0x37FA824 Slot: 6
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x37FA82C Offset: 0x37F682C VA: 0x37FA82C Slot: 7
	public virtual Shader get_autodeskInteractiveShader() { }

	// RVA: 0x37FA834 Offset: 0x37F6834 VA: 0x37FA834 Slot: 8
	public virtual Shader get_autodeskInteractiveTransparentShader() { }

	// RVA: 0x37FA83C Offset: 0x37F683C VA: 0x37FA83C Slot: 9
	public virtual Shader get_autodeskInteractiveMaskedShader() { }

	// RVA: 0x37FA844 Offset: 0x37F6844 VA: 0x37FA844 Slot: 10
	public virtual Shader get_terrainDetailLitShader() { }

	// RVA: 0x37FA84C Offset: 0x37F684C VA: 0x37FA84C Slot: 11
	public virtual Shader get_terrainDetailGrassShader() { }

	// RVA: 0x37FA854 Offset: 0x37F6854 VA: 0x37FA854 Slot: 12
	public virtual Shader get_terrainDetailGrassBillboardShader() { }

	// RVA: 0x37FA85C Offset: 0x37F685C VA: 0x37FA85C Slot: 13
	public virtual Material get_defaultParticleMaterial() { }

	// RVA: 0x37FA864 Offset: 0x37F6864 VA: 0x37FA864 Slot: 14
	public virtual Material get_defaultLineMaterial() { }

	// RVA: 0x37FA86C Offset: 0x37F686C VA: 0x37FA86C Slot: 15
	public virtual Material get_defaultTerrainMaterial() { }

	// RVA: 0x37FA874 Offset: 0x37F6874 VA: 0x37FA874 Slot: 16
	public virtual Material get_defaultUIMaterial() { }

	// RVA: 0x37FA87C Offset: 0x37F687C VA: 0x37FA87C Slot: 17
	public virtual Material get_defaultUIOverdrawMaterial() { }

	// RVA: 0x37FA884 Offset: 0x37F6884 VA: 0x37FA884 Slot: 18
	public virtual Material get_defaultUIETC1SupportedMaterial() { }

	// RVA: 0x37FA88C Offset: 0x37F688C VA: 0x37FA88C Slot: 19
	public virtual Material get_default2DMaterial() { }

	// RVA: 0x37FA894 Offset: 0x37F6894 VA: 0x37FA894 Slot: 20
	public virtual Material get_default2DMaskMaterial() { }

	// RVA: 0x37FA89C Offset: 0x37F689C VA: 0x37FA89C Slot: 21
	public virtual Shader get_defaultShader() { }

	// RVA: 0x37FA8A4 Offset: 0x37F68A4 VA: 0x37FA8A4 Slot: 22
	public virtual Shader get_defaultSpeedTree7Shader() { }

	// RVA: 0x37FA8AC Offset: 0x37F68AC VA: 0x37FA8AC Slot: 23
	public virtual Shader get_defaultSpeedTree8Shader() { }

	// RVA: 0x37FA8B4 Offset: 0x37F68B4 VA: 0x37FA8B4 Slot: 24
	public virtual string get_renderPipelineShaderTag() { }

	// RVA: -1 Offset: -1 Slot: 25
	protected abstract RenderPipeline CreatePipeline();

	// RVA: 0x37FA940 Offset: 0x37F6940 VA: 0x37FA940 Slot: 26
	protected virtual void OnValidate() { }

	// RVA: 0x37FAC70 Offset: 0x37F6C70 VA: 0x37FAC70 Slot: 27
	protected virtual void OnDisable() { }

	// RVA: 0x37FACBC Offset: 0x37F6CBC VA: 0x37FACBC
	protected void .ctor() { }
}
