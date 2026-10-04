// Assembly: Unity.Services.Core.Internal.dll
// Namespace: Unity.Services.Core.Internal
internal class UnityServicesInternal : IUnityServices // TypeDefIndex: 17593
{
	// Fields
	[CompilerGenerated]
	private ServicesInitializationState <State>k__BackingField; // 0x10
	internal bool CanInitialize; // 0x14
	private TaskCompletionSource<object> m_Initialization; // 0x18
	[CompilerGenerated]
	private readonly CoreRegistry <Registry>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly CoreMetrics <Metrics>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly CoreDiagnostics <Diagnostics>k__BackingField; // 0x30

	// Properties
	private ServicesInitializationState State { set; }
	[NotNull]
	internal CoreRegistry Registry { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37B03CC Offset: 0x37AC3CC VA: 0x37B03CC
	private void set_State(ServicesInitializationState value) { }

	[CompilerGenerated]
	// RVA: 0x37B03D4 Offset: 0x37AC3D4 VA: 0x37B03D4
	internal CoreRegistry get_Registry() { }

	// RVA: 0x37AFE60 Offset: 0x37ABE60 VA: 0x37AFE60
	public void .ctor(CoreRegistry registry, CoreMetrics coreMetrics, CoreDiagnostics coreDiagnostics) { }

	// RVA: 0x37B03DC Offset: 0x37AC3DC VA: 0x37B03DC
	private bool HasRequestedInitialization() { }

	[AsyncStateMachine(typeof(UnityServicesInternal.<InitializeServicesAsync>d__33))]
	// RVA: 0x37B03EC Offset: 0x37AC3EC VA: 0x37B03EC
	private Task InitializeServicesAsync() { }

	// RVA: 0x37B00A0 Offset: 0x37AC0A0 VA: 0x37B00A0
	internal void EnableInitialization() { }

	[AsyncStateMachine(typeof(UnityServicesInternal.<EnableInitializationAsync>d__36))]
	// RVA: 0x37B02DC Offset: 0x37AC2DC VA: 0x37B02DC
	internal Task EnableInitializationAsync() { }
}
