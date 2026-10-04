// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Collaborations.NewWave.Events
public class NewWaveGameEndEvent : EventSubBase // TypeDefIndex: 13049
{
	// Fields
	[CompilerGenerated]
	private byte <GameEndCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Result>k__BackingField; // 0x24
	[CompilerGenerated]
	private short <ScriptRetval>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <MonsterDeadCount>k__BackingField; // 0x2C
	[CompilerGenerated]
	private int <Time>k__BackingField; // 0x30
	[CompilerGenerated]
	private byte <BossSubjugation>k__BackingField; // 0x34
	[CompilerGenerated]
	private byte <AvatarBonus>k__BackingField; // 0x35

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	[PacketClass(Code = 141)]
	public byte GameEndCode { get; set; }
	[PacketClass(Code = 78)]
	public int Result { get; set; }
	[PacketClass(Code = 195)]
	public short ScriptRetval { get; set; }
	[PacketClass(Code = 21)]
	public int MonsterDeadCount { get; set; }
	[PacketClass(Code = 172)]
	public int Time { get; set; }
	[PacketClass(Code = 182)]
	public byte BossSubjugation { get; set; }
	[PacketClass(Code = 206)]
	public byte AvatarBonus { get; set; }

	// Methods

	// RVA: 0x36978D0 Offset: 0x36938D0 VA: 0x36978D0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36978D8 Offset: 0x36938D8 VA: 0x36978D8 Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x36978E0 Offset: 0x36938E0 VA: 0x36978E0
	public byte get_GameEndCode() { }

	[CompilerGenerated]
	// RVA: 0x36978E8 Offset: 0x36938E8 VA: 0x36978E8
	public void set_GameEndCode(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36978F0 Offset: 0x36938F0 VA: 0x36978F0
	public int get_Result() { }

	[CompilerGenerated]
	// RVA: 0x36978F8 Offset: 0x36938F8 VA: 0x36978F8
	public void set_Result(int value) { }

	[CompilerGenerated]
	// RVA: 0x3697900 Offset: 0x3693900 VA: 0x3697900
	public short get_ScriptRetval() { }

	[CompilerGenerated]
	// RVA: 0x3697908 Offset: 0x3693908 VA: 0x3697908
	public void set_ScriptRetval(short value) { }

	[CompilerGenerated]
	// RVA: 0x3697910 Offset: 0x3693910 VA: 0x3697910
	public int get_MonsterDeadCount() { }

	[CompilerGenerated]
	// RVA: 0x3697918 Offset: 0x3693918 VA: 0x3697918
	public void set_MonsterDeadCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x3697920 Offset: 0x3693920 VA: 0x3697920
	public int get_Time() { }

	[CompilerGenerated]
	// RVA: 0x3697928 Offset: 0x3693928 VA: 0x3697928
	public void set_Time(int value) { }

	[CompilerGenerated]
	// RVA: 0x3697930 Offset: 0x3693930 VA: 0x3697930
	public byte get_BossSubjugation() { }

	[CompilerGenerated]
	// RVA: 0x3697938 Offset: 0x3693938 VA: 0x3697938
	public void set_BossSubjugation(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3697940 Offset: 0x3693940 VA: 0x3697940
	public byte get_AvatarBonus() { }

	[CompilerGenerated]
	// RVA: 0x3697948 Offset: 0x3693948 VA: 0x3697948
	public void set_AvatarBonus(byte value) { }

	// RVA: 0x3696688 Offset: 0x3692688 VA: 0x3696688
	public void .ctor() { }

	// RVA: 0x3697950 Offset: 0x3693950 VA: 0x3697950
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3697958 Offset: 0x3693958 VA: 0x3697958
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x369795C Offset: 0x369395C VA: 0x369795C
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3697960 Offset: 0x3693960 VA: 0x3697960 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3697D4C Offset: 0x3693D4C VA: 0x3697D4C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
