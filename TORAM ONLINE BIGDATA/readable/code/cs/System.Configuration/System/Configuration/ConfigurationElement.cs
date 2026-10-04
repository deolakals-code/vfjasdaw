// Assembly: System.Configuration.dll
// Namespace: System.Configuration
[DefaultMember("Item")]
public abstract class ConfigurationElement // TypeDefIndex: 17937
{
	// Properties
	protected internal virtual ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x310F79C Offset: 0x310B79C VA: 0x310F79C Slot: 4
	protected internal virtual ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x310F7D4 Offset: 0x310B7D4 VA: 0x310F7D4 Slot: 5
	protected internal virtual bool IsModified() { }

	// RVA: 0x310F80C Offset: 0x310B80C VA: 0x310F80C Slot: 6
	protected internal virtual void Reset(ConfigurationElement parentElement) { }

	// RVA: 0x310F844 Offset: 0x310B844 VA: 0x310F844 Slot: 7
	protected internal virtual void ResetModified() { }
}
