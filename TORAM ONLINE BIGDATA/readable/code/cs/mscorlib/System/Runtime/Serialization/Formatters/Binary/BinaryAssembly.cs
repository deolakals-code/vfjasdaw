// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryAssembly // TypeDefIndex: 10392
{
	// Fields
	internal int assemId; // 0x10
	internal string assemblyString; // 0x18

	// Methods

	// RVA: 0x2F080F4 Offset: 0x2F040F4 VA: 0x2F080F4
	internal void .ctor() { }

	// RVA: 0x2F080FC Offset: 0x2F040FC VA: 0x2F080FC
	internal void Set(int assemId, string assemblyString) { }

	// RVA: 0x2F0810C Offset: 0x2F0410C VA: 0x2F0810C Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x2F0817C Offset: 0x2F0417C VA: 0x2F0817C Slot: 5
	public void Read(__BinaryParser input) { }

	// RVA: 0x2F081E0 Offset: 0x2F041E0 VA: 0x2F081E0
	public void Dump() { }
}
