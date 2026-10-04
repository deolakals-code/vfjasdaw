// Assembly: Assembly-CSharp.dll
// Namespace: 
private class MobObjectManager.PartyMobId // TypeDefIndex: 969
{
	// Fields
	[CompilerGenerated]
	private int <MobId>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <LocalId>k__BackingField; // 0x14
	[CompilerGenerated]
	private int <UniqueId>k__BackingField; // 0x18
	[CompilerGenerated]
	private bool <IsEnd>k__BackingField; // 0x1C
	private bool isStart; // 0x1D
	private float leftTime; // 0x20

	// Properties
	public int MobId { get; set; }
	public byte LocalId { get; set; }
	public int UniqueId { get; set; }
	public bool IsEnd { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1F30EF4 Offset: 0x1F2CEF4 VA: 0x1F30EF4
	public int get_MobId() { }

	[CompilerGenerated]
	// RVA: 0x1F30EFC Offset: 0x1F2CEFC VA: 0x1F30EFC
	private void set_MobId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F30F04 Offset: 0x1F2CF04 VA: 0x1F30F04
	public byte get_LocalId() { }

	[CompilerGenerated]
	// RVA: 0x1F30F0C Offset: 0x1F2CF0C VA: 0x1F30F0C
	private void set_LocalId(byte value) { }

	[CompilerGenerated]
	// RVA: 0x1F30F14 Offset: 0x1F2CF14 VA: 0x1F30F14
	public int get_UniqueId() { }

	[CompilerGenerated]
	// RVA: 0x1F30F1C Offset: 0x1F2CF1C VA: 0x1F30F1C
	private void set_UniqueId(int value) { }

	[CompilerGenerated]
	// RVA: 0x1F30F24 Offset: 0x1F2CF24 VA: 0x1F30F24
	public bool get_IsEnd() { }

	[CompilerGenerated]
	// RVA: 0x1F30F2C Offset: 0x1F2CF2C VA: 0x1F30F2C
	private void set_IsEnd(bool value) { }

	// RVA: 0x1F30F38 Offset: 0x1F2CF38 VA: 0x1F30F38
	public void .ctor(IMobIdData mobId) { }

	// RVA: 0x1F310AC Offset: 0x1F2D0AC VA: 0x1F310AC
	public bool IsMatch(IMobIdData mobId) { }

	// RVA: 0x1F3123C Offset: 0x1F2D23C VA: 0x1F3123C
	public void Start() { }

	// RVA: 0x1F31264 Offset: 0x1F2D264 VA: 0x1F31264
	public void Update() { }
}
