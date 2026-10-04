// Assembly: Unity.Services.Analytics.dll
// Namespace: 
internal class Ua2CoreInitializeCallback : IInitializablePackage // TypeDefIndex: 17430
{
	// Methods

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x379B350 Offset: 0x3797350 VA: 0x379B350
	private static void Register() { }

	[AsyncStateMachine(typeof(Ua2CoreInitializeCallback.<Initialize>d__1))]
	// RVA: 0x379B544 Offset: 0x3797544 VA: 0x379B544 Slot: 4
	public Task Initialize(CoreRegistry registry) { }

	// RVA: 0x379B53C Offset: 0x379753C VA: 0x379B53C
	public void .ctor() { }
}
