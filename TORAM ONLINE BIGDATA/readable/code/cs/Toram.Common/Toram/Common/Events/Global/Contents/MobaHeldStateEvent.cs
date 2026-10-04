// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents
public class MobaHeldStateEvent : EventSubBase // TypeDefIndex: 12655
{
	// Fields
	[CompilerGenerated]
	private MobaGameData[] <HeldGames>k__BackingField; // 0x20
	[CompilerGenerated]
	private TimeSpan <NextPartyGameTime>k__BackingField; // 0x28

	// Properties
	public MobaGameData[] HeldGames { get; set; }
	public TimeSpan NextPartyGameTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363AB58 Offset: 0x3636B58 VA: 0x363AB58
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363AB60 Offset: 0x3636B60 VA: 0x363AB60
	public MobaGameData[] get_HeldGames() { }

	[CompilerGenerated]
	// RVA: 0x363AB68 Offset: 0x3636B68 VA: 0x363AB68
	public void set_HeldGames(MobaGameData[] value) { }

	[CompilerGenerated]
	// RVA: 0x363AB70 Offset: 0x3636B70 VA: 0x363AB70
	public TimeSpan get_NextPartyGameTime() { }

	[CompilerGenerated]
	// RVA: 0x363AB78 Offset: 0x3636B78 VA: 0x363AB78
	public void set_NextPartyGameTime(TimeSpan value) { }

	// RVA: 0x363AB80 Offset: 0x3636B80 VA: 0x363AB80 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363AB88 Offset: 0x3636B88 VA: 0x363AB88 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363AB90 Offset: 0x3636B90 VA: 0x363AB90 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363AC90 Offset: 0x3636C90 VA: 0x363AC90 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
