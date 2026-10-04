// Assembly: Unity.Services.Core.Configuration.dll
// Namespace: Unity.Services.Core.Configuration
internal class ProjectConfiguration : IProjectConfiguration, IServiceComponent // TypeDefIndex: 17893
{
	// Fields
	private readonly IReadOnlyDictionary<string, ConfigurationEntry> m_ConfigValues; // 0x10
	[CompilerGenerated]
	private readonly IJsonSerializer <Serializer>k__BackingField; // 0x18

	// Methods

	// RVA: 0x37A88F8 Offset: 0x37A48F8 VA: 0x37A88F8
	public void .ctor(IReadOnlyDictionary<string, ConfigurationEntry> configValues, IJsonSerializer serializer) { }

	// RVA: 0x37A893C Offset: 0x37A493C VA: 0x37A893C Slot: 4
	public string GetString(string key, string defaultValue) { }
}
