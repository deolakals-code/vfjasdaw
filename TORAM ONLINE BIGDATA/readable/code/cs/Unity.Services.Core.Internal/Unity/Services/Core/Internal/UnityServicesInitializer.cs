// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
internal static class UnityServicesInitializer // TypeDefIndex: 17588
{
	// Methods

	[RuntimeInitializeOnLoadMethod(2)]
	// RVA: 0x37AFAFC Offset: 0x37ABAFC VA: 0x37AFAFC
	private static void CreateStaticInstance() { }

	[AsyncStateMachine(typeof(UnityServicesInitializer.<EnableServicesInitializationAsync>d__1))]
	[RuntimeInitializeOnLoadMethod(0)]
	// RVA: 0x37AFEC0 Offset: 0x37ABEC0 VA: 0x37AFEC0
	private static void EnableServicesInitializationAsync() { }

	// RVA: 0x37AFF54 Offset: 0x37ABF54 VA: 0x37AFF54
	internal static IUnityServices CreateInstance(string servicesId) { }
}
