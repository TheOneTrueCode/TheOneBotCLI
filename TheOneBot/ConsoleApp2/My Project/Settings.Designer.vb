﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("/")>  _
        Public Property wake() As String
            Get
                Return CType(Me("wake"),String)
            End Get
            Set
                Me("wake") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property saveT() As Boolean
            Get
                Return CType(Me("saveT"),Boolean)
            End Get
            Set
                Me("saveT") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property saved() As String
            Get
                Return CType(Me("saved"),String)
            End Get
            Set
                Me("saved") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("These are the default values and have not been changed"&Global.Microsoft.VisualBasic.ChrW(10)&"```css"&Global.Microsoft.VisualBasic.ChrW(10)&"help • • • • • • • "& _ 
            "• • • • • • • • Opens a list of commands"&Global.Microsoft.VisualBasic.ChrW(10)&"ping <discord.com> • • • • • • • • Ping"& _ 
            "s a server and returns the delay in miliseconds (defaults to discord.com)"&Global.Microsoft.VisualBasic.ChrW(10)&"logout"& _ 
            " • • • • • • • • • • • • • • Signs the bot out of discord"&Global.Microsoft.VisualBasic.ChrW(10)&"```")>  _
        Public Property help() As String
            Get
                Return CType(Me("help"),String)
            End Get
            Set
                Me("help") = value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("0")>
        Public Property nWords() As Long
            Get
                Return CType(Me("nWords"), Long)
            End Get
            Set
                Me("nWords") = Value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("False")>
        Public Property debug() As Boolean
            Get
                Return CType(Me("debug"), Boolean)
            End Get
            Set
                Me("debug") = Value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("")>
        Public Property customCommands() As String
            Get
                Return CType(Me("customCommands"), String)
            End Get
            Set
                Me("customCommands") = Value
            End Set
        End Property

        <Global.System.Configuration.UserScopedSettingAttribute(),
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
         Global.System.Configuration.DefaultSettingValueAttribute("False")>
        Public Property initialSetup() As Boolean
            Get
                Return CType(Me("initialSetup"), Boolean)
            End Get
            Set
                Me("initialSetup") = Value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.TheOneBotCLI.My.MySettings
            Get
                Return Global.TheOneBotCLI.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
