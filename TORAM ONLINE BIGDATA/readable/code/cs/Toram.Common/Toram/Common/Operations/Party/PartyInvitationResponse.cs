// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party
public class PartyInvitationResponse : PacketBase // TypeDefIndex: 11467
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <TargetName>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 98)]
	public string TargetName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x370EDD0 Offset: 0x370ADD0 VA: 0x370EDD0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x370EDD8 Offset: 0x370ADD8 VA: 0x370EDD8
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x370EDE0 Offset: 0x370ADE0 VA: 0x370EDE0
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370EDE8 Offset: 0x370ADE8 VA: 0x370EDE8
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x370EDF0 Offset: 0x370ADF0 VA: 0x370EDF0
	public void set_TargetName(string value) { }

	// RVA: 0x370EDF8 Offset: 0x370ADF8 VA: 0x370EDF8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370EE00 Offset: 0x370AE00 VA: 0x370EE00 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370EF78 Offset: 0x370AF78 VA: 0x370EF78 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
