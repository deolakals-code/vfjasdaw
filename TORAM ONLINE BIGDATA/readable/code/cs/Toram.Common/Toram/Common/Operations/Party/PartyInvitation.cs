// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party
public class PartyInvitation : PacketBase // TypeDefIndex: 11466
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Message>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketParameter(Code = 83, IsOptional = True)]
	public string Message { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x370EB10 Offset: 0x370AB10 VA: 0x370EB10
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x370EB18 Offset: 0x370AB18 VA: 0x370EB18
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x370EB20 Offset: 0x370AB20 VA: 0x370EB20
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370EB28 Offset: 0x370AB28 VA: 0x370EB28
	public string get_Message() { }

	[CompilerGenerated]
	// RVA: 0x370EB30 Offset: 0x370AB30 VA: 0x370EB30
	public void set_Message(string value) { }

	// RVA: 0x370EB38 Offset: 0x370AB38 VA: 0x370EB38 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370EB40 Offset: 0x370AB40 VA: 0x370EB40 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370ECE4 Offset: 0x370ACE4 VA: 0x370ECE4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
