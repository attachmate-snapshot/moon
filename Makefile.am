ACLOCAL_AMFLAGS = -I m4

MONO_SUBDIRS=
PERF_SUBDIR=
PLUGIN_SUBDIR=

if INCLUDE_MANAGED_CODE
BUILD_TOOLS = tools/respack
MONO_SUBDIRS += class
if INCLUDE_PERFORMANCE
#PERF_SUBDIR += perf
endif INCLUDE_PERFORMANCE
endif

#if !PLUGIN_INSTALL
if INCLUDE_DESKTOP_MANAGED_CODE
MONO_SUBDIRS += man data
if GTK_PAL
MONO_SUBDIRS += gtk
endif
if INCLUDE_EXAMPLES
MONO_EXAMPLES = examples
endif
endif

if INCLUDE_TESTING
TEST_SUBDIR = test
endif INCLUDE_TESTING

TOOLS_SUBDIR = tools
#endif !PLUGIN_INSTALL

if HAVE_MOZILLA
PLUGIN_SUBDIR += plugin
endif

if BUILD_MONO
MONO_RUNTIME = runtime
endif

if BUILD_GALLIUM
GALLIUM_SUBDIR = gallium
endif

SUBDIRS = \
	. \
	$(MONO_RUNTIME) \
	$(GALLIUM_SUBDIR) \
	generators \
	$(subdirs) \
	m4 \
	$(BUILD_TOOLS) \
	src \
	$(MONO_SUBDIRS) \
	$(PLUGIN_SUBDIR) \
	$(TOOLS_SUBDIR) \
	$(TEST_SUBDIR) \
	$(PERF_SUBDIR) \
	$(MONO_EXAMPLES) \
	scripts \
	sdk

# until we start providing devel packages that install the headers, there's no need to install this .pc
#pkgconfigdir = $(libdir)/pkgconfig
#pkgconfig_DATA=moon.pc

EXTRA_DIST=moon.pc.in LICENSE

# this should be handled by dolt.m4
DISTCLEANFILES=	doltcompile \
		doltlibtool

# custom install rule
test-plugin:
	$(MAKE) $(AM_MAKEFLAGS) -C plugin test-plugin

run-tests:
	$(MAKE) $(AM_MAKEFLAGS) -C test run-tests

run-ms-tests:
	$(MAKE) $(AM_MAKEFLAGS) -C test run-ms-tests

run-perf: 
	$(MAKE) $(AM_MAKEFLAGS) -C perf run-perf

user-plugin: 
if PLUGIN_INSTALL
	$(MAKE) $(AM_MAKEFLAGS) -C plugin user-plugin
else
	@echo "Error: You must configure with Firefox 2 or 3 support"; exit 1
endif

NEEDED_MONO_VERSION:=$(shell grep 'cd mono .*hard' $(PWD)/README | awk -F' ' '{print $$7}')
NEEDED_MONO_BASIC_VERSION:=$(shell grep 'cd mono-basic .*hard' $(PWD)/README | awk -F' ' '{print $$7}')
NEEDED_MESA_VERSION:=$(shell grep 'cd mesa.*reset' $(PWD)/README | awk -F' ' '{print $$7}')
MONO_VERSION=$(shell cd $(MONO_PATH) && git log | head -1 | awk '{print $2}' )

reset-mono:
	cd $(MONO_PATH) && git fetch && git reset --hard $(NEEDED_MONO_VERSION)

reset-mono-basic:
	cd $(MONO_BASIC_PATH) && git fetch && git reset --hard $(NEEDED_MONO_BASIC_VERSION)

reset-mesa:
	cd $(GALLIUM_PATH) && git fetch && git reset --hard $(NEEDED_MESA_VERSION)

check-mono:
	@(if test `awk "BEGIN { print index (\\"$(MONO_VERSION)\\",\\"$(NEEDED_MONO_VERSION)\\") }"` = "0"; then \
	   echo "Your mono version is out of date, please run 'make reset-mono'"; \
	   if test x$(IGNORE_MONO_VERSION) = "x"; then \
	   	exit 1; \
	   fi; \
	 else \
	   echo "Your mono version is up to date"; \
	 fi)
	
all-local: check-mono

dist-hook:
	mkdir $(distdir)/icons
	cp -p $(srcdir)/icons/icon32.png $(srcdir)/icons/icon48.png $(srcdir)/icons/icon128.png $(distdir)/icons

install-test-plugin:
	$(MAKE) -C plugin $@
	$(MAKE) -C test/harness/shocker $@

try:
	tools/try-commit.sh --websiteurl=http://moon.sublimeintervention.com/ --lane=try-trunk --action=None
