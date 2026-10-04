#!/bin/bash
# Skill-data pipeline (PROJECT.md order). Everything runs from this directory; heavy work files live in $TORAM_WORK (default D:\toram_re).
#   bash pipeline.sh              decode every skill (hours) + derived layers
#   bash pipeline.sh --derived    derived layers only (minutes; use after run_skills.py was run for the changed units)
export PYTHONIOENCODING=utf-8 PYTHONHASHSEED=0
SCR="$(cd "$(dirname "$0")" && pwd)"
cd "$SCR"
run() { echo "=== $*" ; "$@" 2>&1 | tail -3; }
if [ "$1" != "--derived" ]; then
  run python build_factory_maps.py
  run python run_skills.py $(cat "${TORAM_WORK:-/d/toram_re}/state/v2_ids.txt")
  run python run_orphan_bufs.py
fi
run python build_reference.py --all
run python render_docs.py
run python finalize_docs.py
run python build_coverage.py
run python render_details.py
run python audit_unresolved.py
run python build_statics.py
run python build_variables.py
run python build_glossary.py
run python render_explained_th.py
run python render_calc_th.py
run python build_engine.py
run python build_calc_spec.py
run python calc_engine.py --selftest
run python calc_engine.py --coverage
run python validate_reference.py
run python build_damage_type.py
run python build_overview.py
(cd "/d/toram reverse data" && run python viewer/toram_viewer.py --selftest)
echo PIPELINE_DONE
