// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
internal interface IComponentRegistry // TypeDefIndex: 17556
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void RegisterServiceComponent<TComponent>(TComponent component);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IComponentRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract TComponent GetServiceComponent<TComponent>();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IComponentRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance);
}
