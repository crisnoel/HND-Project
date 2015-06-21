Imports System.Security.Cryptography 'import library for algorithms
Imports System.IO 'import library
Imports System.Text 'import library for colours
Imports System.Environment 'import library
Imports System.Diagnostics 'import library
Imports System.Data.OleDb 'import library for database connection
Imports System.Windows.Forms.DialogResult 'import library for dialogs such as browse
Imports System.Drawing 'import library
Imports System.ComponentModel 'import library for background workers

Public Class frmHashDatabase

    Private Sub NavigateRecords() 'Private sub for navigation of records

        txtboxEvidenceID.Text = DSet.Tables("Load").Rows(inc).Item(0)
        txtboxCaseNumber.Text = DSet.Tables("Load").Rows(inc).Item(1)
        txtboxChain.Text = DSet.Tables("Load").Rows(inc).Item(2)
        txtboxDate.Text = DSet.Tables("Load").Rows(inc).Item(3)
        txtboxSerial.Text = DSet.Tables("Load").Rows(inc).Item(4)
        txtboxHAlgo.Text = DSet.Tables("Load").Rows(inc).Item(5)
        txtboxHValue.Text = DSet.Tables("Load").Rows(inc).Item(6)
        txtboxHVValue.Text = DSet.Tables("Load").Rows(inc).Item(7)
        txtboxVerified.Text = DSet.Tables("Load").Rows(inc).Item(8)

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Try 'Try statement
            Dim FileDialog As OpenFileDialog = New OpenFileDialog() 'instantiates a new openfiledialog

            FileDialog.Title = "Select A File" 'titles the dialog
            FileDialog.InitialDirectory = "c:\" 'starts the dialog with the C drive
            FileDialog.Filter = "accdb files (*.accdb)|*.accdb|All files (*.*)|*.*" 'filters out all other files except for database files
            FileDialog.FilterIndex = 2
            FileDialog.RestoreDirectory = True
            FileDialog.ShowDialog() 'Shows the dialog
            txtboxFileLocation.Text = FileDialog.FileName() 'the textbox is filled with the selected file name
            txtboxFileLocation.Focus() 'Gives focus to the textbox
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'ends try statement

    End Sub

    Private Sub btnShowLocation_Click(sender As Object, e As EventArgs)

        Dim MsgBoxTitle1 = "Postmortem File Location Confirmation" 'Title of the MsgBox adds more simplicity '
        MsgBox(Filelocation, , MsgBoxTitle1) 'Shows the user the Filelocation String text if correctly inputted
        ListBoxEvent.Items.Add("Inputted File Location Displayed") 'Event log shows that the file location has been inputted into the console

    End Sub

    Private Sub rdoMD5_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMD5.CheckedChanged

        If rdoMD5.Enabled = True Then 'if statement
            AlgorithmSelection = 1 'Variable = 1
            ListBoxEvent.Items.Add("MD5 algorithm has been selected") 'Add statement to the listbox
        End If

    End Sub

    Private Sub rdoSHA_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSHA.CheckedChanged

        If rdoSHA.Enabled = True Then 'if statement
            AlgorithmSelection = 2 'variable = 2
            ListBoxEvent.Items.Add("SHA1 algorithm has been selected") 'Add statement to the listbox
        End If
    End Sub

    Private Sub rdoSHA256_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSHA256.CheckedChanged

        If rdoSHA256.Enabled = True Then 'if statement
            AlgorithmSelection = 3 'variable = 3
            ListBoxEvent.Items.Add("SHA256 algorithm has been selected") 'Add statement to the listbox
        End If

    End Sub

    Private Sub rdoSHA384_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSHA384.CheckedChanged

        If rdoSHA384.Enabled = True Then 'if statement
            AlgorithmSelection = 4 'variable = 4
            ListBoxEvent.Items.Add("SHA384 algorithm has been selected") 'Add statement to the listbox
        End If

    End Sub

    Private Sub btnHash_Click(sender As Object, e As EventArgs) Handles btnHash.Click
        Try 'try statement


            btnVerifyHash.Enabled = True 'button is enabled
            btnHash.Enabled = False 'button is disabled
            If AlgorithmSelection = 1 Then 'if statement
                bkwMD5.RunWorkerAsync() 'starts background worker
            End If
            If AlgorithmSelection = 2 Then 'if statement
                bkwSHA.RunWorkerAsync() 'starts background worker
            End If
            If AlgorithmSelection = 3 Then 'if statement
                bkwShad256.RunWorkerAsync() 'starts background worker
            End If
            If AlgorithmSelection = 4 Then 'if statement
                bkw384.RunWorkerAsync() 'starts background worker
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement

    End Sub

    Private Sub btnVerifyHash_Click(sender As Object, e As EventArgs) Handles btnVerifyHash.Click
        Try 'try statement
            btnVerifyHash.Enabled = False 'button is disabled
            btnVerifyHashValues.Enabled = True 'button is enabled
            If AlgorithmSelection = 1 Then 'if statement
                BKWMD5V.RunWorkerAsync() 'starts background worker
            End If
            If AlgorithmSelection = 2 Then 'if statement
                bkwSHAV.RunWorkerAsync() 'starts background worker
            End If

            If AlgorithmSelection = 3 Then 'if statement
                BKWSHA256V.RunWorkerAsync() 'starts background worker
            End If

            If AlgorithmSelection = 4 Then 'if statement
                bwk384V.RunWorkerAsync() 'starts background worker
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement

    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs)
        Try 'try statement
            ListBoxEvent.Items.Add("Hashing settings have been reset") 'adds statement to listbox
            TheEvidenceFile = vbNullString 'variable = null
            HashCalculation = vbNullString 'variable = null
            TheEvidenceFileVerify = vbNullString 'variable = null
            HashCalculationVerify = vbNullString 'variable = null
            SHAHashCalculation = vbNullString 'variable = null
            SHATheEvidenceFileVerify = vbNullString 'variable = null
            SHAHashCalculationVerify = vbNullString 'variable = null
            DBLocation = vbNullString 'variable = null

            txtboxFileLocation.Clear() 'clears textbox
            txtboxHashValue.Clear() 'clears textbox
            txtboxHashVerified.Clear() 'clears textbox

            rdoMD5.Enabled = True 'radio button enabled
            rdoSHA.Enabled = True 'radio button enabled
            rdoSHA256.Enabled = True 'radio button enabled
            rdoSHA384.Enabled = True 'radio button enabled

            If rdoMD5.Checked = True Then 'if statement
                rdoMD5.Checked = False 'radio button = false
            End If

            If rdoSHA.Checked = True Then 'if statement
                rdoSHA.Checked = False 'radio button = false
            End If

            If rdoSHA256.Checked = True Then 'if statement
                rdoSHA256.Checked = False 'radio button = false
            End If

            If rdoSHA384.Checked = True Then 'if statement
                rdoSHA384.Checked = False 'radio button = false
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)

        Application.Exit() 'Exits application

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try 'try statement
            If btnBrowse.Enabled = True Then 'if statement
                btnBrowse.Enabled = False 'button is disabled
                btnLoad.Enabled = False 'button is disabled
            End If

            Dim LoadSQL As String 'new variable declaration
            Dim cmdOLEDB As New OleDbCommand 'new oledbcommand declaration

            Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & txtboxDatabaseLocation.Text & ";" 'connection string and connection provider
            cnnOLEDB.ConnectionString = strConnectionString 'Connection string = the provider and the textbox database location
            cnnOLEDB.Open() 'opens the connection

            MsgBox("Database Connection Has Been Established") 'Msgbox displays
            ListBoxEvent.Items.Add("Database connected") 'adds statement to the listbox

            LoadSQL = "SELECT * FROM tblEvidence" 'SQL statement decleration

            DAdapter = New OleDb.OleDbDataAdapter(LoadSQL, cnnOLEDB) 'data adapter = SQL statement and the connection string
            DAdapter.Fill(DSet, "Load") 'Fills the load dataset

            inc = 0 'incrementation = 0
            MaxRowsEvidence = DSet.Tables("Load").Rows.Count 'Counts the rows of the table 

            cnnOLEDB.Close() 'closes the connection
            txtboxEvidenceID.Text = DSet.Tables("Load").Rows(inc).Item(0) 'populates the textbox
            txtboxCaseNumber.Text = DSet.Tables("Load").Rows(inc).Item(1) 'populates the textbox
            txtboxChain.Text = DSet.Tables("Load").Rows(inc).Item(2) 'populates the textbox
            txtboxDate.Text = DSet.Tables("Load").Rows(inc).Item(3) 'populates the textbox
            txtboxSerial.Text = DSet.Tables("Load").Rows(inc).Item(4) 'populates the textbox
            txtboxHAlgo.Text = DSet.Tables("Load").Rows(inc).Item(5) 'populates the textbox
            txtboxHValue.Text = DSet.Tables("Load").Rows(inc).Item(6) 'populates the textbox
            txtboxHVValue.Text = DSet.Tables("Load").Rows(inc).Item(7) 'populates the textbox
            txtboxVerified.Text = DSet.Tables("Load").Rows(inc).Item(8) 'populates the textbox

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement

        btnCSearch.Enabled = True 'button enabled
        btnDBReset.Enabled = True 'button enabled
        btnDeleteRecord.Enabled = True 'button enabled
        btnFirstRecord.Enabled = True 'button enabled
        btnFLoad.Enabled = True 'button enabled
        btnHash.Enabled = True 'button enabled
        btnHSearch.Enabled = True 'button enabled
        btnNextRecord.Enabled = True 'button enabled
        btnPreviousRecord.Enabled = True 'button enabled
        btnSelect.Enabled = True 'button enabled
        rdoMD5.Enabled = True 'button enabled
        rdoSHA.Enabled = True 'radio button enabled
        rdoSHA256.Enabled = True 'radio button enabled
        rdoSHA384.Enabled = True 'radio button enabled
        txtboxCaseNumber.Enabled = True 'textbox enabled
        txtboxChain.Enabled = True 'textbox enabled
        txtboxCSearch.Enabled = True 'textbox enabled
        txtboxDate.Enabled = True 'textbox enabled
        txtboxEvidenceID.Enabled = True 'textbox enabled
        txtboxFileLocation.Enabled = True 'textbox enabled
        txtboxHAlgo.Enabled = True 'textbox enabled
        txtboxHashValue.Enabled = True 'textbox enabled
        txtboxHashVerified.Enabled = True 'textbox enabled
        txtboxHSearch.Enabled = True 'textbox enabled
        txtboxHValue.Enabled = True 'textbox enabled
        txtboxHVValue.Enabled = True 'textbox enabled
        txtboxSerial.Enabled = True 'textbox enabled
        txtboxVerified.Enabled = True 'textbox enabled

        txtboxExportCase.Enabled = True 'textbox enabled
        txtboxExportChain.Enabled = True 'textbox enabled
        txtboxExportSerial.Enabled = True 'textbox enabled

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try 'try statement

            Dim FileDialog As OpenFileDialog = New OpenFileDialog() 'instantiates new openfiledialog

            FileDialog.Title = "Select A File" 'titles the dialog
            FileDialog.InitialDirectory = "c:\" 'defaults to C drive
            FileDialog.Filter = "accdb files (*.accdb)|*.accdb|All files (*.*)|*.*" 'filters out all files except database files
            FileDialog.FilterIndex = 2
            FileDialog.RestoreDirectory = True
            FileDialog.ShowDialog() 'shows the dialog
            txtboxDatabaseLocation.Text = FileDialog.FileName() 'File location is filled to the textbox
            txtboxDatabaseLocation.Focus() 'textbox focus
            btnLoad.Enabled = True 'button enabled

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement

    End Sub


    Private Sub btnPreviousRecord_Click(sender As Object, e As EventArgs) Handles btnPreviousRecord.Click

        If inc > 0 Then 'if statement
            inc = inc - 1 'inc minus 1

            NavigateRecords() 'calls navigate function

        Else
            MsgBox("Start of Database") 'message box 
        End If

    End Sub

    Private Sub btnNextRecord_Click(sender As Object, e As EventArgs) Handles btnNextRecord.Click

        If inc <> MaxRowsEvidence - 1 Then 'if statement

            inc = inc + 1 'inc plus 1

            NavigateRecords() 'calls navigate function

        Else
            MsgBox("End of Database") 'message box 
        End If

    End Sub

    Private Sub btnFLoad_Click(sender As Object, e As EventArgs) Handles btnFLoad.Click

        Filelocation = txtboxFileLocation.Text 'Text input declares the FileLocation variable
        ListBoxEvent.Items.Add("File location has been loaded into the Postmortem program") 'adds statement to the listbox

    End Sub

    Private Sub btnFirstRecord_Click(sender As Object, e As EventArgs) Handles btnFirstRecord.Click

        txtboxEvidenceID.Text = DSet.Tables("Load").Rows(0).Item(0) 'populates the textbox
        txtboxCaseNumber.Text = DSet.Tables("Load").Rows(0).Item(1) 'populates the textbox
        txtboxChain.Text = DSet.Tables("Load").Rows(0).Item(2) 'populates the textbox
        txtboxDate.Text = DSet.Tables("Load").Rows(0).Item(3) 'populates the textbox
        txtboxSerial.Text = DSet.Tables("Load").Rows(0).Item(4) 'populates the textbox
        txtboxHAlgo.Text = DSet.Tables("Load").Rows(0).Item(5) 'populates the textbox
        txtboxHValue.Text = DSet.Tables("Load").Rows(0).Item(6) 'populates the textbox
        txtboxHVValue.Text = DSet.Tables("Load").Rows(0).Item(7) 'populates the textbox
        txtboxVerified.Text = DSet.Tables("Load").Rows(0).Item(8) 'populates the textbox

    End Sub

    Private Sub btnHSearch_Click(sender As Object, e As EventArgs) Handles btnHSearch.Click
        Try
            txtboxEvidenceID.Clear() 'Clears the textbox
            txtboxCaseNumber.Clear() 'Clears the textbox
            txtboxChain.Clear() 'Clears the textbox
            txtboxDate.Clear() 'Clears the textbox
            txtboxSerial.Clear() 'Clears the textbox
            txtboxHAlgo.Clear() 'Clears the textbox
            txtboxHValue.Clear() 'Clears the textbox
            txtboxHVValue.Clear() 'Clears the textbox
            txtboxVerified.Clear() 'Clears the textbox

            Dim HashSearchSQL As String 'declares a new string variable
            HashSearchSQL = "SELECT * FROM tblEvidence WHERE [Hash_Value] LIKE '%" & txtboxHSearch.Text & "%' ;" 'SQL statement stated

            DAdapter = New OleDb.OleDbDataAdapter(HashSearchSQL, cnnOLEDB) 'data adapter equals SQL and connection string
            DAdapter.Fill(DSet, "SearchHash") 'Fills the dataset

            MaxRowsEvidence = DSet.Tables("SearchHash").Rows.Count 'counts the rows of the dataset
            inc = -1 'inc equals negative 1

            If inc <> MaxRowsEvidence - 1 Then 'if statement

                inc = inc + 1 'inc equals inc plus 1

            Else

                MsgBox("No More Rows") 'msgbox

            End If

            txtboxEvidenceID.Text = DSet.Tables("SearchHash").Rows(inc).Item(0) 'populates the textbox
            txtboxCaseNumber.Text = DSet.Tables("SearchHash").Rows(inc).Item(1) 'populates the textbox
            txtboxChain.Text = DSet.Tables("SearchHash").Rows(inc).Item(2) 'populates the textbox
            txtboxDate.Text = DSet.Tables("SearchHash").Rows(inc).Item(3) 'populates the textbox
            txtboxSerial.Text = DSet.Tables("SearchHash").Rows(inc).Item(4) 'populates the textbox
            txtboxHAlgo.Text = DSet.Tables("SearchHash").Rows(inc).Item(5) 'populates the textbox
            txtboxHValue.Text = DSet.Tables("SearchHash").Rows(inc).Item(6) 'populates the textbox
            txtboxHVValue.Text = DSet.Tables("SearchHash").Rows(inc).Item(7) 'populates the textbox
            txtboxVerified.Text = DSet.Tables("SearchHash").Rows(inc).Item(8) 'populates the textbox
            ListBoxEvent.Items.Add("Hash search completed") 'add statement to the list box

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement
    End Sub

    Private Sub btnCSearch_Click(sender As Object, e As EventArgs) Handles btnCSearch.Click
        Try
            txtboxEvidenceID.Clear() 'clears textbox
            txtboxCaseNumber.Clear() 'clears textbox
            txtboxChain.Clear() 'clears textbox
            txtboxDate.Clear() 'clears textbox
            txtboxSerial.Clear() 'clears textbox
            txtboxHAlgo.Clear() 'clears textbox
            txtboxHValue.Clear() 'clears textbox
            txtboxHVValue.Clear() 'clears textbox
            txtboxVerified.Clear() 'clears textbox

            Dim CaseSearchSQL As String 'new variable string
            CaseSearchSQL = "SELECT * FROM tblEvidence WHERE [Case_Number] LIKE '%" & txtboxCSearch.Text & "%' ;" 'sql statement

            DAdapter = New OleDb.OleDbDataAdapter(CaseSearchSQL, cnnOLEDB) 'new dataadapter equals SQL statement and connection string
            DAdapter.Fill(DSet, "SearchCase") 'fills the dataset

            MaxRowsEvidence = DSet.Tables("SearchCase").Rows.Count 'counts the rows
            inc = -1 'inc = negative 1

            If inc <> MaxRowsEvidence - 1 Then 'if statement

                inc = inc + 1 'inc = inc + 1

            Else

                MsgBox("No More Rows") 'msgbox

            End If

            txtboxEvidenceID.Text = DSet.Tables("SearchCase").Rows(0).Item(0) 'populates the textbox
            txtboxCaseNumber.Text = DSet.Tables("SearchCase").Rows(0).Item(1) 'populates the textbox
            txtboxChain.Text = DSet.Tables("SearchCase").Rows(0).Item(2) 'populates the textbox
            txtboxDate.Text = DSet.Tables("SearchCase").Rows(0).Item(3) 'populates the textbox
            txtboxSerial.Text = DSet.Tables("SearchCase").Rows(0).Item(4) 'populates the textbox
            txtboxHAlgo.Text = DSet.Tables("SearchCase").Rows(0).Item(5) 'populates the textbox
            txtboxHValue.Text = DSet.Tables("SearchCase").Rows(0).Item(6) 'populates the textbox
            txtboxHVValue.Text = DSet.Tables("SearchCase").Rows(0).Item(7) 'populates the textbox
            txtboxVerified.Text = DSet.Tables("SearchCase").Rows(0).Item(8) 'populates the textbox
            ListBoxEvent.Items.Add("Case number searched") 'add statement to the listbox

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement

    End Sub


    Private Sub btnDBReset_Click(sender As Object, e As EventArgs) Handles btnDBReset.Click
        Try
            txtboxFileLocation.Text = "" 'textbox equals nothing
            txtboxExportCase.Text = "" 'textbox equals nothing
            txtboxExportChain.Text = "" 'textbox equals nothing
            txtboxExportSerial.Text = "" 'textbox equals nothing
            txtboxHashValue.Text = "" 'textbox equals nothing
            txtboxHashVerified.Text = "" 'textbox equals nothing

            ListBoxEvent.Items.Clear() 'clears the listbox

            If rdoMD5.Checked = True Then 'if statement
                rdoMD5.Checked = False 'radio button disabled
            End If

            If rdoSHA.Checked = True Then 'if statement
                rdoSHA.Checked = False 'radio button disabled
            End If

            If rdoSHA256.Checked = True Then 'if statement
                rdoSHA256.Checked = False 'radio button disabled
            End If

            If rdoSHA384.Checked = True Then 'if statement
                rdoSHA384.Checked = False 'radio button disabled
            End If

            btnHash.Enabled = True 'button enabled
            btnVerifyHash.Enabled = False 'button disabled
            btnVerifyHashValues.Enabled = False 'button disabled
            btnExportInput.Enabled = False 'button disabled
            btnExport.Enabled = False 'button disabled
            ListBoxEvent.Items.Clear() 'clears listbox
            ListBoxEvent.Items.Add("Hashing process has been reset")
        Catch ex As Exception
            MessageBox.Show(ex.Message) 'msgbox

        End Try 'end try statement

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnBrowse.Enabled = True 'button enabled
        txtboxDatabaseLocation.Enabled = True 'textbox enabled
        btnExportInput.Enabled = False 'button disabled
        btnLoad.Enabled = False 'button disabled
        btnCSearch.Enabled = False 'button disabled
        btnDBReset.Enabled = False 'button disabled
        btnDeleteRecord.Enabled = False 'button disabled
        btnExport.Enabled = False 'button disabled
        btnFirstRecord.Enabled = False 'button disabled
        btnFLoad.Enabled = False 'button disabled
        btnHash.Enabled = False 'button disabled
        btnHSearch.Enabled = False 'button disabled
        btnVerifyHash.Enabled = False 'button disabled
        btnNextRecord.Enabled = False 'button disabled
        btnPreviousRecord.Enabled = False 'button disabled
        btnVerifyHashValues.Enabled = False 'button disabled
        btnSelect.Enabled = False 'button disabled
        btnVerifyHash.Enabled = False 'button disabled
        rdoMD5.Enabled = False 'radio button disabled
        rdoSHA.Enabled = False 'radio button disabled
        rdoSHA256.Enabled = False 'radio button disabled
        rdoSHA384.Enabled = False 'radio button disabled


        txtboxCaseNumber.Enabled = False 'textbox disabled
        txtboxChain.Enabled = False 'textbox disabled
        txtboxCSearch.Enabled = False 'textbox disabled
        txtboxDate.Enabled = False 'textbox disabled
        txtboxEvidenceID.Enabled = False 'textbox disabled
        txtboxFileLocation.Enabled = False 'textbox disabled
        txtboxHAlgo.Enabled = False 'textbox disabled
        txtboxHashValue.Enabled = False 'textbox disabled
        txtboxHashVerified.Enabled = False 'textbox disabled
        txtboxHSearch.Enabled = False 'textbox disabled
        txtboxHValue.Enabled = False 'textbox disabled
        txtboxHVValue.Enabled = False 'textbox disabled
        txtboxSerial.Enabled = False 'textbox disabled
        txtboxVerified.Enabled = False 'textbox disabled
        txtboxExportCase.Enabled = False 'textbox disabled
        txtboxExportChain.Enabled = False 'textbox disabled
        txtboxExportSerial.Enabled = False 'textbox disabled
    End Sub

    Private Sub btnDeleteRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteRecord.Click
        Try
            Dim CommandBuilderDelete As New OleDb.OleDbCommandBuilder(DAdapter) 'instantiates a new oledbcommand builer
            If MessageBox.Show("Are you sure you want to delete record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then 'messagebox with buttons

                MsgBox("Delete Operating Aborted") 'msgbox
                Exit Sub

            Else

                DSet.Tables("Load").Rows(inc).Delete() 'Deletes the database record
                MaxRowsEvidence = MaxRowsEvidence - 1 'integer reduced by 1

                inc = 0 'inc = 0
                DAdapter.Update(DSet, "Load") 'Updates the dataset
                NavigateRecords() 'calls the navigate record function
                ListBoxEvent.Items.Add("Record has been deleted")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            btnExport.Enabled = False 'button disabled
            'txtboxExportCase.Text = ExportCase
            'txtboxExportChain.Text = ExportChain
            'txtboxExportSerial.Text = ExportSerial

            If rdoMD5.Checked = True Then 'if statement
                ExportAlgorithm = "MD5" 'variable named
            End If

            If rdoSHA.Checked = True Then 'if statement
                ExportAlgorithm = "SHA1" 'variable named
            End If

            If rdoSHA256.Checked = True Then 'if statement
                ExportAlgorithm = "SHA256" 'variable named
            End If

            If rdoSHA384.Checked = True Then 'if statement
                ExportAlgorithm = "SHA384" 'variable named
            End If

            If txtboxHashValue.Text = txtboxHashVerified.Text Then 'if the values of both textboxes are the same

                ExportVerified = "YES" 'variable named

            Else

                ExportVerified = "NO" 'variable named

            End If

            Dim ExportSQL As String 'string variable declared
            ExportSQL = "INSERT INTO tblEvidence (Case_Number, Chain_of_Custody, Date_of_Hash, SerialID, Hash_Algorithm, Hash_Value, Hash_Verified_Value, Verified) VALUES ('" & ExportCase & "','" & ExportChain & "','" & Date.Today & "','" & ExportSerial & "','" & ExportAlgorithm & "','" & txtboxHashValue.Text & "','" & txtboxHashVerified.Text & "','" & ExportVerified & "')" 'SQL statement

            Dim run = New OleDb.OleDbCommand 'new oledbcommand


            cnnOLEDB.Open() 'opens the connection
            run = New OleDbCommand(ExportSQL, cnnOLEDB) 'command runs the sql statement and the connection string
            run.ExecuteNonQuery() 'exectutes the query of "run"
            ListBoxEvent.Items.Add("Inputted information and hash information exported to your chosen database") 'adds a statement to the listbox
            MsgBox("New Hash Added to the Database") 'msg box
            cnnOLEDB.Close() 'closes the connection



        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement


    End Sub

    Private Sub btnExportInput_Click(sender As Object, e As EventArgs) Handles btnExportInput.Click

        btnExportInput.Enabled = False 'button disabled
        btnExport.Enabled = True 'button enabled

        ExportCase = txtboxExportCase.Text 'variable = the textbox
        ExportChain = txtboxExportChain.Text 'variable = the textbox
        ExportSerial = txtboxExportSerial.Text 'variable = the textbox
        ListBoxEvent.Items.Add("Information inputted into Postmortem program") 'add statement to the listbox

    End Sub

    Private Sub bkwShad384_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        Try
            Dim SHA384 As SHA384CryptoServiceProvider = New SHA384CryptoServiceProvider 'instantiates the algorithm
            Dim FileStreamSHA384 As FileStream = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read, 8192) 'Opens a filestream which provides access

            FileStreamSHA384 = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read, 8192) 'variable = the filestream properties
            SHA384.ComputeHash(FileStreamSHA384) 'creates the hash value
            FileStreamSHA384.Close()

            Dim SHA384HashByte As Byte() = SHA384.Hash 'the hash value equals the vaiable
            Dim SHA384HashBuff As StringBuilder = New StringBuilder 'new stringbuilder
            Dim SHA384ByteHash As Byte 'new variable

            For Each SHA384ByteHash In SHA384HashByte
                SHA384HashBuff.Append(String.Format("{0:X2}", SHA384ByteHash)) 'appends the hash value
            Next

            Dim SHA384String As String
            SHA384String = SHA384HashBuff.ToString() 'the hash value is converted to string

            e.Result = SHA384String 'result = the hash value string

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement
    End Sub

    Private Sub bkwShad384_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)
        txtboxHashValue.Text = e.Result.ToString 'textbox = the hash value
        ListBoxEvent.Items.Add("SHA384 hashing process has been completed, hash value is in " & "'Hash Value' text box") 'add statement to listbox
    End Sub

    Private Sub bkwShad256_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bkwShad256.DoWork
        Try

            Dim SHA256 As SHA256CryptoServiceProvider = New SHA256CryptoServiceProvider 'instantiates the algorithm
            Dim FileStreamSHA256 As FileStream = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read, 8192) 'Opens a filestream which provides access

            FileStreamSHA256 = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read, 8192) 'variable = the filestream properties
            SHA256.ComputeHash(FileStreamSHA256) 'creates the hash value
            FileStreamSHA256.Close()

            Dim SHA256HashByte As Byte() = SHA256.Hash 'the hash value equals the vaiable
            Dim SHA256HashBuff As StringBuilder = New StringBuilder 'new stringbuilder
            Dim SHA256ByteHash As Byte 'new variable

            For Each SHA256ByteHash In SHA256HashByte
                SHA256HashBuff.Append(String.Format("{0:X2}", SHA256ByteHash)) 'appends the hash value
            Next

            Dim SHA256String As String
            SHA256String = SHA256HashBuff.ToString() 'the hash value is converted to string

            e.Result = SHA256String 'result = the hash value string
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub bkwShad256_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bkwShad256.RunWorkerCompleted
        txtboxHashValue.Text = e.Result.ToString 'textbox = the hash value
        ListBoxEvent.Items.Add("SHA256 hashing process has been completed, hash value is in " & "'Hash Value' text box") 'add statement to listbox
    End Sub

    Private Sub bkwShad_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs)
        txtboxHashValue.Text = e.Result.ToString 'textbox = the hash value
        ListBoxEvent.Items.Add("SHA hashing process has been completed, hash value is in " & "'Hash Value' text box") 'add statement to listbox
    End Sub

    Private Sub bkwMD5_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bkwMD5.DoWork

        Try

            Dim MD5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider 'instantiates the algorithm
            Dim FileStreamMD5 As FileStream = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read) 'Opens a filestream which provides access

            MD5.ComputeHash(FileStreamMD5) 'creates the hash value
            FileStreamMD5.Close()

            Dim HashByte As Byte() = MD5.Hash 'the hash value equals the vaiable
            Dim HashBuff As StringBuilder = New StringBuilder 'new stringbuilder
            Dim ByteHash As Byte 'new variable

                For Each ByteHash In HashByte
                HashBuff.Append(String.Format("{0:X2}", ByteHash)) 'appends the hash value
                Next

                Dim MD5String As String
            MD5String = HashBuff.ToString() 'the hash value is converted to string

            e.Result = MD5String 'result = the hash value string

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement
    End Sub

    Private Sub bkwMD5_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bkwMD5.RunWorkerCompleted
        txtboxHashValue.Text = e.Result.ToString 'textbox = the hash value
        ListBoxEvent.Items.Add("MD5 hashing process has been completed, hash value is in " & "'Hash Value' text box") 'add statement to listbox
    End Sub


    Private Sub BKWMD5V_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BKWMD5V.DoWork
        Try
            Dim MD5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider 'instantiates the algorithm
            Dim FileStreamMD5 As FileStream = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read) 'Opens a filestream which provides access


            MD5.ComputeHash(FileStreamMD5) 'creates the hash value
            FileStreamMD5.Close()

            Dim HashByte As Byte() = MD5.Hash 'the hash value equals the vaiable
            Dim HashBuff As StringBuilder = New StringBuilder 'new stringbuilder
            Dim ByteHash As Byte 'new variable

            For Each ByteHash In HashByte
                HashBuff.Append(String.Format("{0:X2}", ByteHash)) 'appends the hash value
            Next

            Dim MD5String As String
            MD5String = HashBuff.ToString() 'the hash value is converted to string

            e.Result = MD5String 'result = the hash value string

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub bkwMD5V_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BKWMD5V.RunWorkerCompleted
        txtboxHashVerified.Text = e.Result.ToString 'textbox = the hash value
    End Sub

    Private Sub BKWSHA256V_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BKWSHA256V.DoWork
        Try
            Dim SHA256 As SHA256CryptoServiceProvider = New SHA256CryptoServiceProvider 'instantiates the algorithm
            Dim FileStreamSHA256 As FileStream = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read) 'Opens a filestream which provides access

            FileStreamSHA256 = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read) 'variable = the filestream properties
            SHA256.ComputeHash(FileStreamSHA256) 'creates the hash value
            FileStreamSHA256.Close()

            Dim SHA256HashByte As Byte() = SHA256.Hash 'the hash value equals the vaiable
            Dim SHA256HashBuff As StringBuilder = New StringBuilder 'new stringbuilder
            Dim SHA256ByteHash As Byte 'new variable

            For Each SHA256ByteHash In SHA256HashByte
                SHA256HashBuff.Append(String.Format("{0:X2}", SHA256ByteHash)) 'appends the hash value
            Next

            Dim SHA256String As String
            SHA256String = SHA256HashBuff.ToString() 'the hash value is converted to string

            e.Result = SHA256String 'result = the hash value string

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement
    End Sub

    Private Sub BKWSHA256V_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BKWSHA256V.RunWorkerCompleted
        txtboxHashVerified.Text = e.Result.ToString 'textbox = the hash value
    End Sub

    Private Sub btnVerifyHashValues_Click(sender As Object, e As EventArgs) Handles btnVerifyHashValues.Click
        Try
            btnVerifyHashValues.Enabled = False 'button disabled
            btnExportInput.Enabled = True 'button enabled

            If txtboxHashVerified.Text = txtboxHashValue.Text Then 'if textbox values = the same
                Dim BoxMsg As DialogResult 'instantiates dialog result
                Dim Message1 As String = "HASHES ARE VERIFIED" 'msgbox message
                Dim MsgBoxTitle2 = "Successfull Hash Verification" 'title of messagebox
                BoxMsg = MessageBox.Show(Message1, MsgBoxTitle2) 'msgbox =s the title and message
                txtboxHashVerified.ForeColor = Color.Green 'colour of textbox = green
                ListBoxEvent.Items.Add("Hash verification process has been completed - VERIFIED") 'adds statement to the listbox
            Else
                Dim BoxMsg1 As DialogResult 'instantiates dialog result
                Dim Message2 As String = "**WARNING:HASHES ARE NOT VERIFIED**""" 'msgbox message
                Dim MsgBoxTitle3 = "Unsuccessfull Hash Verification" 'title of messagebox
                BoxMsg1 = MessageBox.Show(Message2, MsgBoxTitle3) 'msgbox =s the title and message
                txtboxHashVerified.ForeColor = Color.Red 'colour of textbox = red
                ListBoxEvent.Items.Add("Hash verification process has been completed - FAILED") 'adds statement to the listbox
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub bkw384_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bkw384.DoWork
        Try
            Dim SHA384 As SHA384CryptoServiceProvider = New SHA384CryptoServiceProvider 'instantiates the algorithm
            Dim FileStreamSHA384 As FileStream = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read) 'Opens a filestream which provides access

            FileStreamSHA384 = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read) 'variable = the filestream properties
            SHA384.ComputeHash(FileStreamSHA384) 'creates the hash value
            FileStreamSHA384.Close()

            Dim SHA384HashByte As Byte() = SHA384.Hash 'the hash value equals the vaiable
            Dim SHA384HashBuff As StringBuilder = New StringBuilder 'new stringbuilder
            Dim SHA384ByteHash As Byte 'new variable

            For Each SHA384ByteHash In SHA384HashByte
                SHA384HashBuff.Append(String.Format("{0:X2}", SHA384ByteHash)) 'appends the hash value
            Next

            Dim SHA384String As String
            SHA384String = SHA384HashBuff.ToString() 'the hash value is converted to string

            e.Result = SHA384String 'result = the hash value string
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement
    End Sub

    Private Sub BKW384_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bkw384.RunWorkerCompleted
        txtboxHashValue.Text = e.Result.ToString 'textbox = the hash value
    End Sub

    Private Sub bwk384V_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwk384V.DoWork
        Try
            Dim SHA384 As SHA384CryptoServiceProvider = New SHA384CryptoServiceProvider 'instantiates the algorithm
            Dim FileStreamSHA384 As FileStream = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read) 'Opens a filestream which provides access

            FileStreamSHA384 = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read) 'variable = the filestream properties
            SHA384.ComputeHash(FileStreamSHA384) 'creates the hash value
            FileStreamSHA384.Close()

            Dim SHA384HashByte As Byte() = SHA384.Hash 'the hash value equals the vaiable
            Dim SHA384HashBuff As StringBuilder = New StringBuilder 'new stringbuilder
            Dim SHA384ByteHash As Byte 'new variable

            For Each SHA384ByteHash In SHA384HashByte
                SHA384HashBuff.Append(String.Format("{0:X2}", SHA384ByteHash)) 'appends the hash value
            Next

            Dim SHA384String As String
            SHA384String = SHA384HashBuff.ToString() 'the hash value is converted to string

            e.Result = SHA384String 'result = the hash value string
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement
    End Sub

    Private Sub bwk384V_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwk384V.RunWorkerCompleted
        txtboxHashVerified.Text = e.Result.ToString 'textbox = the hash value
    End Sub

    Private Sub bkwSHA_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bkwSHA.DoWork
        Try
            Dim SHA As SHA1CryptoServiceProvider = New SHA1CryptoServiceProvider 'instantiates the algorithm
            Dim FileStreamSHA As FileStream = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read) 'Opens a filestream which provides access

            FileStreamSHA = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read) 'variable = the filestream properties
            SHA.ComputeHash(FileStreamSHA) 'creates the hash value
            FileStreamSHA.Close()

            Dim SHAHashByte As Byte() = SHA.Hash 'the hash value equals the vaiable
            Dim SHAHashBuff As StringBuilder = New StringBuilder 'new stringbuilder
            Dim SHAByteHash As Byte 'new variable

            For Each SHAByteHash In SHAHashByte
                SHAHashBuff.Append(String.Format("{0:X2}", SHAByteHash)) 'appends the hash value
            Next

            Dim SHAString As String
            SHAString = SHAHashBuff.ToString() 'the hash value is converted to string

            e.Result = SHAString 'result = the hash value string
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement
    End Sub

    Private Sub bkwSHA_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bkwSHA.RunWorkerCompleted
        txtboxHashValue.Text = e.Result.ToString 'textbox = the hash value
    End Sub

    Private Sub bkwSHAV_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bkwSHAV.DoWork
        Try
            Dim SHA As SHA1CryptoServiceProvider = New SHA1CryptoServiceProvider 'instantiates the algorithm
            Dim FileStreamSHA As FileStream = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read) 'Opens a filestream which provides access

            FileStreamSHA = New FileStream(Filelocation, FileMode.Open, FileAccess.Read, FileShare.Read) 'variable = the filestream properties
            SHA.ComputeHash(FileStreamSHA) 'creates the hash value
            FileStreamSHA.Close()

            Dim SHAHashByte As Byte() = SHA.Hash 'the hash value equals the vaiable
            Dim SHAHashBuff As StringBuilder = New StringBuilder 'new stringbuilder
            Dim SHAByteHash As Byte 'new variable

            For Each SHAByteHash In SHAHashByte
                SHAHashBuff.Append(String.Format("{0:X2}", SHAByteHash)) 'the hash value is converted to string
            Next

            Dim SHAString As String
            SHAString = SHAHashBuff.ToString() 'result = the hash value string

            e.Result = SHAString
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try 'end try statement
    End Sub

    Private Sub bkwSHAV_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bkwSHAV.RunWorkerCompleted
        txtboxHashVerified.Text = e.Result.ToString 'textbox = the hash value
    End Sub

    Private Sub btnExitProgram_Click(sender As Object, e As EventArgs)
        Application.Exit() 'Exits the application
    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit() 'Exits the application

    End Sub

End Class

