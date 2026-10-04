// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Companions
public class PetOwnershipEvent : EventSubBase // TypeDefIndex: 12645
{
	// Fields
	[CompilerGenerated]
	private PetEntityData[] <Pets>k__BackingField; // 0x20

	// Properties
	public override byte Code { get; }
	public override byte SubCode { get; }
	public PetEntityData[] Pets { get; set; }

	// Methods

	// RVA: 0x363868C Offset: 0x363468C VA: 0x363868C
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x3638694 Offset: 0x3634694 VA: 0x3638694 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363869C Offset: 0x363469C VA: 0x363869C Slot: 7
	public override byte get_SubCode() { }

	[CompilerGenerated]
	// RVA: 0x36386A4 Offset: 0x36346A4 VA: 0x36386A4
	public PetEntityData[] get_Pets() { }

	[CompilerGenerated]
	// RVA: 0x36386AC Offset: 0x36346AC VA: 0x36386AC
	public void set_Pets(PetEntityData[] value) { }

	// RVA: 0x36386B4 Offset: 0x36346B4 VA: 0x36386B4
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x36387A4 Offset: 0x36347A4 VA: 0x36387A4
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x3638830 Offset: 0x3634830 VA: 0x3638830 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36388C8 Offset: 0x36348C8 VA: 0x36388C8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
