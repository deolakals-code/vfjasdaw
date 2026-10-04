// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Global.Contents.Moba
public class MobaUpdateStatusResponse : OperationResponseBase // TypeDefIndex: 11618
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x30
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x34

	// Properties
	public short ReturnCode { get; set; }
	public PrimaryStatusData PrimaryStatus { get; set; }
	public int Hp { get; set; }
	public short Mp { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3726220 Offset: 0x3722220 VA: 0x3726220
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3726228 Offset: 0x3722228 VA: 0x3726228
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x3726230 Offset: 0x3722230 VA: 0x3726230
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x3726238 Offset: 0x3722238 VA: 0x3726238
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x3726240 Offset: 0x3722240 VA: 0x3726240
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	[CompilerGenerated]
	// RVA: 0x3726248 Offset: 0x3722248 VA: 0x3726248
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x3726250 Offset: 0x3722250 VA: 0x3726250
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x3726258 Offset: 0x3722258 VA: 0x3726258
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x3726260 Offset: 0x3722260 VA: 0x3726260
	public void set_Mp(short value) { }

	// RVA: 0x3726268 Offset: 0x3722268 VA: 0x3726268 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3726270 Offset: 0x3722270 VA: 0x3726270 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3726278 Offset: 0x3722278 VA: 0x3726278 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37263AC Offset: 0x37223AC VA: 0x37263AC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
