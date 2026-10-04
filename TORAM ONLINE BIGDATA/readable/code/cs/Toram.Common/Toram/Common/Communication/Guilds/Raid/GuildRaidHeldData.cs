// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Communication.Guilds.Raid
public class GuildRaidHeldData : BinaryBase // TypeDefIndex: 13034
{
	// Fields
	[CompilerGenerated]
	private byte <Element>k__BackingField; // 0x19
	[CompilerGenerated]
	private byte <HeldCount>k__BackingField; // 0x1A
	[CompilerGenerated]
	private byte <MaxHpCount>k__BackingField; // 0x1B
	[CompilerGenerated]
	private int <LeftHeldTime>k__BackingField; // 0x1C
	[CompilerGenerated]
	private int <LeftReheldTime>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsPractice>k__BackingField; // 0x24

	// Properties
	public byte Element { get; set; }
	public byte HeldCount { get; set; }
	public byte MaxHpCount { get; set; }
	public virtual int LeftHeldTime { get; set; }
	public virtual int LeftReheldTime { get; set; }
	public bool IsPractice { get; set; }

	// Methods

	// RVA: 0x3693260 Offset: 0x368F260 VA: 0x3693260
	public void .ctor() { }

	// RVA: 0x3693280 Offset: 0x368F280 VA: 0x3693280
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x3693288 Offset: 0x368F288 VA: 0x3693288
	public byte get_Element() { }

	[CompilerGenerated]
	// RVA: 0x3693290 Offset: 0x368F290 VA: 0x3693290
	public void set_Element(byte value) { }

	[CompilerGenerated]
	// RVA: 0x3693298 Offset: 0x368F298 VA: 0x3693298
	public byte get_HeldCount() { }

	[CompilerGenerated]
	// RVA: 0x36932A0 Offset: 0x368F2A0 VA: 0x36932A0
	public void set_HeldCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36932A8 Offset: 0x368F2A8 VA: 0x36932A8
	public byte get_MaxHpCount() { }

	[CompilerGenerated]
	// RVA: 0x36932B0 Offset: 0x368F2B0 VA: 0x36932B0
	public void set_MaxHpCount(byte value) { }

	[CompilerGenerated]
	// RVA: 0x36932B8 Offset: 0x368F2B8 VA: 0x36932B8 Slot: 8
	public virtual int get_LeftHeldTime() { }

	[CompilerGenerated]
	// RVA: 0x36932C0 Offset: 0x368F2C0 VA: 0x36932C0 Slot: 9
	public virtual void set_LeftHeldTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x36932C8 Offset: 0x368F2C8 VA: 0x36932C8 Slot: 10
	public virtual int get_LeftReheldTime() { }

	[CompilerGenerated]
	// RVA: 0x36932D0 Offset: 0x368F2D0 VA: 0x36932D0 Slot: 11
	public virtual void set_LeftReheldTime(int value) { }

	[CompilerGenerated]
	// RVA: 0x36932D8 Offset: 0x368F2D8 VA: 0x36932D8
	public bool get_IsPractice() { }

	[CompilerGenerated]
	// RVA: 0x36932E0 Offset: 0x368F2E0 VA: 0x36932E0
	public void set_IsPractice(bool value) { }

	// RVA: 0x36932EC Offset: 0x368F2EC VA: 0x36932EC Slot: 3
	public override string ToString() { }

	// RVA: 0x36935A8 Offset: 0x368F5A8 VA: 0x36935A8 Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }

	// RVA: 0x3693644 Offset: 0x368F644 VA: 0x3693644 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }
}
