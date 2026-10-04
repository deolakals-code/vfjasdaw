// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Guilds.BBS
public class GuildBBSUpdateRegisterData : OperationRequestBase // TypeDefIndex: 12452
{
	// Fields
	[CompilerGenerated]
	private string <Comment>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <JoinType>k__BackingField; // 0x28
	[CompilerGenerated]
	private byte <ConditionsType>k__BackingField; // 0x29
	[CompilerGenerated]
	private int <ConditionsValue>k__BackingField; // 0x2C
	[CompilerGenerated]
	private bool <FirstRegister>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <OldComment>k__BackingField; // 0x38
	[CompilerGenerated]
	private byte <OldJoinType>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <OldConditionsType>k__BackingField; // 0x41
	[CompilerGenerated]
	private int <OldConditionsValue>k__BackingField; // 0x44
	[CompilerGenerated]
	private byte <OldFlag>k__BackingField; // 0x48

	// Properties
	public string Comment { get; set; }
	public byte JoinType { get; set; }
	public byte ConditionsType { get; set; }
	public int ConditionsValue { get; set; }
	public bool FirstRegister { get; set; }
	public string OldComment { get; set; }
	public byte OldJoinType { get; set; }
	public byte OldConditionsType { get; set; }
	public int OldConditionsValue { get; set; }
	public byte OldFlag { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x360A104 Offset: 0x3606104 VA: 0x360A104
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x360A10C Offset: 0x360610C VA: 0x360A10C
	public string get_Comment() { }

	[CompilerGenerated]
	// RVA: 0x360A114 Offset: 0x3606114 VA: 0x360A114
	public void set_Comment(string value) { }

	[CompilerGenerated]
	// RVA: 0x360A11C Offset: 0x360611C VA: 0x360A11C
	public byte get_JoinType() { }

	[CompilerGenerated]
	// RVA: 0x360A124 Offset: 0x3606124 VA: 0x360A124
	public void set_JoinType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x360A12C Offset: 0x360612C VA: 0x360A12C
	public byte get_ConditionsType() { }

	[CompilerGenerated]
	// RVA: 0x360A134 Offset: 0x3606134 VA: 0x360A134
	public void set_ConditionsType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x360A13C Offset: 0x360613C VA: 0x360A13C
	public int get_ConditionsValue() { }

	[CompilerGenerated]
	// RVA: 0x360A144 Offset: 0x3606144 VA: 0x360A144
	public void set_ConditionsValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x360A14C Offset: 0x360614C VA: 0x360A14C
	public bool get_FirstRegister() { }

	[CompilerGenerated]
	// RVA: 0x360A154 Offset: 0x3606154 VA: 0x360A154
	public void set_FirstRegister(bool value) { }

	[CompilerGenerated]
	// RVA: 0x360A160 Offset: 0x3606160 VA: 0x360A160
	public string get_OldComment() { }

	[CompilerGenerated]
	// RVA: 0x360A168 Offset: 0x3606168 VA: 0x360A168
	public void set_OldComment(string value) { }

	[CompilerGenerated]
	// RVA: 0x360A170 Offset: 0x3606170 VA: 0x360A170
	public byte get_OldJoinType() { }

	[CompilerGenerated]
	// RVA: 0x360A178 Offset: 0x3606178 VA: 0x360A178
	public void set_OldJoinType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x360A180 Offset: 0x3606180 VA: 0x360A180
	public byte get_OldConditionsType() { }

	[CompilerGenerated]
	// RVA: 0x360A188 Offset: 0x3606188 VA: 0x360A188
	public void set_OldConditionsType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x360A190 Offset: 0x3606190 VA: 0x360A190
	public int get_OldConditionsValue() { }

	[CompilerGenerated]
	// RVA: 0x360A198 Offset: 0x3606198 VA: 0x360A198
	public void set_OldConditionsValue(int value) { }

	[CompilerGenerated]
	// RVA: 0x360A1A0 Offset: 0x36061A0 VA: 0x360A1A0
	public byte get_OldFlag() { }

	[CompilerGenerated]
	// RVA: 0x360A1A8 Offset: 0x36061A8 VA: 0x360A1A8
	public void set_OldFlag(byte value) { }

	// RVA: 0x360A1B0 Offset: 0x36061B0 VA: 0x360A1B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x360A1B8 Offset: 0x36061B8 VA: 0x360A1B8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x360A1C0 Offset: 0x36061C0 VA: 0x360A1C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x360A584 Offset: 0x3606584 VA: 0x360A584 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
