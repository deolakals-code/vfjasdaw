// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Pets
public class HousePetSkillSet : OperationRequestBase // TypeDefIndex: 12323
{
	// Fields
	[CompilerGenerated]
	private long <PetUuid>k__BackingField; // 0x20
	[CompilerGenerated]
	private byte <SkillNo>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <SkillId>k__BackingField; // 0x2C
	[CompilerGenerated]
	private byte <MotionId>k__BackingField; // 0x30

	// Properties
	public long PetUuid { get; set; }
	public byte SkillNo { get; set; }
	public int SkillId { get; set; }
	public byte MotionId { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35F34C0 Offset: 0x35EF4C0 VA: 0x35F34C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x35F34C8 Offset: 0x35EF4C8 VA: 0x35F34C8
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x35F34D0 Offset: 0x35EF4D0 VA: 0x35F34D0
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x35F34D8 Offset: 0x35EF4D8 VA: 0x35F34D8
	public byte get_SkillNo() { }

	[CompilerGenerated]
	// RVA: 0x35F34E0 Offset: 0x35EF4E0 VA: 0x35F34E0
	public void set_SkillNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x35F34E8 Offset: 0x35EF4E8 VA: 0x35F34E8
	public int get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x35F34F0 Offset: 0x35EF4F0 VA: 0x35F34F0
	public void set_SkillId(int value) { }

	[CompilerGenerated]
	// RVA: 0x35F34F8 Offset: 0x35EF4F8 VA: 0x35F34F8
	public byte get_MotionId() { }

	[CompilerGenerated]
	// RVA: 0x35F3500 Offset: 0x35EF500 VA: 0x35F3500
	public void set_MotionId(byte value) { }

	// RVA: 0x35F3508 Offset: 0x35EF508 VA: 0x35F3508 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35F3510 Offset: 0x35EF510 VA: 0x35F3510 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35F3518 Offset: 0x35EF518 VA: 0x35F3518 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35F3734 Offset: 0x35EF734 VA: 0x35F3734 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
