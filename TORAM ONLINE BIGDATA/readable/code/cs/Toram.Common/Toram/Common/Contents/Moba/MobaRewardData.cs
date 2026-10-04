// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Contents.Moba
public class MobaRewardData : PacketBase // TypeDefIndex: 11210
{
	// Fields
	private readonly Dictionary<byte, object> rewardTable; // 0x20

	// Properties
	public int Gold { get; }
	public short SupplyEquipId { get; }
	public short SupplyEquipNo { get; }
	public override byte Code { get; }

	// Methods

	// RVA: 0x35DA0FC Offset: 0x35D60FC VA: 0x35DA0FC
	public void .ctor(Dictionary<byte, object> parameters) { }

	// RVA: 0x35DA12C Offset: 0x35D612C VA: 0x35DA12C
	public int get_Gold() { }

	// RVA: 0x35DA1F4 Offset: 0x35D61F4 VA: 0x35DA1F4
	public short get_SupplyEquipId() { }

	// RVA: 0x35DA2BC Offset: 0x35D62BC VA: 0x35DA2BC
	public short get_SupplyEquipNo() { }

	// RVA: 0x35DA384 Offset: 0x35D6384 VA: 0x35DA384
	public bool IsRewardItem() { }

	// RVA: 0x35DA3D8 Offset: 0x35D63D8 VA: 0x35DA3D8
	public bool IsGold() { }

	// RVA: 0x35DA42C Offset: 0x35D642C VA: 0x35DA42C
	public bool IsSupplyEquip() { }

	// RVA: 0x35DA4E0 Offset: 0x35D64E0 VA: 0x35DA4E0 Slot: 4
	public override byte get_Code() { }

	// RVA: 0x35DA4E8 Offset: 0x35D64E8 VA: 0x35DA4E8 Slot: 6
	public override Dictionary<byte, object> GetPacket() { }

	// RVA: 0x35DA4F0 Offset: 0x35D64F0 VA: 0x35DA4F0 Slot: 5
	public override bool SetValue(Dictionary<byte, object> parameters) { }
}
