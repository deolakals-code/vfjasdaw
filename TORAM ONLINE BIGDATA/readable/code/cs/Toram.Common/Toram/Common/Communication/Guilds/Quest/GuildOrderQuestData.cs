// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds.Quest
public class GuildOrderQuestData : UnityHashBase // TypeDefIndex: 13028
{
	// Fields
	[CompilerGenerated]
	private byte <No>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <Id>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <Current>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <GuildGold>k__BackingField; // 0x24
	[CompilerGenerated]
	private RewardData[] <Rewards>k__BackingField; // 0x28

	// Properties
	public byte No { get; set; }
	public int Id { get; set; }
	public int Current { get; set; }
	public int GuildGold { get; set; }
	public RewardData[] Rewards { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3691810 Offset: 0x368D810 VA: 0x3691810
	public void .ctor() { }

	// RVA: 0x3691818 Offset: 0x368D818 VA: 0x3691818
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3691820 Offset: 0x368D820 VA: 0x3691820
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x3691828 Offset: 0x368D828 VA: 0x3691828
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3691830 Offset: 0x368D830 VA: 0x3691830
	public int get_Id() { }

	[CompilerGenerated]
	// RVA: 0x3691838 Offset: 0x368D838 VA: 0x3691838
	public void set_Id(int value) { }

	[CompilerGenerated]
	// RVA: 0x3691840 Offset: 0x368D840 VA: 0x3691840
	public int get_Current() { }

	[CompilerGenerated]
	// RVA: 0x3691848 Offset: 0x368D848 VA: 0x3691848
	public void set_Current(int value) { }

	[CompilerGenerated]
	// RVA: 0x3691850 Offset: 0x368D850 VA: 0x3691850
	public int get_GuildGold() { }

	[CompilerGenerated]
	// RVA: 0x3691858 Offset: 0x368D858 VA: 0x3691858
	public void set_GuildGold(int value) { }

	[CompilerGenerated]
	// RVA: 0x3691860 Offset: 0x368D860 VA: 0x3691860
	public RewardData[] get_Rewards() { }

	[CompilerGenerated]
	// RVA: 0x3691868 Offset: 0x368D868 VA: 0x3691868
	public void set_Rewards(RewardData[] value) { }

	// RVA: 0x3691870 Offset: 0x368D870 VA: 0x3691870 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3691878 Offset: 0x368D878 VA: 0x3691878 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x3691A8C Offset: 0x368DA8C VA: 0x3691A8C Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }
}
