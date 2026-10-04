// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Events.Global.Contents.Moba
public class MobaLevelupEvent : EventSubBase // TypeDefIndex: 12675
{
	// Fields
	[CompilerGenerated]
	private short <ReturnCode>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Exp>k__BackingField; // 0x24
	[CompilerGenerated]
	private int <Hp>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <Mp>k__BackingField; // 0x2C
	[CompilerGenerated]
	private PrimaryStatusData <PrimaryStatus>k__BackingField; // 0x30

	// Properties
	public short ReturnCode { get; set; }
	public int Exp { get; set; }
	public int Hp { get; set; }
	public short Mp { get; set; }
	public PrimaryStatusData PrimaryStatus { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x363EB68 Offset: 0x363AB68 VA: 0x363EB68
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x363EB70 Offset: 0x363AB70 VA: 0x363EB70
	public short get_ReturnCode() { }

	[CompilerGenerated]
	// RVA: 0x363EB78 Offset: 0x363AB78 VA: 0x363EB78
	public void set_ReturnCode(short value) { }

	[CompilerGenerated]
	// RVA: 0x363EB80 Offset: 0x363AB80 VA: 0x363EB80
	public int get_Exp() { }

	[CompilerGenerated]
	// RVA: 0x363EB88 Offset: 0x363AB88 VA: 0x363EB88
	public void set_Exp(int value) { }

	[CompilerGenerated]
	// RVA: 0x363EB90 Offset: 0x363AB90 VA: 0x363EB90
	public int get_Hp() { }

	[CompilerGenerated]
	// RVA: 0x363EB98 Offset: 0x363AB98 VA: 0x363EB98
	public void set_Hp(int value) { }

	[CompilerGenerated]
	// RVA: 0x363EBA0 Offset: 0x363ABA0 VA: 0x363EBA0
	public short get_Mp() { }

	[CompilerGenerated]
	// RVA: 0x363EBA8 Offset: 0x363ABA8 VA: 0x363EBA8
	public void set_Mp(short value) { }

	[CompilerGenerated]
	// RVA: 0x363EBB0 Offset: 0x363ABB0 VA: 0x363EBB0
	public PrimaryStatusData get_PrimaryStatus() { }

	[CompilerGenerated]
	// RVA: 0x363EBB8 Offset: 0x363ABB8 VA: 0x363EBB8
	public void set_PrimaryStatus(PrimaryStatusData value) { }

	// RVA: 0x363EBC0 Offset: 0x363ABC0 VA: 0x363EBC0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x363EBC8 Offset: 0x363ABC8 VA: 0x363EBC8 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x363EBD0 Offset: 0x363ABD0 VA: 0x363EBD0 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x363ED2C Offset: 0x363AD2C VA: 0x363ED2C Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
