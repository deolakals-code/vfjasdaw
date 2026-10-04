// Assembly: Assembly-CSharp.dll
// Namespace: 
private class UIPetRaceResultManager.RankData // TypeDefIndex: 5993
{
	// Fields
	public const int NonGoal = -10;
	public readonly int Id; // 0x10
	private PetModelData petModelInfo; // 0x18
	[CompilerGenerated]
	private GameObject <Model>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <UserName>k__BackingField; // 0x28
	[CompilerGenerated]
	private int <Time>k__BackingField; // 0x30

	// Properties
	public GameObject Model { get; set; }
	public bool IsGoal { get; }
	public string UserName { get; set; }
	public int Time { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x18628B0 Offset: 0x185E8B0 VA: 0x18628B0
	private void set_Model(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x18628B8 Offset: 0x185E8B8 VA: 0x18628B8
	public GameObject get_Model() { }

	// RVA: 0x1860174 Offset: 0x185C174 VA: 0x1860174
	public bool get_IsGoal() { }

	[CompilerGenerated]
	// RVA: 0x18628C0 Offset: 0x185E8C0 VA: 0x18628C0
	public string get_UserName() { }

	[CompilerGenerated]
	// RVA: 0x18628C8 Offset: 0x185E8C8 VA: 0x18628C8
	private void set_UserName(string value) { }

	[CompilerGenerated]
	// RVA: 0x18628D0 Offset: 0x185E8D0 VA: 0x18628D0
	public int get_Time() { }

	[CompilerGenerated]
	// RVA: 0x18628D8 Offset: 0x185E8D8 VA: 0x18628D8
	private void set_Time(int value) { }

	// RVA: 0x18617FC Offset: 0x185D7FC VA: 0x18617FC
	public void .ctor(int id) { }

	// RVA: 0x185FB4C Offset: 0x185BB4C VA: 0x185FB4C
	public void Dispose() { }

	// RVA: 0x1862354 Offset: 0x185E354 VA: 0x1862354
	public void SetUserName(string userName) { }

	// RVA: 0x18620A4 Offset: 0x185E0A4 VA: 0x18620A4
	public void SetTime(int time) { }

	// RVA: 0x18628E0 Offset: 0x185E8E0 VA: 0x18628E0
	public int Sort(UIPetRaceResultManager.RankData s) { }

	// RVA: 0x186235C Offset: 0x185E35C VA: 0x186235C
	public bool SetPetInfo(PetData petInfo) { }

	// RVA: 0x1862928 Offset: 0x185E928 VA: 0x1862928
	public void SetGameModel(GameObject model) { }

	// RVA: 0x1861260 Offset: 0x185D260 VA: 0x1861260
	public string GetTimeLabel() { }
}
