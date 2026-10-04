// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CardGamePlayerCard // TypeDefIndex: 4294
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private short <DrawTrun>k__BackingField; // 0x12
	[CompilerGenerated]
	private byte <MarketSellPrice>k__BackingField; // 0x14
	[CompilerGenerated]
	private CardData <StatusMaster>k__BackingField; // 0x18
	[CompilerGenerated]
	private byte <UniqueId>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <ReserveSale>k__BackingField; // 0x25
	[CompilerGenerated]
	private bool <ReserveAttack>k__BackingField; // 0x26
	[CompilerGenerated]
	private bool <IsRecycle>k__BackingField; // 0x27

	// Properties
	public byte Type { get; set; }
	public short DrawTrun { get; set; }
	public byte MarketSellPrice { get; set; }
	public CardData StatusMaster { get; set; }
	public byte UniqueId { get; set; }
	public bool ReserveSale { get; set; }
	public bool ReserveAttack { get; set; }
	public bool IsRecycle { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x24C6858 Offset: 0x24C2858 VA: 0x24C6858
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x24C6860 Offset: 0x24C2860 VA: 0x24C6860
	private void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x24C6868 Offset: 0x24C2868 VA: 0x24C6868
	public short get_DrawTrun() { }

	[CompilerGenerated]
	// RVA: 0x24C6870 Offset: 0x24C2870 VA: 0x24C6870
	private void set_DrawTrun(short value) { }

	[CompilerGenerated]
	// RVA: 0x24C6878 Offset: 0x24C2878 VA: 0x24C6878
	public byte get_MarketSellPrice() { }

	[CompilerGenerated]
	// RVA: 0x24C6880 Offset: 0x24C2880 VA: 0x24C6880
	private void set_MarketSellPrice(byte value) { }

	[CompilerGenerated]
	// RVA: 0x24C6888 Offset: 0x24C2888 VA: 0x24C6888
	public CardData get_StatusMaster() { }

	[CompilerGenerated]
	// RVA: 0x24C6898 Offset: 0x24C2898 VA: 0x24C6898
	private void set_StatusMaster(CardData value) { }

	[CompilerGenerated]
	// RVA: 0x24C68A4 Offset: 0x24C28A4 VA: 0x24C68A4
	public byte get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x24C68AC Offset: 0x24C28AC VA: 0x24C68AC
	private void set_UniqueId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x24C68B4 Offset: 0x24C28B4 VA: 0x24C68B4
	public bool get_ReserveSale() { }

	[CompilerGenerated]
	// RVA: 0x24C68BC Offset: 0x24C28BC VA: 0x24C68BC
	private void set_ReserveSale(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24C68C8 Offset: 0x24C28C8 VA: 0x24C68C8
	public bool get_ReserveAttack() { }

	[CompilerGenerated]
	// RVA: 0x24C68D0 Offset: 0x24C28D0 VA: 0x24C68D0
	private void set_ReserveAttack(bool value) { }

	[CompilerGenerated]
	// RVA: 0x24C68DC Offset: 0x24C28DC VA: 0x24C68DC
	public bool get_IsRecycle() { }

	[CompilerGenerated]
	// RVA: 0x24C68E4 Offset: 0x24C28E4 VA: 0x24C68E4
	private void set_IsRecycle(bool value) { }

	// RVA: 0x24C68F0 Offset: 0x24C28F0 VA: 0x24C68F0
	public void .ctor() { }

	// RVA: 0x24C6744 Offset: 0x24C2744 VA: 0x24C6744
	public void .ctor(byte type, CardData status, byte handId, short drawTrun, bool isRecycleSetting, byte marketSellPrice) { }

	// RVA: 0x24C6920 Offset: 0x24C2920 VA: 0x24C6920
	public void SetReserveSale(bool sale) { }

	// RVA: 0x24C0ED4 Offset: 0x24BCED4 VA: 0x24C0ED4
	public void SetReserveAttack(bool attack) { }

	// RVA: 0x24C0E04 Offset: 0x24BCE04 VA: 0x24C0E04
	public void OnMarketCard() { }

	// RVA: 0x24C0D28 Offset: 0x24BCD28 VA: 0x24C0D28
	public void OnHandCard() { }
}
