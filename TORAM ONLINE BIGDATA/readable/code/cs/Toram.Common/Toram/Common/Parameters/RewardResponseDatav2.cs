// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Parameters
public class RewardResponseDatav2 : PacketBase // TypeDefIndex: 11128
{
	// Fields
	private readonly Dictionary<byte, object> rewardTable; // 0x20

	// Properties
	public short StatusPoint { get; }
	public short SkillPoint { get; }
	public byte ComboPoint { get; }
	public long ExpL { get; }
	public long Exp { get; }
	public int Gold { get; }
	public int OrbShard { get; }
	public int Orb { get; }
	public int AvatarTicket { get; }
	public int TicketPiece { get; }
	public int GemShard { get; }
	public byte ParameterSlot { get; }
	public ItemDatav2[] ItemList { get; }
	public WarrantyItemDatav2[] WarrantyList { get; }
	public MaterialData[] MaterialList { get; }
	public OrbItemData[] OrbItem { get; }
	public OrbEquipItemData[] OrbEquips { get; }
	public RewardData[] RewardItem { get; }
	public int FoodPoint { get; }
	public StarGemData[] StarGem { get; }
	public int[] HouseBgm { get; }
	public GemCartData[] GemCart { get; }
	public int GemPowder { get; }
	public FishingFishData[] FishingFishList { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35C3618 Offset: 0x35BF618 VA: 0x35C3618
	public void .ctor() { }

	// RVA: 0x35C36A0 Offset: 0x35BF6A0 VA: 0x35C36A0
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x35C36D0 Offset: 0x35BF6D0 VA: 0x35C36D0
	public short get_StatusPoint() { }

	// RVA: 0x35C3798 Offset: 0x35BF798 VA: 0x35C3798
	public short get_SkillPoint() { }

	// RVA: 0x35C3860 Offset: 0x35BF860 VA: 0x35C3860
	public byte get_ComboPoint() { }

	// RVA: 0x35C3928 Offset: 0x35BF928 VA: 0x35C3928
	public long get_ExpL() { }

	// RVA: 0x35C39F0 Offset: 0x35BF9F0 VA: 0x35C39F0
	public long get_Exp() { }

	// RVA: 0x35C39F4 Offset: 0x35BF9F4 VA: 0x35C39F4
	public int get_Gold() { }

	// RVA: 0x35C3ABC Offset: 0x35BFABC VA: 0x35C3ABC
	public int get_OrbShard() { }

	// RVA: 0x35C3B84 Offset: 0x35BFB84 VA: 0x35C3B84
	public int get_Orb() { }

	// RVA: 0x35C3C4C Offset: 0x35BFC4C VA: 0x35C3C4C
	public int get_AvatarTicket() { }

	// RVA: 0x35C3D14 Offset: 0x35BFD14 VA: 0x35C3D14
	public int get_TicketPiece() { }

	// RVA: 0x35C3DDC Offset: 0x35BFDDC VA: 0x35C3DDC
	public int get_GemShard() { }

	// RVA: 0x35C3EA4 Offset: 0x35BFEA4 VA: 0x35C3EA4
	public byte get_ParameterSlot() { }

	// RVA: 0x35C3F6C Offset: 0x35BFF6C VA: 0x35C3F6C
	public ItemDatav2[] get_ItemList() { }

	// RVA: 0x35C4070 Offset: 0x35C0070 VA: 0x35C4070
	public WarrantyItemDatav2[] get_WarrantyList() { }

	// RVA: 0x35C4154 Offset: 0x35C0154 VA: 0x35C4154
	public MaterialData[] get_MaterialList() { }

	// RVA: 0x35C4238 Offset: 0x35C0238 VA: 0x35C4238
	public OrbItemData[] get_OrbItem() { }

	// RVA: 0x35C431C Offset: 0x35C031C VA: 0x35C431C
	public OrbEquipItemData[] get_OrbEquips() { }

	// RVA: 0x35C4400 Offset: 0x35C0400 VA: 0x35C4400
	public RewardData[] get_RewardItem() { }

	// RVA: 0x35C44E4 Offset: 0x35C04E4 VA: 0x35C44E4
	public int get_FoodPoint() { }

	// RVA: 0x35C45AC Offset: 0x35C05AC VA: 0x35C45AC
	public StarGemData[] get_StarGem() { }

	// RVA: 0x35C4690 Offset: 0x35C0690 VA: 0x35C4690
	public int[] get_HouseBgm() { }

	// RVA: 0x35C4750 Offset: 0x35C0750 VA: 0x35C4750
	public GemCartData[] get_GemCart() { }

	// RVA: 0x35C4834 Offset: 0x35C0834 VA: 0x35C4834
	public int get_GemPowder() { }

	// RVA: 0x35C48FC Offset: 0x35C08FC VA: 0x35C48FC
	public FishingFishData[] get_FishingFishList() { }

	// RVA: 0x35C4A14 Offset: 0x35C0A14 VA: 0x35C4A14
	public bool IsStatusPoint() { }

	// RVA: 0x35C4A68 Offset: 0x35C0A68 VA: 0x35C4A68
	public bool IsSkillPoint() { }

	// RVA: 0x35C4ABC Offset: 0x35C0ABC VA: 0x35C4ABC
	public bool IsComboPoint() { }

	// RVA: 0x35C4B10 Offset: 0x35C0B10 VA: 0x35C4B10
	public bool IsExp() { }

	// RVA: 0x35C4B8C Offset: 0x35C0B8C VA: 0x35C4B8C
	public bool IsGold() { }

	// RVA: 0x35C4BE0 Offset: 0x35C0BE0 VA: 0x35C4BE0
	public bool IsOrbShard() { }

	// RVA: 0x35C4C34 Offset: 0x35C0C34 VA: 0x35C4C34
	public bool IsTicketPiece() { }

	// RVA: 0x35C4C88 Offset: 0x35C0C88 VA: 0x35C4C88
	public bool IsGemShard() { }

	// RVA: 0x35C4CDC Offset: 0x35C0CDC VA: 0x35C4CDC
	public bool IsParameterSlot() { }

	// RVA: 0x35C4D30 Offset: 0x35C0D30 VA: 0x35C4D30
	public bool IsItemList() { }

	// RVA: 0x35C4D84 Offset: 0x35C0D84 VA: 0x35C4D84
	public bool IsWarrantyList() { }

	// RVA: 0x35C4DD8 Offset: 0x35C0DD8 VA: 0x35C4DD8
	public bool IsMaterialList() { }

	// RVA: 0x35C4E2C Offset: 0x35C0E2C VA: 0x35C4E2C
	public bool IsOrbItem() { }

	// RVA: 0x35C4E80 Offset: 0x35C0E80 VA: 0x35C4E80
	public bool IsOrbEquips() { }

	// RVA: 0x35C4ED4 Offset: 0x35C0ED4 VA: 0x35C4ED4
	public bool IsFoodPoint() { }

	// RVA: 0x35C4F28 Offset: 0x35C0F28 VA: 0x35C4F28
	public bool IsStarGem() { }

	// RVA: 0x35C4F7C Offset: 0x35C0F7C VA: 0x35C4F7C
	public bool IsHouseBgm() { }

	// RVA: 0x35C4FD0 Offset: 0x35C0FD0 VA: 0x35C4FD0
	public bool IsGemCart() { }

	// RVA: 0x35C5024 Offset: 0x35C1024 VA: 0x35C5024
	public bool IsGemPowder() { }

	// RVA: 0x35C49C0 Offset: 0x35C09C0 VA: 0x35C49C0
	public bool IsFishingFish() { }

	// RVA: 0x35C5078 Offset: 0x35C1078 VA: 0x35C5078 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35C5080 Offset: 0x35C1080 VA: 0x35C5080 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35C5088 Offset: 0x35C1088 VA: 0x35C5088 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
