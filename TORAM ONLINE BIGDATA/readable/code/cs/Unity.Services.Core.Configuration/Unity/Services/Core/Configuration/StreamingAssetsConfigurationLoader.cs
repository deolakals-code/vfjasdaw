// Assembly: Unity.Services.Core.Configuration.dll
// Namespace: Unity.Services.Core.Configuration
internal class StreamingAssetsConfigurationLoader : IConfigurationLoader // TypeDefIndex: 17896
{
	// Fields
	private readonly IJsonSerializer m_Serializer; // 0x10

	// Methods

	// RVA: 0x37A8784 Offset: 0x37A4784 VA: 0x37A8784
	public void .ctor(IJsonSerializer serializer) { }

	[AsyncStateMachine(typeof(StreamingAssetsConfigurationLoader.<GetConfigAsync>d__2))]
	// RVA: 0x37A8B30 Offset: 0x37A4B30 VA: 0x37A8B30 Slot: 4
	public Task<SerializableProjectConfiguration> GetConfigAsync() { }
}
