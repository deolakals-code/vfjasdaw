// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication
public class GuildVariableData : UnityHashBase // TypeDefIndex: 12979
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x19
	[CompilerGenerated]
	private int <Value>k__BackingField; // 0x1C
	[CompilerGenerated]
	private DateTime <UpdateDate>k__BackingField; // 0x20

	// Properties
	[UnityHash(Code = 245)]
	public byte Type { get; set; }
	[UnityHash(Code = 195)]
	public int Value { get; set; }
	[UnityHash(Code = 172)]
	public DateTime UpdateDate { get; set; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x3686504 Offset: 0x3682504 VA: 0x3686504
	public void .ctor() { }

	// RVA: 0x368650C Offset: 0x368250C VA: 0x368650C
	public void .ctor(Dictionary<object, object> parameters) { }

	// RVA: 0x3686514 Offset: 0x3682514 VA: 0x3686514
	public void .ctor(byte type, int value, DateTime date) { }

	[CompilerGenerated]
	// RVA: 0x3686554 Offset: 0x3682554 VA: 0x3686554
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x368655C Offset: 0x368255C VA: 0x368655C
	public void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3686564 Offset: 0x3682564 VA: 0x3686564
	public int get_Value() { }

	[CompilerGenerated]
	// RVA: 0x368656C Offset: 0x368256C VA: 0x368656C
	public void set_Value(int value) { }

	[CompilerGenerated]
	// RVA: 0x3686574 Offset: 0x3682574 VA: 0x3686574
	public DateTime get_UpdateDate() { }

	[CompilerGenerated]
	// RVA: 0x368657C Offset: 0x368257C VA: 0x368657C
	public void set_UpdateDate(DateTime value) { }

	// RVA: 0x3686584 Offset: 0x3682584 VA: 0x3686584
	public byte GetGuildTenantValue(byte tenantFlagType) { }

	// RVA: 0x36865A8 Offset: 0x36825A8 VA: 0x36865A8 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x36865B0 Offset: 0x36825B0 VA: 0x36865B0 Slot: 6
	public override Dictionary<object, object> GetValue() { }

	// RVA: 0x3686794 Offset: 0x3682794 VA: 0x3686794 Slot: 5
	public override bool SetValue(Dictionary<object, object> parameters) { }

	// RVA: 0x36869D0 Offset: 0x36829D0 VA: 0x36869D0
	public static byte ConvertBgmRecipeIdToVariableType(short recipeId) { }

	// RVA: 0x36869F0 Offset: 0x36829F0 VA: 0x36869F0
	public static int ConvertBgmRecipeIdToShiftNum(short recipeId) { }
}
