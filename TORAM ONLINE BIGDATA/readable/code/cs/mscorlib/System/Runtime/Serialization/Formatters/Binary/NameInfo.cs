// Assembly: mscorlib.dll
// Namespace: System.Runtime.Serialization.Formatters.Binary
internal sealed class NameInfo // TypeDefIndex: 10431
{
	// Fields
	internal string NIFullName; // 0x10
	internal long NIobjectId; // 0x18
	internal long NIassemId; // 0x20
	internal InternalPrimitiveTypeE NIprimitiveTypeEnum; // 0x28
	internal Type NItype; // 0x30
	internal bool NIisSealed; // 0x38
	internal bool NIisArray; // 0x39
	internal bool NIisArrayItem; // 0x3A
	internal bool NItransmitTypeOnObject; // 0x3B
	internal bool NItransmitTypeOnMember; // 0x3C
	internal bool NIisParentTypeOnObject; // 0x3D
	internal InternalArrayTypeE NIarrayEnum; // 0x40
	private bool NIsealedStatusChecked; // 0x44

	// Properties
	public bool IsSealed { get; }
	public string NIname { get; set; }

	// Methods

	// RVA: 0x2F1C484 Offset: 0x2F18484 VA: 0x2F1C484
	internal void .ctor() { }

	// RVA: 0x2F1C48C Offset: 0x2F1848C VA: 0x2F1C48C
	internal void Init() { }

	// RVA: 0x2F1C4D0 Offset: 0x2F184D0 VA: 0x2F1C4D0
	public bool get_IsSealed() { }

	// RVA: 0x2F1C51C Offset: 0x2F1851C VA: 0x2F1C51C
	public string get_NIname() { }

	// RVA: 0x2F1C568 Offset: 0x2F18568 VA: 0x2F1C568
	public void set_NIname(string value) { }
}
