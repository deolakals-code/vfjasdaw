// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Party
public class PartyLeaderChange : PacketBase // TypeDefIndex: 11471
{
	// Fields
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x370F878 Offset: 0x370B878 VA: 0x370F878
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x370F880 Offset: 0x370B880 VA: 0x370F880
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x370F888 Offset: 0x370B888 VA: 0x370F888
	public void set_TargetId(int value) { }

	// RVA: 0x370F890 Offset: 0x370B890 VA: 0x370F890 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x370F898 Offset: 0x370B898 VA: 0x370F898 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x370F9B8 Offset: 0x370B9B8 VA: 0x370F9B8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
