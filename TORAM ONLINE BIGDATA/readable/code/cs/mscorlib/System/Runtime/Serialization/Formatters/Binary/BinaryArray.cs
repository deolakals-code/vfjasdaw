// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class BinaryArray // TypeDefIndex: 10403
{
	// Fields
	internal int objectId; // 0x10
	internal int rank; // 0x14
	internal int[] lengthA; // 0x18
	internal int[] lowerBoundA; // 0x20
	internal BinaryTypeEnum binaryTypeEnum; // 0x28
	internal object typeInformation; // 0x30
	internal int assemId; // 0x38
	private BinaryHeaderEnum binaryHeaderEnum; // 0x3C
	internal BinaryArrayTypeEnum binaryArrayTypeEnum; // 0x40

	// Methods

	// RVA: 0x2F09640 Offset: 0x2F05640 VA: 0x2F09640
	internal void .ctor() { }

	// RVA: 0x2F09648 Offset: 0x2F05648 VA: 0x2F09648
	internal void .ctor(BinaryHeaderEnum binaryHeaderEnum) { }

	// RVA: 0x2F09670 Offset: 0x2F05670 VA: 0x2F09670
	internal void Set(int objectId, int rank, int[] lengthA, int[] lowerBoundA, BinaryTypeEnum binaryTypeEnum, object typeInformation, BinaryArrayTypeEnum binaryArrayTypeEnum, int assemId) { }

	// RVA: 0x2F09720 Offset: 0x2F05720 VA: 0x2F09720 Slot: 4
	public void Write(__BinaryWriter sout) { }

	// RVA: 0x2F099F8 Offset: 0x2F059F8 VA: 0x2F099F8 Slot: 5
	public void Read(__BinaryParser input) { }
}
