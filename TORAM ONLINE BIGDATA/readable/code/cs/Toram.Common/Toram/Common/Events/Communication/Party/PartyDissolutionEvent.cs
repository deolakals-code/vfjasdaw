// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyDissolutionEvent : PacketBase // TypeDefIndex: 12866
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 94)]
	public int PartyId { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366B8FC Offset: 0x36678FC VA: 0x366B8FC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366B904 Offset: 0x3667904 VA: 0x366B904
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366B90C Offset: 0x366790C VA: 0x366B90C
	public void set_PartyId(int value) { }

	// RVA: 0x366B914 Offset: 0x3667914 VA: 0x366B914 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366B91C Offset: 0x366791C VA: 0x366B91C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366BA3C Offset: 0x3667A3C VA: 0x366BA3C Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
