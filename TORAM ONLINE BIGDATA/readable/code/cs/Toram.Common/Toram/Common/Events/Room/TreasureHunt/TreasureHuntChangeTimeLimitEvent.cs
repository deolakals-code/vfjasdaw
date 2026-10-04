// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Room.TreasureHunt
public class TreasureHuntChangeTimeLimitEvent : EventSubBase // TypeDefIndex: 12790
{
	// Fields
	[CompilerGenerated]
	private int <TimeLeft>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <UpdateTime>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x28

	// Properties
	[PacketClass(Code = 189)]
	public int TimeLeft { get; set; }
	[PacketClass(Code = 172)]
	public int UpdateTime { get; set; }
	[PacketClass(Code = 245)]
	public byte Type { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3659844 Offset: 0x3655844 VA: 0x3659844
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365984C Offset: 0x365584C VA: 0x365984C
	public int get_TimeLeft() { }

	[CompilerGenerated]
	// RVA: 0x3659854 Offset: 0x3655854 VA: 0x3659854
	public void set_TimeLeft(int value) { }

	[CompilerGenerated]
	// RVA: 0x365985C Offset: 0x365585C VA: 0x365985C
	public int get_UpdateTime() { }

	[CompilerGenerated]
	// RVA: 0x3659864 Offset: 0x3655864 VA: 0x3659864
	public void set_UpdateTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x365986C Offset: 0x365586C VA: 0x365986C
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x3659874 Offset: 0x3655874 VA: 0x3659874
	public void set_Type(byte value) { }

	// RVA: 0x365987C Offset: 0x365587C VA: 0x365987C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3659884 Offset: 0x3655884 VA: 0x3659884 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x365988C Offset: 0x365588C VA: 0x365988C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3659998 Offset: 0x3655998 VA: 0x3659998 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
