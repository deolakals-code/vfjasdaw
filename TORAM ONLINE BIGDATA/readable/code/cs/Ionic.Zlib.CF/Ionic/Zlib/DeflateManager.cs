// Assembly: Ionic.Zlib.CF.dll
// Namespace: Ionic.Zlib
internal sealed class DeflateManager // TypeDefIndex: 17161
{
	// Fields
	private static readonly int MEM_LEVEL_MAX; // 0x0
	private static readonly int MEM_LEVEL_DEFAULT; // 0x4
	private DeflateManager.CompressFunc DeflateFunction; // 0x10
	private static readonly string[] _ErrorMessage; // 0x8
	private static readonly int PRESET_DICT; // 0x10
	private static readonly int INIT_STATE; // 0x14
	private static readonly int BUSY_STATE; // 0x18
	private static readonly int FINISH_STATE; // 0x1C
	private static readonly int Z_DEFLATED; // 0x20
	private static readonly int STORED_BLOCK; // 0x24
	private static readonly int STATIC_TREES; // 0x28
	private static readonly int DYN_TREES; // 0x2C
	private static readonly int Z_BINARY; // 0x30
	private static readonly int Z_ASCII; // 0x34
	private static readonly int Z_UNKNOWN; // 0x38
	private static readonly int Buf_size; // 0x3C
	private static readonly int MIN_MATCH; // 0x40
	private static readonly int MAX_MATCH; // 0x44
	private static readonly int MIN_LOOKAHEAD; // 0x48
	private static readonly int HEAP_SIZE; // 0x4C
	private static readonly int END_BLOCK; // 0x50
	internal ZlibCodec _codec; // 0x18
	internal int status; // 0x20
	internal byte[] pending; // 0x28
	internal int nextPending; // 0x30
	internal int pendingCount; // 0x34
	internal sbyte data_type; // 0x38
	internal int last_flush; // 0x3C
	internal int w_size; // 0x40
	internal int w_bits; // 0x44
	internal int w_mask; // 0x48
	internal byte[] window; // 0x50
	internal int window_size; // 0x58
	internal short[] prev; // 0x60
	internal short[] head; // 0x68
	internal int ins_h; // 0x70
	internal int hash_size; // 0x74
	internal int hash_bits; // 0x78
	internal int hash_mask; // 0x7C
	internal int hash_shift; // 0x80
	internal int block_start; // 0x84
	private DeflateManager.Config config; // 0x88
	internal int match_length; // 0x90
	internal int prev_match; // 0x94
	internal int match_available; // 0x98
	internal int strstart; // 0x9C
	internal int match_start; // 0xA0
	internal int lookahead; // 0xA4
	internal int prev_length; // 0xA8
	internal CompressionLevel compressionLevel; // 0xAC
	internal CompressionStrategy compressionStrategy; // 0xB0
	internal short[] dyn_ltree; // 0xB8
	internal short[] dyn_dtree; // 0xC0
	internal short[] bl_tree; // 0xC8
	internal Tree treeLiterals; // 0xD0
	internal Tree treeDistances; // 0xD8
	internal Tree treeBitLengths; // 0xE0
	internal short[] bl_count; // 0xE8
	internal int[] heap; // 0xF0
	internal int heap_len; // 0xF8
	internal int heap_max; // 0xFC
	internal sbyte[] depth; // 0x100
	internal int _lengthOffset; // 0x108
	internal int lit_bufsize; // 0x10C
	internal int last_lit; // 0x110
	internal int _distanceOffset; // 0x114
	internal int opt_len; // 0x118
	internal int static_len; // 0x11C
	internal int matches; // 0x120
	internal int last_eob_len; // 0x124
	internal short bi_buf; // 0x128
	internal int bi_valid; // 0x12C
	private bool Rfc1950BytesEmitted; // 0x130
	private bool _WantRfc1950HeaderBytes; // 0x131

	// Properties
	internal bool WantRfc1950HeaderBytes { get; set; }

	// Methods

	// RVA: 0x2E34A68 Offset: 0x2E30A68 VA: 0x2E34A68
	internal void .ctor() { }

	// RVA: 0x2E34CCC Offset: 0x2E30CCC VA: 0x2E34CCC
	private void _InitializeLazyMatch() { }

	// RVA: 0x2E34F04 Offset: 0x2E30F04 VA: 0x2E34F04
	private void _InitializeTreeData() { }

	// RVA: 0x2E35000 Offset: 0x2E31000 VA: 0x2E35000
	internal void _InitializeBlocks() { }

	// RVA: 0x2E351D0 Offset: 0x2E311D0 VA: 0x2E351D0
	internal void pqdownheap(short[] tree, int k) { }

