"""Filter dis2.py output down to lines that carry meaning for a damage formula.

usage: python sem.py <file> [method-substring ...]
"""
import re, sys

KEEP = re.compile(
    r"; (?!Method\$System\.Collections|Method\$Singleton|Method\$MobWaveAI|'asbPush)"   # annotated (calls, fields, consts)
    r"|\b(fadd|fsub|fmul|fdiv|fmadd|fmsub|fnmul|scvtf|ucvtf|fcvtzs|fcvtms|frint\w*|fcsel|fmax|fmin|fmaxnm|fminnm|fcmp|fmov|"
    r"mul|madd|msub|sdiv|udiv|neg|csel|csinc|csinv|cset|cinc|lsl|asr|lsr)\b"
    r"|\b(cmp|cmn|tst)\b.*#"
    r"|\bb\.\w+|\b(tbz|tbnz)\b|^====|args:"
    r"|\bmov +w\d+, #|\badd +w\d+, w\d+, #|\bsub +w\d+, w\d+, #"
)
DROP = re.compile(r"0x165d|0x15d8|_TypeInfo$|ldrb +w8, \[x2\d, #0x[0-9a-f]+\] *$|strb +w8, \[x2\d|AddWithResize|List<SkillActionBase\.DamageData>|"
                  r"mov +w8, #1 *$|Method\$System\.Collections")


RAWDROP = re.compile(r"stp +x\d+, x\d+, \[sp|ldp +x(19|2\d|30), x\d+, \[sp|ldr +x30, \[sp|str +x30, \[sp|stp +d\d|ldp +d\d|ldur +x11, \[x10|cmp +x11, x1$|subs +x9, x9, #1|add +x10, x10, #(8|0x10)")


def main():
    raw = sys.argv[1] == "-r"
    args = sys.argv[2:] if raw else sys.argv[1:]
    path, subs = args[0], args[1:]
    on = not subs
    for line in open(path, encoding="utf-8"):
        if line.startswith("===="):
            on = not subs or any(s in line for s in subs)
        if on and (raw or KEEP.search(line)) and not DROP.search(line) and not (raw and RAWDROP.search(line)):
            print(line.rstrip()[:125])


main()
