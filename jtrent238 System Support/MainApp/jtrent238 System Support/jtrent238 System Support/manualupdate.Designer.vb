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

Imports System


'This class was auto-generated by the StronglyTypedResourceBuilder
'class via a tool like ResGen or Visual Studio.
'To add or remove a member, edit your .ResX file then rerun ResGen
'with the /str option, or rebuild your VS project.
'''<summary>
'''  A strongly-typed resource class, for looking up localized strings, etc.
'''</summary>
<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
 Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
 Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
Friend Class manualupdate
    
    Private Shared resourceMan As Global.System.Resources.ResourceManager
    
    Private Shared resourceCulture As Global.System.Globalization.CultureInfo
    
    <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
    Friend Sub New()
        MyBase.New
    End Sub
    
    '''<summary>
    '''  Returns the cached ResourceManager instance used by this class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
        Get
            If Object.ReferenceEquals(resourceMan, Nothing) Then
                Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("jtrent238_System_Support.manualupdate", GetType(manualupdate).Assembly)
                resourceMan = temp
            End If
            Return resourceMan
        End Get
    End Property
    
    '''<summary>
    '''  Overrides the current thread's CurrentUICulture property for all
    '''  resource lookups using this strongly typed resource class.
    '''</summary>
    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
        Get
            Return resourceCulture
        End Get
        Set
            resourceCulture = value
        End Set
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.CodeDom.MemberAttributes similar to Assembly.
    '''</summary>
    Friend Shared ReadOnly Property Cancel_Modifiers() As System.CodeDom.MemberAttributes
        Get
            Dim obj As Object = ResourceManager.GetObject("Cancel.Modifiers", resourceCulture)
            Return CType(obj,System.CodeDom.MemberAttributes)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.Drawing.Bitmap.
    '''</summary>
    Friend Shared ReadOnly Property LogoPictureBox_Image() As System.Drawing.Bitmap
        Get
            Dim obj As Object = ResourceManager.GetObject("LogoPictureBox.Image", resourceCulture)
            Return CType(obj,System.Drawing.Bitmap)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.CodeDom.MemberAttributes similar to Assembly.
    '''</summary>
    Friend Shared ReadOnly Property LogoPictureBox_Modifiers() As System.CodeDom.MemberAttributes
        Get
            Dim obj As Object = ResourceManager.GetObject("LogoPictureBox.Modifiers", resourceCulture)
            Return CType(obj,System.CodeDom.MemberAttributes)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.CodeDom.MemberAttributes similar to Assembly.
    '''</summary>
    Friend Shared ReadOnly Property OK_Modifiers() As System.CodeDom.MemberAttributes
        Get
            Dim obj As Object = ResourceManager.GetObject("OK.Modifiers", resourceCulture)
            Return CType(obj,System.CodeDom.MemberAttributes)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.CodeDom.MemberAttributes similar to Assembly.
    '''</summary>
    Friend Shared ReadOnly Property PasswordLabel_Modifiers() As System.CodeDom.MemberAttributes
        Get
            Dim obj As Object = ResourceManager.GetObject("PasswordLabel.Modifiers", resourceCulture)
            Return CType(obj,System.CodeDom.MemberAttributes)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.CodeDom.MemberAttributes similar to Assembly.
    '''</summary>
    Friend Shared ReadOnly Property PasswordTextBox_Modifiers() As System.CodeDom.MemberAttributes
        Get
            Dim obj As Object = ResourceManager.GetObject("PasswordTextBox.Modifiers", resourceCulture)
            Return CType(obj,System.CodeDom.MemberAttributes)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.CodeDom.MemberAttributes similar to Assembly.
    '''</summary>
    Friend Shared ReadOnly Property UsernameLabel_Modifiers() As System.CodeDom.MemberAttributes
        Get
            Dim obj As Object = ResourceManager.GetObject("UsernameLabel.Modifiers", resourceCulture)
            Return CType(obj,System.CodeDom.MemberAttributes)
        End Get
    End Property
    
    '''<summary>
    '''  Looks up a localized resource of type System.CodeDom.MemberAttributes similar to Assembly.
    '''</summary>
    Friend Shared ReadOnly Property UsernameTextBox_Modifiers() As System.CodeDom.MemberAttributes
        Get
            Dim obj As Object = ResourceManager.GetObject("UsernameTextBox.Modifiers", resourceCulture)
            Return CType(obj,System.CodeDom.MemberAttributes)
        End Get
    End Property
End Class
