// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildInviteCancelAllResponse : PacketBase // TypeDefIndex: 12357
{
	// Fields
	[CompilerGenerated]
	private GuildReserveData[] <Cancels>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x28

	// Properties
	public GuildReserveData[] Cancels { get; set; }
	public short ReturnCode { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35F9FDC Offset: 0x35F5FDC VA: 0x35F9FDC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35F9FE4 Offset: 0x35F5FE4 VA: 0x35F9FE4
	public GuildReserveData[] get_Cancels() { }

	[CompilerGenerated]
	// RVA: 0x35F9FEC Offset: 0x35F5FEC VA: 0x35F9FEC
	public void set_Cancels(GuildReserveData[] value) { }

	[CompilerGenerated]
	// RVA: 0x35F9FF4 Offset: 0x35F5FF4 VA: 0x35F9FF4
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x35F9FFC Offset: 0x35F5FFC VA: 0x35F9FFC
	public void set_ReturnCode(short value) { }

	// RVA: 0x35FA004 Offset: 0x35F6004 VA: 0x35FA004 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FA00C Offset: 0x35F600C VA: 0x35FA00C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35FA114 Offset: 0x35F6114 VA: 0x35FA114 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
