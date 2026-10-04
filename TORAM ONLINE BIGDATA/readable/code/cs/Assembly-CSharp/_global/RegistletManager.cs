// Assembly: Assembly-CSharp.dll
// Namespace: 
public class RegistletManager // TypeDefIndex: 2296
{
	// Fields
	private byte flag; // 0x10
	private int gemPowder; // 0x14
	private GemCartBag _bag; // 0x18
	private GemCartBufferManager gemCartBufManager; // 0x20
	[CompilerGenerated]
	private bool <IsLoadLocalize>k__BackingField; // 0x28
	public readonly int[] NeedGemPowder; // 0x30
	public static int GemPowderLimit; // 0x0
	public static byte SlotLimit; // 0x4

	// Properties
	public bool IsSystemOpen { get; }
	public int GemPowder { get; }
	public GemCartBag Bag { get; }
	public bool IsLoadLocalize { get; set; }
	protected GemCartBufferManager GemCartBufferManager { get; }

	// Methods

	// RVA: 0x217D0A8 Offset: 0x21790A8 VA: 0x217D0A8
	public bool get_IsSystemOpen() { }

	// RVA: 0x217D0C4 Offset: 0x21790C4 VA: 0x217D0C4
	public int get_GemPowder() { }

	// RVA: 0x217D0CC Offset: 0x21790CC VA: 0x217D0CC
	public GemCartBag get_Bag() { }

	[CompilerGenerated]
	// RVA: 0x217D0D4 Offset: 0x21790D4 VA: 0x217D0D4
	public bool get_IsLoadLocalize() { }

	[CompilerGenerated]
	// RVA: 0x217D0DC Offset: 0x21790DC VA: 0x217D0DC
	private void set_IsLoadLocalize(bool value) { }

	// RVA: 0x217D0E8 Offset: 0x21790E8 VA: 0x217D0E8
	protected GemCartBufferManager get_GemCartBufferManager() { }

	// RVA: 0x217D0F0 Offset: 0x21790F0 VA: 0x217D0F0
	public void .ctor(GemCartBufferManager manager) { }

	// RVA: 0x217D1D4 Offset: 0x21791D4 VA: 0x217D1D4
	public void Initialize(RegistletData registletData, GemCartData[] cartData, GemCartEquipData[] equips) { }

	// RVA: 0x217D268 Offset: 0x2179268 VA: 0x217D268
	public bool GetEquipSendData(out Dictionary<byte, long> updateEquips) { }

	// RVA: 0x217D434 Offset: 0x2179434 VA: 0x217D434
	public void AddReward(GemCartData[] rewardGemCart) { }

	// RVA: 0x217D450 Offset: 0x2179450 VA: 0x217D450
	public void UpdateRewardGemPowder(int updateGemPowder) { }

	// RVA: 0x217D458 Offset: 0x2179458 VA: 0x217D458
	public void ProcessingGemCart(int updateGemPowder, long[] uuidList) { }

	// RVA: 0x217D50C Offset: 0x217950C VA: 0x217D50C
	public void Reinforce(GemCartData updateGem, long[] uuidList, int gemPowder) { }

	// RVA: 0x217D608 Offset: 0x2179608 VA: 0x217D608
	public void ExtensionSlot(int updateGemPowder, byte slot) { }

	// RVA: 0x217D628 Offset: 0x2179628 VA: 0x217D628
	public void ChangeGemCartEquip(GemCartEquipData[] updateEquipDatas) { }

	// RVA: 0x217D6D0 Offset: 0x21796D0 VA: 0x217D6D0
	public void ChangeGemCartFlag(GemCartData updateGem) { }

	// RVA: 0x217D6EC Offset: 0x21796EC VA: 0x217D6EC
	public void OpenSystem() { }

	// RVA: 0x217D724 Offset: 0x2179724 VA: 0x217D724
	public void CloseSystem() { }

	// RVA: 0x217D738 Offset: 0x2179738 VA: 0x217D738
	public void ChangeLoadLocalize(bool isLoad) { }

	// RVA: 0x217D0B4 Offset: 0x21790B4 VA: 0x217D0B4
	private bool CheckFlag(byte type) { }

	// RVA: 0x217D700 Offset: 0x2179700 VA: 0x217D700
	private void SetFlag(byte type, bool activate) { }

	// RVA: 0x217D744 Offset: 0x2179744 VA: 0x217D744
	private static void .cctor() { }
}
