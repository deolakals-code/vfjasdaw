// Assembly: Assembly-CSharp.dll
// Namespace: 
public class SkillTextManagerData : TextManagerDataBase // TypeDefIndex: 5275
{
	// Fields
	private static readonly string[] elementKey; // 0x0
	private Dictionary<string, string> skillExName; // 0x28
	private Dictionary<string, string> skillExInfo; // 0x30
	private List<SkillTextManagerData.SkillIconInfo> skillExIconInfo; // 0x38
	private int id; // 0x40

	// Methods

	// RVA: 0x261F778 Offset: 0x261B778 VA: 0x261F778
	public void .ctor() { }

	// RVA: 0x261EDEC Offset: 0x261ADEC VA: 0x261EDEC
	public void .ctor(int id, string name, string description) { }

	// RVA: 0x261EE44 Offset: 0x261AE44 VA: 0x261EE44
	public void .ctor(int id, string name, string description, string iconInfo) { }

	// RVA: 0x261F788 Offset: 0x261B788 VA: 0x261F788
	private void CheckNameText(string name) { }

	// RVA: 0x261F1F8 Offset: 0x261B1F8 VA: 0x261F1F8
	public string GetName(ElementType elementType) { }

	// RVA: 0x261F084 Offset: 0x261B084 VA: 0x261F084
	public string GetName(string key) { }

	// RVA: 0x261FC70 Offset: 0x261BC70 VA: 0x261FC70 Slot: 5
	public override string GetName() { }

	// RVA: 0x261FC78 Offset: 0x261BC78 VA: 0x261FC78
	private string GetColorSkillName(string name) { }

	// RVA: 0x261F940 Offset: 0x261B940 VA: 0x261F940
	private void CheckInfoText(string text) { }

	// RVA: 0x261F460 Offset: 0x261B460 VA: 0x261F460
	public string GetDescription(string key) { }

	// RVA: 0x261FD1C Offset: 0x261BD1C VA: 0x261FD1C Slot: 6
	public override string GetDescription() { }

	// RVA: 0x261FA5C Offset: 0x261BA5C VA: 0x261FA5C
	private void CheckIconInfoText(string text) { }

	// RVA: 0x261FDAC Offset: 0x261BDAC VA: 0x261FDAC
	public SkillTextManagerData.SkillIconInfo[] GetIconInfo() { }

	// RVA: 0x261FE04 Offset: 0x261BE04 VA: 0x261FE04
	public string GetAllName() { }

	// RVA: 0x26200AC Offset: 0x261C0AC VA: 0x26200AC
	public string GetAllDescription() { }

	// RVA: 0x262035C Offset: 0x261C35C VA: 0x262035C
	public string GetIconInfoStr(int iconNo) { }

	// RVA: 0x2620514 Offset: 0x261C514 VA: 0x2620514
	private static void .cctor() { }
}
