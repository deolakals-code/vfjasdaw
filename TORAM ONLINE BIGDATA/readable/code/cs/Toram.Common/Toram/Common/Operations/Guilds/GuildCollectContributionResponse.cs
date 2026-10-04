// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildCollectContributionResponse : OperationResponseBase // TypeDefIndex: 12382
{
	// Fields
	[CompilerGenerated]
	private int <CollectPoint>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <CollectTime>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 205)]
	public int CollectPoint { get; set; }
	[PacketParameter(Code = 172, IsOptional = True)]
	public DateTime CollectTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35FEC1C Offset: 0x35FAC1C VA: 0x35FEC1C
	public void .ctor() { }

	// RVA: 0x35FEC24 Offset: 0x35FAC24 VA: 0x35FEC24
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FEC2C Offset: 0x35FAC2C VA: 0x35FEC2C
	public int get_CollectPoint() { }

	[CompilerGenerated]
	// RVA: 0x35FEC34 Offset: 0x35FAC34 VA: 0x35FEC34
	public void set_CollectPoint(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FEC3C Offset: 0x35FAC3C VA: 0x35FEC3C
	public DateTime get_CollectTime() { }

	[CompilerGenerated]
	// RVA: 0x35FEC44 Offset: 0x35FAC44 VA: 0x35FEC44
	public void set_CollectTime(DateTime value) { }

	// RVA: 0x35FEC4C Offset: 0x35FAC4C VA: 0x35FEC4C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FEC54 Offset: 0x35FAC54 VA: 0x35FEC54 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FEC5C Offset: 0x35FAC5C VA: 0x35FEC5C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FEE20 Offset: 0x35FAE20 VA: 0x35FEE20 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
