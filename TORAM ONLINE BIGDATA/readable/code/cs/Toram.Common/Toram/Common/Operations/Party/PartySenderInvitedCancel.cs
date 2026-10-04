// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party
public class PartySenderInvitedCancel : PacketBase // TypeDefIndex: 11474
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

	// RVA: 0x370FB0C Offset: 0x370BB0C VA: 0x370FB0C
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x370FB14 Offset: 0x370BB14 VA: 0x370FB14
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x370FB1C Offset: 0x370BB1C VA: 0x370FB1C
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x370FB24 Offset: 0x370BB24 VA: 0x370FB24
	public string get_TargetName() { }

	[CompilerGenerated]
	// RVA: 0x370FB2C Offset: 0x370BB2C VA: 0x370FB2C
	public void set_TargetName(string value) { }

	// RVA: 0x370FB34 Offset: 0x370BB34 VA: 0x370FB34 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370FB3C Offset: 0x370BB3C VA: 0x370FB3C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370FCB4 Offset: 0x370BCB4 VA: 0x370FCB4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
