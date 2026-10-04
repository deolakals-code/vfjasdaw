// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobPopManager.MobPop : MobObjectManager.IListener // TypeDefIndex: 1014
{
	// Fields
	private float lastImitationToSymbol; // 0x10
	private Vector3 playerPos; // 0x14
	private MobObjectManager manager; // 0x20
	private float playerPopAreaRange; // 0x28
	private MobPopManager parent; // 0x30
	[CompilerGenerated]
	private MobPopPoint <PopData>k__BackingField; // 0x38
	[CompilerGenerated]
	private GameObject <Imitation>k__BackingField; // 0x40
	[CompilerGenerated]
	private List<GameObject> <Symbols>k__BackingField; // 0x48
	[CompilerGenerated]
	private bool <IsBoss>k__BackingField; // 0x50
	[CompilerGenerated]
	private bool <EnablePop>k__BackingField; // 0x51

	// Properties
	public MobPopPoint PopData { get; set; }
	public GameObject Imitation { get; set; }
	public List<GameObject> Symbols { get; set; }
	public bool IsBoss { get; set; }
	public bool HasImitation { get; }
	public bool IsSymbolized { get; }
	public bool HasSymbol { get; }
	public bool EnablePop { get; set; }
	public int MobID { get; }
	public bool IsInPlayer { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F35184 Offset: 0x1F31184 VA: 0x1F35184
	public MobPopPoint get_PopData() { }

	[CompilerGenerated]
	// RVA: 0x1F3518C Offset: 0x1F3118C VA: 0x1F3518C
	private void set_PopData(MobPopPoint value) { }

	[CompilerGenerated]
	// RVA: 0x1F35194 Offset: 0x1F31194 VA: 0x1F35194
	public GameObject get_Imitation() { }

	[CompilerGenerated]
	// RVA: 0x1F3519C Offset: 0x1F3119C VA: 0x1F3519C
	private void set_Imitation(GameObject value) { }

	[CompilerGenerated]
	// RVA: 0x1F351A4 Offset: 0x1F311A4 VA: 0x1F351A4
	public List<GameObject> get_Symbols() { }

	[CompilerGenerated]
	// RVA: 0x1F351AC Offset: 0x1F311AC VA: 0x1F351AC
	private void set_Symbols(List<GameObject> value) { }

	[CompilerGenerated]
	// RVA: 0x1F351B4 Offset: 0x1F311B4 VA: 0x1F351B4
	public bool get_IsBoss() { }

	[CompilerGenerated]
	// RVA: 0x1F351BC Offset: 0x1F311BC VA: 0x1F351BC
	private void set_IsBoss(bool value) { }

	// RVA: 0x1F351C8 Offset: 0x1F311C8 VA: 0x1F351C8
	public bool get_HasImitation() { }

	// RVA: 0x1F35228 Offset: 0x1F31228 VA: 0x1F35228
	public bool get_IsSymbolized() { }

	// RVA: 0x1F35298 Offset: 0x1F31298 VA: 0x1F35298
	public bool get_HasSymbol() { }

	[CompilerGenerated]
	// RVA: 0x1F352E8 Offset: 0x1F312E8 VA: 0x1F352E8
	public bool get_EnablePop() { }

	[CompilerGenerated]
	// RVA: 0x1F352F0 Offset: 0x1F312F0 VA: 0x1F352F0
	public void set_EnablePop(bool value) { }

	// RVA: 0x1F352FC Offset: 0x1F312FC VA: 0x1F352FC
	public int get_MobID() { }

	// RVA: 0x1F35318 Offset: 0x1F31318 VA: 0x1F35318
	public bool get_IsInPlayer() { }

	// RVA: 0x1F34A84 Offset: 0x1F30A84 VA: 0x1F34A84
	public void .ctor(MobPopPoint point, MobObjectManager manager, MobPopManager parent) { }

	// RVA: 0x1F35354 Offset: 0x1F31354 VA: 0x1F35354
	public void SetImitation(GameObject imitation) { }

	// RVA: 0x1F3535C Offset: 0x1F3135C VA: 0x1F3535C
	public bool ImitationToSymbol() { }

	// RVA: 0x1F35580 Offset: 0x1F31580 VA: 0x1F35580
	public bool SymbolToImitation() { }

	// RVA: 0x1F35588 Offset: 0x1F31588 VA: 0x1F35588
	private void DestroyObject(GameObject obj, bool immediately) { }

	// RVA: 0x1F35770 Offset: 0x1F31770 VA: 0x1F35770
	public void RemoveSymbol(GameObject obj) { }

	// RVA: 0x1F3582C Offset: 0x1F3182C VA: 0x1F3582C
	public bool RemoveSymbolWithCheckImitation(GameObject obj) { }

	// RVA: 0x1F34DE8 Offset: 0x1F30DE8 VA: 0x1F34DE8
	public void Destroy(bool immediately) { }

	// RVA: 0x1F359B0 Offset: 0x1F319B0 VA: 0x1F359B0
	private GameObject CreateImitation(MobPopPoint point) { }

	// RVA: 0x1F35A70 Offset: 0x1F31A70 VA: 0x1F35A70
	public void PopImitation() { }

	// RVA: 0x1F34770 Offset: 0x1F30770 VA: 0x1F34770
	public void PopSymbol() { }

	// RVA: 0x1F350E4 Offset: 0x1F310E4 VA: 0x1F350E4
	public void Update(Vector3 pos) { }

	// RVA: 0x1F35C10 Offset: 0x1F31C10 VA: 0x1F35C10 Slot: 4
	public void SymbolToEnemy(GameObject symbol) { }

	// RVA: 0x1F35C14 Offset: 0x1F31C14 VA: 0x1F35C14 Slot: 5
	public void Remove(GameObject symbol) { }

	// RVA: 0x1F35CD4 Offset: 0x1F31CD4 VA: 0x1F35CD4 Slot: 6
	public void Dead() { }
}
