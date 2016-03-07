#!/usr/bin/python

import sys
# 1: CREATE, UPDATE, READ
# 2: File Location
# 3: Text
if len(sys.argv) > 1:
	if sys.argv[1] == "CREATE":
		print "Create"
	elif sys.argv[1] == "UPDATE":
		print "Update"
	elif sys.argv[1] == "READ":
		print "Read"