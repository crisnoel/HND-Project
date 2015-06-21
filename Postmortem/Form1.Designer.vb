<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHashDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHashDatabase))
        Me.txtboxFileLocation = New System.Windows.Forms.TextBox()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnCSearch = New System.Windows.Forms.Button()
        Me.btnHSearch = New System.Windows.Forms.Button()
        Me.txtboxCSearch = New System.Windows.Forms.TextBox()
        Me.lblSeachCase = New System.Windows.Forms.Label()
        Me.lblSearchash = New System.Windows.Forms.Label()
        Me.txtboxHSearch = New System.Windows.Forms.TextBox()
        Me.btnDeleteRecord = New System.Windows.Forms.Button()
        Me.btnNextRecord = New System.Windows.Forms.Button()
        Me.btnPreviousRecord = New System.Windows.Forms.Button()
        Me.btnFirstRecord = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtboxVerified = New System.Windows.Forms.TextBox()
        Me.txtboxHValue = New System.Windows.Forms.TextBox()
        Me.txtboxHVValue = New System.Windows.Forms.TextBox()
        Me.txtboxSerial = New System.Windows.Forms.TextBox()
        Me.txtboxHAlgo = New System.Windows.Forms.TextBox()
        Me.txtboxChain = New System.Windows.Forms.TextBox()
        Me.txtboxDate = New System.Windows.Forms.TextBox()
        Me.txtboxEvidenceID = New System.Windows.Forms.TextBox()
        Me.txtboxCaseNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtboxDatabaseLocation = New System.Windows.Forms.TextBox()
        Me.lblDatabase = New System.Windows.Forms.Label()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnDBReset = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ListBoxEvent = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btnVerifyHashValues = New System.Windows.Forms.Button()
        Me.btnExportInput = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtboxExportSerial = New System.Windows.Forms.TextBox()
        Me.txtboxExportChain = New System.Windows.Forms.TextBox()
        Me.txtboxExportCase = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtboxHashVerified = New System.Windows.Forms.TextBox()
        Me.txtboxHashValue = New System.Windows.Forms.TextBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnVerifyHash = New System.Windows.Forms.Button()
        Me.btnHash = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rdoSHA384 = New System.Windows.Forms.RadioButton()
        Me.rdoSHA256 = New System.Windows.Forms.RadioButton()
        Me.rdoSHA = New System.Windows.Forms.RadioButton()
        Me.rdoMD5 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFLoad = New System.Windows.Forms.Button()
        Me.lblFileLocation = New System.Windows.Forms.Label()
        Me.bkwShad256 = New System.ComponentModel.BackgroundWorker()
        Me.bkwMD5 = New System.ComponentModel.BackgroundWorker()
        Me.BKWMD5V = New System.ComponentModel.BackgroundWorker()
        Me.BKWSHA256V = New System.ComponentModel.BackgroundWorker()
        Me.bkw384 = New System.ComponentModel.BackgroundWorker()
        Me.bwk384V = New System.ComponentModel.BackgroundWorker()
        Me.bkwSHA = New System.ComponentModel.BackgroundWorker()
        Me.bkwSHAV = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtboxFileLocation
        '
        Me.txtboxFileLocation.Location = New System.Drawing.Point(65, 39)
        Me.txtboxFileLocation.Name = "txtboxFileLocation"
        Me.txtboxFileLocation.Size = New System.Drawing.Size(474, 20)
        Me.txtboxFileLocation.TabIndex = 0
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(197, 65)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(133, 31)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Browse"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(224, 569)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Postmortem V1.6.0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 550)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hash Database and Database Tools"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnCSearch)
        Me.GroupBox7.Controls.Add(Me.btnHSearch)
        Me.GroupBox7.Controls.Add(Me.txtboxCSearch)
        Me.GroupBox7.Controls.Add(Me.lblSeachCase)
        Me.GroupBox7.Controls.Add(Me.lblSearchash)
        Me.GroupBox7.Controls.Add(Me.txtboxHSearch)
        Me.GroupBox7.Controls.Add(Me.btnDeleteRecord)
        Me.GroupBox7.Controls.Add(Me.btnNextRecord)
        Me.GroupBox7.Controls.Add(Me.btnPreviousRecord)
        Me.GroupBox7.Controls.Add(Me.btnFirstRecord)
        Me.GroupBox7.Controls.Add(Me.Label15)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.Label13)
        Me.GroupBox7.Controls.Add(Me.Label12)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Controls.Add(Me.Label10)
        Me.GroupBox7.Controls.Add(Me.Label9)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.txtboxVerified)
        Me.GroupBox7.Controls.Add(Me.txtboxHValue)
        Me.GroupBox7.Controls.Add(Me.txtboxHVValue)
        Me.GroupBox7.Controls.Add(Me.txtboxSerial)
        Me.GroupBox7.Controls.Add(Me.txtboxHAlgo)
        Me.GroupBox7.Controls.Add(Me.txtboxChain)
        Me.GroupBox7.Controls.Add(Me.txtboxDate)
        Me.GroupBox7.Controls.Add(Me.txtboxEvidenceID)
        Me.GroupBox7.Controls.Add(Me.txtboxCaseNumber)
        Me.GroupBox7.Location = New System.Drawing.Point(10, 98)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(562, 446)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Database Evidence Viewer"
        '
        'btnCSearch
        '
        Me.btnCSearch.Location = New System.Drawing.Point(445, 50)
        Me.btnCSearch.Name = "btnCSearch"
        Me.btnCSearch.Size = New System.Drawing.Size(75, 26)
        Me.btnCSearch.TabIndex = 28
        Me.btnCSearch.Text = "Search"
        Me.btnCSearch.UseVisualStyleBackColor = True
        '
        'btnHSearch
        '
        Me.btnHSearch.Location = New System.Drawing.Point(445, 18)
        Me.btnHSearch.Name = "btnHSearch"
        Me.btnHSearch.Size = New System.Drawing.Size(75, 26)
        Me.btnHSearch.TabIndex = 8
        Me.btnHSearch.Text = "Search"
        Me.btnHSearch.UseVisualStyleBackColor = True
        '
        'txtboxCSearch
        '
        Me.txtboxCSearch.Location = New System.Drawing.Point(147, 54)
        Me.txtboxCSearch.Name = "txtboxCSearch"
        Me.txtboxCSearch.Size = New System.Drawing.Size(267, 20)
        Me.txtboxCSearch.TabIndex = 27
        '
        'lblSeachCase
        '
        Me.lblSeachCase.AutoSize = True
        Me.lblSeachCase.Location = New System.Drawing.Point(13, 57)
        Me.lblSeachCase.Name = "lblSeachCase"
        Me.lblSeachCase.Size = New System.Drawing.Size(111, 13)
        Me.lblSeachCase.TabIndex = 26
        Me.lblSeachCase.Text = "Search Case Number:"
        '
        'lblSearchash
        '
        Me.lblSearchash.AutoSize = True
        Me.lblSearchash.Location = New System.Drawing.Point(52, 25)
        Me.lblSearchash.Name = "lblSearchash"
        Me.lblSearchash.Size = New System.Drawing.Size(72, 13)
        Me.lblSearchash.TabIndex = 25
        Me.lblSearchash.Text = "Search Hash:"
        '
        'txtboxHSearch
        '
        Me.txtboxHSearch.Location = New System.Drawing.Point(147, 22)
        Me.txtboxHSearch.Name = "txtboxHSearch"
        Me.txtboxHSearch.Size = New System.Drawing.Size(267, 20)
        Me.txtboxHSearch.TabIndex = 24
        '
        'btnDeleteRecord
        '
        Me.btnDeleteRecord.Location = New System.Drawing.Point(440, 376)
        Me.btnDeleteRecord.Name = "btnDeleteRecord"
        Me.btnDeleteRecord.Size = New System.Drawing.Size(111, 42)
        Me.btnDeleteRecord.TabIndex = 21
        Me.btnDeleteRecord.Text = "Delete Record"
        Me.btnDeleteRecord.UseVisualStyleBackColor = True
        '
        'btnNextRecord
        '
        Me.btnNextRecord.Location = New System.Drawing.Point(295, 376)
        Me.btnNextRecord.Name = "btnNextRecord"
        Me.btnNextRecord.Size = New System.Drawing.Size(114, 42)
        Me.btnNextRecord.TabIndex = 20
        Me.btnNextRecord.Text = ">"
        Me.btnNextRecord.UseVisualStyleBackColor = True
        '
        'btnPreviousRecord
        '
        Me.btnPreviousRecord.Location = New System.Drawing.Point(148, 376)
        Me.btnPreviousRecord.Name = "btnPreviousRecord"
        Me.btnPreviousRecord.Size = New System.Drawing.Size(115, 42)
        Me.btnPreviousRecord.TabIndex = 19
        Me.btnPreviousRecord.Text = "<"
        Me.btnPreviousRecord.UseVisualStyleBackColor = True
        '
        'btnFirstRecord
        '
        Me.btnFirstRecord.Location = New System.Drawing.Point(8, 376)
        Me.btnFirstRecord.Name = "btnFirstRecord"
        Me.btnFirstRecord.Size = New System.Drawing.Size(111, 42)
        Me.btnFirstRecord.TabIndex = 12
        Me.btnFirstRecord.Text = "<<"
        Me.btnFirstRecord.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(258, 303)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Verified"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(372, 256)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Hash Verified Value"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(113, 256)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Hash Value"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(387, 211)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Hash Algorithm"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(114, 211)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Serial ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(388, 163)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Date of Hash"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(98, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Chain of Custody"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(388, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Case Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "EvidenceID"
        '
        'txtboxVerified
        '
        Me.txtboxVerified.Location = New System.Drawing.Point(142, 319)
        Me.txtboxVerified.Name = "txtboxVerified"
        Me.txtboxVerified.Size = New System.Drawing.Size(267, 20)
        Me.txtboxVerified.TabIndex = 9
        Me.txtboxVerified.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxHValue
        '
        Me.txtboxHValue.Location = New System.Drawing.Point(7, 275)
        Me.txtboxHValue.Name = "txtboxHValue"
        Me.txtboxHValue.Size = New System.Drawing.Size(267, 20)
        Me.txtboxHValue.TabIndex = 8
        Me.txtboxHValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxHVValue
        '
        Me.txtboxHVValue.Location = New System.Drawing.Point(286, 275)
        Me.txtboxHVValue.Name = "txtboxHVValue"
        Me.txtboxHVValue.Size = New System.Drawing.Size(267, 20)
        Me.txtboxHVValue.TabIndex = 7
        Me.txtboxHVValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxSerial
        '
        Me.txtboxSerial.Location = New System.Drawing.Point(7, 230)
        Me.txtboxSerial.Name = "txtboxSerial"
        Me.txtboxSerial.Size = New System.Drawing.Size(267, 20)
        Me.txtboxSerial.TabIndex = 6
        Me.txtboxSerial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxHAlgo
        '
        Me.txtboxHAlgo.Location = New System.Drawing.Point(286, 230)
        Me.txtboxHAlgo.Name = "txtboxHAlgo"
        Me.txtboxHAlgo.Size = New System.Drawing.Size(267, 20)
        Me.txtboxHAlgo.TabIndex = 5
        Me.txtboxHAlgo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxChain
        '
        Me.txtboxChain.Location = New System.Drawing.Point(8, 183)
        Me.txtboxChain.Name = "txtboxChain"
        Me.txtboxChain.Size = New System.Drawing.Size(267, 20)
        Me.txtboxChain.TabIndex = 4
        Me.txtboxChain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxDate
        '
        Me.txtboxDate.Location = New System.Drawing.Point(287, 183)
        Me.txtboxDate.Name = "txtboxDate"
        Me.txtboxDate.Size = New System.Drawing.Size(267, 20)
        Me.txtboxDate.TabIndex = 3
        Me.txtboxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxEvidenceID
        '
        Me.txtboxEvidenceID.Location = New System.Drawing.Point(7, 131)
        Me.txtboxEvidenceID.Name = "txtboxEvidenceID"
        Me.txtboxEvidenceID.Size = New System.Drawing.Size(267, 20)
        Me.txtboxEvidenceID.TabIndex = 2
        Me.txtboxEvidenceID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxCaseNumber
        '
        Me.txtboxCaseNumber.Location = New System.Drawing.Point(286, 131)
        Me.txtboxCaseNumber.Name = "txtboxCaseNumber"
        Me.txtboxCaseNumber.Size = New System.Drawing.Size(267, 20)
        Me.txtboxCaseNumber.TabIndex = 1
        Me.txtboxCaseNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnBrowse)
        Me.GroupBox6.Controls.Add(Me.txtboxDatabaseLocation)
        Me.GroupBox6.Controls.Add(Me.lblDatabase)
        Me.GroupBox6.Controls.Add(Me.btnLoad)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 19)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(562, 75)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Database Loader"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(480, 16)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 26)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtboxDatabaseLocation
        '
        Me.txtboxDatabaseLocation.Location = New System.Drawing.Point(118, 26)
        Me.txtboxDatabaseLocation.Name = "txtboxDatabaseLocation"
        Me.txtboxDatabaseLocation.Size = New System.Drawing.Size(356, 20)
        Me.txtboxDatabaseLocation.TabIndex = 6
        '
        'lblDatabase
        '
        Me.lblDatabase.AutoSize = True
        Me.lblDatabase.Location = New System.Drawing.Point(6, 29)
        Me.lblDatabase.Name = "lblDatabase"
        Me.lblDatabase.Size = New System.Drawing.Size(115, 13)
        Me.lblDatabase.TabIndex = 5
        Me.lblDatabase.Text = "Location of Database: "
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(480, 42)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 26)
        Me.btnLoad.TabIndex = 0
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnDBReset
        '
        Me.btnDBReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDBReset.Location = New System.Drawing.Point(148, 65)
        Me.btnDBReset.Name = "btnDBReset"
        Me.btnDBReset.Size = New System.Drawing.Size(43, 31)
        Me.btnDBReset.TabIndex = 6
        Me.btnDBReset.Text = "↻"
        Me.btnDBReset.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ListBoxEvent)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Location = New System.Drawing.Point(594, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(625, 582)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hash Tools and Hash Verification"
        '
        'ListBoxEvent
        '
        Me.ListBoxEvent.FormattingEnabled = True
        Me.ListBoxEvent.Location = New System.Drawing.Point(8, 495)
        Me.ListBoxEvent.Name = "ListBoxEvent"
        Me.ListBoxEvent.Size = New System.Drawing.Size(613, 82)
        Me.ListBoxEvent.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(280, 476)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Event Log"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnVerifyHashValues)
        Me.GroupBox5.Controls.Add(Me.btnExportInput)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.txtboxExportSerial)
        Me.GroupBox5.Controls.Add(Me.txtboxExportChain)
        Me.GroupBox5.Controls.Add(Me.txtboxExportCase)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.txtboxHashVerified)
        Me.GroupBox5.Controls.Add(Me.txtboxHashValue)
        Me.GroupBox5.Controls.Add(Me.btnExport)
        Me.GroupBox5.Controls.Add(Me.btnVerifyHash)
        Me.GroupBox5.Controls.Add(Me.btnHash)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 190)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(613, 283)
        Me.GroupBox5.TabIndex = 5
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Execution Process"
        '
        'btnVerifyHashValues
        '
        Me.btnVerifyHashValues.Location = New System.Drawing.Point(405, 17)
        Me.btnVerifyHashValues.Name = "btnVerifyHashValues"
        Me.btnVerifyHashValues.Size = New System.Drawing.Size(191, 42)
        Me.btnVerifyHashValues.TabIndex = 20
        Me.btnVerifyHashValues.Text = "Verify Hash Values"
        Me.btnVerifyHashValues.UseVisualStyleBackColor = True
        '
        'btnExportInput
        '
        Me.btnExportInput.Location = New System.Drawing.Point(405, 76)
        Me.btnExportInput.Name = "btnExportInput"
        Me.btnExportInput.Size = New System.Drawing.Size(191, 42)
        Me.btnExportInput.TabIndex = 19
        Me.btnExportInput.Text = "Input Information"
        Me.btnExportInput.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(68, 130)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 13)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Enter Serial ID:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(31, 104)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(118, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Enter Chain of Custody:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(46, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(102, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Enter Case Number:"
        '
        'txtboxExportSerial
        '
        Me.txtboxExportSerial.Location = New System.Drawing.Point(152, 127)
        Me.txtboxExportSerial.Name = "txtboxExportSerial"
        Me.txtboxExportSerial.Size = New System.Drawing.Size(213, 20)
        Me.txtboxExportSerial.TabIndex = 14
        '
        'txtboxExportChain
        '
        Me.txtboxExportChain.Location = New System.Drawing.Point(152, 101)
        Me.txtboxExportChain.Name = "txtboxExportChain"
        Me.txtboxExportChain.Size = New System.Drawing.Size(213, 20)
        Me.txtboxExportChain.TabIndex = 13
        '
        'txtboxExportCase
        '
        Me.txtboxExportCase.Location = New System.Drawing.Point(152, 75)
        Me.txtboxExportCase.Name = "txtboxExportCase"
        Me.txtboxExportCase.Size = New System.Drawing.Size(213, 20)
        Me.txtboxExportCase.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "2nd Hash Value "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Hash Value"
        '
        'txtboxHashVerified
        '
        Me.txtboxHashVerified.Location = New System.Drawing.Point(20, 237)
        Me.txtboxHashVerified.Name = "txtboxHashVerified"
        Me.txtboxHashVerified.Size = New System.Drawing.Size(568, 20)
        Me.txtboxHashVerified.TabIndex = 9
        Me.txtboxHashVerified.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtboxHashValue
        '
        Me.txtboxHashValue.Location = New System.Drawing.Point(20, 194)
        Me.txtboxHashValue.Name = "txtboxHashValue"
        Me.txtboxHashValue.Size = New System.Drawing.Size(568, 20)
        Me.txtboxHashValue.TabIndex = 8
        Me.txtboxHashValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(405, 126)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(191, 42)
        Me.btnExport.TabIndex = 7
        Me.btnExport.Text = "Export Verification To Database"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnVerifyHash
        '
        Me.btnVerifyHash.Location = New System.Drawing.Point(208, 17)
        Me.btnVerifyHash.Name = "btnVerifyHash"
        Me.btnVerifyHash.Size = New System.Drawing.Size(191, 42)
        Me.btnVerifyHash.TabIndex = 6
        Me.btnVerifyHash.Text = "Hash File Again"
        Me.btnVerifyHash.UseVisualStyleBackColor = True
        '
        'btnHash
        '
        Me.btnHash.Location = New System.Drawing.Point(11, 17)
        Me.btnHash.Name = "btnHash"
        Me.btnHash.Size = New System.Drawing.Size(191, 42)
        Me.btnHash.TabIndex = 5
        Me.btnHash.Text = "Hash File"
        Me.btnHash.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rdoSHA384)
        Me.GroupBox4.Controls.Add(Me.rdoSHA256)
        Me.GroupBox4.Controls.Add(Me.rdoSHA)
        Me.GroupBox4.Controls.Add(Me.rdoMD5)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 144)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(613, 40)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Algorithm Options"
        '
        'rdoSHA384
        '
        Me.rdoSHA384.AutoSize = True
        Me.rdoSHA384.Location = New System.Drawing.Point(525, 19)
        Me.rdoSHA384.Name = "rdoSHA384"
        Me.rdoSHA384.Size = New System.Drawing.Size(65, 17)
        Me.rdoSHA384.TabIndex = 3
        Me.rdoSHA384.TabStop = True
        Me.rdoSHA384.Text = "SHA384"
        Me.rdoSHA384.UseVisualStyleBackColor = True
        '
        'rdoSHA256
        '
        Me.rdoSHA256.AutoSize = True
        Me.rdoSHA256.Location = New System.Drawing.Point(357, 19)
        Me.rdoSHA256.Name = "rdoSHA256"
        Me.rdoSHA256.Size = New System.Drawing.Size(65, 17)
        Me.rdoSHA256.TabIndex = 2
        Me.rdoSHA256.TabStop = True
        Me.rdoSHA256.Text = "SHA256"
        Me.rdoSHA256.UseVisualStyleBackColor = True
        '
        'rdoSHA
        '
        Me.rdoSHA.AutoSize = True
        Me.rdoSHA.Location = New System.Drawing.Point(193, 19)
        Me.rdoSHA.Name = "rdoSHA"
        Me.rdoSHA.Size = New System.Drawing.Size(53, 17)
        Me.rdoSHA.TabIndex = 1
        Me.rdoSHA.TabStop = True
        Me.rdoSHA.Text = "SHA1"
        Me.rdoSHA.UseVisualStyleBackColor = True
        '
        'rdoMD5
        '
        Me.rdoMD5.AutoSize = True
        Me.rdoMD5.Location = New System.Drawing.Point(28, 19)
        Me.rdoMD5.Name = "rdoMD5"
        Me.rdoMD5.Size = New System.Drawing.Size(48, 17)
        Me.rdoMD5.TabIndex = 0
        Me.rdoMD5.TabStop = True
        Me.rdoMD5.Text = "MD5"
        Me.rdoMD5.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnExit)
        Me.GroupBox3.Controls.Add(Me.btnFLoad)
        Me.GroupBox3.Controls.Add(Me.btnDBReset)
        Me.GroupBox3.Controls.Add(Me.lblFileLocation)
        Me.GroupBox3.Controls.Add(Me.txtboxFileLocation)
        Me.GroupBox3.Controls.Add(Me.btnSelect)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(613, 119)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "File Location"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(564, 11)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(43, 31)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnFLoad
        '
        Me.btnFLoad.Location = New System.Drawing.Point(332, 65)
        Me.btnFLoad.Name = "btnFLoad"
        Me.btnFLoad.Size = New System.Drawing.Size(133, 31)
        Me.btnFLoad.TabIndex = 5
        Me.btnFLoad.Text = "Load"
        Me.btnFLoad.UseVisualStyleBackColor = True
        '
        'lblFileLocation
        '
        Me.lblFileLocation.AutoSize = True
        Me.lblFileLocation.Location = New System.Drawing.Point(165, 23)
        Me.lblFileLocation.Name = "lblFileLocation"
        Me.lblFileLocation.Size = New System.Drawing.Size(271, 13)
        Me.lblFileLocation.TabIndex = 3
        Me.lblFileLocation.Text = "Enter the file location of the evidence you wish to hash -"
        '
        'bkwShad256
        '
        '
        'bkwMD5
        '
        '
        'BKWMD5V
        '
        '
        'BKWSHA256V
        '
        '
        'bkw384
        '
        '
        'bwk384V
        '
        '
        'bkwSHA
        '
        '
        'bkwSHAV
        '
        '
        'frmHashDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1227, 597)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHashDatabase"
        Me.Text = "Postmortem - Henry Manning"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxFileLocation As System.Windows.Forms.TextBox
    Friend WithEvents btnSelect As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFileLocation As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoSHA As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMD5 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents btnVerifyHash As System.Windows.Forms.Button
    Friend WithEvents btnHash As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtboxHashVerified As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListBoxEvent As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents txtboxDatabaseLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblDatabase As System.Windows.Forms.Label
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtboxVerified As System.Windows.Forms.TextBox
    Friend WithEvents txtboxHValue As System.Windows.Forms.TextBox
    Friend WithEvents txtboxHVValue As System.Windows.Forms.TextBox
    Friend WithEvents txtboxSerial As System.Windows.Forms.TextBox
    Friend WithEvents txtboxHAlgo As System.Windows.Forms.TextBox
    Friend WithEvents txtboxChain As System.Windows.Forms.TextBox
    Friend WithEvents txtboxDate As System.Windows.Forms.TextBox
    Friend WithEvents txtboxEvidenceID As System.Windows.Forms.TextBox
    Friend WithEvents txtboxCaseNumber As System.Windows.Forms.TextBox
    Friend WithEvents btnDeleteRecord As System.Windows.Forms.Button
    Friend WithEvents btnNextRecord As System.Windows.Forms.Button
    Friend WithEvents btnPreviousRecord As System.Windows.Forms.Button
    Friend WithEvents btnFirstRecord As System.Windows.Forms.Button
    Friend WithEvents btnCSearch As System.Windows.Forms.Button
    Friend WithEvents btnHSearch As System.Windows.Forms.Button
    Friend WithEvents txtboxCSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSeachCase As System.Windows.Forms.Label
    Friend WithEvents lblSearchash As System.Windows.Forms.Label
    Friend WithEvents txtboxHSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnFLoad As System.Windows.Forms.Button
    Friend WithEvents btnDBReset As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtboxExportSerial As System.Windows.Forms.TextBox
    Friend WithEvents txtboxExportChain As System.Windows.Forms.TextBox
    Friend WithEvents txtboxExportCase As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnExportInput As System.Windows.Forms.Button
    Friend WithEvents rdoSHA256 As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSHA384 As System.Windows.Forms.RadioButton
    Friend WithEvents txtboxHashValue As System.Windows.Forms.TextBox
    Friend WithEvents bkwShad256 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bkwMD5 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BKWMD5V As System.ComponentModel.BackgroundWorker
    Friend WithEvents BKWSHA256V As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnVerifyHashValues As System.Windows.Forms.Button
    Friend WithEvents bkw384 As System.ComponentModel.BackgroundWorker
    Friend WithEvents bwk384V As System.ComponentModel.BackgroundWorker
    Friend WithEvents bkwSHA As System.ComponentModel.BackgroundWorker
    Friend WithEvents bkwSHAV As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
