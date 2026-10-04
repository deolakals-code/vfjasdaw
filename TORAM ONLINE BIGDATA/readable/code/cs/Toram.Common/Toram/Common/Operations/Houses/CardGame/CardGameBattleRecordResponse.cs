// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.CardGame
public class CardGameBattleRecordResponse : OperationResponseBase // TypeDefIndex: 12268
{
	// Fields
	[CompilerGenerated]
	private int <MyRate>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <HighestScore>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsRateValid>k__BackingField; // 0x26

	// Properties
	public int MyRate { get; set; }
	public short HighestScore { get; set; }
	public bool IsRateValid { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E97CC Offset: 0x35E57CC VA: 0x35E97CC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E97D4 Offset: 0x35E57D4 VA: 0x35E97D4
	public int get_MyRate() { }

	[CompilerGenerated]
	// RVA: 0x35E97DC Offset: 0x35E57DC VA: 0x35E97DC
	public void set_MyRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x35E97E4 Offset: 0x35E57E4 VA: 0x35E97E4
	public short get_HighestScore() { }

	[CompilerGenerated]
	// RVA: 0x35E97EC Offset: 0x35E57EC VA: 0x35E97EC
	public void set_HighestScore(short value) { }

	[CompilerGenerated]
	// RVA: 0x35E97F4 Offset: 0x35E57F4 VA: 0x35E97F4
	public bool get_IsRateValid() { }

	[CompilerGenerated]
	// RVA: 0x35E97FC Offset: 0x35E57FC VA: 0x35E97FC
	public void set_IsRateValid(bool value) { }

	// RVA: 0x35E9808 Offset: 0x35E5808 VA: 0x35E9808 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E9810 Offset: 0x35E5810 VA: 0x35E9810 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E9818 Offset: 0x35E5818 VA: 0x35E9818 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E99F0 Offset: 0x35E59F0 VA: 0x35E99F0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
