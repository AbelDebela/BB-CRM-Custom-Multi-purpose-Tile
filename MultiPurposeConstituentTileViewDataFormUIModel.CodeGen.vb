﻿Option Strict On
Option Explicit On
Option Infer On

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by BBUIModelLibrary
'     Version:  4.0.167.0
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
''' <summary>
''' Represents the UI model for the 'Multi Purpose Constituent Tile View Data Form' data form
''' </summary>
<Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModelMetadata(Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View, "bd26be7e-d2b3-4fd3-9679-973452884cf2", "d1ee28d0-6853-4651-9a40-dad4dbebefe4", "Constituent")>
Partial Public Class [MultiPurposeConstituentTileViewDataFormUIModel]
	Inherits Global.Blackbaud.AppFx.UIModeling.Core.DataFormUIModel

#Region "Extensibility methods"

    Partial Private Sub OnCreated()
    End Sub

#End Region

    Private WithEvents _constituentinfo As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of MultiPurposeConstituentTileViewDataFormCONSTITUENTINFOUIModel)
    Private WithEvents _tileheader As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _norecordmessage As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _currentrecordindex As Global.Blackbaud.AppFx.UIModeling.Core.IntegerField
    Private WithEvents _lineone As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _linetwo As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _linethree As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _linefour As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _linefive As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _constituentinfocounttext As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _currentrecordid As Global.Blackbaud.AppFx.UIModeling.Core.GuidField
    Private WithEvents _noconstituentinfo As Global.Blackbaud.AppFx.UIModeling.Core.StringField
    Private WithEvents _headerlink As Global.Blackbaud.AppFx.UIModeling.Core.ShowPageUIAction
    Private WithEvents _linkname As Global.Blackbaud.AppFx.UIModeling.Core.ShowPageUIAction
    Private WithEvents _nextrecord As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
    Private WithEvents _previousrecord As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction

	<System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public Sub New()
        MyBase.New()

        _constituentinfo = New Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of MultiPurposeConstituentTileViewDataFormCONSTITUENTINFOUIModel)
        _tileheader = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _norecordmessage = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _currentrecordindex = New Global.Blackbaud.AppFx.UIModeling.Core.IntegerField
        _lineone = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _linetwo = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _linethree = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _linefour = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _linefive = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _constituentinfocounttext = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _currentrecordid = New Global.Blackbaud.AppFx.UIModeling.Core.GuidField
        _noconstituentinfo = New Global.Blackbaud.AppFx.UIModeling.Core.StringField
        _headerlink = New Global.Blackbaud.AppFx.UIModeling.Core.ShowPageUIAction
        _linkname = New Global.Blackbaud.AppFx.UIModeling.Core.ShowPageUIAction
        _nextrecord = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        _previousrecord = New Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction

        MyBase.Mode = Global.Blackbaud.AppFx.UIModeling.Core.DataFormMode.View
        MyBase.DataFormTemplateId = New System.Guid("bd26be7e-d2b3-4fd3-9679-973452884cf2")
        MyBase.DataFormInstanceId = New System.Guid("d1ee28d0-6853-4651-9a40-dad4dbebefe4")
        MyBase.RecordType = "Constituent"
        MyBase.UserInterfaceUrl = "browser/htmlforms/custom/customconfigurationsetting/MultiPurposeConstituentTileViewDataForm.html"

        '
        '_constituentinfo
        '
        _constituentinfo.Name = "CONSTITUENTINFO"
        _constituentinfo.Caption = "CONSTITUENTINFO"
        _constituentinfo.Visible = False
        _constituentinfo.DBReadOnly = True
        _constituentinfo.AvailableToClient = False
        Me.Fields.Add(_constituentinfo)
        '
        '_tileheader
        '
        _tileheader.Name = "TILEHEADER"
        _tileheader.Caption = "TILEHEADER"
        _tileheader.DBReadOnly = True
        _tileheader.MaxLength = 100
        Me.Fields.Add(_tileheader)
        '
        '_norecordmessage
        '
        _norecordmessage.Name = "NORECORDMESSAGE"
        _norecordmessage.Caption = "NORECORDMESSAGE"
        _norecordmessage.DBReadOnly = True
        _norecordmessage.MaxLength = 100
        Me.Fields.Add(_norecordmessage)
        '
        '_currentrecordindex
        '
        _currentrecordindex.Name = "CURRENTRECORDINDEX"
        _currentrecordindex.Caption = "CURRENTRECORDINDEX"
        _currentrecordindex.Visible = False
        _currentrecordindex.DBReadOnly = True
        _currentrecordindex.AvailableToClient = False
        Me.Fields.Add(_currentrecordindex)
        '
        '_lineone
        '
        _lineone.Name = "LINEONE"
        _lineone.Caption = "Line One"
        _lineone.DBReadOnly = True
        Me.Fields.Add(_lineone)
        '
        '_linetwo
        '
        _linetwo.Name = "LINETWO"
        _linetwo.Caption = "Line Two"
        _linetwo.DBReadOnly = True
        Me.Fields.Add(_linetwo)
        '
        '_linethree
        '
        _linethree.Name = "LINETHREE"
        _linethree.Caption = "Line Three"
        _linethree.DBReadOnly = True
        Me.Fields.Add(_linethree)
        '
        '_linefour
        '
        _linefour.Name = "LINEFOUR"
        _linefour.Caption = "Line Four"
        _linefour.DBReadOnly = True
        Me.Fields.Add(_linefour)
        '
        '_linefive
        '
        _linefive.Name = "LINEFIVE"
        _linefive.Caption = "Line Five"
        _linefive.DBReadOnly = True
        Me.Fields.Add(_linefive)
        '
        '_constituentinfocounttext
        '
        _constituentinfocounttext.Name = "CONSTITUENTINFOCOUNTTEXT"
        _constituentinfocounttext.Caption = "CONSTITUENTINFOCOUNTTEXT"
        _constituentinfocounttext.DBReadOnly = True
        Me.Fields.Add(_constituentinfocounttext)
        '
        '_currentrecordid
        '
        _currentrecordid.Name = "CURRENTRECORDID"
        _currentrecordid.Caption = "CURRENTRECORDID"
        _currentrecordid.Visible = False
        _currentrecordid.DBReadOnly = True
        _currentrecordid.AvailableToClient = False
        Me.Fields.Add(_currentrecordid)
        '
        '_noconstituentinfo
        '
        _noconstituentinfo.Name = "NOCONSTITUENTINFO"
        _noconstituentinfo.Caption = "No records available"
        _noconstituentinfo.Visible = False
        _noconstituentinfo.DBReadOnly = True
        Me.Fields.Add(_noconstituentinfo)
        '
        '_headerlink
        '
        _headerlink.Name = "HEADERLINK"
        _headerlink.Caption = "Constituent Detail"
        _headerlink.PageId = New System.Guid("88159265-2b7e-4c7b-82a2-119d01ecd40f")
        _headerlink.TabId = New System.Guid("886ad8d7-0304-4d75-aa55-b77d50e3bcce")
        _headerlink.ForceReload = False
        _headerlink.ContextIdDefinition = "FORM!CURRENTRECORDID"
        Me.Actions.Add(_headerlink)
        '
        '_linkname
        '
        _linkname.Name = "LINKNAME"
        _linkname.Caption = "Link Name"
        _linkname.PageId = New System.Guid("88159265-2b7e-4c7b-82a2-119d01ecd40f")
        _linkname.ContextIdDefinition = "Fields!CURRENTRECORDID"
        Me.Actions.Add(_linkname)
        '
        '_nextrecord
        '
        _nextrecord.Name = "NEXTRECORD"
        _nextrecord.Caption = ""
        Me.Actions.Add(_nextrecord)
        '
        '_previousrecord
        '
        _previousrecord.Name = "PREVIOUSRECORD"
        _previousrecord.Caption = ""
        Me.Actions.Add(_previousrecord)

		OnCreated()

    End Sub
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [CONSTITUENTINFO]() As Global.Blackbaud.AppFx.UIModeling.Core.CollectionField(Of MultiPurposeConstituentTileViewDataFormCONSTITUENTINFOUIModel)
        Get
            Return _constituentinfo
        End Get
    End Property
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [TILEHEADER]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _tileheader
        End Get
    End Property
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [NORECORDMESSAGE]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _norecordmessage
        End Get
    End Property
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [CURRENTRECORDINDEX]() As Global.Blackbaud.AppFx.UIModeling.Core.IntegerField
        Get
            Return _currentrecordindex
        End Get
    End Property
    
    ''' <summary>
    ''' Line One
    ''' </summary>
    <System.ComponentModel.Description("Line One")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [LINEONE]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _lineone
        End Get
    End Property
    
    ''' <summary>
    ''' Line Two
    ''' </summary>
    <System.ComponentModel.Description("Line Two")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [LINETWO]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _linetwo
        End Get
    End Property
    
    ''' <summary>
    ''' Line Three
    ''' </summary>
    <System.ComponentModel.Description("Line Three")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [LINETHREE]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _linethree
        End Get
    End Property
    
    ''' <summary>
    ''' Line Four
    ''' </summary>
    <System.ComponentModel.Description("Line Four")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [LINEFOUR]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _linefour
        End Get
    End Property
    
    ''' <summary>
    ''' Line Five
    ''' </summary>
    <System.ComponentModel.Description("Line Five")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [LINEFIVE]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _linefive
        End Get
    End Property
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [CONSTITUENTINFOCOUNTTEXT]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _constituentinfocounttext
        End Get
    End Property
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [CURRENTRECORDID]() As Global.Blackbaud.AppFx.UIModeling.Core.GuidField
        Get
            Return _currentrecordid
        End Get
    End Property
    
    ''' <summary>
    ''' No records available
    ''' </summary>
    <System.ComponentModel.Description("No records available")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [NOCONSTITUENTINFO]() As Global.Blackbaud.AppFx.UIModeling.Core.StringField
        Get
            Return _noconstituentinfo
        End Get
    End Property
    
    ''' <summary>
    ''' Constituent Detail
    ''' </summary>
    <System.ComponentModel.Description("Constituent Detail")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [HEADERLINK]() As Global.Blackbaud.AppFx.UIModeling.Core.ShowPageUIAction
        Get
            Return _headerlink
        End Get
    End Property
    
    ''' <summary>
    ''' Link Name
    ''' </summary>
    <System.ComponentModel.Description("Link Name")> _
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [LINKNAME]() As Global.Blackbaud.AppFx.UIModeling.Core.ShowPageUIAction
        Get
            Return _linkname
        End Get
    End Property
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [NEXTRECORD]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _nextrecord
        End Get
    End Property
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("BBUIModelLibrary", "4.0.167.0")> _
    Public ReadOnly Property [PREVIOUSRECORD]() As Global.Blackbaud.AppFx.UIModeling.Core.GenericUIAction
        Get
            Return _previousrecord
        End Get
    End Property
    
End Class