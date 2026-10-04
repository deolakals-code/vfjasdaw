// Assembly: Newtonsoft.Json.dll
// Namespace: Newtonsoft.Json.Bson
[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class BsonWriter : JsonWriter // TypeDefIndex: 16110
{
	// Fields
	private BsonToken _root; // 0x60
	private BsonToken _parent; // 0x68
	private string _propertyName; // 0x70

	// Methods

	// RVA: 0x30EC980 Offset: 0x30E8980 VA: 0x30EC980
	private void AddValue(object value, BsonType type) { }

	// RVA: 0x30ECA00 Offset: 0x30E8A00 VA: 0x30ECA00
	internal void AddToken(BsonToken token) { }

	// RVA: 0x30ECBE8 Offset: 0x30E8BE8 VA: 0x30ECBE8
	public void WriteObjectId(byte[] value) { }

	// RVA: 0x30DE5D8 Offset: 0x30DA5D8 VA: 0x30DE5D8
	public void WriteRegex(string pattern, string options) { }
}
