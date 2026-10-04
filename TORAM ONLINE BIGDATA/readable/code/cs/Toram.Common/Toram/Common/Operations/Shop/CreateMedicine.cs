// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Shop
public class CreateMedicine : OperationRequestBase // TypeDefIndex: 11704
{
	// Fields
	[CompilerGenerated]
	private int <ShopId>k__BackingField; // 0x20
	[CompilerGenerated]
	private short[] <Position>k__BackingField; // 0x28
	[CompilerGenerated]
	private short <SkillId>k__BackingField; // 0x30
	[CompilerGenerated]
	private int <RecipeId>k__BackingField; // 0x34
	[CompilerGenerated]
	private short <ItemNum>k__BackingField; // 0x38

	// Properties
	public int ShopId { get; set; }
	public short[] Position { get; set; }
	public short SkillId { get; set; }
	public int RecipeId { get; set; }
	public short ItemNum { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x3736020 Offset: 0x3732020 VA: 0x3736020
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x3736028 Offset: 0x3732028 VA: 0x3736028
	public int get_ShopId() { }

	[CompilerGenerated]
	// RVA: 0x3736030 Offset: 0x3732030 VA: 0x3736030
	public void set_ShopId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3736038 Offset: 0x3732038 VA: 0x3736038
	public short[] get_Position() { }

	[CompilerGenerated]
	// RVA: 0x3736040 Offset: 0x3732040 VA: 0x3736040
	public void set_Position(short[] value) { }

	[CompilerGenerated]
	// RVA: 0x3736048 Offset: 0x3732048 VA: 0x3736048
	public short get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x3736050 Offset: 0x3732050 VA: 0x3736050
	public void set_SkillId(short value) { }

	[CompilerGenerated]
	// RVA: 0x3736058 Offset: 0x3732058 VA: 0x3736058
	public int get_RecipeId() { }

	[CompilerGenerated]
	// RVA: 0x3736060 Offset: 0x3732060 VA: 0x3736060
	public void set_RecipeId(int value) { }

	[CompilerGenerated]
	// RVA: 0x3736068 Offset: 0x3732068 VA: 0x3736068
	public short get_ItemNum() { }

	[CompilerGenerated]
	// RVA: 0x3736070 Offset: 0x3732070 VA: 0x3736070
	public void set_ItemNum(short value) { }

	// RVA: 0x3736078 Offset: 0x3732078 VA: 0x3736078 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x3736080 Offset: 0x3732080 VA: 0x3736080 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x3736088 Offset: 0x3732088 VA: 0x3736088 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x37361E0 Offset: 0x37321E0 VA: 0x37361E0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
