// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.House
public class CuisineUpdateEvent : EventSubBase // TypeDefIndex: 12815
{
	// Fields
	[CompilerGenerated]
	private List<CuisineSendData> <Cuisines>k__BackingField; // 0x20

	// Properties
	public List<CuisineSendData> Cuisines { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x365FD78 Offset: 0x365BD78 VA: 0x365FD78
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x365FD80 Offset: 0x365BD80 VA: 0x365FD80
	public List<CuisineSendData> get_Cuisines() { }

	[CompilerGenerated]
	// RVA: 0x365FD88 Offset: 0x365BD88 VA: 0x365FD88
	public void set_Cuisines(List<CuisineSendData> value) { }

	// RVA: 0x365FD90 Offset: 0x365BD90 VA: 0x365FD90
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x365FF04 Offset: 0x365BF04 VA: 0x365FF04
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36601CC Offset: 0x365C1CC VA: 0x36601CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36601D4 Offset: 0x365C1D4 VA: 0x36601D4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36601DC Offset: 0x365C1DC VA: 0x36601DC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3660274 Offset: 0x365C274 VA: 0x3660274 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
