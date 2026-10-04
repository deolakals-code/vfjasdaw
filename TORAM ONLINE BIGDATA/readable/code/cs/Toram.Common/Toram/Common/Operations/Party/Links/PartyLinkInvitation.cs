// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party.Links
public class PartyLinkInvitation : OperationRequestBase // TypeDefIndex: 11503
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20

	// Properties
	public int TargetId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37146B8 Offset: 0x37106B8 VA: 0x37146B8
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x37146C0 Offset: 0x37106C0 VA: 0x37146C0
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x37146C8 Offset: 0x37106C8 VA: 0x37146C8
	public void set_TargetId(int value) { }

	// RVA: 0x37146D0 Offset: 0x37106D0 VA: 0x37146D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37146D8 Offset: 0x37106D8 VA: 0x37146D8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37146E0 Offset: 0x37106E0 VA: 0x37146E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3714800 Offset: 0x3710800 VA: 0x3714800 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
