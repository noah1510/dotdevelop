
this version is based on:
	*) commit 92973d97d9db919d8cc6d422e9c0599cf9995c47 
	*) tagged monodevelop-8.4.3.12 
	*) dated 2020-01-24 

some package versions:
	Microsoft.CodeAnalysis.*	(left as it was)
	Microsoft.VisualStudio.*	removed (from vs-editor-api)

modifications:

	 added/reverted:
	^^^^^^^^^^^^^^^^^
main/external/vs-editor-api			<new submodule>

main/msbuild/ReferencesVSEditor.Gtk.props
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValueTreeView.cs
main/src/addins/MonoDevelop.PackageManagement/MonoDevelop.PackageManagement.Gui/ManagePackagesCellViewCheckBox.cs
main/src/addins/MonoDevelop.SourceEditor2/VSEditor/TextEditorFactoryService.cs
main/src/core/MonoDevelop.Ide/MonoDevelop.Ide.Editor/ITextEditorFactoryService.cs

	 modified:
	^^^^^^^^^^^
NuGet.config
main/Directory.Build.props
main/Main.sln
main/external/fsharpbinding/MonoDevelop.FSharpBinding/FSharpFormattingPanelWidget.fs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.Tests/ObjectValueTreeViewControllerTests.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/ExceptionCaught/ExceptionCaughtAdornmentManager.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/ExceptionCaught/ExceptionCaughtProvider.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/BreakpointGlyphFactoryProvider.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/BreakpointGlyphMouseProcessor.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/BreakpointGlyphMouseProcessorProvider.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/BreakpointGlyphTag.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/BreakpointGlyphTagger.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/BreakpointGlyphTaggerProvider.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/CurrentStatementGlyphFactoryProvider.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/CurrentStatementGlyphTag.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/CurrentStatementGlyphTagger.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/CurrentStatementGlyphTaggerProvider.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/GlyphCommandType.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/IActiveGlyphDropHandler.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/IInteractiveGlyph.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/ImageSourceGlyphFactory.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/ReturnStatementGlyphFactoryProvider.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/ReturnStatementGlyphTag.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/ReturnStatementGlyphTagger.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/Glyphs/ReturnStatementGlyphTaggerProvider.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.VSTextView/QuickInfo/DebuggerQuickInfoSource.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger.csproj
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/DebugValueWindow.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ExceptionCaughtDialog.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/LocalsPad.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValuePad.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/PinnedWatch.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/WatchPad.cs
main/src/addins/MonoDevelop.DesignerSupport/MonoDevelop.DesignerSupport/PropertyPad.cs
main/src/addins/MonoDevelop.PackageManagement/MonoDevelop.PackageManagement.Gui/ManagePackagesCellView.cs
main/src/addins/MonoDevelop.PackageManagement/MonoDevelop.PackageManagement.Gui/ManagePackagesDialog.UI.cs
main/src/addins/MonoDevelop.PackageManagement/MonoDevelop.PackageManagement.Gui/ManagePackagesDialog.cs
main/src/addins/MonoDevelop.PackageManagement/MonoDevelop.PackageManagement.csproj
main/src/addins/MonoDevelop.SourceEditor2/Mono.TextEditor/Gui/MdTextViewLineCollection.MdTextViewLine.cs
main/src/addins/MonoDevelop.SourceEditor2/Mono.TextEditor/Gui/MonoTextEditor.ITextView.cs
main/src/addins/MonoDevelop.SourceEditor2/MonoDevelop.SourceEditor.csproj
main/src/addins/MonoDevelop.SourceEditor2/MonoDevelop.SourceEditor/DebugValueTooltipProvider.cs
main/src/addins/MonoDevelop.SourceEditor2/MonoDevelop.SourceEditor/PinnedWatchWidget.cs
main/src/addins/MonoDevelop.SourceEditor2/VSEditor/IMdTextView.cs
main/src/addins/MonoDevelop.SourceEditor2/VSEditor/SmartIndentationService.cs
main/src/addins/MonoDevelop.TextEditor/MonoDevelop.TextEditor.Wpf/Undo/UndoHistoryRegistry.cs
main/src/addins/MonoDevelop.TextEditor/MonoDevelop.TextEditor/EditorCommandHandlers.cs
main/src/addins/MonoDevelop.TextEditor/MonoDevelop.TextEditor/TextViewContent.Commands.cs
main/src/addins/MonoDevelop.TextEditor/MonoDevelop.TextEditor/TextViewContent.Toolbox.cs
main/src/addins/VersionControl/MonoDevelop.VersionControl/MonoDevelop.VersionControl.Views/EditorCompareWidgetBase.DiffScrollbar.cs
main/src/addins/VersionControl/MonoDevelop.VersionControl/MonoDevelop.VersionControl.Views/EditorCompareWidgetBase.MiddleArea.cs
main/src/addins/Xml/Formatting/XmlFormattingPolicyPanelWidget.cs
main/src/core/MonoDevelop.Ide/MonoDevelop.Components.Commands/CommandManager.cs
main/src/core/MonoDevelop.Ide/MonoDevelop.Ide.Commands/WindowCommands.cs
main/src/core/MonoDevelop.Ide/MonoDevelop.Ide.Composition/CompositionManager.cs
main/src/core/MonoDevelop.Ide/MonoDevelop.Ide.Composition/PlatformCatalog.cs
main/src/core/MonoDevelop.Ide/MonoDevelop.Ide.Editor/TextEditor.cs
main/src/core/MonoDevelop.Ide/MonoDevelop.Ide.Fonts/FontChooserPanelWidget.cs
main/src/core/MonoDevelop.Ide/MonoDevelop.Ide.Gui.Dialogs/CommonAboutDialog.cs
main/src/core/MonoDevelop.Ide/MonoDevelop.Ide.Gui/ViewCommandHandlers.cs
main/src/core/MonoDevelop.Ide/MonoDevelop.Ide.Updater/AddinsUpdateHandler.cs
main/src/core/MonoDevelop.Ide/MonoDevelop.Ide.csproj
main/src/core/MonoDevelop.Ide/MonoDevelop.Ide/IdeStartup.cs

	 moved/renamed:
	^^^^^^^^^^^^^^^^

	 deleted:		TODO...
	^^^^^^^^^^
