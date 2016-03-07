#!/usr/bin/python
import sys
import mmap
# 1: UPDATE, READ
# 2: File Location
# 3: Text
if len(sys.argv) > 1:
	if sys.argv[1] == "UPDATE":
		with open(sys.argv[2], "r+b") as f:
			f.write(sys.argv[3])
	elif sys.argv[1] == "READ":
		with open(sys.argv[2], "r+b") as f:
			mm = mmap.mmap(f.fileno(), 0)
			print mm.readline()
			mm.seek(0)
			mm.close()