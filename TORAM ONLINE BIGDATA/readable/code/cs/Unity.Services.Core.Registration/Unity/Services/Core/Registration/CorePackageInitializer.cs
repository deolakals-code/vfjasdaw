// Assembly: Unity.Services.Core.Registration.dll
// Namespace: Unity.Services.Core.Registration
internal class CorePackageInitializer : IInitializablePackageV2, IInitializablePackage, IDiagnosticsComponentProvider // TypeDefIndex: 17821
{
	// Fields
	[CompilerGenerated]
	private ActionScheduler <ActionScheduler>k__BackingField; // 0x10
	[CompilerGenerated]
	private InstallationId <InstallationId>k__BackingField; // 0x18
	[CompilerGenerated]
	private ProjectConfiguration <ProjectConfig>k__BackingField; // 0x20
	[CompilerGenerated]
	private Environments <Environments>k__BackingField; // 0x28
	[CompilerGenerated]
	private ExternalUserId <ExternalUserId>k__BackingField; // 0x30
	[CompilerGenerated]
	private ICloudProjectId <CloudProjectId>k__BackingField; // 0x38
	[CompilerGenerated]
	private IDiagnosticsFactory <DiagnosticsFactory>k__BackingField; // 0x40
	[CompilerGenerated]
	private IMetricsFactory <MetricsFactory>k__BackingField; // 0x48
	[CompilerGenerated]
	private UnityThreadUtilsInternal <UnityThreadUtils>k__BackingField; // 0x50
	private CoreRegistry m_Registry; // 0x58
	private readonly IJsonSerializer m_Serializer; // 0x60
	private InitializationOptions m_CurrentInitializationOptions; // 0x68

