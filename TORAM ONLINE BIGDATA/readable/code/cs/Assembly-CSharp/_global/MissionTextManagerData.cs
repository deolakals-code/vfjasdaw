// Assembly: Assembly-CSharp.dll
// Namespace: 
public class MissionTextManagerData : QuestTextManagerData // TypeDefIndex: 5260
{
	// Fields
	public static readonly int KeywordItemCheckId; // 0x0
	private Dictionary<int, string> keywordItemNames; // 0x38
	private Dictionary<byte, int> keywordItemIconIds; // 0x40
	private Dictionary<byte, List<MissionTextManagerData.CheckIKeywordtemData>> keywordItemCheckDatas; // 0x48
	private Dictionary<byte, List<MissionTextManagerData.PickUpFieldData>> pickupFieldDatas; // 0x50

	// Properties
	public override bool IsKeyWordItem { get; }

	// Methods

	// RVA: 0x261A2BC Offset: 0x26162BC VA: 0x261A2BC Slot: 10
	public override bool get_IsKeyWordItem() { }

	// RVA: 0x261A318 Offset: 0x2616318 VA: 0x261A318
	public void .ctor() { }

	// RVA: 0x261A448 Offset: 0x2616448 VA: 0x261A448
	public void .ctor(string name, Dictionary<int, string> description, Dictionary<int, string> key, Dictionary<int, string> keywordItem, Dictionary<int, string> keywordItemName) { }

	// RVA: 0x2619DE4 Offset: 0x2615DE4 VA: 0x2619DE4
	public void .ctor(string name, Dictionary<int, string> description, Dictionary<int, string> key, Dictionary<int, string> keywordItem, Dictionary<int, string> keywordItemName, Dictionary<int, string> pickupField) { }

	// RVA: 0x261A980 Offset: 0x2616980 VA: 0x261A980 Slot: 11
	public override void GetHaveKeywordItemsNo(List<byte> hitNo, byte keyNo, int currentVal) { }

	// RVA: 0x261ABDC Offset: 0x2616BDC VA: 0x261ABDC Slot: 12
	public override string GetKeywordItemName(byte no) { }

	// RVA: 0x261AC90 Offset: 0x2616C90 VA: 0x261AC90 Slot: 13
	public override int GetKeywordItemIcon(byte no) { }

	// RVA: 0x261AD08 Offset: 0x2616D08 VA: 0x261AD08 Slot: 14
	public override void GetPickupField(List<int> hitField, byte no, int val) { }

	// RVA: 0x261AF80 Offset: 0x2616F80 VA: 0x261AF80
	private static void .cctor() { }
}
