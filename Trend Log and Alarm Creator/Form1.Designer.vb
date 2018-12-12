<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.getBUTTON = New System.Windows.Forms.Button()
        Me.dsnTEXTBOX = New System.Windows.Forms.TextBox()
        Me.objCOMBO = New System.Windows.Forms.ComboBox()
        Me.eventRAD = New System.Windows.Forms.RadioButton()
        Me.trendRAD = New System.Windows.Forms.RadioButton()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.devTEXTBOX = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.devTEXT = New System.Windows.Forms.TextBox()
        Me.totalrefLABEL = New System.Windows.Forms.Label()
        Me.clearBUTTON = New System.Windows.Forms.Button()
        Me.hpBUTTON = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.singledevLABEL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalTL = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.createBUTTON = New System.Windows.Forms.Button()
        Me.srcobjVIEW = New System.Windows.Forms.ListView()
        Me.objref = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.objname = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.createdobjLABEL = New System.Windows.Forms.Label()
        Me.oldevtlVIEW = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.newevtlVIEW = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.oldobjLABEL = New System.Windows.Forms.Label()
        Me.newobjLABEL = New System.Windows.Forms.Label()
        Me.lastdevTEXT = New System.Windows.Forms.TextBox()
        Me.rangeCHECK = New System.Windows.Forms.CheckBox()
        Me.lastdevLABEL = New System.Windows.Forms.Label()
        Me.firstdevLABEL = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totobjsLABEL = New System.Windows.Forms.Label()
        Me.txtSamples = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sampleInterval = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkmatchAVInstance = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'getBUTTON
        '
        Me.getBUTTON.Location = New System.Drawing.Point(12, 293)
        Me.getBUTTON.Name = "getBUTTON"
        Me.getBUTTON.Size = New System.Drawing.Size(88, 23)
        Me.getBUTTON.TabIndex = 0
        Me.getBUTTON.Text = "Get Object List"
        Me.getBUTTON.UseVisualStyleBackColor = True
        '
        'dsnTEXTBOX
        '
        Me.dsnTEXTBOX.Location = New System.Drawing.Point(137, 9)
        Me.dsnTEXTBOX.Name = "dsnTEXTBOX"
        Me.dsnTEXTBOX.Size = New System.Drawing.Size(121, 20)
        Me.dsnTEXTBOX.TabIndex = 2
        Me.dsnTEXTBOX.Text = "Delta Network"
        '
        'objCOMBO
        '
        Me.objCOMBO.DisplayMember = "260"
        Me.objCOMBO.FormattingEnabled = True
        Me.objCOMBO.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.objCOMBO.Location = New System.Drawing.Point(137, 142)
        Me.objCOMBO.Name = "objCOMBO"
        Me.objCOMBO.Size = New System.Drawing.Size(121, 21)
        Me.objCOMBO.TabIndex = 3
        Me.objCOMBO.Text = "AO"
        Me.objCOMBO.ValueMember = "260"
        '
        'eventRAD
        '
        Me.eventRAD.AutoSize = True
        Me.eventRAD.Location = New System.Drawing.Point(12, 261)
        Me.eventRAD.Name = "eventRAD"
        Me.eventRAD.Size = New System.Drawing.Size(58, 17)
        Me.eventRAD.TabIndex = 6
        Me.eventRAD.TabStop = True
        Me.eventRAD.Text = "Events"
        Me.eventRAD.UseVisualStyleBackColor = True
        '
        'trendRAD
        '
        Me.trendRAD.AutoSize = True
        Me.trendRAD.Checked = True
        Me.trendRAD.Location = New System.Drawing.Point(12, 238)
        Me.trendRAD.Name = "trendRAD"
        Me.trendRAD.Size = New System.Drawing.Size(79, 17)
        Me.trendRAD.TabIndex = 7
        Me.trendRAD.TabStop = True
        Me.trendRAD.Text = "Trend Logs"
        Me.trendRAD.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(433, 85)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'devTEXTBOX
        '
        Me.devTEXTBOX.Location = New System.Drawing.Point(137, 46)
        Me.devTEXTBOX.Name = "devTEXTBOX"
        Me.devTEXTBOX.Size = New System.Drawing.Size(121, 20)
        Me.devTEXTBOX.TabIndex = 8
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 203)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(354, 27)
        Me.ProgressBar1.TabIndex = 9
        Me.ProgressBar1.Visible = False
        '
        'devTEXT
        '
        Me.devTEXT.Location = New System.Drawing.Point(433, 63)
        Me.devTEXT.Name = "devTEXT"
        Me.devTEXT.Size = New System.Drawing.Size(121, 20)
        Me.devTEXT.TabIndex = 8
        '
        'totalrefLABEL
        '
        Me.totalrefLABEL.AutoSize = True
        Me.totalrefLABEL.Location = New System.Drawing.Point(0, 535)
        Me.totalrefLABEL.Name = "totalrefLABEL"
        Me.totalrefLABEL.Size = New System.Drawing.Size(13, 13)
        Me.totalrefLABEL.TabIndex = 10
        Me.totalrefLABEL.Text = "0"
        '
        'clearBUTTON
        '
        Me.clearBUTTON.Location = New System.Drawing.Point(105, 415)
        Me.clearBUTTON.Name = "clearBUTTON"
        Me.clearBUTTON.Size = New System.Drawing.Size(93, 27)
        Me.clearBUTTON.TabIndex = 11
        Me.clearBUTTON.Text = "Clear Results"
        Me.clearBUTTON.UseVisualStyleBackColor = True
        '
        'hpBUTTON
        '
        Me.hpBUTTON.Location = New System.Drawing.Point(302, 415)
        Me.hpBUTTON.Name = "hpBUTTON"
        Me.hpBUTTON.Size = New System.Drawing.Size(75, 27)
        Me.hpBUTTON.TabIndex = 12
        Me.hpBUTTON.Text = "Help/About"
        Me.hpBUTTON.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(212, 415)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 27)
        Me.closeButton.TabIndex = 13
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Select Object"
        '
        'singledevLABEL
        '
        Me.singledevLABEL.AutoSize = True
        Me.singledevLABEL.Location = New System.Drawing.Point(10, 49)
        Me.singledevLABEL.Name = "singledevLABEL"
        Me.singledevLABEL.Size = New System.Drawing.Size(110, 13)
        Me.singledevLABEL.TabIndex = 15
        Me.singledevLABEL.Text = "Enter Device Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ODBC DSN Reference"
        '
        'totalTL
        '
        Me.totalTL.AutoSize = True
        Me.totalTL.Location = New System.Drawing.Point(1249, 415)
        Me.totalTL.Name = "totalTL"
        Me.totalTL.Size = New System.Drawing.Size(13, 13)
        Me.totalTL.TabIndex = 18
        Me.totalTL.Text = "0"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(3, 494)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(761, 20)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.Visible = False
        '
        'createBUTTON
        '
        Me.createBUTTON.Enabled = False
        Me.createBUTTON.Location = New System.Drawing.Point(3, 415)
        Me.createBUTTON.Name = "createBUTTON"
        Me.createBUTTON.Size = New System.Drawing.Size(88, 27)
        Me.createBUTTON.TabIndex = 24
        Me.createBUTTON.Text = "Create Objects"
        Me.createBUTTON.UseVisualStyleBackColor = True
        '
        'srcobjVIEW
        '
        Me.srcobjVIEW.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.objref, Me.objname, Me.ColumnHeader5, Me.ColumnHeader8})
        Me.srcobjVIEW.FullRowSelect = True
        Me.srcobjVIEW.Location = New System.Drawing.Point(383, 29)
        Me.srcobjVIEW.Name = "srcobjVIEW"
        Me.srcobjVIEW.Size = New System.Drawing.Size(398, 413)
        Me.srcobjVIEW.TabIndex = 25
        Me.srcobjVIEW.UseCompatibleStateImageBehavior = False
        Me.srcobjVIEW.View = System.Windows.Forms.View.Details
        '
        'objref
        '
        Me.objref.Text = "Object Ref"
        Me.objref.Width = 120
        '
        'objname
        '
        Me.objname.Text = "Name"
        Me.objname.Width = 151
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Value"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "DEV_ID"
        Me.ColumnHeader8.Width = 0
        '
        'createdobjLABEL
        '
        Me.createdobjLABEL.AutoSize = True
        Me.createdobjLABEL.Location = New System.Drawing.Point(12, 217)
        Me.createdobjLABEL.Name = "createdobjLABEL"
        Me.createdobjLABEL.Size = New System.Drawing.Size(0, 13)
        Me.createdobjLABEL.TabIndex = 26
        '
        'oldevtlVIEW
        '
        Me.oldevtlVIEW.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader3, Me.ColumnHeader6, Me.ColumnHeader10})
        Me.oldevtlVIEW.Location = New System.Drawing.Point(787, 29)
        Me.oldevtlVIEW.Name = "oldevtlVIEW"
        Me.oldevtlVIEW.Size = New System.Drawing.Size(428, 413)
        Me.oldevtlVIEW.TabIndex = 28
        Me.oldevtlVIEW.UseCompatibleStateImageBehavior = False
        Me.oldevtlVIEW.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Object Ref"
        Me.ColumnHeader1.Width = 99
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Name"
        Me.ColumnHeader3.Width = 188
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Input Ref"
        Me.ColumnHeader6.Width = 162
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Dev_ID"
        Me.ColumnHeader10.Width = 1
        '
        'newevtlVIEW
        '
        Me.newevtlVIEW.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader7, Me.ColumnHeader9})
        Me.newevtlVIEW.FullRowSelect = True
        Me.newevtlVIEW.Location = New System.Drawing.Point(787, 29)
        Me.newevtlVIEW.Name = "newevtlVIEW"
        Me.newevtlVIEW.Size = New System.Drawing.Size(428, 413)
        Me.newevtlVIEW.TabIndex = 29
        Me.newevtlVIEW.UseCompatibleStateImageBehavior = False
        Me.newevtlVIEW.View = System.Windows.Forms.View.Details
        Me.newevtlVIEW.Visible = False
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Object Ref"
        Me.ColumnHeader2.Width = 99
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Name"
        Me.ColumnHeader4.Width = 188
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Input Ref"
        Me.ColumnHeader7.Width = 213
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Dev_ID"
        Me.ColumnHeader9.Width = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(380, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Select the Desired Objects"
        '
        'oldobjLABEL
        '
        Me.oldobjLABEL.AutoSize = True
        Me.oldobjLABEL.Location = New System.Drawing.Point(784, 9)
        Me.oldobjLABEL.Name = "oldobjLABEL"
        Me.oldobjLABEL.Size = New System.Drawing.Size(230, 13)
        Me.oldobjLABEL.TabIndex = 31
        Me.oldobjLABEL.Text = "Existing TL/EV Objects for selected object type"
        '
        'newobjLABEL
        '
        Me.newobjLABEL.Location = New System.Drawing.Point(784, 9)
        Me.newobjLABEL.Name = "newobjLABEL"
        Me.newobjLABEL.Size = New System.Drawing.Size(230, 13)
        Me.newobjLABEL.TabIndex = 32
        Me.newobjLABEL.Text = "Current TL/EV Objects"
        Me.newobjLABEL.Visible = False
        '
        'lastdevTEXT
        '
        Me.lastdevTEXT.Location = New System.Drawing.Point(137, 87)
        Me.lastdevTEXT.Name = "lastdevTEXT"
        Me.lastdevTEXT.Size = New System.Drawing.Size(121, 20)
        Me.lastdevTEXT.TabIndex = 34
        Me.lastdevTEXT.Visible = False
        '
        'rangeCHECK
        '
        Me.rangeCHECK.AutoSize = True
        Me.rangeCHECK.Location = New System.Drawing.Point(264, 49)
        Me.rangeCHECK.Name = "rangeCHECK"
        Me.rangeCHECK.Size = New System.Drawing.Size(95, 17)
        Me.rangeCHECK.TabIndex = 35
        Me.rangeCHECK.Text = "Device Range"
        Me.rangeCHECK.UseVisualStyleBackColor = True
        '
        'lastdevLABEL
        '
        Me.lastdevLABEL.AutoSize = True
        Me.lastdevLABEL.Location = New System.Drawing.Point(9, 87)
        Me.lastdevLABEL.Name = "lastdevLABEL"
        Me.lastdevLABEL.Size = New System.Drawing.Size(105, 13)
        Me.lastdevLABEL.TabIndex = 36
        Me.lastdevLABEL.Text = "Last Device Address"
        Me.lastdevLABEL.Visible = False
        '
        'firstdevLABEL
        '
        Me.firstdevLABEL.AutoSize = True
        Me.firstdevLABEL.Location = New System.Drawing.Point(9, 49)
        Me.firstdevLABEL.Name = "firstdevLABEL"
        Me.firstdevLABEL.Size = New System.Drawing.Size(104, 13)
        Me.firstdevLABEL.TabIndex = 37
        Me.firstdevLABEL.Text = "First Device Address"
        Me.firstdevLABEL.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(946, 564)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1059, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Total Number of Objects = "
        '
        'totobjsLABEL
        '
        Me.totobjsLABEL.AutoSize = True
        Me.totobjsLABEL.Location = New System.Drawing.Point(1199, 9)
        Me.totobjsLABEL.Name = "totobjsLABEL"
        Me.totobjsLABEL.Size = New System.Drawing.Size(13, 13)
        Me.totobjsLABEL.TabIndex = 39
        Me.totobjsLABEL.Text = "0"
        '
        'txtSamples
        '
        Me.txtSamples.Location = New System.Drawing.Point(137, 116)
        Me.txtSamples.Name = "txtSamples"
        Me.txtSamples.Size = New System.Drawing.Size(121, 20)
        Me.txtSamples.TabIndex = 34
        Me.txtSamples.Text = "2688"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "TLSamples"
        Me.Label6.Visible = False
        '
        'sampleInterval
        '
        Me.sampleInterval.Location = New System.Drawing.Point(137, 169)
        Me.sampleInterval.Name = "sampleInterval"
        Me.sampleInterval.Size = New System.Drawing.Size(121, 20)
        Me.sampleInterval.TabIndex = 34
        Me.sampleInterval.Text = "90000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Interval"
        Me.Label7.Visible = False
        '
        'chkmatchAVInstance
        '
        Me.chkmatchAVInstance.AutoSize = True
        Me.chkmatchAVInstance.Location = New System.Drawing.Point(264, 12)
        Me.chkmatchAVInstance.Name = "chkmatchAVInstance"
        Me.chkmatchAVInstance.Size = New System.Drawing.Size(117, 17)
        Me.chkmatchAVInstance.TabIndex = 41
        Me.chkmatchAVInstance.Text = "Match AV Instance"
        Me.chkmatchAVInstance.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 445)
        Me.Controls.Add(Me.chkmatchAVInstance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.totobjsLABEL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.firstdevLABEL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lastdevLABEL)
        Me.Controls.Add(Me.rangeCHECK)
        Me.Controls.Add(Me.sampleInterval)
        Me.Controls.Add(Me.txtSamples)
        Me.Controls.Add(Me.lastdevTEXT)
        Me.Controls.Add(Me.newobjLABEL)
        Me.Controls.Add(Me.oldobjLABEL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.newevtlVIEW)
        Me.Controls.Add(Me.oldevtlVIEW)
        Me.Controls.Add(Me.createdobjLABEL)
        Me.Controls.Add(Me.srcobjVIEW)
        Me.Controls.Add(Me.createBUTTON)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.totalTL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.singledevLABEL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.hpBUTTON)
        Me.Controls.Add(Me.clearBUTTON)
        Me.Controls.Add(Me.totalrefLABEL)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.devTEXTBOX)
        Me.Controls.Add(Me.trendRAD)
        Me.Controls.Add(Me.eventRAD)
        Me.Controls.Add(Me.objCOMBO)
        Me.Controls.Add(Me.dsnTEXTBOX)
        Me.Controls.Add(Me.getBUTTON)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Event and Trend Creation Utility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents getBUTTON As System.Windows.Forms.Button
    Friend WithEvents dsnTEXTBOX As System.Windows.Forms.TextBox
    Friend WithEvents objCOMBO As System.Windows.Forms.ComboBox
    Friend WithEvents eventRAD As System.Windows.Forms.RadioButton
    Friend WithEvents trendRAD As System.Windows.Forms.RadioButton
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents devTEXTBOX As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents devTEXT As System.Windows.Forms.TextBox
    Friend WithEvents totalrefLABEL As System.Windows.Forms.Label
    Friend WithEvents clearBUTTON As System.Windows.Forms.Button
    Friend WithEvents hpBUTTON As System.Windows.Forms.Button
    Friend WithEvents closeButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents singledevLABEL As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents totalTL As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents createBUTTON As System.Windows.Forms.Button
    Friend WithEvents srcobjVIEW As System.Windows.Forms.ListView
    Friend WithEvents objref As System.Windows.Forms.ColumnHeader
    Friend WithEvents objname As System.Windows.Forms.ColumnHeader
    Friend WithEvents createdobjLABEL As System.Windows.Forms.Label
    Friend WithEvents oldevtlVIEW As System.Windows.Forms.ListView
    Friend WithEvents newevtlVIEW As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents oldobjLABEL As System.Windows.Forms.Label
    Friend WithEvents newobjLABEL As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lastdevTEXT As System.Windows.Forms.TextBox
    Friend WithEvents rangeCHECK As System.Windows.Forms.CheckBox
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lastdevLABEL As System.Windows.Forms.Label
    Friend WithEvents firstdevLABEL As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents totobjsLABEL As System.Windows.Forms.Label
    Friend WithEvents txtSamples As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents sampleInterval As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkmatchAVInstance As System.Windows.Forms.CheckBox

End Class
