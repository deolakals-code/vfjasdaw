// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Data
internal interface IDeviceData // TypeDefIndex: 17444
{
	// Properties
	public abstract string CpuType { get; }
	public abstract string GpuType { get; }
	public abstract int CpuCores { get; }
	public abstract int RamTotal { get; }
	public abstract int ScreenWidth { get; }
	public abstract int ScreenHeight { get; }
	public abstract float ScreenDpi { get; }
	public abstract string OperatingSystem { get; }
	public abstract string DeviceModel { get; }
	public abstract bool IsDebugDevice { get; }
	public abstract bool IsTiny { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract string get_CpuType();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_GpuType();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int get_CpuCores();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract int get_RamTotal();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract int get_ScreenWidth();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract int get_ScreenHeight();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract float get_ScreenDpi();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract string get_OperatingSystem();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_DeviceModel();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool get_IsDebugDevice();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract bool get_IsTiny();
}
