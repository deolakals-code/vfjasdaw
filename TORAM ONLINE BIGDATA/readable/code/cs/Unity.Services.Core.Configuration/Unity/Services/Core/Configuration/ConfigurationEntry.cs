// Assembly: Unity.Services.Core.Configuration.dll
// Namespace: Unity.Services.Core.Configuration
[Serializable]
internal class ConfigurationEntry // TypeDefIndex: 17889
{
	// Fields
	[JsonRequired]
	[SerializeField]
	private string m_Value; // 0x10
	[JsonRequired]
	[SerializeField]
	private bool m_IsReadOnly; // 0x18

	// Properties
	[JsonIgnore]
	public string Value { get; }
	[JsonIgnore]
	public bool IsReadOnly { get; }

	// Methods

	// RVA: 0x37A8618 Offset: 0x37A4618 VA: 0x37A8618
	public string get_Value() { }

	// RVA: 0x37A8620 Offset: 0x37A4620 VA: 0x37A8620
	public bool get_IsReadOnly() { }

	// RVA: 0x37A8628 Offset: 0x37A4628 VA: 0x37A8628
	public void .ctor() { }

	// RVA: 0x37A8630 Offset: 0x37A4630 VA: 0x37A8630
	public void .ctor(string value, bool isReadOnly = False) { }

	// RVA: 0x37A85F4 Offset: 0x37A45F4 VA: 0x37A85F4
	public bool TrySetValue(string value) { }

	// RVA: 0x37A85DC Offset: 0x37A45DC VA: 0x37A85DC
	public static string op_Implicit(ConfigurationEntry entry) { }

	// RVA: 0x37A8570 Offset: 0x37A4570 VA: 0x37A8570
	public static ConfigurationEntry op_Implicit(string value) { }
}
