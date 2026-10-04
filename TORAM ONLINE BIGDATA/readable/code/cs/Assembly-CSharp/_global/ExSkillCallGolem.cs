// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ExSkillCallGolem : ExSkillDataBase // TypeDefIndex: 1817
{
	// Fields
	[CompilerGenerated]
	private byte <Type>k__BackingField; // 0x10
	[CompilerGenerated]
	private byte <AttackPoint>k__BackingField; // 0x11
	[CompilerGenerated]
	private byte <ShieldPoint>k__BackingField; // 0x12
	[CompilerGenerated]
	private byte <SpeedPoint>k__BackingField; // 0x13

	// Properties
	public override SkillId SkillId { get; }
	public byte Type { get; set; }
	public byte AttackPoint { get; set; }
	public byte ShieldPoint { get; set; }
	public byte SpeedPoint { get; set; }

	// Methods

	// RVA: 0x20E42A4 Offset: 0x20E02A4 VA: 0x20E42A4 Slot: 4
	public override SkillId get_SkillId() { }

	[CompilerGenerated]
	// RVA: 0x20E42AC Offset: 0x20E02AC VA: 0x20E42AC
	public byte get_Type() { }

	[CompilerGenerated]
	// RVA: 0x20E42B4 Offset: 0x20E02B4 VA: 0x20E42B4
	private void set_Type(byte value) { }

	[CompilerGenerated]
	// RVA: 0x20E42BC Offset: 0x20E02BC VA: 0x20E42BC
	public byte get_AttackPoint() { }

	[CompilerGenerated]
	// RVA: 0x20E42C4 Offset: 0x20E02C4 VA: 0x20E42C4
	private void set_AttackPoint(byte value) { }

	[CompilerGenerated]
	// RVA: 0x20E42CC Offset: 0x20E02CC VA: 0x20E42CC
	public byte get_ShieldPoint() { }

	[CompilerGenerated]
	// RVA: 0x20E42D4 Offset: 0x20E02D4 VA: 0x20E42D4
	private void set_ShieldPoint(byte value) { }

	[CompilerGenerated]
	// RVA: 0x20E42DC Offset: 0x20E02DC VA: 0x20E42DC
	public byte get_SpeedPoint() { }

	[CompilerGenerated]
	// RVA: 0x20E42E4 Offset: 0x20E02E4 VA: 0x20E42E4
	private void set_SpeedPoint(byte value) { }

	// RVA: 0x20E42EC Offset: 0x20E02EC VA: 0x20E42EC
	public void .ctor() { }

	// RVA: 0x20E4310 Offset: 0x20E0310 VA: 0x20E4310
	public void .ctor(byte[] binary) { }

	// RVA: 0x20E4378 Offset: 0x20E0378 VA: 0x20E4378
	public void .ctor(byte type, byte attack, byte shield, byte speed) { }

	// RVA: 0x20E43C0 Offset: 0x20E03C0 VA: 0x20E43C0 Slot: 6
	public override void SetValue(byte[] binary) { }

	// RVA: 0x20E45BC Offset: 0x20E05BC VA: 0x20E45BC Slot: 5
	public override byte[] ToBinary() { }

	// RVA: 0x20E4964 Offset: 0x20E0964 VA: 0x20E4964
	public byte CalcSurplusPoint(byte lv) { }

	// RVA: 0x20E4988 Offset: 0x20E0988 VA: 0x20E4988
	public byte GetPoint(byte lv, ExSkillCallGolem.PointType type) { }

	// RVA: 0x20E49D4 Offset: 0x20E09D4 VA: 0x20E49D4
	public void PointReset() { }
}
