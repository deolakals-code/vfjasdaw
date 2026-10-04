// Assembly: Toram.Gm.dll
// Namespace: Toram.Gm.Operations
public class GmPetSkillLearning : OperationRequestBase // TypeDefIndex: 17623
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

	// RVA: 0x3799974 Offset: 0x3795974 VA: 0x3799974
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x379997C Offset: 0x379597C VA: 0x379997C
	public long get_PetUuid() { }

	[CompilerGenerated]
	// RVA: 0x3799984 Offset: 0x3795984 VA: 0x3799984
	public void set_PetUuid(long value) { }

	[CompilerGenerated]
	// RVA: 0x379998C Offset: 0x379598C VA: 0x379998C
	public byte get_SkillNo() { }

	[CompilerGenerated]
	// RVA: 0x3799994 Offset: 0x3795994 VA: 0x3799994
	public void set_SkillNo(byte value) { }

	[CompilerGenerated]
	// RVA: 0x379999C Offset: 0x379599C VA: 0x379999C
	public int get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x37999A4 Offset: 0x37959A4 VA: 0x37999A4
	public void set_SkillId(int value) { }

	[CompilerGenerated]
	// RVA: 0x37999AC Offset: 0x37959AC VA: 0x37999AC
	public byte get_MotionId() { }

	[CompilerGenerated]
	// RVA: 0x37999B4 Offset: 0x37959B4 VA: 0x37999B4
	public void set_MotionId(byte value) { }

	// RVA: 0x37999BC Offset: 0x37959BC VA: 0x37999BC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x37999C4 Offset: 0x37959C4 VA: 0x37999C4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x37999CC Offset: 0x37959CC VA: 0x37999CC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x3799BE8 Offset: 0x3795BE8 VA: 0x3799BE8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
