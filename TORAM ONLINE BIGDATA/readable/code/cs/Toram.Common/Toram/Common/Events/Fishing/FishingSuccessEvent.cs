// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Fishing
public class FishingSuccessEvent : EventSubBase // TypeDefIndex: 12702
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <FishId>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Size>k__BackingField; // 0x28

	// Properties
	[PacketParameter(Code = 0)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 10)]
	public int FishId { get; set; }
	[PacketParameter(Code = 11)]
	public int Size { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3644AFC Offset: 0x3640AFC VA: 0x3644AFC
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3644B04 Offset: 0x3640B04 VA: 0x3644B04
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3644B0C Offset: 0x3640B0C VA: 0x3644B0C
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3644B14 Offset: 0x3640B14 VA: 0x3644B14
	public int get_FishId() { }

	[CompilerGenerated]
	// RVA: 0x3644B1C Offset: 0x3640B1C VA: 0x3644B1C
	public void set_FishId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3644B24 Offset: 0x3640B24 VA: 0x3644B24
	public int get_Size() { }

	[CompilerGenerated]
	// RVA: 0x3644B2C Offset: 0x3640B2C VA: 0x3644B2C
	public void set_Size(int value) { }

	// RVA: 0x3644B34 Offset: 0x3640B34 VA: 0x3644B34 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3644B3C Offset: 0x3640B3C VA: 0x3644B3C Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3644B44 Offset: 0x3640B44 VA: 0x3644B44 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x3644C3C Offset: 0x3640C3C VA: 0x3644C3C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
