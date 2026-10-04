// Assembly: System.dll
// Namespace: System
public class UriBuilder // TypeDefIndex: 14028
{
	// Fields
	private bool _changed; // 0x10
	private string _fragment; // 0x18
	private string _host; // 0x20
	private string _password; // 0x28
	private string _path; // 0x30
	private int _port; // 0x38
	private string _query; // 0x40
	private string _scheme; // 0x48
	private string _schemeDelimiter; // 0x50
	private Uri _uri; // 0x58
	private string _username; // 0x60

	// Properties
	public string Path { set; }
	public Uri Uri { get; }

	// Methods

	// RVA: 0x34626A4 Offset: 0x345E6A4 VA: 0x34626A4
	public void .ctor(Uri uri) { }

	// RVA: 0x3462878 Offset: 0x345E878 VA: 0x3462878
	private void Init(Uri uri) { }

	// RVA: 0x3462C28 Offset: 0x345EC28 VA: 0x3462C28
	public void set_Path(string value) { }

	// RVA: 0x3462CE8 Offset: 0x345ECE8 VA: 0x3462CE8
	public Uri get_Uri() { }

	// RVA: 0x3462D88 Offset: 0x345ED88 VA: 0x3462D88 Slot: 0
	public override bool Equals(object rparam) { }

	// RVA: 0x3462DE4 Offset: 0x345EDE4 VA: 0x3462DE4 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x3462A54 Offset: 0x345EA54 VA: 0x3462A54
	private void SetFieldsFromUri(Uri uri) { }

	// RVA: 0x3462E04 Offset: 0x345EE04 VA: 0x3462E04 Slot: 3
	public override string ToString() { }
}
