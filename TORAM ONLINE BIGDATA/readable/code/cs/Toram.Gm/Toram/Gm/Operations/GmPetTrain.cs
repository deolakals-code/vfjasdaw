// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Operations
public class GmPetTrain : OperationRequestBase // TypeDefIndex: 17625
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <Train>k__BackingField; // 0x28

	// Properties
	public long PetUuid { get; set; }
	public short Train { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3799FC4 Offset: 0x3795FC4 VA: 0x3799FC4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3799FCC Offset: 0x3795FCC VA: 0x3799FCC
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x3799FD4 Offset: 0x3795FD4 VA: 0x3799FD4
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x3799FDC Offset: 0x3795FDC VA: 0x3799FDC
	public short get_Train() { }

	[CompilerGenerated]
	// RVA: 0x3799FE4 Offset: 0x3795FE4 VA: 0x3799FE4
	public void set_Train(short value) { }

	// RVA: 0x3799FEC Offset: 0x3795FEC VA: 0x3799FEC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3799FF4 Offset: 0x3795FF4 VA: 0x3799FF4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3799FFC Offset: 0x3795FFC VA: 0x3799FFC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x379A174 Offset: 0x3796174 VA: 0x379A174 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
