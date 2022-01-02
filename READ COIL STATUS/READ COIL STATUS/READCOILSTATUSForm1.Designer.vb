<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class READCOILSTATUSForm1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(READCOILSTATUSForm1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReadCoilStatus = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.txtReceiMsg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSendMSg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReadCoilStatus)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtResult)
        Me.GroupBox1.Controls.Add(Me.txtReceiMsg)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSendMSg)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(766, 339)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FUNCTION COIL STATUS"
        '
        'btnReadCoilStatus
        '
        Me.btnReadCoilStatus.Location = New System.Drawing.Point(146, 282)
        Me.btnReadCoilStatus.Name = "btnReadCoilStatus"
        Me.btnReadCoilStatus.Size = New System.Drawing.Size(266, 39)
        Me.btnReadCoilStatus.TabIndex = 0
        Me.btnReadCoilStatus.Text = "Read Coil Status"
        Me.btnReadCoilStatus.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Result:"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(138, 158)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(584, 105)
        Me.txtResult.TabIndex = 3
        '
        'txtReceiMsg
        '
        Me.txtReceiMsg.Location = New System.Drawing.Point(138, 91)
        Me.txtReceiMsg.Name = "txtReceiMsg"
        Me.txtReceiMsg.Size = New System.Drawing.Size(584, 22)
        Me.txtReceiMsg.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ReceiMsg:"
        '
        'txtSendMSg
        '
        Me.txtSendMSg.Location = New System.Drawing.Point(138, 36)
        Me.txtSendMSg.Name = "txtSendMSg"
        Me.txtSendMSg.Size = New System.Drawing.Size(584, 22)
        Me.txtSendMSg.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SendMsg:"
        '
        'READCOILSTATUSForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(882, 753)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "READCOILSTATUSForm1"
        Me.Text = "READ COIL STATUS / KELOMPOK 6"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtReceiMsg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSendMSg As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReadCoilStatus As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResult As TextBox
End Class
