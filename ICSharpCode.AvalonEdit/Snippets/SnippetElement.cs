﻿// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <owner name="Daniel Grunwald"/>
//     <version>$Revision$</version>
// </file>

using System;
using System.Collections.Generic;
using ICSharpCode.AvalonEdit.Editing;
using ICSharpCode.AvalonEdit.Utils;

namespace ICSharpCode.AvalonEdit.Snippets
{
	/// <summary>
	/// An element inside a snippet.
	/// </summary>
	[Serializable]
	public abstract class SnippetElement
	{
		/// <summary>
		/// Performs insertion of the snippet.
		/// </summary>
		public abstract void Insert(InsertionContext context);
	}
}
