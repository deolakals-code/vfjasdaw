// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Operations.Houses.Cuisine
public class CuisineGetRecipeResponse : OperationResponseBase // TypeDefIndex: 12252
{
	// Fields
	[CompilerGenerated]
	private CuisineRecipeSendData[] <RecipeList>k__BackingField; // 0x20

	// Properties
	[PacketParameter(Code = 213)]
	public CuisineRecipeSendData[] RecipeList { get; set; }
	public override byte Code { get; }
	public override byte SubCode { get; }

	// Methods

	// RVA: 0x35E7764 Offset: 0x35E3764 VA: 0x35E7764
	public void .ctor(Dictionary<byte, object> parameters) { }

	[CompilerGenerated]
	// RVA: 0x35E776C Offset: 0x35E376C VA: 0x35E776C
	public CuisineRecipeSendData[] get_RecipeList() { }

	[CompilerGenerated]
	// RVA: 0x35E7774 Offset: 0x35E3774 VA: 0x35E7774
	public void set_RecipeList(CuisineRecipeSendData[] value) { }

	// RVA: 0x35E777C Offset: 0x35E377C VA: 0x35E777C
	private void SetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E7848 Offset: 0x35E3848 VA: 0x35E7848
	private void GetClass(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E78CC Offset: 0x35E38CC VA: 0x35E78CC Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35E78D4 Offset: 0x35E38D4 VA: 0x35E78D4 Slot: 7
	public override byte get_SubCode() { }

	// RVA: 0x35E78DC Offset: 0x35E38DC VA: 0x35E78DC Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }

	// RVA: 0x35E7974 Offset: 0x35E3974 VA: 0x35E7974 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }
}