	// RVA: 0x2E35384 Offset: 0x2E31384 VA: 0x2E35384
	internal static bool _IsSmaller(short[] tree, int n, int m, sbyte[] depth) { }

	// RVA: 0x2E35410 Offset: 0x2E31410 VA: 0x2E35410
	internal void scan_tree(short[] tree, int max_code) { }

	// RVA: 0x2E35650 Offset: 0x2E31650 VA: 0x2E35650
	internal int build_bl_tree() { }

	// RVA: 0x2E35C2C Offset: 0x2E31C2C VA: 0x2E35C2C
	internal void send_all_trees(int lcodes, int dcodes, int blcodes) { }

	// RVA: 0x2E35E90 Offset: 0x2E31E90 VA: 0x2E35E90
	internal void send_tree(short[] tree, int max_code) { }

	// RVA: 0x2E360D0 Offset: 0x2E320D0 VA: 0x2E360D0
	private void put_bytes(byte[] p, int start, int len) { }

	// RVA: 0x2E3608C Offset: 0x2E3208C VA: 0x2E3608C
	internal void send_code(int c, short[] tree) { }

	// RVA: 0x2E35D5C Offset: 0x2E31D5C VA: 0x2E35D5C
	internal void send_bits(int value, int length) { }

	// RVA: 0x2E36118 Offset: 0x2E32118 VA: 0x2E36118
	internal void _tr_align() { }

	// RVA: 0x2E36338 Offset: 0x2E32338 VA: 0x2E36338
	internal bool _tr_tally(int dist, int lc) { }

	// RVA: 0x2E366F0 Offset: 0x2E326F0 VA: 0x2E366F0
	internal void send_compressed_block(short[] ltree, short[] dtree) { }

	// RVA: 0x2E369E8 Offset: 0x2E329E8 VA: 0x2E369E8
	internal void set_data_type() { }

	// RVA: 0x2E36264 Offset: 0x2E32264 VA: 0x2E36264
	internal void bi_flush() { }

	// RVA: 0x2E36B54 Offset: 0x2E32B54 VA: 0x2E36B54
	internal void bi_windup() { }

	// RVA: 0x2E36C04 Offset: 0x2E32C04 VA: 0x2E36C04
	internal void copy_block(int buf, int len, bool header) { }

	// RVA: 0x2E36D1C Offset: 0x2E32D1C VA: 0x2E36D1C
	internal void flush_block_only(bool eof) { }

	// RVA: 0x2E36F70 Offset: 0x2E32F70 VA: 0x2E36F70
	internal BlockState DeflateNone(FlushType flush) { }

	// RVA: 0x2E37334 Offset: 0x2E33334 VA: 0x2E37334
	internal void _tr_stored_block(int buf, int stored_len, bool eof) { }

	// RVA: 0x2E36D64 Offset: 0x2E32D64 VA: 0x2E36D64
	internal void _tr_flush_block(int buf, int stored_len, bool eof) { }

	// RVA: 0x2E370EC Offset: 0x2E330EC VA: 0x2E370EC
	private void _fillWindow() { }

	// RVA: 0x2E373D8 Offset: 0x2E333D8 VA: 0x2E373D8
	internal BlockState DeflateFast(FlushType flush) { }

	// RVA: 0x2E37D04 Offset: 0x2E33D04 VA: 0x2E37D04
	internal BlockState DeflateSlow(FlushType flush) { }

	// RVA: 0x2E37848 Offset: 0x2E33848 VA: 0x2E37848
	internal int longest_match(int cur_match) { }

	// RVA: 0x2E38288 Offset: 0x2E34288 VA: 0x2E38288
	internal bool get_WantRfc1950HeaderBytes() { }

	// RVA: 0x2E38290 Offset: 0x2E34290 VA: 0x2E38290
	internal void set_WantRfc1950HeaderBytes(bool value) { }

	// RVA: 0x2E3829C Offset: 0x2E3429C VA: 0x2E3829C
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int bits, CompressionStrategy compressionStrategy) { }

	// RVA: 0x2E38334 Offset: 0x2E34334 VA: 0x2E38334
	internal int Initialize(ZlibCodec codec, CompressionLevel level, int windowBits, int memLevel, CompressionStrategy strategy) { }

	// RVA: 0x2E38674 Offset: 0x2E34674 VA: 0x2E38674
	internal void Reset() { }

	// RVA: 0x2E34E2C Offset: 0x2E30E2C VA: 0x2E34E2C
	private void SetDeflater() { }

	// RVA: 0x2E38B9C Offset: 0x2E34B9C VA: 0x2E38B9C
	internal int Deflate(FlushType flush) { }

	// RVA: 0x2E3935C Offset: 0x2E3535C VA: 0x2E3935C
	private static void .cctor() { }
}
