// Assembly: System.dll
// Namespace: System.Net
[DefaultMember("Item")]
[ComVisible(True)]
[Serializable]
public class WebHeaderCollection : NameValueCollection, ISerializable // TypeDefIndex: 14412
{
	// Fields
	private static readonly HeaderInfoTable HInfo; // 0x0
	private string[] m_CommonHeaders; // 0x60
	private int m_NumCommonHeaders; // 0x68
	private static readonly string[] s_CommonHeaderNames; // 0x8
	private static readonly sbyte[] s_CommonHeaderHints; // 0x10
	private NameValueCollection m_InnerCollection; // 0x70
	private WebHeaderCollectionType m_Type; // 0x78
	private static readonly char[] HttpTrimCharacters; // 0x18
	private static WebHeaderCollection.RfcChar[] RfcCharMap; // 0x20

	// Properties
	private NameValueCollection InnerCollection { get; }
	private bool AllowHttpRequestHeader { get; }
	public override int Count { get; }

	// Methods

	// RVA: 0x34EFDD0 Offset: 0x34EBDD0 VA: 0x34EFDD0
	private void NormalizeCommonHeaders() { }

	// RVA: 0x34EFEE8 Offset: 0x34EBEE8 VA: 0x34EFEE8
	private NameValueCollection get_InnerCollection() { }

	// RVA: 0x34EFF90 Offset: 0x34EBF90 VA: 0x34EFF90
	internal static bool AllowMultiValues(string name) { }

	// RVA: 0x34F0114 Offset: 0x34EC114 VA: 0x34F0114
	private bool get_AllowHttpRequestHeader() { }

	// RVA: 0x34F0154 Offset: 0x34EC154 VA: 0x34F0154
	public void Remove(HttpRequestHeader header) { }

	// RVA: 0x34F0244 Offset: 0x34EC244 VA: 0x34F0244
	internal void AddInternal(string name, string value) { }

	// RVA: 0x34F0298 Offset: 0x34EC298 VA: 0x34F0298
	internal void ChangeInternal(string name, string value) { }

	// RVA: 0x34F02EC Offset: 0x34EC2EC VA: 0x34F02EC
	internal void RemoveInternal(string name) { }

	// RVA: 0x34F0348 Offset: 0x34EC348 VA: 0x34F0348
	internal static string CheckBadChars(string name, bool isHeaderValue) { }

	// RVA: 0x34F06E4 Offset: 0x34EC6E4 VA: 0x34F06E4
	internal static bool ContainsNonAsciiChars(string token) { }

	// RVA: 0x34F0768 Offset: 0x34EC768 VA: 0x34F0768
	internal void ThrowOnRestrictedHeader(string headerName) { }

	// RVA: 0x34F08D4 Offset: 0x34EC8D4 VA: 0x34F08D4 Slot: 15
	public override void Add(string name, string value) { }

	// RVA: 0x34F0A84 Offset: 0x34ECA84 VA: 0x34F0A84
	public void Add(string header) { }

	// RVA: 0x34F0D54 Offset: 0x34ECD54 VA: 0x34F0D54 Slot: 18
	public override void Set(string name, string value) { }

	// RVA: 0x34F0F7C Offset: 0x34ECF7C VA: 0x34F0F7C
	internal void SetInternal(string name, string value) { }

	// RVA: 0x34F1198 Offset: 0x34ED198 VA: 0x34F1198 Slot: 19
	public override void Remove(string name) { }

	// RVA: 0x34F12D0 Offset: 0x34ED2D0 VA: 0x34F12D0 Slot: 17
	public override string[] GetValues(string header) { }

	// RVA: 0x34F14D0 Offset: 0x34ED4D0 VA: 0x34F14D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x34F152C Offset: 0x34ED52C VA: 0x34F152C
	internal static string GetAsString(NameValueCollection cc, bool winInetCompat, bool forTrace) { }

	// RVA: 0x34ECC78 Offset: 0x34E8C78 VA: 0x34ECC78
	public void .ctor() { }

	// RVA: 0x34F17D8 Offset: 0x34ED7D8 VA: 0x34F17D8
	internal void .ctor(WebHeaderCollectionType type) { }

	// RVA: 0x34F18D4 Offset: 0x34ED8D4 VA: 0x34F18D4
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x34F1AA0 Offset: 0x34EDAA0 VA: 0x34F1AA0 Slot: 12
	public override void OnDeserialization(object sender) { }

	// RVA: 0x34F1AA4 Offset: 0x34EDAA4 VA: 0x34F1AA4 Slot: 11
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x34F1C24 Offset: 0x34EDC24 VA: 0x34F1C24 Slot: 9
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x34F1C30 Offset: 0x34EDC30 VA: 0x34F1C30 Slot: 16
	public override string Get(string name) { }

	// RVA: 0x34F1F5C Offset: 0x34EDF5C VA: 0x34F1F5C Slot: 13
	public override IEnumerator GetEnumerator() { }

	// RVA: 0x34F1FD0 Offset: 0x34EDFD0 VA: 0x34F1FD0 Slot: 14
	public override int get_Count() { }

	// RVA: 0x34F2000 Offset: 0x34EE000 VA: 0x34F2000 Slot: 20
	public override string Get(int index) { }

	// RVA: 0x34F2040 Offset: 0x34EE040 VA: 0x34F2040 Slot: 21
	public override string GetKey(int index) { }

	// RVA: 0x34F2080 Offset: 0x34EE080 VA: 0x34F2080
	private static void .cctor() { }
}
