// Assembly: AppsFlyer.dll
// Namespace: 
private sealed class Json.Serializer // TypeDefIndex: 17273
{
	// Fields
	private StringBuilder builder; // 0x10

	// Methods

	// RVA: 0x16EDF4C Offset: 0x16E9F4C VA: 0x16EDF4C
	private void .ctor() { }

	// RVA: 0x16ED2D8 Offset: 0x16E92D8 VA: 0x16ED2D8
	public static string Serialize(object obj) { }

	// RVA: 0x16EDFB8 Offset: 0x16E9FB8 VA: 0x16EDFB8
	private void SerializeValue(object value) { }

	// RVA: 0x16EE7A4 Offset: 0x16EA7A4 VA: 0x16EE7A4
	private void SerializeObject(IDictionary obj) { }

	// RVA: 0x16EE444 Offset: 0x16EA444 VA: 0x16EE444
	private void SerializeArray(IList anArray) { }

	// RVA: 0x16EE188 Offset: 0x16EA188 VA: 0x16EE188
	private void SerializeString(string str) { }

	// RVA: 0x16EEC30 Offset: 0x16EAC30 VA: 0x16EEC30
	private void SerializeOther(object value) { }
}
