// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaUpdateStatus : OperationRequestBase // TypeDefIndex: 11617
{
	// Fields
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x20

	// Properties
	public PrimaryStatusData PrimaryStatus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3725FD4 Offset: 0x3721FD4 VA: 0x3725FD4
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3725FDC Offset: 0x3721FDC VA: 0x3725FDC
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x3725FE4 Offset: 0x3721FE4 VA: 0x3725FE4
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	// RVA: 0x3725FEC Offset: 0x3721FEC VA: 0x3725FEC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3725FF4 Offset: 0x3721FF4 VA: 0x3725FF4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3725FFC Offset: 0x3721FFC VA: 0x3725FFC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3726084 Offset: 0x3722084 VA: 0x3726084 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
