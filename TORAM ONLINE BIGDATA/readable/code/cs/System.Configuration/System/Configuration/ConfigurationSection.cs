// Assembly: System.Configuration.dll
// Namespace: System.Configuration
public abstract class ConfigurationSection : ConfigurationElement // TypeDefIndex: 17938
{
	// Methods

	// RVA: 0x310F87C Offset: 0x310B87C VA: 0x310F87C Slot: 8
	protected internal virtual void DeserializeSection(XmlReader reader) { }

	// RVA: 0x310F8B4 Offset: 0x310B8B4 VA: 0x310F8B4 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x310F8EC Offset: 0x310B8EC VA: 0x310F8EC Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x310F924 Offset: 0x310B924 VA: 0x310F924 Slot: 9
	protected internal virtual string SerializeSection(ConfigurationElement parentElement, string name, ConfigurationSaveMode saveMode) { }
}
