// Assembly: System.Data.dll
// Namespace: System.Data
internal sealed class DataError // TypeDefIndex: 14686
{
	// Fields
	private string _rowError; // 0x10
	private int _count; // 0x18
	private DataError.ColumnError[] _errorList; // 0x20

	// Properties
	internal string Text { get; set; }
	internal bool HasErrors { get; }

	// Methods

	// RVA: 0x31E48C4 Offset: 0x31E08C4 VA: 0x31E48C4
	internal void .ctor() { }

	// RVA: 0x31E4924 Offset: 0x31E0924 VA: 0x31E4924
	internal void .ctor(string rowError) { }

	// RVA: 0x31E49FC Offset: 0x31E09FC VA: 0x31E49FC
	internal string get_Text() { }

	// RVA: 0x31E4A04 Offset: 0x31E0A04 VA: 0x31E4A04
	internal void set_Text(string value) { }

	// RVA: 0x31E4A08 Offset: 0x31E0A08 VA: 0x31E4A08
	internal bool get_HasErrors() { }

	// RVA: 0x31E4A3C Offset: 0x31E0A3C VA: 0x31E4A3C
	internal void SetColumnError(DataColumn column, string error) { }

	// RVA: 0x31E4D70 Offset: 0x31E0D70 VA: 0x31E4D70
	internal string GetColumnError(DataColumn column) { }

	// RVA: 0x31E4B6C Offset: 0x31E0B6C VA: 0x31E4B6C
	internal void Clear(DataColumn column) { }

	// RVA: 0x31E4E0C Offset: 0x31E0E0C VA: 0x31E4E0C
	internal void Clear() { }

	// RVA: 0x31E4EB8 Offset: 0x31E0EB8 VA: 0x31E4EB8
	internal DataColumn[] GetColumnsInError() { }

	// RVA: 0x31E499C Offset: 0x31E099C VA: 0x31E499C
	private void SetText(string errorText) { }

	// RVA: 0x31E4C18 Offset: 0x31E0C18 VA: 0x31E4C18
	internal int IndexOf(DataColumn column) { }
}
