// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Operations
public class BCollaborationMatchingChange : OperationRequestBase // TypeDefIndex: 13061
{
	// Fields
	[CompilerGenerated]
	private bool <MatchingFlag>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 20)]
	public bool MatchingFlag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x369B0EC Offset: 0x36970EC VA: 0x369B0EC
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x369B0F4 Offset: 0x36970F4 VA: 0x369B0F4
	public bool get_MatchingFlag() { }

	[CompilerGenerated]
	// RVA: 0x369B0FC Offset: 0x36970FC VA: 0x369B0FC
	public void set_MatchingFlag(bool value) { }

	// RVA: 0x369B108 Offset: 0x3697108 VA: 0x369B108 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369B110 Offset: 0x3697110 VA: 0x369B110 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x369B118 Offset: 0x3697118 VA: 0x369B118 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x369B240 Offset: 0x3697240 VA: 0x369B240 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
