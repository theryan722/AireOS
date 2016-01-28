#!/bin/bash

if ! /bin/ip route | grep -q ^default; then
  echo "DISCONNECTED"
  exit 0
fi
if="$(/bin/ip route | 
  awk '$1 == "default" {for (i=2;i<=NF;i++) if ($i == "dev") { i++;print $i; exit}}')"
if [ -z "$if" -o \! -e /sys/class/net/"$if" ]; then
  echo "ERROR"
  exit 1
fi
if /usr/sbin/iw dev "$if" info &>/dev/null; then
  echo "WIRELESS"
else
  echo "WIRED"
fi