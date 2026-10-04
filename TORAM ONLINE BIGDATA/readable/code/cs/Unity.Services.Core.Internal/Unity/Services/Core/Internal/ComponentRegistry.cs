// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
internal class ComponentRegistry : IComponentRegistry // TypeDefIndex: 17555
{
	// Fields
	[CompilerGenerated]
	private readonly Dictionary<int, IServiceComponent> <ComponentTypeHashToInstance>k__BackingField; // 0x10

	// Properties
	[NotNull]
	internal Dictionary<int, IServiceComponent> ComponentTypeHashToInstance { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37AB0BC Offset: 0x37A70BC VA: 0x37AB0BC
	internal Dictionary<int, IServiceComponent> get_ComponentTypeHashToInstance() { }

	// RVA: 0x37AB0C4 Offset: 0x37A70C4 VA: 0x37AB0C4
	public void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 4
	public void RegisterServiceComponent<TComponent>(TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E234C Offset: 0x27DE34C VA: 0x27E234C
	|-ComponentRegistry.RegisterServiceComponent<object>
	|
	|-RVA: 0x27E24FC Offset: 0x27DE4FC VA: 0x27E24FC
	|-ComponentRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public TComponent GetServiceComponent<TComponent>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E1F68 Offset: 0x27DDF68 VA: 0x27E1F68
	|-ComponentRegistry.GetServiceComponent<object>
	|
	|-RVA: 0x27E2130 Offset: 0x27DE130 VA: 0x27E2130
	|-ComponentRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37AB14C Offset: 0x37A714C VA: 0x37AB14C
	private bool IsComponentTypeRegistered(int componentTypeHash) { }

	// RVA: 0x37AB214 Offset: 0x37A7214 VA: 0x37AB214 Slot: 6
	public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance) { }
}
