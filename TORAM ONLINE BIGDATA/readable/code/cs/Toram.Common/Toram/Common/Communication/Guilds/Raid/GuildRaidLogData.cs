// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds.Raid
public class GuildRaidLogData : BinaryBase // TypeDefIndex: 13030
{
	// Fields
	[CompilerGenerated]
	private byte <No>k__BackingField; // 0x19
	[CompilerGenerated]
	private string <MemberName>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <ItemId>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Num>k__BackingField; // 0x2C
	[CompilerGenerated]
	private DateTime <UpdateDate>k__BackingField; // 0x30

	// Properties
	public byte No { get; set; }
	public string MemberName { get; set; }
	public int ItemId { get; set; }
	public int Num { get; set; }
	public DateTime UpdateDate { get; set; }

	// Methods

	// RVA: 0x36922C0 Offset: 0x368E2C0 VA: 0x36922C0
	public void .ctor() { }

	// RVA: 0x36922C8 Offset: 0x368E2C8 VA: 0x36922C8
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36922D0 Offset: 0x368E2D0 VA: 0x36922D0
	public byte get_No() { }

	[CompilerGenerated]
	// RVA: 0x36922D8 Offset: 0x368E2D8 VA: 0x36922D8
	public void set_No(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36922E0 Offset: 0x368E2E0 VA: 0x36922E0
	public string get_MemberName() { }

	[CompilerGenerated]
	// RVA: 0x36922E8 Offset: 0x368E2E8 VA: 0x36922E8
	public void set_MemberName(string value) { }

	[CompilerGenerated]
	// RVA: 0x36922F0 Offset: 0x368E2F0 VA: 0x36922F0
	public int get_ItemId() { }

	[CompilerGenerated]
	// RVA: 0x36922F8 Offset: 0x368E2F8 VA: 0x36922F8
	public void set_ItemId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3692300 Offset: 0x368E300 VA: 0x3692300
	public int get_Num() { }

	[CompilerGenerated]
	// RVA: 0x3692308 Offset: 0x368E308 VA: 0x3692308
	public void set_Num(int value) { }

	[CompilerGenerated]
	// RVA: 0x3692310 Offset: 0x368E310 VA: 0x3692310
	public DateTime get_UpdateDate() { }

	[CompilerGenerated]
	// RVA: 0x3692318 Offset: 0x368E318 VA: 0x3692318
	public void set_UpdateDate(DateTime value) { }

	// RVA: 0x3692320 Offset: 0x368E320 VA: 0x3692320 Slot: 3
	public override string ToString() { }

	// RVA: 0x369255C Offset: 0x368E55C VA: 0x369255C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x369261C Offset: 0x368E61C VA: 0x369261C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
