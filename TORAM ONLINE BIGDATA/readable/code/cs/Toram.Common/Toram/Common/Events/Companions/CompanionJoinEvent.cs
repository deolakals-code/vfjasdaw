// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Companions
public class CompanionJoinEvent : EventSubBase // TypeDefIndex: 12643
{
	// Fields
	[CompilerGenerated]
	private Dictionary<byte, object> <NewJoinMemberData>k__BackingField; // 0x20

	// Properties
	public Dictionary<byte, object> NewJoinMemberData { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3638198 Offset: 0x3634198 VA: 0x3638198
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x36381A0 Offset: 0x36341A0 VA: 0x36381A0
	public Dictionary<byte, object> get_NewJoinMemberData() { }

	[CompilerGenerated]
	// RVA: 0x36381A8 Offset: 0x36341A8 VA: 0x36381A8
	public void set_NewJoinMemberData(Dictionary<byte, object> value) { }

	// RVA: 0x36381B0 Offset: 0x36341B0 VA: 0x36381B0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36381B8 Offset: 0x36341B8 VA: 0x36381B8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x36381C0 Offset: 0x36341C0 VA: 0x36381C0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3638328 Offset: 0x3634328 VA: 0x3638328 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
