// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Data
internal class CommonDataWrapper : ICommonData // TypeDefIndex: 17446
{
	// Fields
	[CompilerGenerated]
	private readonly string <Version>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <GameBundleId>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly string <ProjectId>k__BackingField; // 0x20
	[CompilerGenerated]
	private readonly string <Platform>k__BackingField; // 0x28
	[CompilerGenerated]
	private readonly string <BuildGUID>k__BackingField; // 0x30
	[CompilerGenerated]
	private readonly string <Idfv>k__BackingField; // 0x38
	[CompilerGenerated]
	private readonly string <GameStoreId>k__BackingField; // 0x40
	[CompilerGenerated]
	private readonly bool <HasVolume>k__BackingField; // 0x48

	// Properties
	public string Version { get; }
	public string GameBundleId { get; }
	public string ProjectId { get; }
	public string Platform { get; }
	public string BuildGUID { get; }
	public string Idfv { get; }
	public string GameStoreId { get; }
	public bool HasVolume { get; }
	public float Volume { get; }
	public double BatteryLevel { get; }
	public string AnalyticsRegionLanguageCode { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x37A0D80 Offset: 0x379CD80 VA: 0x37A0D80 Slot: 4
	public string get_Version() { }

	[CompilerGenerated]
	// RVA: 0x37A0D88 Offset: 0x379CD88 VA: 0x37A0D88 Slot: 5
	public string get_GameBundleId() { }

	[CompilerGenerated]
	// RVA: 0x37A0D90 Offset: 0x379CD90 VA: 0x37A0D90 Slot: 6
	public string get_ProjectId() { }

	[CompilerGenerated]
	// RVA: 0x37A0D98 Offset: 0x379CD98 VA: 0x37A0D98 Slot: 7
	public string get_Platform() { }

	[CompilerGenerated]
	// RVA: 0x37A0DA0 Offset: 0x379CDA0 VA: 0x37A0DA0 Slot: 8
	public string get_BuildGUID() { }

	[CompilerGenerated]
	// RVA: 0x37A0DA8 Offset: 0x379CDA8 VA: 0x37A0DA8 Slot: 9
	public string get_Idfv() { }

	[CompilerGenerated]
	// RVA: 0x37A0DB0 Offset: 0x379CDB0 VA: 0x37A0DB0 Slot: 10
	public string get_GameStoreId() { }

	[CompilerGenerated]
	// RVA: 0x37A0DB8 Offset: 0x379CDB8 VA: 0x37A0DB8 Slot: 11
	public bool get_HasVolume() { }

	// RVA: 0x37A0DC0 Offset: 0x379CDC0 VA: 0x37A0DC0 Slot: 12
	public float get_Volume() { }

	// RVA: 0x37A1098 Offset: 0x379D098 VA: 0x37A1098 Slot: 13
	public double get_BatteryLevel() { }

	// RVA: 0x37A10B0 Offset: 0x379D0B0 VA: 0x37A10B0 Slot: 14
	public string get_AnalyticsRegionLanguageCode() { }

	// RVA: 0x379D368 Offset: 0x3799368 VA: 0x379D368
	public void .ctor(string cloudProjectId) { }

	// RVA: 0x37A10FC Offset: 0x379D0FC VA: 0x37A10FC
	private static string GetPlatform() { }
}
