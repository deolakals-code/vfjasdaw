// Assembly: Photon3Unity3D.dll
// Namespace: ExitGames.Client.Photon
public class Protocol16 : IProtocol // TypeDefIndex: 16997
{
	// Fields
	private readonly byte[] versionBytes; // 0x10
	private readonly byte[] memShort; // 0x18
	private readonly long[] memLongBlock; // 0x20
	private readonly byte[] memLongBlockBytes; // 0x28
	private static readonly float[] memFloatBlock; // 0x0
	private static readonly byte[] memFloatBlockBytes; // 0x8
	private readonly double[] memDoubleBlock; // 0x30
	private readonly byte[] memDoubleBlockBytes; // 0x38
	private readonly byte[] memInteger; // 0x40
	private readonly byte[] memLong; // 0x48
	private readonly byte[] memFloat; // 0x50
	private readonly byte[] memDouble; // 0x58
	private byte[] memString; // 0x60

	// Properties
	internal override string protocolType { get; }
	internal override byte[] VersionBytes { get; }

	// Methods

	// RVA: 0x310476C Offset: 0x310076C VA: 0x310476C Slot: 4
	internal override string get_protocolType() { }

	// RVA: 0x31047AC Offset: 0x31007AC VA: 0x31047AC Slot: 5
	internal override byte[] get_VersionBytes() { }

	// RVA: 0x31047B4 Offset: 0x31007B4 VA: 0x31047B4
	private bool SerializeCustom(StreamBuffer dout, object serObject) { }

	// RVA: 0x3104C3C Offset: 0x3100C3C VA: 0x3104C3C
	private object DeserializeCustom(StreamBuffer din, byte customTypeCode) { }

	// RVA: 0x3104E10 Offset: 0x3100E10 VA: 0x3104E10
	private Type GetTypeOfCode(byte typeCode) { }

	// RVA: 0x3105228 Offset: 0x3101228 VA: 0x3105228
	private Protocol16.GpType GetCodeOfType(Type type) { }

	// RVA: 0x31054C0 Offset: 0x31014C0 VA: 0x31054C0
	private Array CreateArrayByType(byte arrayType, short length) { }

	// RVA: 0x31054DC Offset: 0x31014DC VA: 0x31054DC
	private void SerializeOperationRequest(StreamBuffer stream, OperationRequest serObject, bool setType) { }

	// RVA: 0x3105508 Offset: 0x3101508 VA: 0x3105508 Slot: 10
	public override void SerializeOperationRequest(StreamBuffer stream, byte operationCode, Dictionary<byte, object> parameters, bool setType) { }

	// RVA: 0x31057A8 Offset: 0x31017A8 VA: 0x31057A8 Slot: 16
	public override OperationRequest DeserializeOperationRequest(StreamBuffer din) { }

	// RVA: 0x310597C Offset: 0x310197C VA: 0x310597C Slot: 11
	public override void SerializeOperationResponse(StreamBuffer stream, OperationResponse serObject, bool setType) { }

	// RVA: 0x3105A50 Offset: 0x3101A50 VA: 0x3105A50 Slot: 17
	public override OperationResponse DeserializeOperationResponse(StreamBuffer stream) { }

	// RVA: 0x3105B94 Offset: 0x3101B94 VA: 0x3105B94 Slot: 9
	public override void SerializeEventData(StreamBuffer stream, EventData serObject, bool setType) { }

	// RVA: 0x3105C04 Offset: 0x3101C04 VA: 0x3105C04 Slot: 15
	public override EventData DeserializeEventData(StreamBuffer din) { }

	// RVA: 0x3105584 Offset: 0x3101584 VA: 0x3105584
	private void SerializeParameterTable(StreamBuffer stream, Dictionary<byte, object> parameters) { }

	// RVA: 0x310584C Offset: 0x310184C VA: 0x310584C
	private Dictionary<byte, object> DeserializeParameterTable(StreamBuffer stream) { }

	// RVA: 0x3105CA8 Offset: 0x3101CA8 VA: 0x3105CA8 Slot: 6
	public override void Serialize(StreamBuffer dout, object serObject, bool setType) { }

	// RVA: 0x3106434 Offset: 0x3102434 VA: 0x3106434
	private void SerializeByte(StreamBuffer dout, byte serObject, bool setType) { }

	// RVA: 0x3106490 Offset: 0x3102490 VA: 0x3106490
	private void SerializeBoolean(StreamBuffer dout, bool serObject, bool setType) { }

	// RVA: 0x31078FC Offset: 0x31038FC VA: 0x31078FC Slot: 7
	public override void SerializeShort(StreamBuffer dout, short serObject, bool setType) { }

	// RVA: 0x31064EC Offset: 0x31024EC VA: 0x31064EC
	private void SerializeInteger(StreamBuffer dout, int serObject, bool setType) { }

	// RVA: 0x3106650 Offset: 0x3102650 VA: 0x3106650
	private void SerializeLong(StreamBuffer dout, long serObject, bool setType) { }

	// RVA: 0x3106828 Offset: 0x3102828 VA: 0x3106828
	private void SerializeFloat(StreamBuffer dout, float serObject, bool setType) { }

	// RVA: 0x3106AD0 Offset: 0x3102AD0 VA: 0x3106AD0
	private void SerializeDouble(StreamBuffer dout, double serObject, bool setType) { }

