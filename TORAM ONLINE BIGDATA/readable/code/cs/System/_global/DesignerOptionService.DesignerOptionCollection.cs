// Assembly: System.dll
// Namespace: 
[DefaultMember("Item")]
[TypeConverter(typeof(DesignerOptionService.DesignerOptionConverter))]
[Editor("", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
public sealed class DesignerOptionService.DesignerOptionCollection : ICollection // TypeDefIndex: 14286
{
	// Fields
	private DesignerOptionService _service; // 0x10
	private string _name; // 0x18
	private object _value; // 0x20
	private ArrayList _children; // 0x28
	private PropertyDescriptorCollection _properties; // 0x30

	// Properties
	public int Count { get; }
	public string Name { get; }
	public PropertyDescriptorCollection Properties { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: 0x34CF1E0 Offset: 0x34CB1E0 VA: 0x34CF1E0 Slot: 5
	public int get_Count() { }

	// RVA: 0x34CF2AC Offset: 0x34CB2AC VA: 0x34CF2AC
	public string get_Name() { }

	// RVA: 0x34CF2B4 Offset: 0x34CB2B4 VA: 0x34CF2B4
	public PropertyDescriptorCollection get_Properties() { }

	// RVA: 0x34CFA90 Offset: 0x34CBA90 VA: 0x34CFA90 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x34CF20C Offset: 0x34CB20C VA: 0x34CF20C
	private void EnsurePopulated() { }

	// RVA: 0x34CFAD4 Offset: 0x34CBAD4 VA: 0x34CFAD4 Slot: 8
	public IEnumerator GetEnumerator() { }

	// RVA: 0x34CFB00 Offset: 0x34CBB00 VA: 0x34CFB00 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x34CFB08 Offset: 0x34CBB08 VA: 0x34CFB08 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }
}
