// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Fishing
public class NoticeHitRateEvent : EventSubBase // TypeDefIndex: 12703
{
	// Fields
	[CompilerGenerated]
	private int <StartRate>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <HitCount>k__BackingField; // 0x24
	[CompilerGenerated]
	private byte <ChummingRate>k__BackingField; // 0x25
	[CompilerGenerated]
	private int <HitRate>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <RandNum>k__BackingField; // 0x2C

	// Properties
	[PacketParameter(Code = 62)]
	public int StartRate { get; set; }
	[PacketParameter(Code = 10)]
	public byte HitCount { get; set; }
	[PacketParameter(Code = 11)]
	public byte ChummingRate { get; set; }
	[PacketParameter(Code = 12)]
	public int HitRate { get; set; }
	[PacketParameter(Code = 13)]
	public int RandNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3644DEC Offset: 0x3640DEC VA: 0x3644DEC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3644DF4 Offset: 0x3640DF4 VA: 0x3644DF4
	public int get_StartRate() { }

	[CompilerGenerated]
	// RVA: 0x3644DFC Offset: 0x3640DFC VA: 0x3644DFC
	public void set_StartRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x3644E04 Offset: 0x3640E04 VA: 0x3644E04
	public byte get_HitCount() { }

	[CompilerGenerated]
	// RVA: 0x3644E0C Offset: 0x3640E0C VA: 0x3644E0C
	public void set_HitCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3644E14 Offset: 0x3640E14 VA: 0x3644E14
	public byte get_ChummingRate() { }

	[CompilerGenerated]
	// RVA: 0x3644E1C Offset: 0x3640E1C VA: 0x3644E1C
	public void set_ChummingRate(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3644E24 Offset: 0x3640E24 VA: 0x3644E24
	public int get_HitRate() { }

	[CompilerGenerated]
	// RVA: 0x3644E2C Offset: 0x3640E2C VA: 0x3644E2C
	public void set_HitRate(int value) { }

	[CompilerGenerated]
	// RVA: 0x3644E34 Offset: 0x3640E34 VA: 0x3644E34
	public int get_RandNum() { }

	[CompilerGenerated]
	// RVA: 0x3644E3C Offset: 0x3640E3C VA: 0x3644E3C
	public void set_RandNum(int value) { }

	// RVA: 0x3644E44 Offset: 0x3640E44 VA: 0x3644E44 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3644E4C Offset: 0x3640E4C VA: 0x3644E4C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3644E54 Offset: 0x3640E54 VA: 0x3644E54 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3644FB0 Offset: 0x3640FB0 VA: 0x3644FB0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
