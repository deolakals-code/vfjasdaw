// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildGetBoosterResponse : OperationRequestBase // TypeDefIndex: 12377
{
	// Fields
	[CompilerGenerated]
	private GuildBoosterData <BoosterData>k__BackingField; // 0x20

	// Properties
	[PacketClass(Code = 199)]
	public GuildBoosterData BoosterData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35FD3DC Offset: 0x35F93DC VA: 0x35FD3DC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FD3E4 Offset: 0x35F93E4 VA: 0x35FD3E4
	public GuildBoosterData get_BoosterData() { }

	[CompilerGenerated]
	// RVA: 0x35FD3EC Offset: 0x35F93EC VA: 0x35FD3EC
	public void set_BoosterData(GuildBoosterData value) { }

	// RVA: 0x35FD3F4 Offset: 0x35F93F4 VA: 0x35FD3F4 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FD3FC Offset: 0x35F93FC VA: 0x35FD3FC Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FD404 Offset: 0x35F9404 VA: 0x35FD404 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FD5A0 Offset: 0x35F95A0 VA: 0x35FD5A0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
