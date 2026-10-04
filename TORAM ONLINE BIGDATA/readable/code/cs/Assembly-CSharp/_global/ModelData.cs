// Assembly: Assembly-CSharp.dll
// Namespace: 
public class ModelData // TypeDefIndex: 5326
{
	// Fields
	private static readonly string[] shaderType; // 0x0
	public Dictionary<string, MeshData> MeshData; // 0x10
	private Texture2D[] textureData; // 0x18
	private byte[][] texturePixelData; // 0x20
	public Dictionary<byte, Dictionary<MaterialProperty, object>> MaterialData; // 0x28
	public Dictionary<int, BoneMotionClip> MotionClipData; // 0x30
	public Dictionary<byte, byte> BillBoard; // 0x38
	[CompilerGenerated]
	private int <BoneId>k__BackingField; // 0x40
	[CompilerGenerated]
	private byte <Version>k__BackingField; // 0x44
	public BoneData BoneData; // 0x48
	private DateTime lastUpdate; // 0x50
	[CompilerGenerated]
	private ModelDataState <DataState>k__BackingField; // 0x58
	[CompilerGenerated]
	private string <AssetPath>k__BackingField; // 0x60
	[CompilerGenerated]
	private string <AssetFile>k__BackingField; // 0x68
	private byte lockCount; // 0x70

	// Properties
	public int BoneId { get; set; }
	public byte Version { get; set; }
	public ModelDataState DataState { get; set; }
	public string AssetPath { get; set; }
	public string AssetFile { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x262F7D8 Offset: 0x262B7D8 VA: 0x262F7D8
	private void set_BoneId(int value) { }

	[CompilerGenerated]
	// RVA: 0x262F7E0 Offset: 0x262B7E0 VA: 0x262F7E0
	public int get_BoneId() { }

	[CompilerGenerated]
	// RVA: 0x262F7E8 Offset: 0x262B7E8 VA: 0x262F7E8
	private void set_Version(byte value) { }

	[CompilerGenerated]
	// RVA: 0x262F7F0 Offset: 0x262B7F0 VA: 0x262F7F0
	public byte get_Version() { }

	[CompilerGenerated]
	// RVA: 0x262F7F8 Offset: 0x262B7F8 VA: 0x262F7F8
	public ModelDataState get_DataState() { }

	[CompilerGenerated]
	// RVA: 0x262F800 Offset: 0x262B800 VA: 0x262F800
	private void set_DataState(ModelDataState value) { }

	[CompilerGenerated]
	// RVA: 0x262F808 Offset: 0x262B808 VA: 0x262F808
	public string get_AssetPath() { }

	[CompilerGenerated]
	// RVA: 0x262F810 Offset: 0x262B810 VA: 0x262F810
	private void set_AssetPath(string value) { }

	[CompilerGenerated]
	// RVA: 0x262F818 Offset: 0x262B818 VA: 0x262F818
	public string get_AssetFile() { }

	[CompilerGenerated]
	// RVA: 0x262F820 Offset: 0x262B820 VA: 0x262F820
	private void set_AssetFile(string value) { }

	// RVA: 0x262F828 Offset: 0x262B828 VA: 0x262F828
	public void .ctor() { }

	// RVA: 0x262F944 Offset: 0x262B944 VA: 0x262F944
	public void .ctor(string assetPath, string assetFile) { }

	// RVA: 0x262FA90 Offset: 0x262BA90 VA: 0x262FA90
	public void Loading() { }

	// RVA: 0x262FA9C Offset: 0x262BA9C VA: 0x262FA9C
	public void Err() { }

	// RVA: 0x262FAA8 Offset: 0x262BAA8 VA: 0x262FAA8
	public void Lock() { }

	// RVA: 0x262FAD0 Offset: 0x262BAD0 VA: 0x262FAD0
	public void Uulock() { }

	// RVA: 0x262FAE4 Offset: 0x262BAE4 VA: 0x262FAE4
	public void LeaveField() { }

	// RVA: 0x262FF10 Offset: 0x262BF10 VA: 0x262FF10
	public bool ClearCheck() { }

	// RVA: 0x262FB00 Offset: 0x262BB00 VA: 0x262FB00
	public void Clear() { }

	// RVA: 0x262FF54 Offset: 0x262BF54 VA: 0x262FF54
	public long GetBlockSize(Dictionary<ModelDataType, long> header, long position, long len) { }

	// RVA: 0x26300B0 Offset: 0x262C0B0 VA: 0x26300B0
	public bool Load(byte[] binary) { }

	// RVA: 0x2630108 Offset: 0x262C108 VA: 0x2630108
	public bool Load(string fileName, byte[] binary) { }

	// RVA: 0x2630930 Offset: 0x262C930 VA: 0x2630930
	private void LoadTexture(BinaryReader read, long postion) { }

	// RVA: 0x26320F4 Offset: 0x262E0F4 VA: 0x26320F4
	public bool GetTexture(byte id, out Texture2D texture2D) { }

	// RVA: 0x2630B70 Offset: 0x262CB70 VA: 0x2630B70
	private void LoadMaterial(BinaryReader read, long postion) { }

	// RVA: 0x26326F4 Offset: 0x262E6F4 VA: 0x26326F4
	private void LoadMesh(byte[] binary, long position) { }

	// RVA: 0x26314E0 Offset: 0x262D4E0 VA: 0x26314E0
	private void LoadMesh(BinaryReader read, long postion) { }

	// RVA: 0x2631FEC Offset: 0x262DFEC VA: 0x2631FEC
	private void LoadOffset(BinaryReader read, long postion) { }

	// RVA: 0x26313A4 Offset: 0x262D3A4 VA: 0x26313A4
	private void LoadMotionClip(string fileName, BinaryReader read, long postion) { }

	// RVA: 0x2632970 Offset: 0x262E970 VA: 0x2632970
	private void LoadMotionClip(byte[] binary, long position) { }

	// RVA: 0x2630E70 Offset: 0x262CE70 VA: 0x2630E70
	private void LoadBoneTrans(BinaryReader read, long postion) { }

	// RVA: 0x26310D4 Offset: 0x262D0D4 VA: 0x26310D4
	private void LoadDynamicBoneTrans(BinaryReader read, long postion) { }

	// RVA: 0x2631188 Offset: 0x262D188 VA: 0x2631188
	private void LoadBillBoardBoneTrans(BinaryReader read, long postion) { }

	// RVA: 0x263123C Offset: 0x262D23C VA: 0x263123C
	private void LoadExMotionBoneTrans(BinaryReader read, long postion) { }

	// RVA: 0x26312F0 Offset: 0x262D2F0 VA: 0x26312F0
	private void LoadRotationBoneTrans(BinaryReader read, long postion) { }

	// RVA: 0x2630F24 Offset: 0x262CF24 VA: 0x2630F24
	private void LoadRenderState(BinaryReader read, long postion) { }

	// RVA: 0x2631EB8 Offset: 0x262DEB8 VA: 0x2631EB8
	private void LoadBillBoard(BinaryReader read, long postion) { }

	// RVA: 0x2632A98 Offset: 0x262EA98 VA: 0x2632A98
	private static void .cctor() { }
}
