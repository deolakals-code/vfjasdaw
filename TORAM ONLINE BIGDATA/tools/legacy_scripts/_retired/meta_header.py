import struct

M = r"D:\SteamLibrary\steamapps\common\Toram Online\ToramOnline_Data\il2cpp_data\Metadata\global-metadata.dat"
b = open(M, "rb").read()
sanity, ver = struct.unpack_from("<Ii", b, 0)
print(f"sanity={sanity:#x} version={ver} filesize={len(b)}")
NAMES = ["stringLiteral", "stringLiteralData", "string", "events", "properties", "methods",
         "parameterDefaultValues", "fieldDefaultValues", "defaultValueData", "fieldMarshaledSizes",
         "parameters", "fields", "genericParameters", "genericParameterConstraints", "genericContainers",
         "nestedTypes", "interfaces", "vtableMethods", "interfaceOffsets", "typeDefinitions", "images",
         "assemblies", "fieldRefs", "referencedAssemblies", "attributeData", "attributeDataRange",
         "unresolvedVCallParamTypes", "unresolvedVCallParamRanges", "windowsRuntimeTypeNames",
         "windowsRuntimeStrings", "exportedTypeDefinitions"]
first = struct.unpack_from("<I", b, 8)[0]
n = (first - 8) // 8
for i in range(n):
    off, size = struct.unpack_from("<Ii", b, 8 + i * 8)
    name = NAMES[i] if i < len(NAMES) else "?"
    divs = " ".join(f"%{d}={size % d}" for d in (12, 20, 32, 36, 88))
    print(f"{i:>2} {name:<28} off={off:#010x} size={size:>10}  {divs}")
