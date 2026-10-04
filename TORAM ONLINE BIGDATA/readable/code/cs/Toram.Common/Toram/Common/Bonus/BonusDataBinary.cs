// Assembly: Toram.Common.dll
// Namespace: Toram.Common.Bonus
public class BonusDataBinary : BinaryBase // TypeDefIndex: 13088
{
	// Fields
	[CompilerGenerated]
	private BonusScriptData <ScriptData>k__BackingField; // 0x20
	[CompilerGenerated]
	private float <ElapsedTime>k__BackingField; // 0x28

	// Properties
	public BonusScriptData ScriptData { get; set; }
	public float ElapsedTime { get; set; }

	// Methods

	// RVA: 0x36A0AB8 Offset: 0x369CAB8 VA: 0x36A0AB8
	public void .ctor(byte[] binary) { }

	[CompilerGenerated]
	// RVA: 0x36A0AC0 Offset: 0x369CAC0 VA: 0x36A0AC0
	public BonusScriptData get_ScriptData() { }

	[CompilerGenerated]
	// RVA: 0x36A0AC8 Offset: 0x369CAC8 VA: 0x36A0AC8
	private void set_ScriptData(BonusScriptData value) { }

	[CompilerGenerated]
	// RVA: 0x36A0AD0 Offset: 0x369CAD0 VA: 0x36A0AD0
	public float get_ElapsedTime() { }

	[CompilerGenerated]
	// RVA: 0x36A0AD8 Offset: 0x369CAD8 VA: 0x36A0AD8
	protected void set_ElapsedTime(float value) { }

	// RVA: 0x36A0AE0 Offset: 0x369CAE0 VA: 0x36A0AE0 Slot: 4
	protected override bool SetValue(MemoryStream ms, bool isThrow) { }

	// RVA: 0x36A0C3C Offset: 0x369CC3C VA: 0x36A0C3C Slot: 7
	protected override void GetBinary(MemoryStream ms, bool isThrow) { }
}
