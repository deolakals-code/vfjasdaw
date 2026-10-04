// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.PetRace
public class PetRacePetSelect : OperationRequestBase // TypeDefIndex: 12229
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20

	// Properties
	public long PetUuid { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E3EF0 Offset: 0x35DFEF0 VA: 0x35E3EF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35E3EF8 Offset: 0x35DFEF8 VA: 0x35E3EF8
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35E3F00 Offset: 0x35DFF00 VA: 0x35E3F00
	public void set_PetUuid(long value) { }

	// RVA: 0x35E3F08 Offset: 0x35DFF08 VA: 0x35E3F08 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E3F10 Offset: 0x35DFF10 VA: 0x35E3F10 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E3F18 Offset: 0x35DFF18 VA: 0x35E3F18 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35E3FB8 Offset: 0x35DFFB8 VA: 0x35E3FB8 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
