// Assembly: Toram.Client.dll
// Namespace: 
private class PacketDeserializer.ProtocolDeserializer // TypeDefIndex: 15122
{
	// Fields
	private readonly byte[] memShort; // 0x10
	private readonly byte[] memInt; // 0x18
	private readonly byte[] memLong; // 0x20
	private readonly byte[] memFloat; // 0x28
	private readonly byte[] memDouble; // 0x30
	private byte[] memString; // 0x38

	// Methods

	// RVA: 0x3583034 Offset: 0x357F034 VA: 0x3583034
	private Type GetTypeOfCode(byte typeCode) { }

	// RVA: 0x3583358 Offset: 0x357F358 VA: 0x3583358
	private Array CreateArrayByType(byte arrayType, short length) { }

	// RVA: 0x3583374 Offset: 0x357F374 VA: 0x3583374
	public object Deserialize(StreamBuffer din, byte type) { }

	// RVA: 0x3583BAC Offset: 0x357FBAC VA: 0x3583BAC
	public byte DeserializeByte(StreamBuffer din) { }

	// RVA: 0x35844A0 Offset: 0x35804A0 VA: 0x35844A0
	private bool DeserializeBoolean(StreamBuffer din) { }

	// RVA: 0x3584124 Offset: 0x3580124 VA: 0x3584124
	public short DeserializeShort(StreamBuffer din) { }

	// RVA: 0x3583FE0 Offset: 0x357FFE0 VA: 0x3583FE0
	private int DeserializeInteger(StreamBuffer din) { }

	// RVA: 0x3584234 Offset: 0x3580234 VA: 0x3584234
	private long DeserializeLong(StreamBuffer din) { }

	// RVA: 0x3583D68 Offset: 0x357FD68 VA: 0x3583D68
	private float DeserializeFloat(StreamBuffer din) { }

	// RVA: 0x3583BD8 Offset: 0x357FBD8 VA: 0x3583BD8
	private double DeserializeDouble(StreamBuffer din) { }

	// RVA: 0x35844D4 Offset: 0x35804D4 VA: 0x35844D4
	private string DeserializeString(StreamBuffer din) { }

	// RVA: 0x358467C Offset: 0x358067C VA: 0x358467C
	private Array DeserializeArray(StreamBuffer din) { }

	// RVA: 0x35845D8 Offset: 0x35805D8 VA: 0x35845D8
	private byte[] DeserializeByteArray(StreamBuffer din, int size = -1) { }

	// RVA: 0x35843D4 Offset: 0x35803D4 VA: 0x35843D4
	private int[] DeserializeIntArray(StreamBuffer din, int size = -1) { }

	// RVA: 0x3583AD4 Offset: 0x357FAD4 VA: 0x3583AD4
	private string[] DeserializeStringArray(StreamBuffer din) { }

	// RVA: 0x35848EC Offset: 0x35808EC VA: 0x35848EC
	private object[] DeserializeObjectArray(StreamBuffer din) { }

	// RVA: 0x3583EB8 Offset: 0x357FEB8 VA: 0x3583EB8
	private Dictionary<object, object> DeserializeHashTable(StreamBuffer din) { }

	// RVA: 0x35837BC Offset: 0x357F7BC VA: 0x35837BC
	private IDictionary DeserializeDictionary(StreamBuffer din) { }

	// RVA: 0x3584A10 Offset: 0x3580A10 VA: 0x3584A10
	private bool DeserializeDictionaryArray(StreamBuffer din, short size, out Array arrayResult) { }

	// RVA: 0x3584C50 Offset: 0x3580C50 VA: 0x3584C50
	private Type DeserializeDictionaryType(StreamBuffer reader, out byte keyTypeCode, out byte valTypeCode) { }

	// RVA: 0x3582F18 Offset: 0x357EF18 VA: 0x3582F18
	public Dictionary<byte, object> DeserializeParameterTable(StreamBuffer stream) { }

	// RVA: 0x3582DA8 Offset: 0x357EDA8 VA: 0x3582DA8
	public void .ctor() { }
}
