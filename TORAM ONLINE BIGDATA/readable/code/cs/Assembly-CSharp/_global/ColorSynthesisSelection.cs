// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ColorSynthesisSelection // TypeDefIndex: 6729
{
	// Fields
	public ColorSynthesisCostTable.Target Target; // 0x10
	public ColorSynthesisCostTable.EquipBase EquipBase; // 0x14
	public int PartIndex; // 0x18
	public int WeaponTypeIndex; // 0x1C
	public short WeaponItemType; // 0x20
	public int MetalPoint; // 0x24
	public int MainGemId; // 0x28
	public int[] SubGemIds; // 0x30

	// Properties
	public int GemCount { get; }
	public bool ContainsHammer { get; }

	// Methods

	// RVA: 0x19CD950 Offset: 0x19C9950 VA: 0x19CD950
	public int get_GemCount() { }

	// RVA: 0x19CC190 Offset: 0x19C8190 VA: 0x19CC190
	public bool get_ContainsHammer() { }

	// RVA: 0x19CBE80 Offset: 0x19C7E80 VA: 0x19CBE80
	public void Clear() { }

	// RVA: 0x19CD054 Offset: 0x19C9054 VA: 0x19CD054
	public void .ctor() { }
}
