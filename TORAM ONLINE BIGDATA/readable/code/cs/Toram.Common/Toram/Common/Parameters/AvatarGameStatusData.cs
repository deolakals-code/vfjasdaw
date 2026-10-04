// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
public class AvatarGameStatusData : UnityHashBase // TypeDefIndex: 11112
{
	// Fields
	[CompilerGenerated]
	private int <Gold>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <OrbShard>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TicketPiece>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <GemShard>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <MagicGauge>k__BackingField; // 0x2C
	[CompilerGenerated]
	private TimeSpan <MagicTimeSpan>k__BackingField; // 0x30

	// Properties
	[UnityHash(Code = 28)]
	public int Gold { get; set; }
	[UnityHash(Code = 230)]
	public int OrbShard { get; set; }
	[UnityHash(Code = 247)]
	public int TicketPiece { get; set; }
	[UnityHash(Code = 48, IsOptional = True)]
	public int GemShard { get; set; }
	[UnityHash(Code = 205)]
	public short MagicGauge { get; set; }
	[UnityHash(Code = 172)]
	public TimeSpan MagicTimeSpan { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35BD57C Offset: 0x35B957C VA: 0x35BD57C
	public void .ctor() { }

	// RVA: 0x35BD584 Offset: 0x35B9584 VA: 0x35BD584
	public void .ctor(Dictionary<object, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35BD58C Offset: 0x35B958C VA: 0x35BD58C
	public int get_Gold() { }

	[CompilerGenerated]
	// RVA: 0x35BD594 Offset: 0x35B9594 VA: 0x35BD594
	public void set_Gold(int value) { }

	[CompilerGenerated]
	// RVA: 0x35BD59C Offset: 0x35B959C VA: 0x35BD59C
	public int get_OrbShard() { }

	[CompilerGenerated]
	// RVA: 0x35BD5A4 Offset: 0x35B95A4 VA: 0x35BD5A4
	public void set_OrbShard(int value) { }

	[CompilerGenerated]
	// RVA: 0x35BD5AC Offset: 0x35B95AC VA: 0x35BD5AC
	public int get_TicketPiece() { }

	[CompilerGenerated]
	// RVA: 0x35BD5B4 Offset: 0x35B95B4 VA: 0x35BD5B4
	public void set_TicketPiece(int value) { }

	[CompilerGenerated]
	// RVA: 0x35BD5BC Offset: 0x35B95BC VA: 0x35BD5BC
	public int get_GemShard() { }

	[CompilerGenerated]
	// RVA: 0x35BD5C4 Offset: 0x35B95C4 VA: 0x35BD5C4
	public void set_GemShard(int value) { }

	[CompilerGenerated]
	// RVA: 0x35BD5CC Offset: 0x35B95CC VA: 0x35BD5CC
	public short get_MagicGauge() { }

	[CompilerGenerated]
	// RVA: 0x35BD5D4 Offset: 0x35B95D4 VA: 0x35BD5D4
	public void set_MagicGauge(short value) { }

	[CompilerGenerated]
	// RVA: 0x35BD5DC Offset: 0x35B95DC VA: 0x35BD5DC
	public TimeSpan get_MagicTimeSpan() { }

	[CompilerGenerated]
	// RVA: 0x35BD5E4 Offset: 0x35B95E4 VA: 0x35BD5E4
	public void set_MagicTimeSpan(TimeSpan value) { }

	// RVA: 0x35BD5EC Offset: 0x35B95EC VA: 0x35BD5EC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35BD5F4 Offset: 0x35B95F4 VA: 0x35BD5F4 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x35BD9C0 Offset: 0x35B99C0 VA: 0x35BD9C0 Slot: 6
	public override Dictionary<object, object> GetValue() { }
}
