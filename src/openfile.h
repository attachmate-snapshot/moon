/*
 * runtime.h: Core surface and canvas definitions.
 *
 * Author:
 *   Miguel de Icaza (miguel@novell.com)
 *
 * Copyright 2007 Novell, Inc. (http://www.novell.com)
 *
 * See the LICENSE file included with the distribution for details.
 * 
 */

#ifndef __OPENFILE_H__
#define __OPENFILE_H__

G_BEGIN_DECLS

char * open_file_dialog_show              (const char *title, bool multsel, const char *filter, int idx);

G_END_DECLS

#endif
