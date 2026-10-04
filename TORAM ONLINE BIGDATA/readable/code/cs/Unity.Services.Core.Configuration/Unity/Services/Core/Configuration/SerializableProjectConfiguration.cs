// Assembly: Unity.Services.Core.Configuration.dll
// Namespace: Unity.Services.Core.Configuration
[Serializable]
internal struct SerializableProjectConfiguration // TypeDefIndex: 17894
{
	// Fields
	[SerializeField]
	[JsonRequired]
	internal string[] Keys; // 0x0
	[JsonRequired]
	[SerializeField]
	internal ConfigurationEntry[] Values; // 0x8

	// Properties
	public static SerializableProjectConfiguration Empty { get; }

	// Methods

	// RVA: 0x37A8A14 Offset: 0x37A4A14 VA: 0x37A8A14
	public static SerializableProjectConfiguration get_Empty() { }
}
