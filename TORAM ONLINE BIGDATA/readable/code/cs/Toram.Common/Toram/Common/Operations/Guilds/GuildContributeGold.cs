// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds
public class GuildContributeGold : OperationRequestBase // TypeDefIndex: 12371
{
	// Fields
	[CompilerGenerated]
	private int <ContributeGold>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 28)]
	public int ContributeGold { get; set; }
	public override byte SubCode { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35FC798 Offset: 0x35F8798 VA: 0x35FC798
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35FC7A0 Offset: 0x35F87A0 VA: 0x35FC7A0
	public int get_ContributeGold() { }

	[CompilerGenerated]
	// RVA: 0x35FC7A8 Offset: 0x35F87A8 VA: 0x35FC7A8
	public void set_ContributeGold(int value) { }

	// RVA: 0x35FC7B0 Offset: 0x35F87B0 VA: 0x35FC7B0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35FC7B8 Offset: 0x35F87B8 VA: 0x35FC7B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35FC7C0 Offset: 0x35F87C0 VA: 0x35FC7C0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35FC860 Offset: 0x35F8860 VA: 0x35FC860 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
