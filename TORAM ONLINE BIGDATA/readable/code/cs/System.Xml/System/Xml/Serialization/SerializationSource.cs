// Assembly: System.Xml.dll
// Namespace: System.Xml.Serialization
internal abstract class SerializationSource // TypeDefIndex: 13500
{
	// Fields
	private Type[] includedTypes; // 0x10
	private string namspace; // 0x18
	private bool canBeGenerated; // 0x20

	// Methods

	// RVA: 0x33E7F34 Offset: 0x33E3F34 VA: 0x33E7F34
	public void .ctor(string namspace, Type[] includedTypes) { }

	// RVA: 0x33E7F80 Offset: 0x33E3F80 VA: 0x33E7F80
	protected bool BaseEquals(SerializationSource other) { }
}
