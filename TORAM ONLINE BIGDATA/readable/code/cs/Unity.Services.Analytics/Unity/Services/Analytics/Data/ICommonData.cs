// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Data
internal interface ICommonData // TypeDefIndex: 17443
{
	// Properties
	public abstract string Version { get; }
	public abstract string GameBundleId { get; }
	public abstract string ProjectId { get; }
	public abstract string Platform { get; }
	public abstract string BuildGUID { get; }
	public abstract string Idfv { get; }
	public abstract string GameStoreId { get; }
	public abstract bool HasVolume { get; }
	public abstract float Volume { get; }
	public abstract double BatteryLevel { get; }
	public abstract string AnalyticsRegionLanguageCode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_Version();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_GameBundleId();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract string get_ProjectId();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract string get_Platform();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract string get_BuildGUID();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string get_Idfv();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract string get_GameStoreId();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract bool get_HasVolume();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract float get_Volume();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract double get_BatteryLevel();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract string get_AnalyticsRegionLanguageCode();
}