	// RVA: 0x3107A30 Offset: 0x3103A30 VA: 0x3107A30 Slot: 8
	public override void SerializeString(StreamBuffer dout, string serObject, bool setType) { }

	// RVA: 0x31071CC Offset: 0x31031CC VA: 0x31071CC
	private void SerializeArray(StreamBuffer dout, Array serObject, bool setType) { }

	// RVA: 0x3106EC4 Offset: 0x3102EC4 VA: 0x3106EC4
	private void SerializeByteArray(StreamBuffer dout, byte[] serObject, bool setType) { }

	// RVA: 0x3106F40 Offset: 0x3102F40 VA: 0x3106F40
	private void SerializeIntArrayOptimized(StreamBuffer inWriter, int[] serObject, bool setType) { }

	// RVA: 0x3107110 Offset: 0x3103110 VA: 0x3107110
	private void SerializeObjectArray(StreamBuffer dout, object[] objects, bool setType) { }

	// RVA: 0x3106CA8 Offset: 0x3102CA8 VA: 0x3106CA8
	private void SerializeHashTable(StreamBuffer dout, Hashtable serObject, bool setType) { }

	// RVA: 0x310787C Offset: 0x310387C VA: 0x310787C
	private void SerializeDictionary(StreamBuffer dout, IDictionary serObject, bool setType) { }

	// RVA: 0x31082D0 Offset: 0x31042D0 VA: 0x31082D0
	private void SerializeDictionaryHeader(StreamBuffer writer, Type dictType) { }

	// RVA: 0x3107B58 Offset: 0x3103B58 VA: 0x3107B58
	private void SerializeDictionaryHeader(StreamBuffer writer, object dict, out bool setKeyType, out bool setValueType) { }

	// RVA: 0x3107DE4 Offset: 0x3103DE4 VA: 0x3107DE4
	private void SerializeDictionaryElements(StreamBuffer writer, object dict, bool setKeyType, bool setValueType) { }

	// RVA: 0x31082F0 Offset: 0x31042F0 VA: 0x31082F0 Slot: 12
	public override object Deserialize(StreamBuffer din, byte type) { }

	// RVA: 0x3109A00 Offset: 0x3105A00 VA: 0x3109A00 Slot: 14
	public override byte DeserializeByte(StreamBuffer din) { }

	// RVA: 0x3108FC4 Offset: 0x3104FC4 VA: 0x3108FC4
	private bool DeserializeBoolean(StreamBuffer din) { }

	// RVA: 0x3109A2C Offset: 0x3105A2C VA: 0x3109A2C Slot: 13
	public override short DeserializeShort(StreamBuffer din) { }

	// RVA: 0x31086E8 Offset: 0x31046E8 VA: 0x31086E8
	private int DeserializeInteger(StreamBuffer din) { }

	// RVA: 0x3108FF8 Offset: 0x3104FF8 VA: 0x3108FF8
	private long DeserializeLong(StreamBuffer din) { }

	// RVA: 0x3109198 Offset: 0x3105198 VA: 0x3109198
	private float DeserializeFloat(StreamBuffer din) { }

	// RVA: 0x31092E8 Offset: 0x31052E8 VA: 0x31092E8
	private double DeserializeDouble(StreamBuffer din) { }

	// RVA: 0x310882C Offset: 0x310482C VA: 0x310882C
	private string DeserializeString(StreamBuffer din) { }

	// RVA: 0x3109478 Offset: 0x3105478 VA: 0x3109478
	private Array DeserializeArray(StreamBuffer din) { }

	// RVA: 0x3108A20 Offset: 0x3104A20 VA: 0x3108A20
	private byte[] DeserializeByteArray(StreamBuffer din) { }

	// RVA: 0x3108ABC Offset: 0x3104ABC VA: 0x3108ABC
	private int[] DeserializeIntArray(StreamBuffer din) { }

	// RVA: 0x310893C Offset: 0x310493C VA: 0x310893C
	private string[] DeserializeStringArray(StreamBuffer din) { }

	// RVA: 0x31098C8 Offset: 0x31058C8 VA: 0x31098C8
	private object[] DeserializeObjectArray(StreamBuffer din) { }

	// RVA: 0x3108B80 Offset: 0x3104B80 VA: 0x3108B80
	private Hashtable DeserializeHashTable(StreamBuffer din) { }

	// RVA: 0x3108C94 Offset: 0x3104C94 VA: 0x3108C94
	private IDictionary DeserializeDictionary(StreamBuffer din) { }

	// RVA: 0x3109B3C Offset: 0x3105B3C VA: 0x3109B3C
	private bool DeserializeDictionaryArray(StreamBuffer din, short size, out Array arrayResult) { }

	// RVA: 0x3109DA4 Offset: 0x3105DA4 VA: 0x3109DA4
	private Type DeserializeDictionaryType(StreamBuffer reader, out byte keyTypeCode, out byte valTypeCode) { }

	// RVA: 0x31045B0 Offset: 0x31005B0 VA: 0x31045B0
	public void .ctor() { }

	// RVA: 0x3109FA4 Offset: 0x3105FA4 VA: 0x3109FA4
	private static void .cctor() { }
}
