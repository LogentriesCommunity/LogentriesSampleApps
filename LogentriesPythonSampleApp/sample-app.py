#!/usr/bin/env python

from logentries import LogentriesHandler
import logging

log = logging.getLogger('logentries')
log.setLevel(logging.INFO)
# Set my Logentries Token
test = LogentriesHandler("LOGENTRIES-TOKEN")

log.addHandler(test)
# Log away!
log.warn("Warning message")
log.info("Info message")
