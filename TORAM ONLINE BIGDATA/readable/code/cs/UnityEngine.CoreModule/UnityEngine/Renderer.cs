// Assembly: UnityEngine.CoreModule.dll
// Namespace: UnityEngine
[NativeHeader("Runtime/Graphics/Renderer.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
public class Renderer : Component // TypeDefIndex: 16248
{
	// Properties
	public Bounds bounds { get; }
	public Bounds localBounds { get; set; }
	public bool enabled { set; }
	public bool isVisible { get; }
	public ShadowCastingMode shadowCastingMode { set; }
	public bool receiveShadows { set; }
	public LightProbeUsage lightProbeUsage { set; }
	public ReflectionProbeUsage reflectionProbeUsage { set; }
	public Material[] materials { get; set; }
	public Material material { get; set; }
	public Material sharedMaterial { get; }
	public Material[] sharedMaterials { get; set; }

	// Methods

	[FreeFunction(Name = "RendererScripting::GetWorldBounds", HasExplicitThis = True)]
	// RVA: 0x37D5078 Offset: 0x37D1078 VA: 0x37D5078
	public Bounds get_bounds() { }

	[FreeFunction(Name = "RendererScripting::GetLocalBounds", HasExplicitThis = True)]
	// RVA: 0x37D5124 Offset: 0x37D1124 VA: 0x37D5124
	public Bounds get_localBounds() { }

	[NativeName("SetLocalAABB")]
	// RVA: 0x37D51D0 Offset: 0x37D11D0 VA: 0x37D51D0
	public void set_localBounds(Bounds value) { }

	[NativeName("ResetLocalAABB")]
	// RVA: 0x37D5258 Offset: 0x37D1258 VA: 0x37D5258
	public void ResetLocalBounds() { }

	[FreeFunction(Name = "RendererScripting::GetMaterial", HasExplicitThis = True)]
	// RVA: 0x37D5294 Offset: 0x37D1294 VA: 0x37D5294
	private Material GetMaterial() { }

	[FreeFunction(Name = "RendererScripting::GetSharedMaterial", HasExplicitThis = True)]
	// RVA: 0x37D52D0 Offset: 0x37D12D0 VA: 0x37D52D0
	private Material GetSharedMaterial() { }

	[FreeFunction(Name = "RendererScripting::SetMaterial", HasExplicitThis = True)]
	// RVA: 0x37D530C Offset: 0x37D130C VA: 0x37D530C
	private void SetMaterial(Material m) { }

	[FreeFunction(Name = "RendererScripting::GetMaterialArray", HasExplicitThis = True)]
	// RVA: 0x37D5350 Offset: 0x37D1350 VA: 0x37D5350
	private Material[] GetMaterialArray() { }

	[FreeFunction(Name = "RendererScripting::SetMaterialArray", HasExplicitThis = True)]
	// RVA: 0x37D538C Offset: 0x37D138C VA: 0x37D538C
	private void SetMaterialArray(Material[] m, int length) { }

	// RVA: 0x37D53E0 Offset: 0x37D13E0 VA: 0x37D53E0
	private void SetMaterialArray(Material[] m) { }

	// RVA: 0x37D5448 Offset: 0x37D1448 VA: 0x37D5448
	public void set_enabled(bool value) { }

	[NativeName("IsVisibleInScene")]
	// RVA: 0x37D548C Offset: 0x37D148C VA: 0x37D548C
	public bool get_isVisible() { }

	// RVA: 0x37D54C8 Offset: 0x37D14C8 VA: 0x37D54C8
	public void set_shadowCastingMode(ShadowCastingMode value) { }

	// RVA: 0x37D550C Offset: 0x37D150C VA: 0x37D550C
	public void set_receiveShadows(bool value) { }

	// RVA: 0x37D5550 Offset: 0x37D1550 VA: 0x37D5550
	public void set_lightProbeUsage(LightProbeUsage value) { }

	// RVA: 0x37D5594 Offset: 0x37D1594 VA: 0x37D5594
	public void set_reflectionProbeUsage(ReflectionProbeUsage value) { }

	[NativeName("GetMaterialArray")]
	// RVA: 0x37D55D8 Offset: 0x37D15D8 VA: 0x37D55D8
	private Material[] GetSharedMaterialArray() { }

	// RVA: 0x37D5614 Offset: 0x37D1614 VA: 0x37D5614
	public Material[] get_materials() { }

	// RVA: 0x37D5650 Offset: 0x37D1650 VA: 0x37D5650
	public void set_materials(Material[] value) { }

	// RVA: 0x37D5654 Offset: 0x37D1654 VA: 0x37D5654
	public Material get_material() { }

	// RVA: 0x37D5690 Offset: 0x37D1690 VA: 0x37D5690
	public void set_material(Material value) { }

	// RVA: 0x37D56D4 Offset: 0x37D16D4 VA: 0x37D56D4
	public Material get_sharedMaterial() { }

	// RVA: 0x37D5710 Offset: 0x37D1710 VA: 0x37D5710
	public Material[] get_sharedMaterials() { }

	// RVA: 0x37D574C Offset: 0x37D174C VA: 0x37D574C
	public void set_sharedMaterials(Material[] value) { }

	// RVA: 0x37D5750 Offset: 0x37D1750 VA: 0x37D5750
	public void .ctor() { }

	// RVA: 0x37D50E0 Offset: 0x37D10E0 VA: 0x37D50E0
	private void get_bounds_Injected(out Bounds ret) { }

	// RVA: 0x37D518C Offset: 0x37D118C VA: 0x37D518C
	private void get_localBounds_Injected(out Bounds ret) { }

	// RVA: 0x37D5214 Offset: 0x37D1214 VA: 0x37D5214
	private void set_localBounds_Injected(ref Bounds value) { }
}
