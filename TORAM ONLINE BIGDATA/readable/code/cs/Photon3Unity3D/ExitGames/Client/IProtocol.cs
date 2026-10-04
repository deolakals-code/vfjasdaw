// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client
public abstract class IProtocol // TypeDefIndex: 16953
{
	// Properties
	internal abstract string protocolType { get; }
	internal abstract byte[] VersionBytes { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract string get_protocolType();

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract byte[] get_VersionBytes();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract void Serialize(StreamBuffer dout, object serObject, bool setType);

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void SerializeShort(StreamBuffer dout, short serObject, bool setType);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void SerializeString(StreamBuffer dout, string serObject, bool setType);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType);

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void SerializeOperationRequest(StreamBuffer stream, byte operationCode, Dictionary<byte, object> parameters, bool setType);

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract object Deserialize(StreamBuffer din, byte type);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract short DeserializeShort(StreamBuffer din);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract byte DeserializeByte(StreamBuffer din);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract EventData DeserializeEventData(StreamBuffer din);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract OperationRequest DeserializeOperationRequest(StreamBuffer din);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract OperationResponse DeserializeOperationResponse(StreamBuffer stream);

	// RVA: 0x30F0E68 Offset: 0x30ECE68 VA: 0x30F0E68
	public byte[] Serialize(object obj) { }

	// RVA: 0x30F0FF8 Offset: 0x30ECFF8 VA: 0x30F0FF8
	protected void .ctor() { }
}
