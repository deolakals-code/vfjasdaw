// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.GameEvents
public class MiniGameEndEvent : EventSubBase // TypeDefIndex: 12683
{
	// Fields
	[CompilerGenerated]
	private byte <State>k__BackingField; // 0x20
	[CompilerGenerated]
	private MiniGameResultData <Result>k__BackingField; // 0x28

	// Properties
	public byte State { get; set; }
	public MiniGameResultData Result { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3641274 Offset: 0x363D274 VA: 0x3641274
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x364127C Offset: 0x363D27C VA: 0x364127C
	public byte get_State() { }

	[CompilerGenerated]
	// RVA: 0x3641284 Offset: 0x363D284 VA: 0x3641284
	public void set_State(byte value) { }

	[CompilerGenerated]
	// RVA: 0x364128C Offset: 0x363D28C VA: 0x364128C
	public MiniGameResultData get_Result() { }

	[CompilerGenerated]
	// RVA: 0x3641294 Offset: 0x363D294 VA: 0x3641294
	public void set_Result(MiniGameResultData value) { }

	// RVA: 0x364129C Offset: 0x363D29C VA: 0x364129C Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36412A4 Offset: 0x363D2A4 VA: 0x36412A4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36412AC Offset: 0x363D2AC VA: 0x36412AC
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36413CC Offset: 0x363D3CC VA: 0x36413CC
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3641448 Offset: 0x363D448 VA: 0x3641448 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3641578 Offset: 0x363D578 VA: 0x3641578 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
