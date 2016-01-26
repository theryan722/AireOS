#!/bin/sh
echo `(pactl list sinks | grep "Volume: 0:")| awk '{print $3}'`