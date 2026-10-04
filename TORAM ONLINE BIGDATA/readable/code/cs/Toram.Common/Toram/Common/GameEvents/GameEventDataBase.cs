// Assembly: Toram.Common.dll
// Namespace: Toram.Common.GameEvents
public abstract class GameEventDataBase : UnityHashBase // TypeDefIndex: 11179
{
	// Fields
	[CompilerGenerated]
	private bool <IsUpdate>k__BackingField; // 0x19

	// Properties
	public abstract int Version { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35D2918 Offset: 0x35CE918 VA: 0x35D2918
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract int get_Version();

	// RVA: 0x35D2920 Offset: 0x35CE920 VA: 0x35D2920
	public byte[] Serialize() { }

	// RVA: 0x35D2B04 Offset: 0x35CEB04 VA: 0x35D2B04
	private bool Deserialize(byte[] serializeData) { }

	// RVA: 0x35D2D10 Offset: 0x35CED10 VA: 0x35D2D10
	public bool ClientDeserialize(byte[] serializeData) { }

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract bool VersionInitialize();

	// RVA: -1 Offset: -1 Slot: 9
	protected abstract void Serialize(MemoryStream ms);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract bool Deserialize(MemoryStream ms, bool isInitialize);

	// RVA: 0x35D2EE8 Offset: 0x35CEEE8 VA: 0x35D2EE8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35D2EF0 Offset: 0x35CEEF0 VA: 0x35D2EF0 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35D301C Offset: 0x35CF01C VA: 0x35D301C Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
