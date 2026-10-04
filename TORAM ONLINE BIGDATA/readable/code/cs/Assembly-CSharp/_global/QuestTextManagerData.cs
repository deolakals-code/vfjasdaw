// Assembly: Assembly-CSharp.dll
// Namespace: 
public class QuestTextManagerData : TextManagerDataBase // TypeDefIndex: 5265
{
	// Fields
	private readonly Dictionary<int, string> Descriptions; // 0x28
	private readonly Dictionary<int, string> Keys; // 0x30

	// Properties
	public virtual bool IsKeyWordItem { get; }

	// Methods

	// RVA: 0x261C720 Offset: 0x2618720 VA: 0x261C720 Slot: 10
	public virtual bool get_IsKeyWordItem() { }

	// RVA: 0x261C728 Offset: 0x2618728 VA: 0x261C728
	public void .ctor() { }

	// RVA: 0x261C4D0 Offset: 0x26184D0 VA: 0x261C4D0
	public void .ctor(string name, Dictionary<int, string> description, Dictionary<int, string> key) { }

	// RVA: 0x261C820 Offset: 0x2618820 VA: 0x261C820
	public string GetKey(int id) { }

	// RVA: 0x261C8C8 Offset: 0x26188C8 VA: 0x261C8C8
	public string GetDescription(int id) { }

	// RVA: 0x261C95C Offset: 0x261895C VA: 0x261C95C
	public string GetKeyFormat(int id, object[] args) { }

	// RVA: 0x261C9CC Offset: 0x26189CC VA: 0x261C9CC
	public string GetDescriptionFormat(int id, object[] args) { }

	// RVA: 0x261CA3C Offset: 0x2618A3C VA: 0x261CA3C Slot: 11
	public virtual void GetHaveKeywordItemsNo(List<byte> hitNo, byte keyNo, int currentVal) { }

	// RVA: 0x261CA40 Offset: 0x2618A40 VA: 0x261CA40 Slot: 12
	public virtual string GetKeywordItemName(byte no) { }

	// RVA: 0x261CA80 Offset: 0x2618A80 VA: 0x261CA80 Slot: 13
	public virtual int GetKeywordItemIcon(byte no) { }

	// RVA: 0x261CA88 Offset: 0x2618A88 VA: 0x261CA88 Slot: 14
	public virtual void GetPickupField(List<int> hitField, byte no, int val) { }

	// RVA: 0x261CA8C Offset: 0x2618A8C VA: 0x261CA8C
	public ValueTuple<string, string> GetTitles() { }
}
