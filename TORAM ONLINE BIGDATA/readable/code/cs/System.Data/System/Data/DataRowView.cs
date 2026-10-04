// Assembly: System.Data.dll
// Namespace: System.Data
[DefaultMember("Item")]
public class DataRowView : ICustomTypeDescriptor // TypeDefIndex: 14704
{
	// Fields
	private readonly DataView _dataView; // 0x10
	private readonly DataRow _row; // 0x18
	private bool _delayBeginEdit; // 0x20
	private static readonly PropertyDescriptorCollection s_zeroPropertyDescriptorCollection; // 0x0
	[CompilerGenerated]
	private PropertyChangedEventHandler PropertyChanged; // 0x28

	// Properties
	public DataView DataView { get; }
	private DataRowVersion RowVersionDefault { get; }
	public DataRow Row { get; }
	public bool IsNew { get; }

	// Methods

	// RVA: 0x31EFCDC Offset: 0x31EBCDC VA: 0x31EFCDC
	internal void .ctor(DataView dataView, DataRow row) { }

	// RVA: 0x31EFD20 Offset: 0x31EBD20 VA: 0x31EFD20 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x31EFD2C Offset: 0x31EBD2C VA: 0x31EFD2C Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x31EFD4C Offset: 0x31EBD4C VA: 0x31EFD4C
	public DataView get_DataView() { }

	// RVA: 0x31EFD54 Offset: 0x31EBD54 VA: 0x31EFD54
	private DataRowVersion get_RowVersionDefault() { }

	// RVA: 0x31EFDAC Offset: 0x31EBDAC VA: 0x31EFDAC
	internal int GetRecord() { }

	// RVA: 0x31EFDD0 Offset: 0x31EBDD0 VA: 0x31EFDD0
	internal bool HasRecord() { }

	// RVA: 0x31E45D0 Offset: 0x31E05D0 VA: 0x31E45D0
	internal object GetColumnValue(DataColumn column) { }

	// RVA: 0x31E4750 Offset: 0x31E0750 VA: 0x31E4750
	internal void SetColumnValue(DataColumn column, object value) { }

	// RVA: 0x31EFDF4 Offset: 0x31EBDF4 VA: 0x31EFDF4
	public DataView CreateChildView(DataRelation relation, bool followParent) { }

	// RVA: 0x31EBD70 Offset: 0x31E7D70 VA: 0x31EBD70
	public DataView CreateChildView(DataRelation relation) { }

	// RVA: 0x31EFF8C Offset: 0x31EBF8C VA: 0x31EFF8C
	public DataRow get_Row() { }

	// RVA: 0x31EFF94 Offset: 0x31EBF94 VA: 0x31EFF94 Slot: 9
	public void EndEdit() { }

	// RVA: 0x31EFFE0 Offset: 0x31EBFE0 VA: 0x31EFFE0
	public bool get_IsNew() { }

	// RVA: 0x31F0008 Offset: 0x31EC008 VA: 0x31F0008
	internal void RaisePropertyChangedEvent(string propName) { }

	// RVA: 0x31F0098 Offset: 0x31EC098 VA: 0x31F0098 Slot: 4
	private AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { }

	// RVA: 0x31F00F0 Offset: 0x31EC0F0 VA: 0x31F00F0 Slot: 5
	private TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { }

	// RVA: 0x31F00F8 Offset: 0x31EC0F8 VA: 0x31F00F8 Slot: 6
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { }

	// RVA: 0x31F0194 Offset: 0x31EC194 VA: 0x31F0194 Slot: 7
	private PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(Attribute[] attributes) { }

	// RVA: 0x31F021C Offset: 0x31EC21C VA: 0x31F021C Slot: 8
	private object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(PropertyDescriptor pd) { }

	// RVA: 0x31F0220 Offset: 0x31EC220 VA: 0x31F0220
	private static void .cctor() { }
}
