// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.MiniGame
public class MiniGameJoinResponse : OperationResponseBase // TypeDefIndex: 12003
{
	// Fields
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x20
	[CompilerGenerated]
	private long <LeftStartUpTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private long <LeftEndTime>k__BackingField; // 0x30
	[CompilerGenerated]
	private MiniGameTeamData <TeamA>k__BackingField; // 0x38
	[CompilerGenerated]
	private MiniGameTeamData <TeamB>k__BackingField; // 0x40
	[CompilerGenerated]
	private MiniGameResultData <Result>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <ItemPermission>k__BackingField; // 0x50

	// Properties
	public byte State { get; set; }
	public long LeftStartUpTime { get; set; }
	public long LeftEndTime { get; set; }
	public MiniGameTeamData TeamA { get; set; }
	public MiniGameTeamData TeamB { get; set; }
	public MiniGameResultData Result { get; set; }
	public bool ItemPermission { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3774CFC Offset: 0x3770CFC VA: 0x3774CFC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3774D04 Offset: 0x3770D04 VA: 0x3774D04
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x3774D0C Offset: 0x3770D0C VA: 0x3774D0C
	public void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3774D14 Offset: 0x3770D14 VA: 0x3774D14
	public long get_LeftStartUpTime() { }

	[CompilerGenerated]
	// RVA: 0x3774D1C Offset: 0x3770D1C VA: 0x3774D1C
	public void set_LeftStartUpTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x3774D24 Offset: 0x3770D24 VA: 0x3774D24
	public long get_LeftEndTime() { }

	[CompilerGenerated]
	// RVA: 0x3774D2C Offset: 0x3770D2C VA: 0x3774D2C
	public void set_LeftEndTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x3774D34 Offset: 0x3770D34 VA: 0x3774D34
	public MiniGameTeamData get_TeamA() { }

	[CompilerGenerated]
	// RVA: 0x3774D3C Offset: 0x3770D3C VA: 0x3774D3C
	public void set_TeamA(MiniGameTeamData value) { }

	[CompilerGenerated]
	// RVA: 0x3774D44 Offset: 0x3770D44 VA: 0x3774D44
	public MiniGameTeamData get_TeamB() { }

	[CompilerGenerated]
	// RVA: 0x3774D4C Offset: 0x3770D4C VA: 0x3774D4C
	public void set_TeamB(MiniGameTeamData value) { }

	[CompilerGenerated]
	// RVA: 0x3774D54 Offset: 0x3770D54 VA: 0x3774D54
	public MiniGameResultData get_Result() { }

	[CompilerGenerated]
	// RVA: 0x3774D5C Offset: 0x3770D5C VA: 0x3774D5C
	public void set_Result(MiniGameResultData value) { }

	[CompilerGenerated]
	// RVA: 0x3774D64 Offset: 0x3770D64 VA: 0x3774D64
	public bool get_ItemPermission() { }

	[CompilerGenerated]
	// RVA: 0x3774D6C Offset: 0x3770D6C VA: 0x3774D6C
	public void set_ItemPermission(bool value) { }

	// RVA: 0x3774D78 Offset: 0x3770D78 VA: 0x3774D78
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3774FF8 Offset: 0x3770FF8 VA: 0x3774FF8
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x37750CC Offset: 0x37710CC VA: 0x37750CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37750D4 Offset: 0x37710D4 VA: 0x37750D4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37750DC Offset: 0x37710DC VA: 0x37750DC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3775334 Offset: 0x3771334 VA: 0x3775334 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
