// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectWithMap // TypeDefIndex: 10401
{
	// Fields
	internal BinaryHeaderEnum binaryHeaderEnum; // 0x10
	internal int objectId; // 0x14
	internal string name; // 0x18
	internal int numMembers; // 0x20
	internal string[] memberNames; // 0x28
	internal int assemId; // 0x30

	// Methods

	// RVA: 0x2F08D28 Offset: 0x2F04D28 VA: 0x2F08D28
	internal void .ctor() { }

	// RVA: 0x2F08D30 Offset: 0x2F04D30 VA: 0x2F08D30
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x2F08D58 Offset: 0x2F04D58 VA: 0x2F08D58
	internal void Set(int objectId, string name, int numMembers, string[] memberNames, int assemId) { }

	// RVA: 0x2F08DBC Offset: 0x2F04DBC VA: 0x2F08DBC Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x2F08ED0 Offset: 0x2F04ED0 VA: 0x2F08ED0 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x2F0903C Offset: 0x2F0503C VA: 0x2F0903C
	public void Dump() { }
}
