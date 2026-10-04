// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
internal class LockedComponentRegistry : IComponentRegistry // TypeDefIndex: 17557
{
	// Fields
	[CompilerGenerated]
	private readonly IComponentRegistry <Registry>k__BackingField; // 0x10

	// Properties
	[NotNull]
	internal IComponentRegistry Registry { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37AB28C Offset: 0x37A728C VA: 0x37AB28C
	internal IComponentRegistry get_Registry() { }

	// RVA: 0x37AB294 Offset: 0x37A7294 VA: 0x37AB294
	public void .ctor(IComponentRegistry registryToLock) { }

	// RVA: -1 Offset: -1 Slot: 4
	public void RegisterServiceComponent<TComponent>(TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D7478 Offset: 0x26D3478 VA: 0x26D7478
	|-LockedComponentRegistry.RegisterServiceComponent<object>
	|
	|-RVA: 0x26D74C0 Offset: 0x26D34C0 VA: 0x26D74C0
	|-LockedComponentRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public TComponent GetServiceComponent<TComponent>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x26D72AC Offset: 0x26D32AC VA: 0x26D72AC
	|-LockedComponentRegistry.GetServiceComponent<object>
	|
	|-RVA: 0x26D7354 Offset: 0x26D3354 VA: 0x26D7354
	|-LockedComponentRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37AB2C4 Offset: 0x37A72C4 VA: 0x37AB2C4 Slot: 6
	public void ResetProvidedComponents(IDictionary<int, IServiceComponent> componentTypeHashToInstance) { }
}
