// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: 
private sealed class Json.Serializer // TypeDefIndex: 17107
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x1705BF4 Offset: 0x1701BF4 VA: 0x1705BF4
	private void .ctor() { }

	// RVA: 0x1704F80 Offset: 0x1700F80 VA: 0x1704F80
	public static string Serialize(object obj) { }

	// RVA: 0x1705C60 Offset: 0x1701C60 VA: 0x1705C60
	private void SerializeValue(object value) { }

	// RVA: 0x170644C Offset: 0x170244C VA: 0x170644C
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x17060EC Offset: 0x17020EC VA: 0x17060EC
	private void SerializeArray(IList anArray) { }

	// RVA: 0x1705E30 Offset: 0x1701E30 VA: 0x1705E30
	private void SerializeString(string str) { }

	// RVA: 0x17068D8 Offset: 0x17028D8 VA: 0x17068D8
	private void SerializeOther(object value) { }
}
