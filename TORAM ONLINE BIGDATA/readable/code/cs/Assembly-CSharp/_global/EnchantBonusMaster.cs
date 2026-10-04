// Assembly: Assembly-CSharp.dll
// Namespace: 
public class EnchantBonusMaster // TypeDefIndex: 2138
{
	// Fields
	private static EnchantBonusMaster instance; // 0x0
	private EnchantBonusData[] bonusMaster; // 0x10
	private HashSet<KeyValuePair<short, short>> emphasisPoropertyIdList; // 0x18
	[CompilerGenerated]
	private bool <IsReadyEmphasisBinary>k__BackingField; // 0x20

	// Properties
	public static EnchantBonusMaster Instance { get; }
	public bool IsReadyEmphasisBinary { get; set; }

	// Methods

	// RVA: 0x214CC30 Offset: 0x2148C30 VA: 0x214CC30
	public static EnchantBonusMaster get_Instance() { }

	// RVA: 0x214CCB4 Offset: 0x2148CB4 VA: 0x214CCB4
	private void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x214CD3C Offset: 0x2148D3C VA: 0x214CD3C
	public bool get_IsReadyEmphasisBinary() { }

	[CompilerGenerated]
	// RVA: 0x214CD44 Offset: 0x2148D44 VA: 0x214CD44
	private void set_IsReadyEmphasisBinary(bool value) { }

	// RVA: 0x214CD50 Offset: 0x2148D50 VA: 0x214CD50
	public short GetBonusRate(short capId, byte capVal) { }

	// RVA: 0x214CE48 Offset: 0x2148E48 VA: 0x214CE48
	public bool EmphasisBonusCheck(short capId, short capVal) { }

	// RVA: 0x214CEEC Offset: 0x2148EEC VA: 0x214CEEC
	public bool Read(byte[] data) { }
}
