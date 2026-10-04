// Assembly: Assembly-CSharp.dll
// Namespace: 
public class CommunityURLManager.CommunityURLData : TextManagerDataBase // TypeDefIndex: 5223
{
	// Fields
	public readonly string ButtonLabel; // 0x28
	public readonly string ButtonText; // 0x30
	public readonly string URL; // 0x38
	[CompilerGenerated]
	private string <ExPopText>k__BackingField; // 0x40
	[CompilerGenerated]
	private string <OnePushKey>k__BackingField; // 0x48
	private DateTime startTime; // 0x50
	private DateTime endTime; // 0x58
	private readonly byte Flag; // 0x60

	// Properties
	public string ExPopText { get; set; }
	public string OnePushKey { get; set; }
	public bool IsNews { get; }
	public bool IsExPopText { get; }
	public bool IsOnePushKeyButton { get; }
	public bool IsTime { get; }
	public bool IsActiveTime { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x260FD9C Offset: 0x260BD9C VA: 0x260FD9C
	public string get_ExPopText() { }

	[CompilerGenerated]
	// RVA: 0x260FDA4 Offset: 0x260BDA4 VA: 0x260FDA4
	private void set_ExPopText(string value) { }

	[CompilerGenerated]
	// RVA: 0x260FDAC Offset: 0x260BDAC VA: 0x260FDAC
	public string get_OnePushKey() { }

	[CompilerGenerated]
	// RVA: 0x260FDB4 Offset: 0x260BDB4 VA: 0x260FDB4
	private void set_OnePushKey(string value) { }

	// RVA: 0x260FB14 Offset: 0x260BB14 VA: 0x260FB14
	public void .ctor(string buttonLabel, string buttonText, string url, byte flag) { }

	// RVA: 0x260FDBC Offset: 0x260BDBC VA: 0x260FDBC
	public bool get_IsNews() { }

	// RVA: 0x260FBE0 Offset: 0x260BBE0 VA: 0x260FBE0
	public bool get_IsExPopText() { }

	// RVA: 0x260FC0C Offset: 0x260BC0C VA: 0x260FC0C
	public bool get_IsOnePushKeyButton() { }

	// RVA: 0x260FC38 Offset: 0x260BC38 VA: 0x260FC38
	public bool get_IsTime() { }

	// RVA: 0x260FDC8 Offset: 0x260BDC8 VA: 0x260FDC8
	public bool get_IsActiveTime() { }

	// RVA: 0x260FBEC Offset: 0x260BBEC VA: 0x260FBEC
	public bool SetExPopText(string exPopText) { }

	// RVA: 0x260FC18 Offset: 0x260BC18 VA: 0x260FC18
	public bool SetOnePushKey(string onePushKey) { }

	// RVA: 0x260FC44 Offset: 0x260BC44 VA: 0x260FC44
	public bool SetTimer(long start, long end) { }

	// RVA: 0x260FED0 Offset: 0x260BED0 VA: 0x260FED0
	public void OpenURL() { }
}
