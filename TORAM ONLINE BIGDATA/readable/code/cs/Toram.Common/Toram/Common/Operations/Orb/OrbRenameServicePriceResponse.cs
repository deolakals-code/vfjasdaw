// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Orb
public class OrbRenameServicePriceResponse : OperationResponseBase // TypeDefIndex: 11820
{
	// Fields
	[CompilerGenerated]
	private int <OrbPrice>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <NowNameDays>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 229)]
	public int OrbPrice { get; set; }
	[PacketParameter(Code = 172)]
	public int NowNameDays { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x37515D0 Offset: 0x374D5D0 VA: 0x37515D0
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x37515D8 Offset: 0x374D5D8 VA: 0x37515D8
	public int get_OrbPrice() { }

	[CompilerGenerated]
	// RVA: 0x37515E0 Offset: 0x374D5E0 VA: 0x37515E0
	public void set_OrbPrice(int value) { }

	[CompilerGenerated]
	// RVA: 0x37515E8 Offset: 0x374D5E8 VA: 0x37515E8
	public int get_NowNameDays() { }

	[CompilerGenerated]
	// RVA: 0x37515F0 Offset: 0x374D5F0 VA: 0x37515F0
	public void set_NowNameDays(int value) { }

	// RVA: 0x37515F8 Offset: 0x374D5F8 VA: 0x37515F8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3751600 Offset: 0x374D600 VA: 0x3751600 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3751608 Offset: 0x374D608 VA: 0x3751608 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3751774 Offset: 0x374D774 VA: 0x3751774 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
