// Assembly: Assembly-CSharp.dll
// Namespace: 
public class OrbShopManager.GachaDetailData // TypeDefIndex: 2167
{
	// Fields
	public readonly int ProductId; // 0x10
	public readonly int ItemId; // 0x14
	public readonly byte Rare; // 0x18
	public readonly bool IsAvatar; // 0x19
	public readonly int Num; // 0x1C
	public readonly bool IsPack; // 0x20
	public readonly int rate; // 0x24

	// Properties
	public virtual float Rate { get; }

	// Methods

	// RVA: 0x2154C4C Offset: 0x2150C4C VA: 0x2154C4C Slot: 4
	public virtual float get_Rate() { }

	// RVA: 0x2154C64 Offset: 0x2150C64 VA: 0x2154C64
	public void .ctor(int productId, int itemId, byte rare, int rate, bool avatar) { }

	// RVA: 0x2154CC0 Offset: 0x2150CC0 VA: 0x2154CC0
	public void .ctor(int productId, int itemId, byte rare, bool avatar, int num, int rate, bool pack) { }

	// RVA: 0x2154D2C Offset: 0x2150D2C VA: 0x2154D2C Slot: 5
	public virtual int Sort(OrbShopManager.GachaDetailData b) { }
}
