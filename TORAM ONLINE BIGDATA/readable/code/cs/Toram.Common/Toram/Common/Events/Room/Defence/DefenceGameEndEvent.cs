// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.Defence
public class DefenceGameEndEvent : EventSubBase // TypeDefIndex: 12772
{
	// Fields
	[CompilerGenerated]
	private byte <GameEnd>k__BackingField; // 0x20
	[CompilerGenerated]
	private DefenceScore <Score>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <KillCount>k__BackingField; // 0x30
	[CompilerGenerated]
	private RewardResponseDatav2 <Reward>k__BackingField; // 0x38
	[CompilerGenerated]
	private int <Exp>k__BackingField; // 0x40

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public byte GameEnd { get; set; }
	public DefenceScore Score { get; set; }
	public int KillCount { get; set; }
	public RewardResponseDatav2 Reward { get; set; }
	public int Exp { get; set; }

	// Methods

	// RVA: 0x3655928 Offset: 0x3651928 VA: 0x3655928
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3655930 Offset: 0x3651930 VA: 0x3655930 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3655938 Offset: 0x3651938 VA: 0x3655938 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x3655940 Offset: 0x3651940 VA: 0x3655940
	public byte get_GameEnd() { }

	[CompilerGenerated]
	// RVA: 0x3655948 Offset: 0x3651948 VA: 0x3655948
	public void set_GameEnd(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3655950 Offset: 0x3651950 VA: 0x3655950
	public DefenceScore get_Score() { }

	[CompilerGenerated]
	// RVA: 0x3655958 Offset: 0x3651958 VA: 0x3655958
	public void set_Score(DefenceScore value) { }

	[CompilerGenerated]
	// RVA: 0x3655960 Offset: 0x3651960 VA: 0x3655960
	public int get_KillCount() { }

	[CompilerGenerated]
	// RVA: 0x3655968 Offset: 0x3651968 VA: 0x3655968
	public void set_KillCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x3655970 Offset: 0x3651970 VA: 0x3655970
	public RewardResponseDatav2 get_Reward() { }

	[CompilerGenerated]
	// RVA: 0x3655978 Offset: 0x3651978 VA: 0x3655978
	public void set_Reward(RewardResponseDatav2 value) { }

	[CompilerGenerated]
	// RVA: 0x3655980 Offset: 0x3651980 VA: 0x3655980
	public int get_Exp() { }

	[CompilerGenerated]
	// RVA: 0x3655988 Offset: 0x3651988 VA: 0x3655988
	public void set_Exp(int value) { }

	// RVA: 0x3655990 Offset: 0x3651990 VA: 0x3655990 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3655D28 Offset: 0x3651D28 VA: 0x3655D28 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
