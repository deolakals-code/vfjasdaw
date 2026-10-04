// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.BCollaboration.Operations
public class BCollaborationGetRankingResponse : OperationResponseBase // TypeDefIndex: 13064
{
	// Fields
	[CompilerGenerated]
	private short <MainWeapon>k__BackingField; // 0x20
	[CompilerGenerated]
	private short <SubWeapon>k__BackingField; // 0x22
	[CompilerGenerated]
	private BCollaborationRankingSendData[] <Ranking>k__BackingField; // 0x28
	[CompilerGenerated]
	private BCRankingPropertiesData <PropertyFirst>k__BackingField; // 0x30
	[CompilerGenerated]
	private BCRankingPropertiesData <PropertySecond>k__BackingField; // 0x38
	[CompilerGenerated]
	private BCRankingPropertiesData <PropertyThird>k__BackingField; // 0x40
	[CompilerGenerated]
	private int <ElapsedTime>k__BackingField; // 0x48

	// Properties
	[PacketParameter(Code = 78)]
	public short MainWeapon { get; set; }
	[PacketParameter(Code = 79)]
	public short SubWeapon { get; set; }
	public BCollaborationRankingSendData[] Ranking { get; set; }
	public BCRankingPropertiesData PropertyFirst { get; set; }
	public BCRankingPropertiesData PropertySecond { get; set; }
	public BCRankingPropertiesData PropertyThird { get; set; }
	public int ElapsedTime { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x369B574 Offset: 0x3697574 VA: 0x369B574
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x369B57C Offset: 0x369757C VA: 0x369B57C
	public short get_MainWeapon() { }

	[CompilerGenerated]
	// RVA: 0x369B584 Offset: 0x3697584 VA: 0x369B584
	public void set_MainWeapon(short value) { }

	[CompilerGenerated]
	// RVA: 0x369B58C Offset: 0x369758C VA: 0x369B58C
	public short get_SubWeapon() { }

	[CompilerGenerated]
	// RVA: 0x369B594 Offset: 0x3697594 VA: 0x369B594
	public void set_SubWeapon(short value) { }

	[CompilerGenerated]
	// RVA: 0x369B59C Offset: 0x369759C VA: 0x369B59C
	public BCollaborationRankingSendData[] get_Ranking() { }

	[CompilerGenerated]
	// RVA: 0x369B5A4 Offset: 0x36975A4 VA: 0x369B5A4
	public void set_Ranking(BCollaborationRankingSendData[] value) { }

	[CompilerGenerated]
	// RVA: 0x369B5AC Offset: 0x36975AC VA: 0x369B5AC
	public BCRankingPropertiesData get_PropertyFirst() { }

	[CompilerGenerated]
	// RVA: 0x369B5B4 Offset: 0x36975B4 VA: 0x369B5B4
	public void set_PropertyFirst(BCRankingPropertiesData value) { }

	[CompilerGenerated]
	// RVA: 0x369B5BC Offset: 0x36975BC VA: 0x369B5BC
	public BCRankingPropertiesData get_PropertySecond() { }

	[CompilerGenerated]
	// RVA: 0x369B5C4 Offset: 0x36975C4 VA: 0x369B5C4
	public void set_PropertySecond(BCRankingPropertiesData value) { }

	[CompilerGenerated]
	// RVA: 0x369B5CC Offset: 0x36975CC VA: 0x369B5CC
	public BCRankingPropertiesData get_PropertyThird() { }

	[CompilerGenerated]
	// RVA: 0x369B5D4 Offset: 0x36975D4 VA: 0x369B5D4
	public void set_PropertyThird(BCRankingPropertiesData value) { }

	[CompilerGenerated]
	// RVA: 0x369B5DC Offset: 0x36975DC VA: 0x369B5DC
	public int get_ElapsedTime() { }

	[CompilerGenerated]
	// RVA: 0x369B5E4 Offset: 0x36975E4 VA: 0x369B5E4
	public void set_ElapsedTime(int value) { }

	// RVA: 0x369B5EC Offset: 0x36975EC VA: 0x369B5EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x369B5F4 Offset: 0x36975F4 VA: 0x369B5F4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x369B5FC Offset: 0x36975FC VA: 0x369B5FC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x369B950 Offset: 0x3697950 VA: 0x369B950
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x369BB20 Offset: 0x3697B20 VA: 0x369BB20 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x369BCF4 Offset: 0x3697CF4 VA: 0x369BCF4 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
