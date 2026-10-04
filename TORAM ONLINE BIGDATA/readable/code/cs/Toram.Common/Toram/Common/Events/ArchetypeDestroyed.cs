// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events
public class ArchetypeDestroyed : PacketBase // TypeDefIndex: 12615
{
	// Fields
	[CompilerGenerated]
	private int <ArchetypeId>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24

	// Properties
	[PacketParameter(Code = 74)]
	public int ArchetypeId { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3631408 Offset: 0x362D408 VA: 0x3631408
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x3631410 Offset: 0x362D410 VA: 0x3631410
	public int get_ArchetypeId() { }

	[CompilerGenerated]
	// RVA: 0x3631418 Offset: 0x362D418 VA: 0x3631418
	public void set_ArchetypeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3631420 Offset: 0x362D420 VA: 0x3631420
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3631428 Offset: 0x362D428 VA: 0x3631428
	public void set_ArchetypeType(byte value) { }

	// RVA: 0x3631430 Offset: 0x362D430 VA: 0x3631430 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3631438 Offset: 0x362D438 VA: 0x3631438 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x36315B0 Offset: 0x362D5B0 VA: 0x36315B0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