	// Properties
	internal ActionScheduler ActionScheduler { get; set; }
	internal InstallationId InstallationId { get; set; }
	internal ProjectConfiguration ProjectConfig { get; set; }
	internal Environments Environments { get; set; }
	internal ExternalUserId ExternalUserId { get; set; }
	internal ICloudProjectId CloudProjectId { get; set; }
	internal IDiagnosticsFactory DiagnosticsFactory { get; set; }
	internal IMetricsFactory MetricsFactory { get; set; }
	internal UnityThreadUtilsInternal UnityThreadUtils { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37B17F0 Offset: 0x37AD7F0 VA: 0x37B17F0
	internal ActionScheduler get_ActionScheduler() { }

	[CompilerGenerated]
	// RVA: 0x37B17F8 Offset: 0x37AD7F8 VA: 0x37B17F8
	private void set_ActionScheduler(ActionScheduler value) { }

	[CompilerGenerated]
	// RVA: 0x37B1800 Offset: 0x37AD800 VA: 0x37B1800
	internal InstallationId get_InstallationId() { }

	[CompilerGenerated]
	// RVA: 0x37B1808 Offset: 0x37AD808 VA: 0x37B1808
	private void set_InstallationId(InstallationId value) { }

	[CompilerGenerated]
	// RVA: 0x37B1810 Offset: 0x37AD810 VA: 0x37B1810
	internal ProjectConfiguration get_ProjectConfig() { }

	[CompilerGenerated]
	// RVA: 0x37B1818 Offset: 0x37AD818 VA: 0x37B1818
	private void set_ProjectConfig(ProjectConfiguration value) { }

	[CompilerGenerated]
	// RVA: 0x37B1820 Offset: 0x37AD820 VA: 0x37B1820
	internal Environments get_Environments() { }

	[CompilerGenerated]
	// RVA: 0x37B1828 Offset: 0x37AD828 VA: 0x37B1828
	private void set_Environments(Environments value) { }

	[CompilerGenerated]
	// RVA: 0x37B1830 Offset: 0x37AD830 VA: 0x37B1830
	internal ExternalUserId get_ExternalUserId() { }

	[CompilerGenerated]
	// RVA: 0x37B1838 Offset: 0x37AD838 VA: 0x37B1838
	private void set_ExternalUserId(ExternalUserId value) { }

	[CompilerGenerated]
	// RVA: 0x37B1840 Offset: 0x37AD840 VA: 0x37B1840
	internal ICloudProjectId get_CloudProjectId() { }

	[CompilerGenerated]
	// RVA: 0x37B1848 Offset: 0x37AD848 VA: 0x37B1848
	private void set_CloudProjectId(ICloudProjectId value) { }

	[CompilerGenerated]
	// RVA: 0x37B1850 Offset: 0x37AD850 VA: 0x37B1850
	internal IDiagnosticsFactory get_DiagnosticsFactory() { }

	[CompilerGenerated]
	// RVA: 0x37B1858 Offset: 0x37AD858 VA: 0x37B1858
	private void set_DiagnosticsFactory(IDiagnosticsFactory value) { }

	[CompilerGenerated]
	// RVA: 0x37B1860 Offset: 0x37AD860 VA: 0x37B1860
	internal IMetricsFactory get_MetricsFactory() { }

	[CompilerGenerated]
	// RVA: 0x37B1868 Offset: 0x37AD868 VA: 0x37B1868
	private void set_MetricsFactory(IMetricsFactory value) { }

	[CompilerGenerated]
	// RVA: 0x37B1870 Offset: 0x37AD870 VA: 0x37B1870
	internal UnityThreadUtilsInternal get_UnityThreadUtils() { }

	[CompilerGenerated]
	// RVA: 0x37B1878 Offset: 0x37AD878 VA: 0x37B1878
	private void set_UnityThreadUtils(UnityThreadUtilsInternal value) { }

	[RuntimeInitializeOnLoadMethod(1)]
	// RVA: 0x37B1880 Offset: 0x37AD880 VA: 0x37B1880
	private static void InitializeOnLoad() { }

	// RVA: 0x37B1974 Offset: 0x37AD974 VA: 0x37B1974 Slot: 6
	public void Register(CorePackageRegistry registry) { }

	// RVA: 0x37B1944 Offset: 0x37AD944 VA: 0x37B1944
	public void .ctor(IJsonSerializer serializer) { }

	// RVA: 0x37B1BA8 Offset: 0x37ADBA8 VA: 0x37B1BA8 Slot: 5
	public Task Initialize(CoreRegistry registry) { }

	// RVA: 0x37B1CA8 Offset: 0x37ADCA8 VA: 0x37B1CA8 Slot: 4
	public Task InitializeInstanceAsync(CoreRegistry registry) { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<InitializeComponents>d__47))]
	// RVA: 0x37B1BC4 Offset: 0x37ADBC4 VA: 0x37B1BC4
	private Task InitializeComponents() { }

	// RVA: 0x37B1CC4 Offset: 0x37ADCC4 VA: 0x37B1CC4
	private bool HaveInitOptionsChanged() { }

	// RVA: 0x37B1D38 Offset: 0x37ADD38 VA: 0x37B1D38
	private void FreeOptionsDependantComponents() { }

	// RVA: 0x37B1D80 Offset: 0x37ADD80 VA: 0x37B1D80
	internal void InitializeInstallationId() { }

	// RVA: 0x37B1E08 Offset: 0x37ADE08 VA: 0x37B1E08
	internal void InitializeActionScheduler() { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<InitializeProjectConfigAsync>d__52))]
	// RVA: 0x37B1E90 Offset: 0x37ADE90 VA: 0x37B1E90
	internal Task InitializeProjectConfigAsync(InitializationOptions options) { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<GenerateProjectConfigurationAsync>d__53))]
	// RVA: 0x37B1F8C Offset: 0x37ADF8C VA: 0x37B1F8C
	internal Task<ProjectConfiguration> GenerateProjectConfigurationAsync(InitializationOptions options) { }

	[AsyncStateMachine(typeof(CorePackageInitializer.<GetSerializedConfigOrEmptyAsync>d__54))]
	// RVA: 0x37B20A8 Offset: 0x37AE0A8 VA: 0x37B20A8
	internal static Task<SerializableProjectConfiguration> GetSerializedConfigOrEmptyAsync() { }

	// RVA: 0x37B2198 Offset: 0x37AE198 VA: 0x37B2198
	internal void InitializeExternalUserId(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x37B230C Offset: 0x37AE30C VA: 0x37B230C
	internal void InitializeEnvironments(IProjectConfiguration projectConfiguration) { }

	// RVA: 0x37B2458 Offset: 0x37AE458 VA: 0x37B2458
	internal void InitializeMetrics() { }

	// RVA: 0x37B24CC Offset: 0x37AE4CC VA: 0x37B24CC
	internal void InitializeDiagnostics() { }

	// RVA: 0x37B2540 Offset: 0x37AE540 VA: 0x37B2540
	internal void InitializeCloudProjectId(ICloudProjectId cloudProjectId) { }

	// RVA: 0x37B25BC Offset: 0x37AE5BC VA: 0x37B25BC
	internal void InitializeUnityThreadUtils() { }

	[CompilerGenerated]
	// RVA: 0x37B2630 Offset: 0x37AE630 VA: 0x37B2630
	private void <InitializeComponents>g__RegisterProvidedComponents|47_0() { }

	[CompilerGenerated]
	// RVA: 0x37B27C4 Offset: 0x37AE7C4 VA: 0x37B27C4
	internal static bool <InitializeComponents>g__SendFailedInitDiagnostic|47_1(Exception reason) { }
}
