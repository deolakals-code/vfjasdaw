// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
public sealed class CoreRegistry // TypeDefIndex: 17560
{
	// Fields
	[CompilerGenerated]
	private static CoreRegistry <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly string <InstanceId>k__BackingField; // 0x10
	[CompilerGenerated]
	private ServicesType <Type>k__BackingField; // 0x18
	[CompilerGenerated]
	private InitializationOptions <Options>k__BackingField; // 0x20
	[CompilerGenerated]
	private IPackageRegistry <PackageRegistry>k__BackingField; // 0x28
	[CompilerGenerated]
	private IComponentRegistry <ComponentRegistry>k__BackingField; // 0x30
	[CompilerGenerated]
	private IServiceRegistry <ServiceRegistry>k__BackingField; // 0x38

	// Properties
	public static CoreRegistry Instance { get; set; }
	internal ServicesType Type { get; set; }
	internal InitializationOptions Options { get; }
	[NotNull]
	internal IPackageRegistry PackageRegistry { get; set; }
	[NotNull]
	internal IComponentRegistry ComponentRegistry { get; set; }
	[NotNull]
	private IServiceRegistry ServiceRegistry { set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37AB6EC Offset: 0x37A76EC VA: 0x37AB6EC
	public static CoreRegistry get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x37AB734 Offset: 0x37A7734 VA: 0x37AB734
	internal static void set_Instance(CoreRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x37AB78C Offset: 0x37A778C VA: 0x37AB78C
	internal ServicesType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x37AB794 Offset: 0x37A7794 VA: 0x37AB794
	private void set_Type(ServicesType value) { }

	[CompilerGenerated]
	// RVA: 0x37AB79C Offset: 0x37A779C VA: 0x37AB79C
	internal InitializationOptions get_Options() { }

	[CompilerGenerated]
	// RVA: 0x37AB7A4 Offset: 0x37A77A4 VA: 0x37AB7A4
	internal IPackageRegistry get_PackageRegistry() { }

	[CompilerGenerated]
	// RVA: 0x37AB7AC Offset: 0x37A77AC VA: 0x37AB7AC
	private void set_PackageRegistry(IPackageRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x37AB7B4 Offset: 0x37A77B4 VA: 0x37AB7B4
	internal IComponentRegistry get_ComponentRegistry() { }

	[CompilerGenerated]
	// RVA: 0x37AB7BC Offset: 0x37A77BC VA: 0x37AB7BC
	private void set_ComponentRegistry(IComponentRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x37AB7C4 Offset: 0x37A77C4 VA: 0x37AB7C4
	private void set_ServiceRegistry(IServiceRegistry value) { }

	// RVA: 0x37AB7CC Offset: 0x37A77CC VA: 0x37AB7CC
	internal void .ctor(IPackageRegistry packageRegistry, ServicesType type = 0, string instanceId) { }

	// RVA: -1 Offset: -1
	public CoreRegistration RegisterPackage<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E3EC4 Offset: 0x27DFEC4 VA: 0x27E3EC4
	|-CoreRegistry.RegisterPackage<object>
	|
	|-RVA: 0x27E3F74 Offset: 0x27DFF74 VA: 0x27E3F74
	|-CoreRegistry.RegisterPackage<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public void RegisterServiceComponent<TComponent>(TComponent component) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E40B4 Offset: 0x27E00B4 VA: 0x27E40B4
	|-CoreRegistry.RegisterServiceComponent<object>
	|
	|-RVA: 0x27E4164 Offset: 0x27E0164 VA: 0x27E4164
	|-CoreRegistry.RegisterServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public TComponent GetServiceComponent<TComponent>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E3CF8 Offset: 0x27DFCF8 VA: 0x27E3CF8
	|-CoreRegistry.GetServiceComponent<object>
	|
	|-RVA: 0x27E3DA0 Offset: 0x27DFDA0 VA: 0x27E3DA0
	|-CoreRegistry.GetServiceComponent<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37AB930 Offset: 0x37A7930 VA: 0x37AB930
	internal void LockComponentRegistration() { }
}
