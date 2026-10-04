// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Communication.Party
public class PartyInvitationEvent : PacketBase // TypeDefIndex: 12870
{
	// Fields
	[CompilerGenerated]
	private int <PartyId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <TargetId>k__BackingField; // 0x24
	[CompilerGenerated]
	private PartyReserveData <ReserveData>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 94)]
	public int PartyId { get; set; }
	[PacketParameter(Code = 96)]
	public int TargetId { get; set; }
	[PacketClass(Code = 175)]
	public PartyReserveData ReserveData { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x366C690 Offset: 0x3668690 VA: 0x366C690
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x366C698 Offset: 0x3668698 VA: 0x366C698
	public int get_PartyId() { }

	[CompilerGenerated]
	// RVA: 0x366C6A0 Offset: 0x36686A0 VA: 0x366C6A0
	public void set_PartyId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366C6A8 Offset: 0x36686A8 VA: 0x366C6A8
	public int get_TargetId() { }

	[CompilerGenerated]
	// RVA: 0x366C6B0 Offset: 0x36686B0 VA: 0x366C6B0
	public void set_TargetId(int value) { }

	[CompilerGenerated]
	// RVA: 0x366C6B8 Offset: 0x36686B8 VA: 0x366C6B8
	public PartyReserveData get_ReserveData() { }

	[CompilerGenerated]
	// RVA: 0x366C6C0 Offset: 0x36686C0 VA: 0x366C6C0
	public void set_ReserveData(PartyReserveData value) { }

	// RVA: 0x366C6C8 Offset: 0x36686C8 VA: 0x366C6C8
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x366C7E8 Offset: 0x36687E8 VA: 0x366C7E8
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x366C864 Offset: 0x3668864 VA: 0x366C864 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x366C86C Offset: 0x366886C VA: 0x366C86C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x366C9E8 Offset: 0x36689E8 VA: 0x366C9E8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
