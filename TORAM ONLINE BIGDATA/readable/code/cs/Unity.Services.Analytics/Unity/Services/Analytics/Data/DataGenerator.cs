// Assembly: Unity.Services.Analytics.dll
// Namespace: Unity.Services.Analytics.Data
internal class DataGenerator : IDataGenerator // TypeDefIndex: 17449
{
	// Fields
	private readonly IBuffer m_Buffer; // 0x10
	private readonly ICommonData m_CommonData; // 0x18
	private readonly IDeviceData m_DeviceData; // 0x20

	// Methods

	// RVA: 0x379D474 Offset: 0x3799474 VA: 0x379D474
	public void .ctor(IBuffer buffer, ICommonData staticData, IDeviceData deviceData) { }

	// RVA: 0x37A1298 Offset: 0x379D298 VA: 0x37A1298 Slot: 5
	public void SdkStartup(string callingMethodIdentifier) { }

	// RVA: 0x37A2118 Offset: 0x379E118 VA: 0x37A2118 Slot: 4
	public void GameRunning(string callingMethodIdentifier) { }

	// RVA: 0x37A2254 Offset: 0x379E254 VA: 0x37A2254 Slot: 6
	public void NewPlayer(string callingMethodIdentifier) { }

	// RVA: 0x37A2490 Offset: 0x379E490 VA: 0x37A2490 Slot: 7
	public void GameStarted(string callingMethodIdentifier) { }

	// RVA: 0x37A2B08 Offset: 0x379EB08 VA: 0x37A2B08 Slot: 8
	public void GameEnded(string callingMethodIdentifier, DataGenerator.SessionEndState quitState) { }

	// RVA: 0x37A2D14 Offset: 0x379ED14 VA: 0x37A2D14 Slot: 9
	public void ClientDevice(string callingMethodIdentifier) { }

	// RVA: 0x37A152C Offset: 0x379D52C VA: 0x37A152C Slot: 10
	public void PushCommonParams(string callingMethodIdentifier) { }
}
