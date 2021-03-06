﻿using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOHighlighter
{
	[Export(typeof(EditorFormatDefinition))]
	[ClassificationType(ClassificationTypeNames = "Comment.Todo")]
	[Name("Comment.Todo")]
	[BaseDefinition(PredefinedClassificationTypeNames.Comment)]
	[UserVisible(true)]
	[Order(After = PredefinedClassificationTypeNames.Comment)]
	[Order(After = "XML Doc Comment")]
	internal sealed class Format_Comment_Todo
	:
		ClassificationFormatDefinition
	{
		public Format_Comment_Todo()
		{
			DisplayName = "Todo Comment";

			BackgroundCustomizable = false;
			ForegroundColor = Default.Colors.Todo;
			IsBold = true;
		}
	}
}
