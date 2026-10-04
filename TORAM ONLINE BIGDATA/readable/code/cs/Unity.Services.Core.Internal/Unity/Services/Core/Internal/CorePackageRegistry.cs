// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
public sealed class CorePackageRegistry // TypeDefIndex: 17558
{
	// Fields
	[CompilerGenerated]
	private static CorePackageRegistry <Instance>k__BackingField; // 0x0
	[CompilerGenerated]
	private IPackageRegistry <Registry>k__BackingField; // 0x10

	// Properties
	public static CorePackageRegistry Instance { get; set; }
	internal IPackageRegistry Registry { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37AB310 Offset: 0x37A7310 VA: 0x37AB310
	public static CorePackageRegistry get_Instance() { }

	[CompilerGenerated]
	// RVA: 0x37AB358 Offset: 0x37A7358 VA: 0x37AB358
	internal static void set_Instance(CorePackageRegistry value) { }

	[CompilerGenerated]
	// RVA: 0x37AB3B0 Offset: 0x37A73B0 VA: 0x37AB3B0
	internal IPackageRegistry get_Registry() { }

	[CompilerGenerated]
	// RVA: 0x37AB3B8 Offset: 0x37A73B8 VA: 0x37AB3B8
	internal void set_Registry(IPackageRegistry value) { }

	// RVA: 0x37AB3C0 Offset: 0x37A73C0 VA: 0x37AB3C0
	internal void .ctor() { }

	// RVA: -1 Offset: -1
	public CoreRegistration Register<TPackage>(TPackage package) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x27E3688 Offset: 0x27DF688 VA: 0x27E3688
	|-CorePackageRegistry.Register<object>
	|
	|-RVA: 0x27E3738 Offset: 0x27DF738 VA: 0x27E3738
	|-CorePackageRegistry.Register<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x37AB5E8 Offset: 0x37A75E8 VA: 0x37AB5E8
	internal void Lock() { }
}
