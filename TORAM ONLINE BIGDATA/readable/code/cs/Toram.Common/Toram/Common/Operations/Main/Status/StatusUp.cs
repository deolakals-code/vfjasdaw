// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Main.Status
public class StatusUp : PacketBase // TypeDefIndex: 12087
{
	// Fields
	[CompilerGenerated]
	private int <AvatarUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <ArchetypeType>k__BackingField; // 0x24
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x28

	// Properties
	public override byte Code { get; }
	[PacketParameter(Code = 1)]
	public int AvatarUuid { get; set; }
	[PacketParameter(Code = 55)]
	public byte ArchetypeType { get; set; }
	[PacketClass(Code = 69, IsOptional = True)]
	public PrimaryStatusData PrimaryStatus { get; set; }

	// Methods

	// RVA: 0x378485C Offset: 0x378085C VA: 0x378485C
	public void .ctor() { }

	// RVA: 0x3784864 Offset: 0x3780864 VA: 0x3784864 Slot: 4
	public override byte get_Code() { }

	[CompilerGenerated]
	// RVA: 0x378486C Offset: 0x378086C VA: 0x378486C
	public int get_AvatarUuid() { }

	[CompilerGenerated]
	// RVA: 0x3784874 Offset: 0x3780874 VA: 0x3784874
	public void set_AvatarUuid(int value) { }

	[CompilerGenerated]
	// RVA: 0x378487C Offset: 0x378087C VA: 0x378487C
	public byte get_ArchetypeType() { }

	[CompilerGenerated]
	// RVA: 0x3784884 Offset: 0x3780884 VA: 0x3784884
	public void set_ArchetypeType(byte value) { }

	[CompilerGenerated]
	// RVA: 0x378488C Offset: 0x378088C VA: 0x378488C
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x3784894 Offset: 0x3780894 VA: 0x3784894
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	// RVA: 0x378489C Offset: 0x378089C VA: 0x378489C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3784AE8 Offset: 0x3780AE8 VA: 0x3784AE8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
