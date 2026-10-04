// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildChangeRenovationResponse : OperationResponseBase // TypeDefIndex: 12359
{
	// Fields
	[CompilerGenerated]
	private byte <RenovationId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 2)]
	public byte RenovationId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35FA720 Offset: 0x35F6720 VA: 0x35FA720
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FA728 Offset: 0x35F6728 VA: 0x35FA728
	public byte get_RenovationId() { }

	[CompilerGenerated]
	// RVA: 0x35FA730 Offset: 0x35F6730 VA: 0x35FA730
	public void set_RenovationId(byte value) { }

	// RVA: 0x35FA738 Offset: 0x35F6738 VA: 0x35FA738 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FA740 Offset: 0x35F6740 VA: 0x35FA740 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FA748 Offset: 0x35F6748 VA: 0x35FA748 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FA868 Offset: 0x35F6868 VA: 0x35FA868 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
