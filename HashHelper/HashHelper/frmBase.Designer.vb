<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBase))
        Me.gboxkWh = New System.Windows.Forms.GroupBox()
        Me.numCost = New System.Windows.Forms.NumericUpDown()
        Me.lblkWhCost = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.numTime = New System.Windows.Forms.NumericUpDown()
        Me.numWatts = New System.Windows.Forms.NumericUpDown()
        Me.btnResetkWh = New System.Windows.Forms.Button()
        Me.btnCalculatekWh = New System.Windows.Forms.Button()
        Me.lblkWh = New System.Windows.Forms.Label()
        Me.txtkWh = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblWatts = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gboxHash = New System.Windows.Forms.GroupBox()
        Me.lboxTypes = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numHash = New System.Windows.Forms.NumericUpDown()
        Me.lboxHash = New System.Windows.Forms.ListBox()
        Me.gboxkWh.SuspendLayout()
        CType(Me.numCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numWatts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.gboxHash.SuspendLayout()
        CType(Me.numHash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gboxkWh
        '
        Me.gboxkWh.Controls.Add(Me.numCost)
        Me.gboxkWh.Controls.Add(Me.lblkWhCost)
        Me.gboxkWh.Controls.Add(Me.Label1)
        Me.gboxkWh.Controls.Add(Me.txtTotalCost)
        Me.gboxkWh.Controls.Add(Me.numTime)
        Me.gboxkWh.Controls.Add(Me.numWatts)
        Me.gboxkWh.Controls.Add(Me.btnResetkWh)
        Me.gboxkWh.Controls.Add(Me.btnCalculatekWh)
        Me.gboxkWh.Controls.Add(Me.lblkWh)
        Me.gboxkWh.Controls.Add(Me.txtkWh)
        Me.gboxkWh.Controls.Add(Me.lblTime)
        Me.gboxkWh.Controls.Add(Me.lblWatts)
        Me.gboxkWh.Location = New System.Drawing.Point(12, 27)
        Me.gboxkWh.Name = "gboxkWh"
        Me.gboxkWh.Size = New System.Drawing.Size(460, 115)
        Me.gboxkWh.TabIndex = 0
        Me.gboxkWh.TabStop = False
        Me.gboxkWh.Text = "kWh"
        '
        'numCost
        '
        Me.numCost.DecimalPlaces = 2
        Me.numCost.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numCost.Location = New System.Drawing.Point(50, 76)
        Me.numCost.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numCost.Name = "numCost"
        Me.numCost.Size = New System.Drawing.Size(120, 20)
        Me.numCost.TabIndex = 2
        '
        'lblkWhCost
        '
        Me.lblkWhCost.AutoSize = True
        Me.lblkWhCost.Location = New System.Drawing.Point(13, 78)
        Me.lblkWhCost.Name = "lblkWhCost"
        Me.lblkWhCost.Size = New System.Drawing.Size(31, 13)
        Me.lblkWhCost.TabIndex = 9
        Me.lblkWhCost.Text = "Cost:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Total Cost ="
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Location = New System.Drawing.Point(241, 52)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(180, 20)
        Me.txtTotalCost.TabIndex = 6
        '
        'numTime
        '
        Me.numTime.Location = New System.Drawing.Point(50, 50)
        Me.numTime.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numTime.Name = "numTime"
        Me.numTime.Size = New System.Drawing.Size(120, 20)
        Me.numTime.TabIndex = 1
        '
        'numWatts
        '
        Me.numWatts.Location = New System.Drawing.Point(50, 27)
        Me.numWatts.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numWatts.Name = "numWatts"
        Me.numWatts.Size = New System.Drawing.Size(120, 20)
        Me.numWatts.TabIndex = 0
        '
        'btnResetkWh
        '
        Me.btnResetkWh.Location = New System.Drawing.Point(331, 86)
        Me.btnResetkWh.Name = "btnResetkWh"
        Me.btnResetkWh.Size = New System.Drawing.Size(90, 23)
        Me.btnResetkWh.TabIndex = 4
        Me.btnResetkWh.Text = "Reset"
        Me.btnResetkWh.UseVisualStyleBackColor = True
        '
        'btnCalculatekWh
        '
        Me.btnCalculatekWh.Location = New System.Drawing.Point(221, 86)
        Me.btnCalculatekWh.Name = "btnCalculatekWh"
        Me.btnCalculatekWh.Size = New System.Drawing.Size(90, 23)
        Me.btnCalculatekWh.TabIndex = 3
        Me.btnCalculatekWh.Text = "Calculate"
        Me.btnCalculatekWh.UseVisualStyleBackColor = True
        '
        'lblkWh
        '
        Me.lblkWh.AutoSize = True
        Me.lblkWh.Location = New System.Drawing.Point(176, 29)
        Me.lblkWh.Name = "lblkWh"
        Me.lblkWh.Size = New System.Drawing.Size(39, 13)
        Me.lblkWh.TabIndex = 5
        Me.lblkWh.Text = "kWh ="
        '
        'txtkWh
        '
        Me.txtkWh.Location = New System.Drawing.Point(221, 26)
        Me.txtkWh.Name = "txtkWh"
        Me.txtkWh.ReadOnly = True
        Me.txtkWh.Size = New System.Drawing.Size(200, 20)
        Me.txtkWh.TabIndex = 5
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(11, 52)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(33, 13)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "Time:"
        '
        'lblWatts
        '
        Me.lblWatts.AutoSize = True
        Me.lblWatts.Location = New System.Drawing.Point(6, 29)
        Me.lblWatts.Name = "lblWatts"
        Me.lblWatts.Size = New System.Drawing.Size(38, 13)
        Me.lblWatts.TabIndex = 2
        Me.lblWatts.Text = "Watts:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As..."
        '
        'gboxHash
        '
        Me.gboxHash.Controls.Add(Me.lboxTypes)
        Me.gboxHash.Controls.Add(Me.Label2)
        Me.gboxHash.Controls.Add(Me.numHash)
        Me.gboxHash.Controls.Add(Me.lboxHash)
        Me.gboxHash.Location = New System.Drawing.Point(12, 148)
        Me.gboxHash.Name = "gboxHash"
        Me.gboxHash.Size = New System.Drawing.Size(250, 165)
        Me.gboxHash.TabIndex = 1
        Me.gboxHash.TabStop = False
        Me.gboxHash.Text = "Hash"
        '
        'lboxTypes
        '
        Me.lboxTypes.FormattingEnabled = True
        Me.lboxTypes.Items.AddRange(New Object() {"H/s", "kH/s", "MH/s", "GH/s", "TH/s", "PH/s", "EH/s"})
        Me.lboxTypes.Location = New System.Drawing.Point(14, 45)
        Me.lboxTypes.Name = "lboxTypes"
        Me.lboxTypes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lboxTypes.Size = New System.Drawing.Size(34, 108)
        Me.lboxTypes.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Hash:"
        '
        'numHash
        '
        Me.numHash.DecimalPlaces = 5
        Me.numHash.Location = New System.Drawing.Point(50, 19)
        Me.numHash.Maximum = New Decimal(New Integer() {-1486618624, 232830643, 0, 0})
        Me.numHash.Name = "numHash"
        Me.numHash.Size = New System.Drawing.Size(120, 20)
        Me.numHash.TabIndex = 0
        '
        'lboxHash
        '
        Me.lboxHash.FormattingEnabled = True
        Me.lboxHash.Location = New System.Drawing.Point(50, 45)
        Me.lboxHash.Name = "lboxHash"
        Me.lboxHash.Size = New System.Drawing.Size(185, 108)
        Me.lboxHash.TabIndex = 2
        '
        'frmBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.gboxHash)
        Me.Controls.Add(Me.gboxkWh)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmBase"
        Me.Text = "HashHelper 1.0"
        Me.gboxkWh.ResumeLayout(False)
        Me.gboxkWh.PerformLayout()
        CType(Me.numCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numWatts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gboxHash.ResumeLayout(False)
        Me.gboxHash.PerformLayout()
        CType(Me.numHash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gboxkWh As GroupBox
    Friend WithEvents btnResetkWh As Button
    Friend WithEvents btnCalculatekWh As Button
    Friend WithEvents lblkWh As Label
    Friend WithEvents txtkWh As TextBox
    Friend WithEvents lblTime As Label
    Friend WithEvents lblWatts As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gboxHash As GroupBox
    Friend WithEvents numTime As NumericUpDown
    Friend WithEvents numWatts As NumericUpDown
    Friend WithEvents numCost As NumericUpDown
    Friend WithEvents lblkWhCost As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents lboxHash As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents numHash As NumericUpDown
    Friend WithEvents lboxTypes As ListBox
End Class
