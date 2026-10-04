// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryObject // TypeDefIndex: 10394
{
	// Fields
	internal int objectId; // 0x10
	internal int mapId; // 0x14

	// Methods

	// RVA: 0x2F0824C Offset: 0x2F0424C VA: 0x2F0824C
	internal void .ctor() { }

	// RVA: 0x2F08254 Offset: 0x2F04254 VA: 0x2F08254
	internal void Set(int objectId, int mapId) { }

	// RVA: 0x2F0825C Offset: 0x2F0425C VA: 0x2F0825C Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x2F082CC Offset: 0x2F042CC VA: 0x2F082CC Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x2F08328 Offset: 0x2F04328 VA: 0x2F08328
	public void Dump() { }
}
