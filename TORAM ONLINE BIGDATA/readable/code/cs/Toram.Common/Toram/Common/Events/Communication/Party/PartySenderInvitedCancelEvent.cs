// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartySenderInvitedCancelEvent : PacketBase // TypeDefIndex: 12880
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <SenderId>k__BackingField; // 0x28
	[CompilerGenerated]
	private string <SenderName>k__BackingField; // 0x30

	// Properties
	[PacketParameter(Code = 94)]
	public int PartyId { get; set; }
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 99)]
	public int SenderId { get; set; }
	[PacketParameter(Code = 100)]
	public string SenderName { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366E954 Offset: 0x366A954 VA: 0x366E954
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366E95C Offset: 0x366A95C VA: 0x366E95C
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366E964 Offset: 0x366A964 VA: 0x366E964
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366E96C Offset: 0x366A96C VA: 0x366E96C
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x366E974 Offset: 0x366A974 VA: 0x366E974
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366E97C Offset: 0x366A97C VA: 0x366E97C
	public int get_SenderId() { }

	[CompilerGenerated]
	// RVA: 0x366E984 Offset: 0x366A984 VA: 0x366E984
	public void set_SenderId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366E98C Offset: 0x366A98C VA: 0x366E98C
	public string get_SenderName() { }

	[CompilerGenerated]
	// RVA: 0x366E994 Offset: 0x366A994 VA: 0x366E994
	public void set_SenderName(string value) { }

	// RVA: 0x366E99C Offset: 0x366A99C VA: 0x366E99C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366E9A4 Offset: 0x366A9A4 VA: 0x366E9A4 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366EBAC Offset: 0x366ABAC VA: 0x366EBAC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
