// Assembly: System.Configuration.dll
// Namespace: System.Configuration
public sealed class IgnoreSection : ConfigurationSection // TypeDefIndex: 17944
{
	// Properties
	protected internal override ConfigurationPropertyCollection Properties { get; }

	// Methods

	// RVA: 0x310F960 Offset: 0x310B960 VA: 0x310F960
	public void .ctor() { }

	// RVA: 0x310F998 Offset: 0x310B998 VA: 0x310F998 Slot: 4
	protected internal override ConfigurationPropertyCollection get_Properties() { }

	// RVA: 0x310F9D0 Offset: 0x310B9D0 VA: 0x310F9D0 Slot: 8
	protected internal override void DeserializeSection(XmlReader xmlReader) { }

	// RVA: 0x310FA08 Offset: 0x310BA08 VA: 0x310FA08 Slot: 5
	protected internal override bool IsModified() { }

	// RVA: 0x310FA40 Offset: 0x310BA40 VA: 0x310FA40 Slot: 6
	protected internal override void Reset(ConfigurationElement parentSection) { }

	// RVA: 0x310FA78 Offset: 0x310BA78 VA: 0x310FA78 Slot: 7
	protected internal override void ResetModified() { }

	// RVA: 0x310FAB0 Offset: 0x310BAB0 VA: 0x310FAB0 Slot: 9
	protected internal override string SerializeSection(ConfigurationElement parentSection, string name, ConfigurationSaveMode saveMode) { }
}
