// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents
public class MiniGameMemberStateEvent : EventSubBase // TypeDefIndex: 12689
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

	// Properties
	public byte State { get; set; }
	public long LeftStartUpTime { get; set; }
	public long LeftEndTime { get; set; }
	public MiniGameTeamData TeamA { get; set; }
	public MiniGameTeamData TeamB { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3642860 Offset: 0x363E860 VA: 0x3642860
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3642868 Offset: 0x363E868 VA: 0x3642868
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x3642870 Offset: 0x363E870 VA: 0x3642870
	public void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3642878 Offset: 0x363E878 VA: 0x3642878
	public long get_LeftStartUpTime() { }

	[CompilerGenerated]
	// RVA: 0x3642880 Offset: 0x363E880 VA: 0x3642880
	public void set_LeftStartUpTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x3642888 Offset: 0x363E888 VA: 0x3642888
	public long get_LeftEndTime() { }

	[CompilerGenerated]
	// RVA: 0x3642890 Offset: 0x363E890 VA: 0x3642890
	public void set_LeftEndTime(long value) { }

	[CompilerGenerated]
	// RVA: 0x3642898 Offset: 0x363E898 VA: 0x3642898
	public MiniGameTeamData get_TeamA() { }

	[CompilerGenerated]
	// RVA: 0x36428A0 Offset: 0x363E8A0 VA: 0x36428A0
	public void set_TeamA(MiniGameTeamData value) { }

	[CompilerGenerated]
	// RVA: 0x36428A8 Offset: 0x363E8A8 VA: 0x36428A8
	public MiniGameTeamData get_TeamB() { }

	[CompilerGenerated]
	// RVA: 0x36428B0 Offset: 0x363E8B0 VA: 0x36428B0
	public void set_TeamB(MiniGameTeamData value) { }

	// RVA: 0x36428B8 Offset: 0x363E8B8 VA: 0x36428B8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36428C0 Offset: 0x363E8C0 VA: 0x36428C0 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36428C8 Offset: 0x363E8C8 VA: 0x36428C8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3642A9C Offset: 0x363EA9C VA: 0x3642A9C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3642B44 Offset: 0x363EB44 VA: 0x3642B44 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3642D18 Offset: 0x363ED18 VA: 0x3642D18 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
