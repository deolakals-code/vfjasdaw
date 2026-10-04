// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Operations
public class GmPetReset : OperationRequestBase // TypeDefIndex: 17620
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20

	// Properties
	public long PetUuid { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x379913C Offset: 0x379513C VA: 0x379913C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3799144 Offset: 0x3795144 VA: 0x3799144
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x379914C Offset: 0x379514C VA: 0x379914C
	public void set_PetUuid(long value) { }

	// RVA: 0x3799154 Offset: 0x3795154 VA: 0x3799154 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x379915C Offset: 0x379515C VA: 0x379915C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3799164 Offset: 0x3795164 VA: 0x3799164 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3799284 Offset: 0x3795284 VA: 0x3799284 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
