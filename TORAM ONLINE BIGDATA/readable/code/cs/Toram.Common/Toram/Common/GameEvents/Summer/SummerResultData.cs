// Assembly: Toram.Common.dll
// Namespace: Toram.Common.GameEvents.Summer
public class SummerResultData : BinaryBase // TypeDefIndex: 11186
{
	// Fields
	[CompilerGenerated]
	private int <LobbyId>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <LobbyOwnerId>k__BackingField; // 0x20
	[CompilerGenerated]
	private DateTime <LobbyCreateTime>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Point>k__BackingField; // 0x30
	[CompilerGenerated]
	private short[] <UseGoods>k__BackingField; // 0x38
	[CompilerGenerated]
	private short <UseHarpoon>k__BackingField; // 0x40
	[CompilerGenerated]
	private DateTime <DiveTime>k__BackingField; // 0x48
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x50

	// Properties
	public int LobbyId { get; set; }
	public int LobbyOwnerId { get; set; }
	public DateTime LobbyCreateTime { get; set; }
	public int Point { get; set; }
	public short[] UseGoods { get; set; }
	public short UseHarpoon { get; set; }
	public DateTime DiveTime { get; set; }
	public byte State { get; set; }

	// Methods

	// RVA: 0x35D459C Offset: 0x35D059C VA: 0x35D459C
	public void .ctor() { }

	// RVA: 0x35D45A4 Offset: 0x35D05A4 VA: 0x35D45A4
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x35D45AC Offset: 0x35D05AC VA: 0x35D45AC
	public int get_LobbyId() { }

	[CompilerGenerated]
	// RVA: 0x35D45B4 Offset: 0x35D05B4 VA: 0x35D45B4
	protected void set_LobbyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D45BC Offset: 0x35D05BC VA: 0x35D45BC
	public int get_LobbyOwnerId() { }

	[CompilerGenerated]
	// RVA: 0x35D45C4 Offset: 0x35D05C4 VA: 0x35D45C4
	protected void set_LobbyOwnerId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D45CC Offset: 0x35D05CC VA: 0x35D45CC
	public DateTime get_LobbyCreateTime() { }

	[CompilerGenerated]
	// RVA: 0x35D45D4 Offset: 0x35D05D4 VA: 0x35D45D4
	protected void set_LobbyCreateTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x35D45DC Offset: 0x35D05DC VA: 0x35D45DC
	public int get_Point() { }

	[CompilerGenerated]
	// RVA: 0x35D45E4 Offset: 0x35D05E4 VA: 0x35D45E4
	protected void set_Point(int value) { }

	[CompilerGenerated]
	// RVA: 0x35D45EC Offset: 0x35D05EC VA: 0x35D45EC
	public short[] get_UseGoods() { }

	[CompilerGenerated]
	// RVA: 0x35D45F4 Offset: 0x35D05F4 VA: 0x35D45F4
	protected void set_UseGoods(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x35D45FC Offset: 0x35D05FC VA: 0x35D45FC
	public short get_UseHarpoon() { }

	[CompilerGenerated]
	// RVA: 0x35D4604 Offset: 0x35D0604 VA: 0x35D4604
	protected void set_UseHarpoon(short value) { }

	[CompilerGenerated]
	// RVA: 0x35D460C Offset: 0x35D060C VA: 0x35D460C
	public DateTime get_DiveTime() { }

	[CompilerGenerated]
	// RVA: 0x35D4614 Offset: 0x35D0614 VA: 0x35D4614
	protected void set_DiveTime(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x35D461C Offset: 0x35D061C VA: 0x35D461C
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x35D4624 Offset: 0x35D0624 VA: 0x35D4624
	protected void set_State(byte value) { }

	// RVA: 0x35D462C Offset: 0x35D062C VA: 0x35D462C Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x35D47CC Offset: 0x35D07CC VA: 0x35D47CC Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