main/external/libgit-binary			<submodule>
main/external/libgit2				<submodule>
main/external/libgit2sharp			<submodule>
main/src/addins/VersionControl/MonoDevelop.VersionControl.Git	<directory>

main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/AddNewExpressionObjectValueNode.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/DebuggerObjectValueNode.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/ExpressionEventArgs.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/Gtk/GtkObjectValueTreeView.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/IDebuggerService.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/IEvaluatingGroupObjectValueNode.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/IObjectValueTreeView.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/IStackFrame.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/ISupportChildObjectValueNodeReplacement.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/LoadingObjectValueNode.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/Mac/MacDebuggerObjectCellViewBase.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/Mac/MacDebuggerObjectNameView.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/Mac/MacDebuggerObjectPinView.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/Mac/MacDebuggerObjectTypeView.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/Mac/MacDebuggerObjectValueView.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/Mac/MacDebuggerTextField.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/Mac/MacObjectValueNode.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/Mac/MacObjectValueTreeView.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/Mac/MacObjectValueTreeViewDataSource.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/Mac/MacObjectValueTreeViewDelegate.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/ObjectValueDebuggerService.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/ObjectValueNode.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/ObjectValueNodeEventArgs.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/ObjectValueStackFrame.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/ObjectValueTreeView.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/ObjectValueTreeViewController.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/ObjectValueTreeViewFakes.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/RootObjectValueNode.cs
main/src/addins/MonoDevelop.Debugger/MonoDevelop.Debugger/ObjectValue/ShowMoreValuesObjectValueNode.cs

##############################################################################################

	 how to build:
	^^^^^^^^^^^^^^^

$ git submodule init 
$ git submodule update 

$ ./configure --profile=gnome 

$ make clean 
$ make 

	IF NEEDED, make copies of the following files with fixed filenames:
$ cp ./main/external/fsharpbinding/packages/FSharp.Core/fsharp.core.4.1.0.2.nupkg ./main/external/fsharpbinding/packages/FSharp.Core/FSharp.Core.4.1.0.2.nupkg
$ cp ./main/external/fsharpbinding/packages/System.ValueTuple/system.valuetuple.4.4.0.nupkg ./main/external/fsharpbinding/packages/System.ValueTuple/System.ValueTuple.4.4.0.nupkg
	THEN re-try building ( make clean && make ).

	 how to run:
	^^^^^^^^^^^^^

$ make run 

	or

$ mono ./main/build/bin/MonoDevelop.exe --no-redirect 

	or (with no logging output to console)

$ mono ./main/build/bin/MonoDevelop.exe 

	 known problems:
	^^^^^^^^^^^^^^^^^
*) GIT support has been removed.
*) the QuickFix menu is not working in editor.
*) win10 wsl : the process seems to hang and keep running after closing the app.

