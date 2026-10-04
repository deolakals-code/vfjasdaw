// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Guild
public class GuildRunBoosterEvent : PacketBase // TypeDefIndex: 12923
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Point>k__BackingField; // 0x24
	[CompilerGenerated]
	private DateTime <Time>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Rate>k__BackingField; // 0x30
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x38
	[CompilerGenerated]
	private GameStatusData <GameStatus>k__BackingField; // 0x40

	// Properties
	public byte Type { get; set; }
	public int Point { get; set; }
	public DateTime Time { get; set; }
	public int Rate { get; set; }
	public string UserName { get; set; }
	public GameStatusData GameStatus { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x367922C Offset: 0x367522C VA: 0x367922C
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3679234 Offset: 0x3675234 VA: 0x3679234
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x367923C Offset: 0x367523C VA: 0x367923C
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3679244 Offset: 0x3675244 VA: 0x3679244
	public int get_Point() { }

	[CompilerGenerated]
	// RVA: 0x367924C Offset: 0x367524C VA: 0x367924C
	public void set_Point(int value) { }

	[CompilerGenerated]
	// RVA: 0x3679254 Offset: 0x3675254 VA: 0x3679254
	public DateTime get_Time() { }

	[CompilerGenerated]
	// RVA: 0x367925C Offset: 0x367525C VA: 0x367925C
	public void set_Time(DateTime value) { }

	[CompilerGenerated]
	// RVA: 0x3679264 Offset: 0x3675264 VA: 0x3679264
	public int get_Rate() { }

	[CompilerGenerated]
	// RVA: 0x367926C Offset: 0x367526C VA: 0x367926C
	public void set_Rate(int value) { }

	[CompilerGenerated]
	// RVA: 0x3679274 Offset: 0x3675274 VA: 0x3679274
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x367927C Offset: 0x367527C VA: 0x367927C
	public void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x3679284 Offset: 0x3675284 VA: 0x3679284
	public GameStatusData get_GameStatus() { }

	[CompilerGenerated]
	// RVA: 0x367928C Offset: 0x367528C VA: 0x367928C
	public void set_GameStatus(GameStatusData value) { }

	// RVA: 0x3679294 Offset: 0x3675294 VA: 0x3679294 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x367929C Offset: 0x367529C VA: 0x367929C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36795FC Offset: 0x36755FC VA: 0x36795FC Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
