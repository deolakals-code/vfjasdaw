// Assembly: Unity.Services.Core.Configuration.dll
// Namespace: Unity.Services.Core.Configuration
[Extension]
internal static class ConfigurationCollectionHelper // TypeDefIndex: 17888
{
	// Methods

	[Extension]
	// RVA: 0x37A7FC8 Offset: 0x37A3FC8 VA: 0x37A7FC8
	public static void FillWith(IDictionary<string, ConfigurationEntry> self, SerializableProjectConfiguration config) { }

	[Extension]
	// RVA: 0x37A81EC Offset: 0x37A41EC VA: 0x37A81EC
	public static void FillWith(IDictionary<string, ConfigurationEntry> self, InitializationOptions options) { }

	[Extension]
	// RVA: 0x37A8058 Offset: 0x37A4058 VA: 0x37A8058
	private static void SetOrCreateEntry(IDictionary<string, ConfigurationEntry> self, string key, ConfigurationEntry entry) { }
}
