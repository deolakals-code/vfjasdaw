// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObjectString // TypeDefIndex: 10397
{
	// Fields
	internal int objectId; // 0x10
	internal string value; // 0x18

	// Methods

	// RVA: 0x2F0869C Offset: 0x2F0469C VA: 0x2F0869C
	internal void .ctor() { }

	// RVA: 0x2F086A4 Offset: 0x2F046A4 VA: 0x2F086A4
	internal void Set(int objectId, string value) { }

	// RVA: 0x2F086B4 Offset: 0x2F046B4 VA: 0x2F086B4 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x2F08724 Offset: 0x2F04724 VA: 0x2F08724 Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x2F08788 Offset: 0x2F04788 VA: 0x2F08788
	public void Dump() { }
}
