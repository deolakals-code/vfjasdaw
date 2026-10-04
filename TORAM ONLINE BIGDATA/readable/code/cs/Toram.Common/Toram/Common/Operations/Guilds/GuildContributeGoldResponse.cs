// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildContributeGoldResponse : OperationResponseBase // TypeDefIndex: 12373
{
	// Fields
	[CompilerGenerated]
	private int <GuildGold>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <ContributeGold>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 195)]
	public int GuildGold { get; set; }
	[PacketParameter(Code = 28)]
	public int Gold { get; set; }
	[PacketParameter(Code = 199)]
	public int ContributeGold { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35FCC48 Offset: 0x35F8C48 VA: 0x35FCC48
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35FCC50 Offset: 0x35F8C50 VA: 0x35FCC50
	public int get_GuildGold() { }

	[CompilerGenerated]
	// RVA: 0x35FCC58 Offset: 0x35F8C58 VA: 0x35FCC58
	public void set_GuildGold(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FCC60 Offset: 0x35F8C60 VA: 0x35FCC60
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35FCC68 Offset: 0x35F8C68 VA: 0x35FCC68
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x35FCC70 Offset: 0x35F8C70 VA: 0x35FCC70
	public int get_ContributeGold() { }

	[CompilerGenerated]
	// RVA: 0x35FCC78 Offset: 0x35F8C78 VA: 0x35FCC78
	public void set_ContributeGold(int value) { }

	// RVA: 0x35FCC80 Offset: 0x35F8C80 VA: 0x35FCC80 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FCC88 Offset: 0x35F8C88 VA: 0x35FCC88 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FCC90 Offset: 0x35F8C90 VA: 0x35FCC90 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35FCE40 Offset: 0x35F8E40 VA: 0x35FCE40 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
