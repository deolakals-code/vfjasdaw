// Assembly: Assembly-CSharp-firstpass.dll
// Namespace: 
private sealed class Json.Serializer // TypeDefIndex: 17103
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x1703E60 Offset: 0x16FFE60 VA: 0x1703E60
	private void .ctor() { }

	// RVA: 0x17031EC Offset: 0x16FF1EC VA: 0x17031EC
	public static string Serialize(object obj) { }

	// RVA: 0x1703ECC Offset: 0x16FFECC VA: 0x1703ECC
	private void SerializeValue(object value) { }

	// RVA: 0x17046B8 Offset: 0x17006B8 VA: 0x17046B8
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x1704358 Offset: 0x1700358 VA: 0x1704358
	private void SerializeArray(IList anArray) { }

	// RVA: 0x170409C Offset: 0x170009C VA: 0x170409C
	private void SerializeString(string str) { }

	// RVA: 0x1704B44 Offset: 0x1700B44 VA: 0x1704B44
	private void SerializeOther(object value) { }
}
