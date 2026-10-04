// Assembly: mscorlib.dll
// Namespace: System
[Serializable]
public sealed class OperatingSystem : ISerializable, ICloneable // TypeDefIndex: 9718
{
	// Fields
	private readonly Version _version; // 0x10
	private readonly PlatformID _platform; // 0x18
	private readonly string _servicePack; // 0x20
	private string _versionString; // 0x28

	// Properties
	public PlatformID Platform { get; }
	public string VersionString { get; }

	// Methods

	// RVA: 0x30069B0 Offset: 0x30029B0 VA: 0x30069B0
	public void .ctor(PlatformID platform, Version version) { }

	// RVA: 0x30069B8 Offset: 0x30029B8 VA: 0x30069B8
	internal void .ctor(PlatformID platform, Version version, string servicePack) { }

	// RVA: 0x3006B04 Offset: 0x3002B04 VA: 0x3006B04 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3006B38 Offset: 0x3002B38 VA: 0x3006B38
	public PlatformID get_Platform() { }

	// RVA: 0x3006B40 Offset: 0x3002B40 VA: 0x3006B40 Slot: 5
	public object Clone() { }

	// RVA: 0x3006BB4 Offset: 0x3002BB4 VA: 0x3006BB4 Slot: 3
	public override string ToString() { }

	// RVA: 0x3006BB8 Offset: 0x3002BB8 VA: 0x3006BB8
	public string get_VersionString() { }
}
