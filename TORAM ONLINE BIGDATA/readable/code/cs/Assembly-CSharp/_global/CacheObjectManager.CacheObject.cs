// Assembly: Assembly-CSharp.dll
// Namespace: 
private class CacheObjectManager.CacheObject // TypeDefIndex: 5462
{
	// Fields
	[CompilerGenerated]
	private string <Name>k__BackingField; // 0x10
	[CompilerGenerated]
	private Object <Object>k__BackingField; // 0x18
	[CompilerGenerated]
	private CacheObjectManager.CacheType <Type>k__BackingField; // 0x20
	[CompilerGenerated]
	private string <Tag>k__BackingField; // 0x28
	[CompilerGenerated]
	private CacheObjectFlag <Flag>k__BackingField; // 0x30
	[CompilerGenerated]
	private float <RegisterTime>k__BackingField; // 0x34

	// Properties
	public string Name { get; set; }
	public Object Object { get; set; }
	public CacheObjectManager.CacheType Type { get; set; }
	public string Tag { get; set; }
	public CacheObjectFlag Flag { get; set; }
	public float RegisterTime { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1773658 Offset: 0x176F658 VA: 0x1773658
	public string get_Name() { }

	[CompilerGenerated]
	// RVA: 0x1773660 Offset: 0x176F660 VA: 0x1773660
	private void set_Name(string value) { }

	[CompilerGenerated]
	// RVA: 0x1773668 Offset: 0x176F668 VA: 0x1773668
	public Object get_Object() { }

	[CompilerGenerated]
	// RVA: 0x1773670 Offset: 0x176F670 VA: 0x1773670
	private void set_Object(Object value) { }

	[CompilerGenerated]
	// RVA: 0x1773678 Offset: 0x176F678 VA: 0x1773678
	public CacheObjectManager.CacheType get_Type() { }

	[CompilerGenerated]
	// RVA: 0x1773680 Offset: 0x176F680 VA: 0x1773680
	private void set_Type(CacheObjectManager.CacheType value) { }

	[CompilerGenerated]
	// RVA: 0x1773688 Offset: 0x176F688 VA: 0x1773688
	public string get_Tag() { }

	[CompilerGenerated]
	// RVA: 0x1773690 Offset: 0x176F690 VA: 0x1773690
	private void set_Tag(string value) { }

	[CompilerGenerated]
	// RVA: 0x1773698 Offset: 0x176F698 VA: 0x1773698
	public CacheObjectFlag get_Flag() { }

	[CompilerGenerated]
	// RVA: 0x17736A0 Offset: 0x176F6A0 VA: 0x17736A0
	private void set_Flag(CacheObjectFlag value) { }

	[CompilerGenerated]
	// RVA: 0x17736A8 Offset: 0x176F6A8 VA: 0x17736A8
	public float get_RegisterTime() { }

	[CompilerGenerated]
	// RVA: 0x17736B0 Offset: 0x176F6B0 VA: 0x17736B0
	private void set_RegisterTime(float value) { }

	// RVA: 0x1772610 Offset: 0x176E610 VA: 0x1772610
	public void .ctor(string name, Object obj, CacheObjectFlag flag, CacheObjectManager.CacheType type) { }

	// RVA: 0x177292C Offset: 0x176E92C VA: 0x177292C
	public void .ctor(string name, Object obj, CacheObjectFlag flag, CacheObjectManager.CacheType type, string tag) { }

	// RVA: 0x1772D9C Offset: 0x176ED9C VA: 0x1772D9C
	public void Dispose() { }

	// RVA: 0x1772B10 Offset: 0x176EB10 VA: 0x1772B10
	public void UppdateTime() { }

	// RVA: 0x1772060 Offset: 0x176E060 VA: 0x1772060
	public bool UpdateTag(string baseTag, string tag) { }
}
