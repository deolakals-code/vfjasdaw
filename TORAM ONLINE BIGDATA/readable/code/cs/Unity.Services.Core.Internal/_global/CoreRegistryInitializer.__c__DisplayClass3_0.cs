// Assembly: Unity.Services.Core.Internal.dll
// Namespace: 
[CompilerGenerated]
private sealed class CoreRegistryInitializer.<>c__DisplayClass3_0 // TypeDefIndex: 17563
{
	// Fields
	public Stopwatch stopwatch; // 0x10
	public List<PackageInitializationInfo> packagesInitInfos; // 0x18
	public List<Exception> failureReasons; // 0x20
	public CoreRegistryInitializer <>4__this; // 0x28
	public DependencyTree dependencyTree; // 0x30

	// Methods

	// RVA: 0x37ABB1C Offset: 0x37A7B1C VA: 0x37ABB1C
	public void .ctor() { }

	[AsyncStateMachine(typeof(CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__TryInitializePackageAsync|0>d))]
	// RVA: 0x37ABB24 Offset: 0x37A7B24 VA: 0x37ABB24
	internal Task <InitializeRegistryAsync>g__TryInitializePackageAsync|0(IInitializablePackage package) { }

	// RVA: 0x37ABC20 Offset: 0x37A7C20 VA: 0x37ABC20
	internal IInitializablePackage <InitializeRegistryAsync>g__GetPackageAt|1(int index) { }

	[AsyncStateMachine(typeof(CoreRegistryInitializer.<>c__DisplayClass3_0.<<InitializeRegistryAsync>g__InitializePackageAsync|2>d))]
	// RVA: 0x37ABCB0 Offset: 0x37A7CB0 VA: 0x37ABCB0
	internal Task <InitializeRegistryAsync>g__InitializePackageAsync|2(IInitializablePackage package) { }

	// RVA: 0x37ABDAC Offset: 0x37A7DAC VA: 0x37ABDAC
	internal void <InitializeRegistryAsync>g__Fail|3() { }
}
